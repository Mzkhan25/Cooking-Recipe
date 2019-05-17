using System;
using System.Data.Entity;
using System.Linq;
using Contract;
using Contract.IRepository;
using Models.Models;
using Models.Models.Common;

namespace Interaction.Repository
{
    public class IngredientRepository : IIngredientRepository
    {
        private readonly IContext _db;

        public IngredientRepository()
        {
            _db = new Context();
        }

        public IQueryable<Ingredient> GetAll()
        {
            return _db.Ingredients.Where(ingredient => ingredient.IsDeleted != true);
        }

        public BaseException Save(Ingredient item)
        {
            var baseException = new BaseException();
            try
            {
                var isNew = false;
                var dbItem = _db.Ingredients.Find(item.Id);
                if (dbItem != null && item.Id != 0)
                {
                    _db.Entry(dbItem).State = EntityState.Modified;
                }
                else
                {
                    dbItem = item;
                    dbItem.DateAdded = DateTime.UtcNow;
                    dbItem.AddedBy = item.AddedBy;
                    isNew = true;
                }

                dbItem.Name = item.Name;
                dbItem.Quantity = item.Quantity;

                dbItem.DateModified = DateTime.UtcNow;
                dbItem.ModifiedBy = item.ModifiedBy;

                if (isNew)
                {
                    _db.Entry(dbItem).State = EntityState.Added;
                    _db.Ingredients.Add(dbItem);
                }

                _db.SaveChanges();
                baseException.HasError = false;
            }
            catch (Exception e)
            {
                baseException.HasError = true;
                baseException.Message = e.Message;
            }

            return baseException;
        }

        public BaseException Delete(int id)
        {
            var baseException = new BaseException();
            try
            {
                var dbItem = _db.Ingredients.FirstOrDefault(user => user.Id == id);
                _db.Entry(dbItem).State = EntityState.Modified;
                if (dbItem != null)
                {
                    dbItem.DateModified = DateTime.UtcNow;
                    dbItem.IsDeleted = true;
                    baseException.Id = dbItem.Id;
                }

                _db.SaveChanges();
                baseException.HasError = false;
            }
            catch (Exception e)
            {
                baseException.HasError = true;
                baseException.Message = e.Message;
            }

            return baseException;
        }
    }
}