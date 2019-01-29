using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using TreeGeneric.Model;

namespace TreeGeneric.BussinessLogic
{
    public interface IDonationService
    {
        void Insert(Donation donation);
        void Update(Donation donation);
        void Delete(int id);
        Donation Find(int id);
        Donation Find(Expression<Func<Donation, bool>> Where);
        IEnumerable<Donation> GetAll();
        IEnumerable<Donation> GetAll(Expression<Func<Donation, bool>> Where);
    }
}
