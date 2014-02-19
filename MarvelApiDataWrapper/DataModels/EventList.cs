using System;
using System.Collections.Generic;
using System.Linq;

using MarvelApiDataWrapper.DataModels.BaseModels;

using Newtonsoft.Json;

namespace MarvelApiDataWrapper.DataModels
{
    public class EventList : ListBase
    {
        [JsonProperty("items")]
        public IList<EventSummary> Items { get; set; }
    }
}
