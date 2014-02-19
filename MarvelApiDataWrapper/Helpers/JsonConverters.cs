using System;
using System.Collections.Generic;
using System.Linq;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace MarvelApiDataWrapper.Helpers
{
    public class JsonConverters : DateTimeConverterBase
    {
        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            var minDate = new DateTime(1900, 1, 1);
            if (reader.TokenType != JsonToken.Date)
            {
                return minDate;
            }

            var value = (DateTime)reader.Value;
            if (value < minDate)
                return minDate;

            return value;


        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            var val = new DateTime(1900,1,1);
            if(value is DateTime)
            {
                val = (DateTime) value;
            }
            writer.WriteValue(val);
        }
    }
}
