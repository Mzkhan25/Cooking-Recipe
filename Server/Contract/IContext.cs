using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Threading.Tasks;
using Models.Models;

namespace Contract
{
    public interface IContext
    {
        
        DbSet<Ingredient> Ingredients { get; set; }
        DbSet<Recipe> Recipes { get; set; }
        DbSet<RecipeIngredient> RecipeIngredients { get; set; }
        DbSet<User> Users { get; set; }
        int SaveChanges();
        Task<int> SaveChangesAsync();
        DbEntityEntry Entry(object o);
        void Dispose();
    }
}