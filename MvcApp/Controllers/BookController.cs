using EFFramework;
using Models;
using Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApp.Controllers
{
  public class BookController : Controller
  {
    BooksOrUsersService service = new BooksOrUsersService();
    public BookController()
    {
    }


    //
    // GET: /Book/

    public ActionResult Index()
    {
      //Book b = new Book();
      //b.ID = 7;
      //b.Uid = 1;
      //b.Name = "天书奇谈" + DateTime.Now;
      //users u = new users();
      //u.id = 1;
      //u.user_name = "周杰伦" + DateTime.Now;
      //service.Add(b);
      //service.Add(u);
      //service.Commit();
     users users = service.GetModel<users>(s => s.id == 1);
      //book.Name = "天天向上";
      List<UserOnBookModel> bk = service.GetSqlQuery<UserOnBookModel>();

      return Content(bk[0].BookName);
      // return Content("");
    }

  }
}
