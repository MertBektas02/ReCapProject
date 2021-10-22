using DataAccess.Abstract;
using Entity.Concrete;
using Entity.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemoryDal
{
    public class InMemoryCarDal : ICarDal
    {

        List<CarEntity> _Cars;
        public InMemoryCarDal()
        {
            _Cars = new List<CarEntity>
            {
                new CarEntity{CarID=1,CarName="Toyota",DailyPrice=5000,Description="no description",ModelYear=1999},
                new CarEntity{CarID=2,CarName="Audi",DailyPrice=5000,Description="no description",ModelYear=1999},
                new CarEntity{CarID=3,CarName="BMW",DailyPrice=5000,Description="no description",ModelYear=1999},
                new CarEntity{CarID=4,CarName="Mitsubishi",DailyPrice=5000,Description="no description",ModelYear=1999},
                new CarEntity{CarID=5,CarName="JEEP",DailyPrice=5000,Description="no description",ModelYear=1999},

            };
        }
        public void Add(CarEntity entity)
        {
            _Cars.Add(entity);
        }

        public void Delete(CarEntity entity)
        {
            CarEntity CarToDelete = _Cars.SingleOrDefault(p => p.CarID == entity.CarID);
            _Cars.Remove(CarToDelete);
        }

        public CarEntity Get(Expression<Func<CarEntity, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<CarEntity> GetAll(Expression<Func<CarEntity, bool>> filter = null)
        {
            return _Cars;
        }

        public List<CarDetailDto> GetCarDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(CarEntity entity)
        {
            CarEntity CarToUpdate = _Cars.SingleOrDefault(p => p.CarID == entity.CarID);
            CarToUpdate.CarName = entity.CarName;
            CarToUpdate.Description = entity.Description;
            CarToUpdate.DailyPrice = entity.DailyPrice;
            CarToUpdate.ModelYear = entity.ModelYear;
        }
    }
}
