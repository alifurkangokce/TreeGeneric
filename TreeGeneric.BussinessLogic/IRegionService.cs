using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using TreeGeneric.Model;

namespace TreeGeneric.BussinessLogic
{
    public interface IRegionService
    {
        void Insert(Region region);
        void Update(Region region);
        void Delete(int id);
        Region Find(int id);
        Region Find(Expression<Func<Region, bool>> Where);
        IEnumerable<Region> GetAll();
        IEnumerable<Region> GetAll(Expression<Func<Region, bool>> Where);
    }
}
