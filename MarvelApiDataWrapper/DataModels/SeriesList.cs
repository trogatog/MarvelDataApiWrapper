using System;
using System.Collections.Generic;
using System.Linq;

using MarvelApiDataWrapper.DataModels.BaseModels;

using Newtonsoft.Json;

namespace MarvelApiDataWrapper.DataModels
{
    public class SeriesList : ListBase
    {
        [JsonProperty("items")]
        public IList<SeriesSummary> Items { get; set; }
    }
}
