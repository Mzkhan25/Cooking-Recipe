using System.Data.Entity;
using Contract;
using Data.Models;

namespace Interaction
{
    public class Context : DbContext, IContext
    {
        public Context()
        {
            Database.Connection.ConnectionString =
                @"Data Source=TK-LPT-0045;Initial Catalog=CookingRecipe;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Ingredient> Ingredients { get; set; }
        public DbSet<Recipe> Recipes { get; set; }
        public DbSet<RecipeIngredient> RecipeIngredients { get; set; }
    }
}