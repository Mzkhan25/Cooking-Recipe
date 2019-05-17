using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Models.Models.Common;

namespace Models.Models
{
    public class Ingredient : BaseClass
    {
        public string Name { get; set; }
        public int Quantity { get; set; }
        
    }
}