using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DatVeXemPhim.Dao;
namespace DatVeXemPhim.Controllers
{
    public class DetailController : Controller
    {
        // GET: Detail
        public ActionResult Index(int id)
        {
            var phim = new ProductDao().ViewDetail(id);
            ViewBag.Category = new ProductDao().ViewDetail(phim.FilId);
            return View(phim);
        }
    }
}