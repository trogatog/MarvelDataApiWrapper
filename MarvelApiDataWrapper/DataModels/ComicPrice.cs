using System;
using System.Collections.Generic;
using System.Linq;

using MarvelApiDataWrapper.DataModels.BaseModels;

using Newtonsoft.Json;

namespace MarvelApiDataWrapper.DataModels
{
    public class ComicPrice : NumericIdentifier
    {
        [JsonProperty("type")]
        public string Type { get; set; }
        [JsonProperty("price")]
        public float Price { get; set; }
    }
}
