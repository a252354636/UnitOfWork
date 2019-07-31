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
      Book b = new Book();
      //b.ID = 7;
      //b.Uid = 1;
      //b.Name = "天书奇谈" + DateTime.Now;
      //users u = new users();
      //u.id = 1;
      //u.user_name = "周杰伦" + DateTime.Now;
      //service.Add(b);
      //service.Add(u);
      //service.Commit();
      service.Add(b);
      channel_article_news u = service.GetModel<channel_article_news>(s => s.id == 13);
      //book.Name = "天天向上";
      // List<UserOnBookModel> bk = service.GetSqlQuery<UserOnBookModel>();
      u.title += "哈哈哈啊哈哈哈哈";
      service.Commit();
      return Content(u.title);
      // return Content("");
    }

  }
}
