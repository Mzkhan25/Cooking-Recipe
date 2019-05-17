using System;
using System.Data.Entity;
using System.Linq;
using Contract;
using Contract.IRepository;
using Models.Models;
using Models.Models.Common;

namespace Interaction.Repository
{
    public class RecipeRepository : IRecipeRepository
    {
        private readonly IContext _db;

        public RecipeRepository()
        {
            _db = new Context();
        }

        public IQueryable<Recipe> GetAll()
        {
            throw new NotImplementedException();
        }

        public BaseException Save(Recipe item)
        {
            var baseException = new BaseException();
            try
            {
                var isNew = false;
                var dbItem = _db.Recipes.Find(item.Id);
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
                dbItem.DueDay = item.DueDay;

                dbItem.DateModified = DateTime.UtcNow;
                dbItem.ModifiedBy = item.ModifiedBy;

                if (isNew)
                {
                    _db.Entry(dbItem).State = EntityState.Added;
                    _db.Recipes.Add(dbItem);
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
                var dbItem = _db.Recipes.FirstOrDefault(user => user.Id == id);
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