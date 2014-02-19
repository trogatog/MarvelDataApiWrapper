using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace MarvelApiDataWrapper.DataModels
{
    public class ApiTypeMap 
    {
        [Column(Order=0), Key]
        public int TypeId { get; set; }
        [Column(Order=1), Key]
        public int ReturnTypeId { get; set; }
    }
}
