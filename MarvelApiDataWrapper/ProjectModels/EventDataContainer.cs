﻿using System;
using System.Collections.Generic;
using System.Linq;

using MarvelApiDataWrapper.DataModels;
using MarvelApiDataWrapper.ProjectModels.BaseModels;

namespace MarvelApiDataWrapper.ProjectModels
{
    public class EventDataContainer<T> : DataContainerBase<T> where T : Event
    {
    }
}
