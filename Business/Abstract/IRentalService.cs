using Core.Utilities.Results;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IRentalService
    {
        IDataResult<List<Rentals>> GetAll();
        IDataResult<Rentals> GetByCarId(int id);

        IResult Add(Rentals rental);
    }
}
