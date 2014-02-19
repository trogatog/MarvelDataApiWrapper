using System;
using System.Collections.Generic;
using System.Linq;

using MarvelApiDataWrapper.DataModels.BaseModels;

using Newtonsoft.Json;

namespace MarvelApiDataWrapper.DataModels
{
    public class ComicList : ListBase
    {
        [JsonProperty("items")]
        public IList<ComicSummary> Items { get; set; }
    }
}
