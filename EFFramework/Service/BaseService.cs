using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace EFFramework
{
  public class BaseService : IBaseService 
  {
    public UnitOfWork uw;
    public BaseService()
    {
      uw = new UnitOfWork();
    }
    public void Add<T>(T entity) where T : IBaseEntity
    {
      uw.Add<T>(entity);
    }

    public void Commit()
    {
      uw.Commit();
    }

    public T GetModel<T>(Expression<Func<T, bool>> filter) where T : IBaseEntity
    {
      return uw.GetModel<T>(filter);
    }
 
  }
}

