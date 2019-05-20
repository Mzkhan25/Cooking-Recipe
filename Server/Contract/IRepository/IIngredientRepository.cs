using System.Linq;
using Data.Models;
using Data.Models.Common;

namespace Contract.IRepository
{
    public interface IIngredientRepository
    {
        IQueryable<Ingredient> GetAll();
        BaseException Save(Ingredient item);
        BaseException Delete(int id);
    }
}