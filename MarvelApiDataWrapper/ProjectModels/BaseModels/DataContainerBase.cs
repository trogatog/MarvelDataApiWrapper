using System;
using System.Collections.Generic;
using System.Linq;

using Newtonsoft.Json;

namespace MarvelApiDataWrapper.ProjectModels.BaseModels
{
    public abstract class DataContainerBase<T> where T : class 
    {
        [JsonProperty("offset")]
        public int Offset { get; set; } 
        [JsonProperty("limit")]
        public int Limit { get; set; }
        [JsonProperty("total")]
        public int Total { get; set; }
        [JsonProperty("count")]
        public int Count { get; set; }
        [JsonProperty("results")]
        public IList<T> Results { get; set; }
    }
}
