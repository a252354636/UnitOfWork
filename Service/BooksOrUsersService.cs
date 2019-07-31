﻿using EFFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
  public  class BooksOrUsersService: BaseService
  {
    public List<TM> GetSqlQuery<TM>()
    {
      string sql = "select b.ID newsid,b.title title,u.user_name UserName from dt_channel_article_news b join dt_users u on u.user_name = b.user_name  where b.id ={0}";
      return uw.GetSqlQuery<TM>(sql, "1");
    }
  }
}
