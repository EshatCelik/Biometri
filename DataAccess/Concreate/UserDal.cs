using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entity.Entities;
using Entity.Entities.ContextEntities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concreate
{
    public class UserDal : IEFRepositoryBase<User, ContextDB>, IUserDal
    {
        List<User> list;
        public UserDal()
        {
            list = new List<User>()
                {
                new User() { Name = "ali", LastName = "can", BirthDate = "12.12.2020", Id = 1 },
                new User() { Name = "veli", LastName = "can", BirthDate = "12.12.2020", Id = 2 },
                new User() { Name = "deli", LastName = "can", BirthDate = "12.12.2020", Id = 3 },
                new User() { Name = "belli", LastName = "can", BirthDate = "12.12.2020", Id = 4 }
            };
        }
        public List<User> GetAll()
        {
            return list;

        }
    }
}
