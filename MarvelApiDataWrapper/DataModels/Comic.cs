using System;
using System.Collections.Generic;
using System.Linq;

using MarvelApiDataWrapper.DataModels.BaseModels;

using Newtonsoft.Json;

namespace MarvelApiDataWrapper.DataModels
{
    public class Comic : ObjectBase
    {
        [JsonProperty("digitalId")]
        public int DigitalId { get; set; }
        [JsonProperty("title")]
        public string Title { get; set; }
        [JsonProperty("issueNumber")]
        public int IssueNumber { get; set; }
        [JsonProperty("variantDescription")]
        public string VariantDescription { get; set; }
        [JsonProperty("description")]
        public string Description { get; set; }
        [JsonProperty("modified")]
        public DateTime Modified { get; set; }
        [JsonProperty("isbn")]
        public string ISBN { get; set; }
        [JsonProperty("upc")]
        public string Upc { get; set; }
        [JsonProperty("diamondCode")]
        public string DiamondCode { get; set; }
        [JsonProperty("ean")]
        public string EAN { get; set; }
        [JsonProperty("issn")]
        public string ISSN { get; set; }
        [JsonProperty("format")]
        public string Format { get; set; }
        [JsonProperty("pageCount")]
        public int PageCount { get; set; }
        [JsonProperty("textObjects")]
        public IList<TextObject> TextObjects { get; set; }
        [JsonProperty("urls")]
        public IList<Url> Urls { get; set; }
        [JsonProperty("series")]
        public SeriesSummary SeriesSummary { get; set; }
        [JsonProperty("variants")]
        public IList<ComicSummary> Variants { get; set; }
        [JsonProperty("collections")]
        public IList<ComicSummary> Collections { get; set; }
        [JsonProperty("collectedIssues")]
        public IList<ComicSummary> CollectedIssues { get; set; }
        [JsonProperty("dates")]
        public IList<ComicDate> Dates { get; set; }
        [JsonProperty("prices")]
        public IList<ComicPrice> Prices { get; set; }
        [JsonProperty("thumbnail")]
        public Image Thumbnail { get; set; }
        [JsonProperty("images")]
        public IList<Image> Images { get; set; }
        [JsonProperty("creators")]
        public CreatorList CreatorList { get; set; }
        [JsonProperty("characters")]
        public CharacterList CharacterList { get; set; }
        [JsonProperty("stories")]
        public StoryList StoryList { get; set; }
        [JsonProperty("events")]
        public EventList EventList { get; set; } 
        
    }
}
