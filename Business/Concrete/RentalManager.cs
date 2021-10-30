using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class RentalManager : IRentalService
    {
        IRentalsDal _rentalsDal;
        public RentalManager(IRentalsDal rentalsDal)
        {
            _rentalsDal = rentalsDal;
        }
        public IResult Add(Rentals rental)
        {

            var rentalDate = _rentalsDal.Get(r => r.CarId == rental.CarId);
            if (rentalDate == null || rentalDate.ReturnDate < DateTime.Now.Date)
            {
                _rentalsDal.Add(rental);
                return new SuccessResult(Messages.CarAdded);
            }
            else
            {
                return new ErrorResult(Messages.Invalid);
            }
        }

        public IDataResult<List<Rentals>> GetAll()
        {
            return new SuccessDataResult<List<Rentals>>(_rentalsDal.GetAll(), Messages.RentalListed);

        }

        public IDataResult<Rentals> GetByCarId(int id)
        {
            return new SuccessDataResult<Rentals>(_rentalsDal.Get(p => p.CarId == id));
        }
    }
}
