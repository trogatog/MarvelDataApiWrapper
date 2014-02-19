using System;
using System.Collections.Generic;
using System.Linq;

using MarvelApiDataWrapper.DataModels.BaseModels;
using MarvelApiDataWrapper.Enums;

namespace MarvelApiDataWrapper.Contracts
{
    public interface IMarvelApi<out T> where T : class
    {
        T GetAll(MarvelTypes type);
        T GetTypeByEntity(ObjectBase entity, MarvelTypes type);
        T GetTypeByUrl(string url);
    }
}
