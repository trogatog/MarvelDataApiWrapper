using System;
using System.Collections.Generic;
using System.Linq;

using MarvelApiDataWrapper.DataModels.BaseModels;

using Newtonsoft.Json;

namespace MarvelApiDataWrapper.DataModels
{
    public class Character : ObjectBase
    {
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("description")]
        public string Description { get; set; }
        [JsonProperty("modified")]
        public DateTime Modified { get; set; }
        [JsonProperty("resourceURI")]
        public string ResourceUri { get; set; }
        [JsonProperty("urls")]
        public IList<Url> Urls { get; set; }
        [JsonProperty("thumbnail")]
        public Image Thumbnail { get; set; }
        [JsonProperty("comics")]
        public ComicList ComicList { get; set; }
        [JsonProperty("stories")]
        public StoryList StoryList { get; set; }
        [JsonProperty("events")]
        public EventList EventList { get; set; }
        [JsonProperty("series")]
        public SeriesList SeriesList { get; set; }
    }
}
