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
        IBaseService service = new BaseService();
        public BookController()
        {
        }


        //
        // GET: /Book/

        public ActionResult Index()
        {
            Book b = new Book();
            b.ID = 7;
            b.Name = "天书奇谈" + DateTime.Now;
            Users u = new Users();
            u.ID = 1;
            u.Name = "周杰伦"+DateTime.Now;
            service.Add(b);
            service.Add(u);
            service.Commit();
            service.GetModel<Book>(s => s.ID == 1);
           //book.Name = "天天向上";
            List<UserOnBookModel> bk = service.GetSqlQuery<UserOnBookModel>();

           return Content(bk[0].BookName);
           // return Content("");
        }

    }
}
