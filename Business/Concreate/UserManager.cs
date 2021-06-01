using Business.Abstract;
using DataAccess.Abstract;
using Entity.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concreate
{

    public class UserManager : IUserService
    {
        IUserDal _userDal;

        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;

        }

        public void Add(User entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(User entity)
        {
            throw new NotImplementedException();
        }

        public List<User> GetAll()
        {
            return _userDal.GetAll();
        }

        public void Update(User entity)
        {
            throw new NotImplementedException();
        }
    }
}
