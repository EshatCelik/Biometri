using Entity.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IUserService
    {
        void Add(User entity);
        void Delete(User entity);
        void Update(User entity);
        List<User> GetAll();
    }
}
