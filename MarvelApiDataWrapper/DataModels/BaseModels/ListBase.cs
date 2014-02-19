using System;
using System.Collections.Generic;
using System.Linq;

using Newtonsoft.Json;

namespace MarvelApiDataWrapper.DataModels.BaseModels
{
    public class ListBase : NumericIdentifier
    {
        [JsonProperty("available")]
        public int Available { get; set; }
        [JsonProperty("returned")]
        public int Returned { get; set; }
        [JsonProperty("collectionURI")]
        public string CollectionUrl { get; set; }
    }
}
