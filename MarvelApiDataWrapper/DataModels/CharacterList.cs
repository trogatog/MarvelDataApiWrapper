using System;
using System.Collections.Generic;
using System.Linq;

using MarvelApiDataWrapper.DataModels.BaseModels;

using Newtonsoft.Json;

namespace MarvelApiDataWrapper.DataModels
{
    public class CharacterList : ListBase
    {
        [JsonProperty("items")]
        public IList<CharacterSummary> Items { get; set; }
    }
}
