using Entity.Concrete;
using Entity.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService
    {
        List<CarEntity> GetAll();
        CarEntity getbyId(int id); //List<CarEntity> getById(int id);
        List<CarDetailDto> GetCarDetails();

    }
}
