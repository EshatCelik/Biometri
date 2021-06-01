using Core.DataAccess;
using Entity.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IUserDal:IBaseRepository<User>
    {
        List<User> GetAll();

    }
}
