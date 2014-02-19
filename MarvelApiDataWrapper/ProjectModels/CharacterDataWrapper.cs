using System;
using System.Collections.Generic;
using System.Linq;

using MarvelApiDataWrapper.DataModels;
using MarvelApiDataWrapper.ProjectModels.BaseModels;

using Newtonsoft.Json;

namespace MarvelApiDataWrapper.ProjectModels
{
    public class CharacterDataWrapper : DataWrapperBase
    {
        [JsonProperty("data")]
        public CharacterDataContainer<Character> CharacterDataContainer { get; set; }
    }
}
