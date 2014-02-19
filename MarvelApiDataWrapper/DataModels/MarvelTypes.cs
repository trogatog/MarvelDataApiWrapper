using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

using MarvelApiDataWrapper.DataModels.BaseModels;

namespace MarvelApiDataWrapper.DataModels
{
    public class MarvelType : NumericIdentifier
    {
        [Required]
        [MaxLength(50)]
        public string Description { get; set; }
    }
}
