using DatVeXemPhim.Dao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DatVeXemPhim.Controllers
{
    public class RapDetailController : Controller
    {
        // GET: RapDetail
        public ActionResult Index(int id)
        {
            var rap = new CinemaDao().XemChiTiet(id);
            ViewBag.CheckRap = new CinemaDao().XemChiTiet(rap.CinId);
            return View(rap);
        }
    }
}