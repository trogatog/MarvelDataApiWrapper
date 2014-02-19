using System;
using System.Collections.Generic;
using System.Linq;

using Newtonsoft.Json;

namespace MarvelApiDataWrapper.DataModels.BaseModels
{
    public abstract class SummaryBase : NumericIdentifier
    {
        [JsonProperty("resourceURI")]
        public string ResourceUrl { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
