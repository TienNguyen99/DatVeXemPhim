using DatVeXemPhim.Dao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DatVeXemPhim.Controllers
{
    public class RapController : Controller
    {
        // GET: Rap
        public ActionResult Index()
        {
            ViewBag.Rap = new CinemaDao().ListRap();
            return View();
        }
    }
}