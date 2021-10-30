using DataAccess.Abstract;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemoryDal
{
    class InMemoryCustomerDal : ICustomerDal
    {
        List<Customers> _customers;
        public InMemoryCustomerDal()
        {
            _customers = new List<Customers>
            {
                new Customers{UserId=1,CompanyName="RondomCompanyName"}
            };
        }

        public void Add(Customers entity)
        {
            _customers.Add(entity);
        }

        public void Delete(Customers entity)
        {
            Customers CustomersToDelete = _customers.SingleOrDefault(p => p.UserId == entity.UserId);
            _customers.Remove(CustomersToDelete);
        }

        public Customers Get(Expression<Func<Customers, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Customers> GetAll(Expression<Func<Customers, bool>> filter = null)
        {
            return _customers;
        }

        public void Update(Customers entity)
        {
            Customers CustomerToUpdate = _customers.SingleOrDefault(p => p.UserId == entity.UserId);
            CustomerToUpdate.CompanyName = entity.CompanyName;
        }
    }
}
