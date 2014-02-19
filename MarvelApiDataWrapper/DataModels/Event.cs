using System;
using System.Collections.Generic;
using System.Linq;

using MarvelApiDataWrapper.DataModels.BaseModels;

using Newtonsoft.Json;

namespace MarvelApiDataWrapper.DataModels
{
    public class Event : ObjectBase
    {
        [JsonProperty("title")]
        public string Title { get; set; }
        [JsonProperty("description")]
        public string Description { get; set; }
        [JsonProperty("resourceURI")]
        public string ResourceUri { get; set; }
        [JsonProperty("urls")]
        public IList<Url> Urls { get; set; }
        [JsonProperty("start")]
        public DateTime Start { get; set; }
        [JsonProperty("end")]
        public DateTime End { get; set; }
        [JsonProperty("thumbnail")]
        public Image Thumbail { get; set; }
        [JsonProperty("comics")]
        public ComicList ComicList { get; set; }
        [JsonProperty("stories")]
        public StoryList StoryList { get; set; }
        [JsonProperty("series")]
        public SeriesList SeriesList { get; set; }
        [JsonProperty("characters")]
        public CharacterList CharacterList { get; set; }
        [JsonProperty("creators")]
        public CreatorList CreatorList { get; set; }
        [JsonProperty("next")]
        public EventSummary NextEvent { get; set; }
        [JsonProperty("previous")]
        public EventSummary PreviousEvent { get; set; }
    }
}
