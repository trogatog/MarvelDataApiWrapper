using System;
using System.Collections.Generic;
using System.Linq;

using Newtonsoft.Json;

namespace MarvelApiDataWrapper.DataModels.BaseModels
{
    public abstract class SummaryRole : SummaryBase
    {
        [JsonProperty("role")]
        public string Role { get; set; }
    }
}
