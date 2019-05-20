using System.Linq;
using Data.Models;
using Data.Models.Common;

namespace Contract.IRepository
{
    public interface IUserRepository
    {
        IQueryable<User> GetAll();
        BaseException Save(User item);
        BaseException Delete(int id);
    }
}