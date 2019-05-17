using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Models.Models.Common;

namespace Models.Models
{
    public class RecipeIngredient : BaseClass
    {
        public int RecipeId { get; set; }
        public int IngredientId { get; set; }
    }
}