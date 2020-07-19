using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DatVeXemPhim.Areas.Admin.Models;
using System.Web.Mvc;
using DatVeXemPhim.Dao;

namespace DatVeXemPhim.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            ViewBag.Slides = new SlideDao().ListAll();
            var filmDao = new ProductDao();
            ViewBag.NewFilms = filmDao.ListNewFilm();
            ViewBag.PhimSapChieu = filmDao.ListPhimSapChieu();
            
            return View();
        }

    }
}