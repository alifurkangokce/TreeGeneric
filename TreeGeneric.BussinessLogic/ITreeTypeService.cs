using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using TreeGeneric.Model;

namespace TreeGeneric.BussinessLogic
{
   public interface ITreeTypeService
    {
        void Insert(TreeType treeType);
        void Update(TreeType treeType);
        void Delete(int id);
        TreeType Find(int id);
        TreeType Find(Expression<Func<TreeType, bool>> Where);
        IEnumerable<TreeType> GetAll();
        IEnumerable<TreeType> GetAll(Expression<Func<TreeType, bool>> Where);
    }
}
