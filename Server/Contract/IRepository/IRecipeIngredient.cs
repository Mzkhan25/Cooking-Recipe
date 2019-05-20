using System.Linq;
using Data.Models;
using Data.Models.Common;

namespace Contract.IRepository
{
    public interface IRecipeIngredient
    {
        IQueryable<RecipeIngredient> GetAll();
        BaseException Save(RecipeIngredient item);
        BaseException Delete(int id);
    }
}