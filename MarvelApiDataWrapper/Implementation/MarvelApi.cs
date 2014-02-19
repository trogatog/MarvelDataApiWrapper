using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Cryptography;
using System.Text;

using MarvelApiDataWrapper.Constants;
using MarvelApiDataWrapper.Contracts;
using MarvelApiDataWrapper.DataModels;
using MarvelApiDataWrapper.DataModels.BaseModels;
using MarvelApiDataWrapper.Enums;
using MarvelApiDataWrapper.Extensions;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Serialization;

namespace MarvelApiDataWrapper.Implementation
{
    public class MarvelApi<T> : IMarvelApi<T> where T : class
    {
        private readonly IConfiguration _configuration;
        private readonly HttpClient _client;
        private HttpRequestMessage _requestMessage;
        private readonly List<string> _jsonErrors;
        private string _rfc1123Date;

        public MarvelApi(IConfiguration configuration, HttpClient client = null)
        {
            _configuration = configuration;
            _client = client ?? new HttpClient();
            _jsonErrors = new List<string>();
        }

        public T GetAll(MarvelTypes type)
        {
            return GetResultsFromEndpoint(type);
        }

        public T GetTypeByEntity(ObjectBase entity, MarvelTypes type)
        {
            MarvelTypes resultType;

            if(entity.GetType() == typeof(Character))
                resultType = MarvelTypes.Characters;
            else if (entity.GetType() == typeof(Comic))
                resultType = MarvelTypes.Comics;
            else if(entity.GetType() == typeof(Creator))
                resultType = MarvelTypes.Creators;
            else if (entity.GetType() == typeof(Event))
                resultType = MarvelTypes.Events;
            else if(entity.GetType() == typeof(Series))
                resultType = MarvelTypes.Series;
            else 
                resultType = MarvelTypes.Stories;

            return GetResultsFromEndpoint(resultType, entity.MarvelId, type);
        }

        public T GetTypeByUrl(string url)
        {
            return CreateRequestMessageUrl(url);
        }

        private string CreateHash()
        {
            _rfc1123Date = DateTime.UtcNow.ToString(MarvelConstants.RFC1123_DATE_TIME_FORMAT);
            var md5 = MD5.Create();
            var inputString = _rfc1123Date + _configuration.PrivateKey + _configuration.PublicKey;
            var inputBytes = Encoding.ASCII.GetBytes(inputString);
            var hash = md5.ComputeHash(inputBytes);

            var sb = new StringBuilder();
            foreach (var t in hash)
            {
                sb.Append(t.ToString(MarvelConstants.LOWER_CASE_STRING_FORMAT));
            }
            return sb.ToString();
        }

        private T CreateRequestMessageUrl(string url)
        {
            var hash = CreateHash();
            url = string.Format(UrlFormatters.URL_PARAMETERS, url, _rfc1123Date, _configuration.PublicKey, hash);
            _requestMessage = new HttpRequestMessage(HttpMethod.Get, url);
            return SendMessageAsync();
        }

        private T CreateRequestMessage(string byRequestEndpoint, int? byId = null, MarvelTypes type = MarvelTypes.All)
        {
            var url = string.Format(UrlFormatters.REST_ENDPOINT_FORMATTER, _configuration.MarvelApiEndpoint, _configuration.MarvelApiVersion);
            url = url.AppendUrlPath(byRequestEndpoint);
            if (byId != null)
            {
                url = url.AppendUrlPath(byId.ToString());
            }

            if (type != MarvelTypes.All)
            {
                var name = Enum.GetName(typeof(MarvelTypes), type);
                if (name != null && !name.ToLower().Equals(byRequestEndpoint))
                {
                    url = url.AppendUrlPath(name.ToLower());
                }
            }
            
            return CreateRequestMessageUrl(url);
        }

        private T GetResultsFromEndpoint(MarvelTypes getType, int? typeId = null, MarvelTypes type = MarvelTypes.All)
        {
            var name = Enum.GetName(typeof(MarvelTypes), getType);

            if (name != null)
                name = name.ToLower();

            return CreateRequestMessage(name, typeId, type);
        }

        private T SendMessageAsync()
        {
            T responseData;
            using (var result = _client.SendAsync(_requestMessage))
            {
                var json = result.ContinueWith(t => t.Result.Content.ReadAsStringAsync().Result).Result;
                var statusCode = result.Result.StatusCode;
                if (statusCode == HttpStatusCode.OK)
                    responseData = DeserializeJson(json);
                else
                {
                    return null;
                }
            }
            
            return responseData;
        }

        private T DeserializeJson(string json)
        {
            var output = JsonConvert.DeserializeObject<dynamic>(json);

            if (((JObject)output).Count == 0)
                return null;

            var wrapperData = JsonConvert.DeserializeObject<T>(json, JsonSerializer());
            
            return wrapperData;
        }

        private JsonSerializerSettings JsonSerializer()
        {
            return new JsonSerializerSettings
            {
                Error = delegate(object sender, ErrorEventArgs args)
                {
                    _jsonErrors.Add(args.ErrorContext.Error.Message);
                    args.ErrorContext.Handled = true;
                }
            };
        }
    }
}
