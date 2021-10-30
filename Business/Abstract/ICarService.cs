using Core.Utilities.Results;
using Entity.Concrete;
using Entity.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService
    {
        IDataResult< List<CarEntity>> GetAll();
        IDataResult<CarEntity>  getbyId(int id); //List<CarEntity> getById(int id);
        IDataResult< List<CarDetailDto>> GetCarDetails();
        IResult Add(CarEntity car);

    }
}
