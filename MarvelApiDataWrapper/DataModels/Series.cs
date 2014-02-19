using System;
using System.Collections.Generic;
using System.Linq;

using MarvelApiDataWrapper.DataModels.BaseModels;
using MarvelApiDataWrapper.Helpers;

using Newtonsoft.Json;

namespace MarvelApiDataWrapper.DataModels
{
    public class Series : ObjectBase
    {
        [JsonProperty("title")]
        public string Title { get; set; }
        [JsonProperty("description")]
        public string Description { get; set; }
        [JsonProperty("resourceURI")]
        public string ResourceUri { get; set; }
        [JsonProperty("urls")]
        public IList<Url> Urls { get; set; }
        [JsonProperty("startYear")]
        public int StartYear { get; set; }
        [JsonProperty("endYear")]
        public int EndYear { get; set; }
        [JsonProperty("rating")]
        public string Rating { get; set; }
        [JsonConverter(typeof(JsonConverters))]
        [JsonProperty("modified")]
        public DateTime Modified { get; set; }
        [JsonProperty("thumbnail")]
        public Image Thumbnail { get; set; }
        [JsonProperty("comics")]
        public ComicList ComicList { get; set; }
        [JsonProperty("stories")]
        public StoryList StoryList { get; set; }
        [JsonProperty("events")]
        public EventList EventList { get; set; }
        [JsonProperty("characters")]
        public CharacterList CharacterList { get; set; }
        [JsonProperty("creators")]
        public CreatorList CreatorList { get; set; }
        [JsonProperty("next")]
        public SeriesSummary Next { get; set; }
        [JsonProperty("previous")]
        public SeriesSummary Previous { get; set; }
    }
}
