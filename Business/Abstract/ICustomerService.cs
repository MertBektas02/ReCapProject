using Core.Utilities.Results;
using Entity.Concrete;
using Entity.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICustomerService
    {
        IDataResult<List<Customers>> GetAll();
        IDataResult<Customers> GetById(int id);
        IDataResult<List<CustomerDetailDto>> GetCustomerDetails();
        IResult Add(Customers customers);
    }
}
