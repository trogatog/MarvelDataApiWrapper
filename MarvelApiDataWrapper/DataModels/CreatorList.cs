using System;
using System.Collections.Generic;
using System.Linq;

using MarvelApiDataWrapper.DataModels.BaseModels;

using Newtonsoft.Json;

namespace MarvelApiDataWrapper.DataModels
{
    public class CreatorList : ListBase
    {
        [JsonProperty("items")]
        public IList<CreatorSummary> Items { get; set; }
    }
}
