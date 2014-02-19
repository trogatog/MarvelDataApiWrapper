using System;
using System.Collections.Generic;
using System.Linq;

using MarvelApiDataWrapper.DataModels.BaseModels;

using Newtonsoft.Json;

namespace MarvelApiDataWrapper.DataModels
{
    public class StorySummary : SummaryBase 
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
