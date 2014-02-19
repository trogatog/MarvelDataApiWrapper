using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Configuration;
using System.Linq;

using MarvelApiDataWrapper.Contracts;

namespace MarvelApiDataWrapper.Implementation
{
    public class Configuration : IConfiguration
    {
        public Configuration() : this(ConfigurationManager.AppSettings)
        {
            
        }

        internal Configuration(NameValueCollection appSettings)
        {
            PublicKey = appSettings["PublicKey"];
            PrivateKey = appSettings["PrivateKey"];
            MarvelApiEndpoint = appSettings["MarvelApiEndpoint"];
            MarvelApiVersion = appSettings["MarvelApiVersion"];
        }
        public string PublicKey { get; private set; }
        public string PrivateKey { get; private set; }
        public string MarvelApiEndpoint { get; private set; }
        public string MarvelApiVersion { get; private set; }
    }
}
