using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

using Newtonsoft.Json;

namespace MarvelApiDataWrapper.ProjectModels.BaseModels
{
    public abstract class DataWrapperBase
    {
        [JsonProperty("code")]
        public int Code { get; set; }
        [JsonProperty("status")]
        public string Status { get; set; }
        [Key]
        [JsonProperty("etag")]
        public string Etag { get; set; }
    }
}
