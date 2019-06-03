using EFFramework;
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
      string sql = "select b.ID bookid,b.Name BookName,u.Name UserName from books b join Users u on u.id = b.Uid  where b.id ={0}";
      return uw.GetSqlQuery<TM>(sql, "1");
    }
  }
}
