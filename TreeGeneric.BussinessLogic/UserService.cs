using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using TreeGeneric.Data;
using TreeGeneric.Model;

namespace TreeGeneric.BussinessLogic
{
   public class UserService:IUserService
    {
        private readonly IRepository<User> repository;
        public UserService(IRepository<User> repository)
        {
            this.repository = repository;
        }

        public void Delete(int id)
        {
            var UsertoDelete = repository.Find(id);
            if (UsertoDelete != null)
            {
                repository.Delete(UsertoDelete);
            }
        }

        public User Find(int id)
        {
            return repository.Find(id);
        }

        public User Find(Expression<Func<User, bool>> Where)
        {
            return repository.Find(Where);
        }

        public IEnumerable<User> GetAll()
        {
            return repository.GetAll(r => true);
        }

        public IEnumerable<User> GetAll(Expression<Func<User, bool>> Where)
        {
            return repository.GetAll(Where);
        }

        public void Insert(User user)
        {
            repository.Insert(user);
        }

        public void Update(User user)
        {
            repository.Update(user);
        }
    }
}
