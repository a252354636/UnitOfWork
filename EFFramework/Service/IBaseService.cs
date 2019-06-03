using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace EFFramework
{
  public  interface IBaseService
    {
        void Add<T>(T entity) where T :IBaseEntity;
        void Commit();

        T GetModel<T>(Expression<Func<T, bool>> filter) where T : IBaseEntity;

    }
}
