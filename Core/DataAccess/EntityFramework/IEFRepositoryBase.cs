
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.DataAccess.EntityFramework
{
    public class IEFRepositoryBase<TEntity, TContext> : IBaseRepository<TEntity>
        where TEntity : class, new() 
        where TContext : DbContext, new()
    {
        public void Add(TEntity entity)
        {
            using (TContext db =new TContext())
            {
                var dd = db.Entry(entity);
                dd.State = EntityState.Added;
                db.SaveChanges();
            }
        }

        public void Delete(TEntity entity)
        {
            using (TContext db =new TContext())
            {
                var sil = db.Entry(entity);
                sil.State = EntityState.Deleted;
                db.SaveChanges();
            }
        }

      

        public void Update(TEntity entity)
        {
            using (TContext db = new TContext())
            {
                var dd = db.Entry(entity);
                dd.State = EntityState.Modified;
                db.SaveChanges();
            }
        }
    }
}
