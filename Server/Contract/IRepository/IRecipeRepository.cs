using System.Linq;
using Data.Models;
using Data.Models.Common;

namespace Contract.IRepository
{
    public interface IRecipeRepository
    {
        IQueryable<Recipe> GetAll();
        BaseException Save(Recipe item);
        BaseException Delete(int id);
    }
}