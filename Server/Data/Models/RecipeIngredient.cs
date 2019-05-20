using Data.Models.Common;

namespace Data.Models
{
    public class RecipeIngredient : BaseClass
    {
        public int RecipeId { get; set; }
        public int IngredientId { get; set; }
    }
}