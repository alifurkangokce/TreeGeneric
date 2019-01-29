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
    public class TreeTypeService:ITreeTypeService
    {
        private readonly IRepository<TreeType> repository;
        public TreeTypeService(IRepository<TreeType> repository)
        {
            this.repository = repository;
        }

        public void Delete(int id)
        {
            var TreeTypetoDelete = repository.Find(id);
            if (TreeTypetoDelete != null)
            {
                repository.Delete(TreeTypetoDelete);
            }
        }

        public TreeType Find(int id)
        {
            return repository.Find(id);
        }

        public TreeType Find(Expression<Func<TreeType, bool>> Where)
        {
            return repository.Find(Where);
        }

        public IEnumerable<TreeType> GetAll()
        {
            return repository.GetAll(r => true);
        }

        public IEnumerable<TreeType> GetAll(Expression<Func<TreeType, bool>> Where)
        {
            return repository.GetAll(Where);
        }

        public void Insert(TreeType treeType)
        {
            repository.Insert(treeType);
        }

        public void Update(TreeType treeType)
        {
            repository.Update(treeType);
        }
    }
}
