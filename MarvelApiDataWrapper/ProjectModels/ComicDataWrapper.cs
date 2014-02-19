using System;
using System.Collections.Generic;
using System.Linq;

using MarvelApiDataWrapper.DataModels;
using MarvelApiDataWrapper.ProjectModels.BaseModels;

using Newtonsoft.Json;

namespace MarvelApiDataWrapper.ProjectModels
{
    public class ComicDataWrapper : DataWrapperBase
    {
        [JsonProperty("data")]
        public ComicDataContainer<Comic> ComicDataContainer { get; set; }
    }
}
