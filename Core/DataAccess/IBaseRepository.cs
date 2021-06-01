using System;
using System.Collections.Generic;
using System.Text;

namespace Core.DataAccess
{
    public interface IBaseRepository<T> where T : class, new()
    {

        void Add(T entity);
        void Delete(T entity);
        void Update(T entity);
    }
}
