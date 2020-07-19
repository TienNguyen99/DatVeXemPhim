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
    public class FilmsController : Controller
    {
        private BookingTicketEntities2 db = new BookingTicketEntities2();

        // GET: Admin/Films
        public ActionResult Index()
        {
            var films = db.Films.Include(f => f.Country).Include(f => f.TypeFilm);
            return View(films.ToList());
        }

        // GET: Admin/Films/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Film film = db.Films.Find(id);
            if (film == null)
            {
                return HttpNotFound();
            }
            return View(film);
        }

        // GET: Admin/Films/Create
        public ActionResult Create()
        {
            ViewBag.CouId = new SelectList(db.Countries, "CouId", "NameCo");
            ViewBag.TypId = new SelectList(db.TypeFilms, "TypId", "NameT");
            return View();
        }

        // POST: Admin/Films/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "FilId,TypId,CouId,NameF,Director,Actor,Duration,Description,Detail,Picture,PictureBig,Status")] Film film)
        {
            if (ModelState.IsValid)
            {
                db.Films.Add(film);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.CouId = new SelectList(db.Countries, "CouId", "NameCo", film.CouId);
            ViewBag.TypId = new SelectList(db.TypeFilms, "TypId", "NameT", film.TypId);
            return View(film);
        }

        // GET: Admin/Films/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Film film = db.Films.Find(id);
            if (film == null)
            {
                return HttpNotFound();
            }
            ViewBag.CouId = new SelectList(db.Countries, "CouId", "NameCo", film.CouId);
            ViewBag.TypId = new SelectList(db.TypeFilms, "TypId", "NameT", film.TypId);
            return View(film);
        }

        // POST: Admin/Films/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "FilId,TypId,CouId,NameF,Director,Actor,Duration,Description,Detail,Picture,PictureBig,Status")] Film film)
        {
            if (ModelState.IsValid)
            {
                db.Entry(film).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.CouId = new SelectList(db.Countries, "CouId", "NameCo", film.CouId);
            ViewBag.TypId = new SelectList(db.TypeFilms, "TypId", "NameT", film.TypId);
            return View(film);
        }

        // GET: Admin/Films/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Film film = db.Films.Find(id);
            if (film == null)
            {
                return HttpNotFound();
            }
            return View(film);
        }

        // POST: Admin/Films/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Film film = db.Films.Find(id);
            db.Films.Remove(film);
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
