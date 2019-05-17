using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
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
            BaseException baseException = new BaseException();
            try
            {
                throw new NotImplementedException();
            }
            catch (Exception e)
            {
                baseException.Message = e.Message;

            }

            return baseException;
        }

        public BaseException Delete(int id)
        {
            BaseException baseException = new BaseException();
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

            }
            catch (Exception e)
            {
                baseException.Message = e.Message;

            }

            return baseException;
        }
    }
}