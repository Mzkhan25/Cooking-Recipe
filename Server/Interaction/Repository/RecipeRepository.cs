﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
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