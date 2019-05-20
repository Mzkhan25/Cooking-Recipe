using System;
using Data.Models.Common;

namespace Data.Models
{
    public class Recipe : BaseClass
    {
        public string Name { get; set; }
        public DateTime DueDay { get; set; }
    }
}