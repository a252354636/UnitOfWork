﻿using EFFramework;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class BaseService : IBaseService
    {
        public UnitOfWork uw;
        public BaseService()
        {
            uw = new UnitOfWork();
        }
        public void Add<T>(T entity) where T :IBaseEntity
        {
            uw.Add<T>(entity);
        }

        public void Commit()
        {
            uw.Commit();
        }

        public T GetModel<T>(Expression<Func<T, bool>> filter) where T :IBaseEntity
        {
            return uw.GetModel<T>(filter);
        }
        public List<TM> GetSqlQuery<TM>()
        {
            string sql = "select b.ID bookid,b.Name BookName,u.Name UserName from books b join Users u on u.id = b.Uid  where b.id ={0}";
            return uw.GetSqlQuery<TM>(sql,"1");
        }
    }
}
