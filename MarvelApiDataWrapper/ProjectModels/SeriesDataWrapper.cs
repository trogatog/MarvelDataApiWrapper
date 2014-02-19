using System;
using System.Collections.Generic;
using System.Linq;

using MarvelApiDataWrapper.DataModels;
using MarvelApiDataWrapper.ProjectModels.BaseModels;

using Newtonsoft.Json;

namespace MarvelApiDataWrapper.ProjectModels
{
    public class SeriesDataWrapper : DataWrapperBase
    {
        [JsonProperty("data")]
        public SeriesDataContainer<Series> SeriesDataContainer { get; set; }
    }
}
