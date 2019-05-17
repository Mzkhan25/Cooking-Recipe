using System.Linq;
using Models.Models;
using Models.Models.Common;

namespace Contract.IRepository
{
    public interface IRecipeIngredient
    {
        IQueryable<RecipeIngredient> GetAll();
        BaseException Save(RecipeIngredient item);
        BaseException Delete(int id);
    }
}