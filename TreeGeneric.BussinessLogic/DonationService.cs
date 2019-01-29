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
   public class DonationService:IDonationService
    {
        private readonly IRepository<Donation> repository;
        public DonationService(IRepository<Donation> repository)
        {
            this.repository = repository;
        }

        public void Delete(int id)
        {
            var DonationtoDelete = repository.Find(id);
            if (DonationtoDelete != null)
            {
                repository.Delete(DonationtoDelete);
            }
        }

        public Donation Find(int id)
        {
            return repository.Find(id);
        }

        public Donation Find(Expression<Func<Donation, bool>> Where)
        {
            return repository.Find(Where);
        }

        public IEnumerable<Donation> GetAll()
        {
            return repository.GetAll(r => true);
        }

        public IEnumerable<Donation> GetAll(Expression<Func<Donation, bool>> Where)
        {
            return repository.GetAll(Where);
        }

        public void Insert(Donation donation)
        {
            repository.Insert(donation);
        }

        public void Update(Donation donation)
        {
            repository.Update(donation);
        }
    }
}
