using System.Linq;
using Models.Models;
using Models.Models.Common;

namespace Contract.IRepository
{
    public interface IUserRepository
    {
        IQueryable<User> GetAll();
        BaseException Save(User item);
        BaseException Delete(int id);
    }
}