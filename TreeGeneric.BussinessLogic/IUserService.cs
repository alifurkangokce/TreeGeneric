using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using TreeGeneric.Model;

namespace TreeGeneric.BussinessLogic
{
   public interface IUserService
    {
        void Insert(User user);
        void Update(User user);
        void Delete(int id);
        User Find(int id);
        User Find(Expression<Func<User, bool>> Where);
        IEnumerable<User> GetAll();
        IEnumerable<User> GetAll(Expression<Func<User, bool>> Where);
    }
}
