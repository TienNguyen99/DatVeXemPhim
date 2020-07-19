using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using DatVeXemPhim.Areas.Admin.Models;

namespace DatVeXemPhim.Areas.Admin.Controllers
{
    public class ShowTimesController : Controller
    {
        private BookingTicketEntities2 db = new BookingTicketEntities2();

        // GET: Admin/ShowTimes
        public ActionResult Index()
        {
            var showTimes = db.ShowTimes.Include(s => s.Cinema).Include(s => s.Film);
            return View(showTimes.ToList());
        }

        // GET: Admin/ShowTimes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ShowTime showTime = db.ShowTimes.Find(id);
            if (showTime == null)
            {
                return HttpNotFound();
            }
            return View(showTime);
        }

        // GET: Admin/ShowTimes/Create
        public ActionResult Create()
        {
            ViewBag.CinId = new SelectList(db.Cinemas, "CinId", "NameCi");
            ViewBag.FilId = new SelectList(db.Films, "FilId", "NameF");
            return View();
        }

        // POST: Admin/ShowTimes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ShoId,FilId,CinId,ShowTime1,Time,View,Price,Status")] ShowTime showTime)
        {
            if (ModelState.IsValid)
            {
                db.ShowTimes.Add(showTime);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.CinId = new SelectList(db.Cinemas, "CinId", "NameCi", showTime.CinId);
            ViewBag.FilId = new SelectList(db.Films, "FilId", "NameF", showTime.FilId);
            return View(showTime);
        }

        // GET: Admin/ShowTimes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ShowTime showTime = db.ShowTimes.Find(id);
            if (showTime == null)
            {
                return HttpNotFound();
            }
            ViewBag.CinId = new SelectList(db.Cinemas, "CinId", "NameCi", showTime.CinId);
            ViewBag.FilId = new SelectList(db.Films, "FilId", "NameF", showTime.FilId);
            return View(showTime);
        }

        // POST: Admin/ShowTimes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ShoId,FilId,CinId,ShowTime1,Time,View,Price,Status")] ShowTime showTime)
        {
            if (ModelState.IsValid)
            {
                db.Entry(showTime).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.CinId = new SelectList(db.Cinemas, "CinId", "NameCi", showTime.CinId);
            ViewBag.FilId = new SelectList(db.Films, "FilId", "NameF", showTime.FilId);
            return View(showTime);
        }

        // GET: Admin/ShowTimes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ShowTime showTime = db.ShowTimes.Find(id);
            if (showTime == null)
            {
                return HttpNotFound();
            }
            return View(showTime);
        }

        // POST: Admin/ShowTimes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ShowTime showTime = db.ShowTimes.Find(id);
            db.ShowTimes.Remove(showTime);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
