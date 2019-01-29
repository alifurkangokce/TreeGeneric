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
    public class PlantingService:IPlantingService
    {
        private readonly IRepository<Planting> repository;
        public PlantingService(IRepository<Planting> repository)
        {
            this.repository = repository;
        }

        public void Delete(int id)
        {
            var PlantingtoDelete = repository.Find(id);
            if (PlantingtoDelete != null)
            {
                repository.Delete(PlantingtoDelete);
            }
        }

        public Planting Find(int id)
        {
            return repository.Find(id);
        }

        public Planting Find(Expression<Func<Planting, bool>> Where)
        {
            return repository.Find(Where);
        }

        public IEnumerable<Planting> GetAll()
        {
            return repository.GetAll(r => true);
        }

        public IEnumerable<Planting> GetAll(Expression<Func<Planting, bool>> Where)
        {
            return repository.GetAll(Where);
        }

        public void Insert(Planting planting)
        {
            repository.Insert(planting);
        }

        public void Update(Planting planting)
        {
            repository.Update(planting);
        }
    }
}
