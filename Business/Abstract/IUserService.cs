using Core.Utilities.Results;
using Entity.Concrete;
using Entity.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IUserService
    {
        IDataResult<List<Users>> GetAll();
        IDataResult<Users> GetById(int id);
        IDataResult<List<UsersDetailDto>> GetUsersDetails();
        IResult Add(Users users);
    }
}
