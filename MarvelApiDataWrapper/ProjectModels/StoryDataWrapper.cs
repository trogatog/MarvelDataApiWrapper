using System;
using System.Collections.Generic;
using System.Linq;

using MarvelApiDataWrapper.DataModels;
using MarvelApiDataWrapper.ProjectModels.BaseModels;

using Newtonsoft.Json;

namespace MarvelApiDataWrapper.ProjectModels
{
    public class StoryDataWrapper : DataWrapperBase
    {
        [JsonProperty("data")]
        public StoryDataContainer<Story> StoryDataContainer { get; set; }
    }
}
