using System;
using System.Data.Entity;
using System.Linq;
using Contract;
using Contract.IRepository;
using Models.Models;
using Models.Models.Common;

namespace Interaction.Repository
{
    public class RecipeIngredientRepository : IRecipeIngredient
    {
        private readonly IContext _db;

        public RecipeIngredientRepository()
        {
            _db = new Context();
        }

        public IQueryable<RecipeIngredient> GetAll()
        {
            throw new NotImplementedException();
        }

        public BaseException Save(RecipeIngredient item)
        {
            var baseException = new BaseException();
            try
            {
                var isNew = false;
                var dbItem = _db.RecipeIngredients.Find(item.Id);
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

                dbItem.RecipeId = item.RecipeId;
                dbItem.IngredientId = item.IngredientId;

                dbItem.DateModified = DateTime.UtcNow;
                dbItem.ModifiedBy = item.ModifiedBy;

                if (isNew)
                {
                    _db.Entry(dbItem).State = EntityState.Added;
                    _db.RecipeIngredients.Add(dbItem);
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
                var dbItem = _db.RecipeIngredients.FirstOrDefault(user => user.Id == id);
                _db.Entry(dbItem).State = EntityState.Modified;
                if (dbItem != null)
                {
                    dbItem.DateModified = DateTime.UtcNow;
                    dbItem.IsDeleted = true;
                    baseException.Id = dbItem.Id;
                }

                _db.SaveChanges();
                baseException.HasError = true;
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