using EFFramework;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
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
      context.SaveChanges();
      //foreach (var key in repositories)
      //{
      //    ((dynamic)key.Value).SaveChanges();
      //}
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
    /// <summary>
    /// 分页查询 
    /// </summary>
    /// <param name="pageCount">总页数</param>
    /// <param name="pageIndex">当前页码</param>
    /// <param name="pageSize">页容量</param>
    /// <param name="whereLambda">条件 lambda表达式</param>
    /// <param name="orderByExpressions">多条件排序</param>
    /// <returns></returns>
    public IQueryable<T> GetListByPageByOrders<T>(ref int Count, int pageIndex, int pageSize, Expression<Func<T, bool>> whereLambda, params IOrderByExpression<T>[] orderByExpressions) where T : IBaseEntity
    {

      try
      {
        Count = context.Set<T>().Where(whereLambda).Count();
        var query = context.Set<T>().Where(whereLambda);
        if (orderByExpressions == null)
          return query;

        IOrderedQueryable<T> output = null;

        foreach (var orderByExpression in orderByExpressions)
        {
          if (output == null)
            output = orderByExpression.ApplyOrderBy(query);
          else
            output = orderByExpression.ApplyThenBy(output);
        }

        return output.Skip((pageIndex - 1) * pageSize).Take(pageSize) ?? query.Skip((pageIndex - 1) * pageSize).Take(pageSize);
      }
      catch (Exception ex)
      {
        return null;
      }
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
