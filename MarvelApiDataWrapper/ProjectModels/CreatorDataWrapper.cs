using System;
using System.Collections.Generic;
using System.Linq;

using MarvelApiDataWrapper.DataModels;
using MarvelApiDataWrapper.ProjectModels.BaseModels;

using Newtonsoft.Json;

namespace MarvelApiDataWrapper.ProjectModels
{
    public class CreatorDataWrapper : DataWrapperBase
    {
        [JsonProperty("data")]
        public CreatorDataContainer<Creator> CreatorDataContainer { get; set; }
    }
}
