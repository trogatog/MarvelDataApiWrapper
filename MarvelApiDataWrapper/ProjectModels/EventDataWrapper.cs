using System;
using System.Collections.Generic;
using System.Linq;

using MarvelApiDataWrapper.DataModels;
using MarvelApiDataWrapper.ProjectModels.BaseModels;

using Newtonsoft.Json;

namespace MarvelApiDataWrapper.ProjectModels
{
    public class EventDataWrapper : DataWrapperBase
    {
        [JsonProperty("data")]
        public EventDataContainer<Event> EventDataContainer { get; set; }
    }
}
