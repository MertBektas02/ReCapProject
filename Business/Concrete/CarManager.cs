using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entity.Concrete;
using Entity.DTOs;
using System;
using System.Collections.Generic;
using System.Text;




namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _CarDal;
        public CarManager(ICarDal carDal)
        {
            _CarDal = carDal;
        }

        public IResult Add(CarEntity car)
        {
            _CarDal.Add(car);
            return new SuccessResult();
            if (car.CarName.Length>2)  //bu niye unreacable code oluyor? MyFinalProject'te de unreacable code olmuştu.
            {
                return new ErrorResult(Messages.Invalid);
            }
            else
            {
                return new SuccessResult(Messages.CarAdded);
            }
        }

        public IDataResult< List<CarEntity>> GetAll()
        {
            if (DateTime.Now.Hour==22)
            {
                return new ErrorDataResult<List<CarEntity>>(Messages.MaintenanceTime);
            }

            return new SuccessDataResult<List<CarEntity>>(_CarDal.GetAll(), Messages.CarListed);
        }

        public IDataResult<CarEntity> getbyId(int id)
        {
            return new SuccessDataResult<CarEntity>( _CarDal.Get(p => p.CarID == id));
        }

        public IDataResult< List<CarDetailDto>> GetCarDetails()
        {
            return new SuccessDataResult<List<CarDetailDto>>( _CarDal.GetCarDetails());
        }
    }
}
