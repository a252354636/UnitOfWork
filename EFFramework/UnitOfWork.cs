using EFFramework;
using Models;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace EFFramework
{
    public class UnitOfWork : IDisposable
    {
        private BaseDbContext context;
        private bool disposed;
        private Dictionary<string, object> repositories;
        private QueryReporitory qr;
        public UnitOfWork()
        {
            context = new BaseDbContext();
        }

        private Repository<T> Repository<T>() where T : IBaseEntity
        {
            if (repositories == null)
            {
                repositories = new Dictionary<string, object>();
            }

            var type = typeof(T).Name;

            if (!repositories.ContainsKey(type))
            {
                var repositoryType = typeof(Repository<>);
                var repositoryInstance = Activator.CreateInstance(repositoryType.MakeGenericType(typeof(T)), context);
                repositories.Add(type, repositoryInstance);
            }
            return (Repository<T>)repositories[type];
        }
        private QueryReporitory Repository()
        {
            if (qr == null)
                qr = (QueryReporitory)Activator.CreateInstance(typeof(QueryReporitory), context);
            return qr;
        }
        public void Add<T>(T entity) where T : IBaseEntity
        {
            var rep = this.Repository<T>();
            rep.Add(entity);
        }
        public void Commit()
        {
            foreach (var key in repositories)
            {
                ((dynamic)key.Value).SaveChanges();
            }
        }
        public T GetModel<T>(Expression<Func<T, bool>> filter) where T : IBaseEntity
        {
            var rep = this.Repository<T>();
            return rep.GetModel(filter);
        }
        public List<TM> GetSqlQuery<TM>(string sql, params object[] parameters)
        {
            return this.Repository().GetSqlQuery<TM>(sql, parameters);
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        public virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            disposed = true;
        }
    }
}
