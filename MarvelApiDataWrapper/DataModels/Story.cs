using System;
using System.Collections.Generic;
using System.Linq;

using MarvelApiDataWrapper.DataModels.BaseModels;
using MarvelApiDataWrapper.Helpers;

using Newtonsoft.Json;

namespace MarvelApiDataWrapper.DataModels
{
    public class Story : ObjectBase
    {
        [JsonProperty("title")]
        public string Title { get; set; }
        [JsonProperty("description")]
        public string Description { get; set; }
        [JsonProperty("resourceURI")]
        public string ResourceUri { get; set; }
        [JsonProperty("type")]
        public string Type { get; set; }
        [JsonConverter(typeof(JsonConverters))]
        [JsonProperty("modified")]
        public DateTime Modified { get; set; }
        [JsonProperty("thumbnail")]
        public Image Thumbnail { get; set; }
        [JsonProperty("comics")]
        public ComicList ComicList { get; set; }
        [JsonProperty("series")]
        public SeriesList SeriesList { get; set; }
        [JsonProperty("events")]
        public EventList EventList { get; set; }
        [JsonProperty("characters")]
        public CharacterList CharacterList { get; set; }
        [JsonProperty("creators")]
        public CreatorList CreatorList { get; set; }
        [JsonProperty("originalissue")]
        public ComicSummary OriginalIssue { get; set; }
    }
}
