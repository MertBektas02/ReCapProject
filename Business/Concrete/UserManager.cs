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
    public class UserManager : IUserService
    {
        IUsersDal _userDal;
        public UserManager(IUsersDal usersDal)
        {

            _userDal = usersDal;
        }
        public IResult Add(Users users)
        {
            _userDal.Add(users);
            return new SuccessResult();
        }

        public IDataResult<List<Users>> GetAll()
        {
            return new SuccessDataResult<List<Users>>(_userDal.GetAll(), Messages.UsersAdded);
        }

        public IDataResult<Users> GetById(int id)
        {
            return new SuccessDataResult<Users>(_userDal .Get(p => p.Id == id));

        }

        public IDataResult<List<UsersDetailDto>> GetUsersDetails()
        {
            return new SuccessDataResult<List<UsersDetailDto>>(_userDal.GetUsersDetails());
        }
    }
}
