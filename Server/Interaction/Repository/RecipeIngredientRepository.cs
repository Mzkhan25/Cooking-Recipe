using System;
using System.Collections.Generic;
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
                throw new NotImplementedException();
            }
            catch (Exception e)
            {
                baseException.Message = e.Message;

            }

            return baseException;
        }
    }
}