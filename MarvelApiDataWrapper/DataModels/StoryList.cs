using System;
using System.Collections.Generic;
using System.Linq;

using MarvelApiDataWrapper.DataModels.BaseModels;

using Newtonsoft.Json;

namespace MarvelApiDataWrapper.DataModels
{
    public class StoryList : ListBase
    {
        [JsonProperty("items")]
        public IList<StorySummary> Items { get; set; }
    }
}
