using System;
using System.Collections.Generic;
using System.Linq;

using MarvelApiDataWrapper.DataModels.BaseModels;
using MarvelApiDataWrapper.Helpers;

using Newtonsoft.Json;

namespace MarvelApiDataWrapper.DataModels
{
    public class Creator : ObjectBase
    {
        [JsonProperty("firstName")]
        public string FirstName { get; set; }
        [JsonProperty("middleName")]
        public string MiddleName { get; set; }
        [JsonProperty("lastName")]
        public string LastName { get; set; }
        [JsonProperty("suffix")]
        public string Suffix { get; set; }
        [JsonProperty("fullName")]
        public string FullName { get; set; }
        [JsonConverter(typeof(JsonConverters))]
        [JsonProperty("modified")]
        public DateTime Modified { get; set; }
        [JsonProperty("resourceURI")]
        public string ResourceUri { get; set; }
        [JsonProperty("urls")]
        public IList<Url> Urls { get; set; }
        [JsonProperty("thumbnail")]
        public Image Thumbnail { get; set; }
        [JsonProperty("series")]
        public SeriesList SeriesList { get; set; }
        [JsonProperty("stories")]
        public StoryList StoryList { get; set; }
        [JsonProperty("comics")]
        public ComicList ComicList { get; set; }
        [JsonProperty("events")]
        public EventList EventList { get; set; }
    }
}
