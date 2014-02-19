using System;
using System.Collections.Generic;
using System.Linq;

using MarvelApiDataWrapper.DataModels;
using MarvelApiDataWrapper.ProjectModels.BaseModels;

namespace MarvelApiDataWrapper.ProjectModels
{
    public class SeriesDataContainer<T> : DataContainerBase<T> where T : Series
    {
    }
}
