using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using TreeGeneric.Model;

namespace TreeGeneric.BussinessLogic
{
    public interface IPostService
    {
        void Insert(Post post);
        void Update(Post post);
        void Delete(int id);
        Post Find(int id);
        Post Find(Expression<Func<Post, bool>> Where);
        IEnumerable<Post> GetAll();
        IEnumerable<Post> GetAll(Expression<Func<Post, bool>> Where);
    }
}
