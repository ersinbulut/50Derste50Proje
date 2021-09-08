using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Proje6_AtliKulup.Models.Entity;

namespace Proje6_AtliKulup.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        Proje5AtDBEntities db = new Proje5AtDBEntities();
        public ActionResult Index()
        {
            var degerler = db.TBLBILGI.ToList();
            return View(degerler);
        }
    }
}