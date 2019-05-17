using System;
using System.Data.Entity;
using System.Linq;
using Contract;
using Contract.IRepository;
using Models.Models;
using Models.Models.Common;

namespace Interaction.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly IContext _db;

        public UserRepository()
        {
            _db = new Context();
        }

        public IQueryable<User> GetAll()
        {
            throw new NotImplementedException();
        }

        public BaseException Save(User item)
        {
            var baseException = new BaseException();
            try
            {
                var isNew = false;
                var dbItem = _db.Users.Find(item.Id);
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

                dbItem.UserName = item.UserName;
                dbItem.Password = item.Password;

                dbItem.DateModified = DateTime.UtcNow;
                dbItem.ModifiedBy = item.ModifiedBy;

                if (isNew)
                {
                    _db.Entry(dbItem).State = EntityState.Added;
                    _db.Users.Add(dbItem);
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
                var dbItem = _db.Users.FirstOrDefault(user => user.Id == id);
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