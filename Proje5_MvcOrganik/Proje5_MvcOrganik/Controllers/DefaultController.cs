using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Proje5_MvcOrganik.Models.Entity;

namespace Proje5_MvcOrganik.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        Proje3TarımDBEntities db = new Proje3TarımDBEntities();
        public ActionResult Index()
        {
            var degerler = db.TBLURUNLER.ToList();
            return View(degerler);
        }
    }
}