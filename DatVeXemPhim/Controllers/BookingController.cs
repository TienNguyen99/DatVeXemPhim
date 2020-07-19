using DatVeXemPhim.Dao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DatVeXemPhim.Controllers
{
    public class BookingController : Controller
    {
        // GET: Booking
        public ActionResult Index()
        {
            return View();
        }
        
        public ActionResult LichChieu(long id)
        {
            ViewBag.Raps = new BookingDao().ListAllCinema();
            ViewBag.Shows = new BookingDao().ListLichChieu();
            var phim = new ProductDao().ViewDetail(id);
            ViewBag.Category = new ProductDao().ViewDetail(phim.FilId);
            return View(phim);
        }
    }
}