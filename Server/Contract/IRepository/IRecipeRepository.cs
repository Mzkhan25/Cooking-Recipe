using System.Linq;
using Models.Models;
using Models.Models.Common;

namespace Contract.IRepository
{
    public interface IRecipeRepository
    {
        IQueryable<Recipe> GetAll();
        BaseException Save(Recipe item);
        BaseException Delete(int id);
    }
}