using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DatVeXemPhim.Areas.Admin.Models;
using System.Web.Mvc;

namespace DatVeXemPhim.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            BookingTicketEntities1 db = new BookingTicketEntities1();
            var data = (from d in db.Slides select d).ToList();

            return View(data);
        }
    }
}