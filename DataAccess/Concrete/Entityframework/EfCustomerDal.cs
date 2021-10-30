using Core.DataAccess.Entityframework;
using DataAccess.Abstract;
using Entity.Concrete;
using Entity.DTOs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DataAccess.Concrete.Entityframework
{
    public class EfCustomerDal : EfEntityRepositoryBase<Customers, CarProject1Context>, ICustomerDal
    {
        public List<CustomerDetailDto> GetCustomerDetails()
        {
            throw new NotImplementedException();
        }
    }
}
