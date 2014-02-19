using System;
using System.Linq;

using MarvelApiDataWrapper.Contracts;
using MarvelApiDataWrapper.DataModels;
using MarvelApiDataWrapper.Enums;
using MarvelApiDataWrapper.Implementation;
using MarvelApiDataWrapper.ProjectModels;

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MarvelData.Test.Tests
{
    [TestClass]
    public class CharacterTests
    {
        private Configuration _configuration;
        private IMarvelApi<CharacterDataWrapper> _marvelApi;

        [TestInitialize]
        public void Initialize()
        {
            _configuration = new Configuration();
            _marvelApi = new MarvelApi<CharacterDataWrapper>(_configuration);
        }

        [TestMethod]
        public void Attempting_to_get_all_characters_returns_a_valid_object()
        {
            var result = _marvelApi.GetAll(MarvelTypes.Characters);
            Assert.AreEqual(result.CharacterDataContainer.Count, result.CharacterDataContainer.Results.Count);
        }

        [TestMethod]
        public void Attempting_to_get_a_specific_character_returns_all_Character_data()
        {
            var character = new Character { MarvelId = 1009521 };

            var result = _marvelApi.GetTypeByEntity(character, MarvelTypes.Characters);
            Assert.AreEqual(" Hank Pym", result.CharacterDataContainer.Results[0].Name);
        }
    }

    [TestClass]
    public class ComicTests
    {
        private Configuration _configuration;
        private IMarvelApi<ComicDataWrapper> _marvelApi;

        [TestInitialize]
        public void Initialize()
        {
            _configuration = new Configuration();
            _marvelApi = new MarvelApi<ComicDataWrapper>(_configuration);
        }

        [TestMethod]
        public void Attempting_to_get_all_Comics_returns_a_valid_object()
        {
            var result = _marvelApi.GetAll(MarvelTypes.Comics);
            Assert.IsNotNull(result);
            Assert.AreEqual(result.ComicDataContainer.Count, result.ComicDataContainer.Results.Count);
        }

        [TestMethod]
        public void Attempting_to_get_a_specific_comic_returns_all_comic_data()
        {
            //var result = _marvelApi.GetCharacterById(1009521);
            //Assert.AreEqual(" Hank Pym", result.CharacterDataContainer.Results[0].Name);
        }
    }
}
