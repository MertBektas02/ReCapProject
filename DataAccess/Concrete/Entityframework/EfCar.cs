using DataAccess.Abstract;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using Core.DataAccess.Entityframework;
using Entity.DTOs;

namespace DataAccess.Concrete.Entityframework
{
    public class EfCar : EfEntityRepositoryBase<CarEntity, CarProject1Context>, ICarDal
    {
        public List<CarDetailDto> GetCarDetails()
        {
            using (CarProject1Context context = new CarProject1Context()) 
            {
                var result = from p in context.CarEntitiesTable
                             join c in context.CarColorTable
                             on p.ColorID equals c.ID

                             join d in context.CarBrandTable
                             on p.BrandID equals d.Id


                             select new CarDetailDto
                             {
                                 CarID = p.CarID,
                                 CarName = p.CarName,
                                 DailyPrice = p.DailyPrice,
                                 ColorID = c.ID,
                                 Description = p.Description

                             };
                return result.ToList();
            }
        }
    }
}  //halen EfColor ve EfBrandDal classlarını oluşturmadım. İhtiyaç duyarsam oluşturacağım.
