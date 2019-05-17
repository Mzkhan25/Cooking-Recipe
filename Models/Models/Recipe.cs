using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Models.Models.Common;

namespace Models.Models
{
    public class Recipe : BaseClass
    {
        public string Name { get; set; }
        public DateTime DueDay { get; set; }
    }
}