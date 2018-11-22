using Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;

namespace EFFramework
{
    public class Repository<T> where T : IBaseEntity
    {
        private BaseDbContext uw;
        private IDbSet<T> entities;

        private IDbSet<T> Entities
        {
            get
            {
                if (entities == null)
                {
                    entities = uw.Set<T>();
                }
                return entities;
            }
        }
        public Repository(BaseDbContext context)
        {
            this.uw = context;
        }
        public void Add(T entity)
        {
            this.Entities.Add(entity);
        }
        public void SaveChanges()
        {
            this.uw.SaveChanges();
        }
        public T GetModel(Expression<Func<T, bool>> filter)
        {
            return this.Entities.FirstOrDefault(filter);
        }
    }
}
