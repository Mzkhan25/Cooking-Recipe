using System.Linq;
using Models.Models;
using Models.Models.Common;

namespace Contract.IRepository
{
    public interface IIngredientRepository
    {
        IQueryable<Ingredient> GetAll();
        BaseException Save(Ingredient item);
        BaseException Delete(int id);
    }
}