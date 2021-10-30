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
    public class EfUserDal : EfEntityRepositoryBase<Users, CarProject1Context>, IUsersDal
    {
        public List<UsersDetailDto> GetUsersDetails()
        {
            using (CarProject1Context context=new CarProject1Context())
            {
                var result = from p in context.Users
                             join x in context.CustomersTable
                             on p.Id equals x.UserId

                             select new UsersDetailDto
                             {
                                 UserId = x.UserId,
                                 CompanyName=x.CompanyName,

                                 Id = p.Id,
                                 FirstName =p.FirstName,
                                 LastName=p.LastName,
                                 Email=p.Email,
                                 Password=p.Password
                                 
                             };
                return result.ToList();
            }
        }
    }
}
