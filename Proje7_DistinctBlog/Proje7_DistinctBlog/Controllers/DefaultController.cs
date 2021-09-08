using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Proje7_DistinctBlog.Models.Entity;
using Proje7_DistinctBlog.Models.Sınfım;

namespace Proje7_DistinctBlog.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        Proje6DistinctBlogDBEntities db = new Proje6DistinctBlogDBEntities();

        public ActionResult Index()
        {
            Class1 cs = new Class1();
            cs.Deger1 = db.TBLHAKKIMDA.ToList();
            cs.Deger2 = db.TBLILETİSİM.ToList();
            return View(cs);
        }
    }
}