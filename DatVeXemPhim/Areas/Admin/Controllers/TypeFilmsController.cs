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
    public class TypeFilmsController : Controller
    {
        private BookingTicketEntities1 db = new BookingTicketEntities1();

        // GET: Admin/TypeFilms
        public ActionResult Index()
        {
            return View(db.TypeFilms.ToList());
        }

        // GET: Admin/TypeFilms/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TypeFilm typeFilm = db.TypeFilms.Find(id);
            if (typeFilm == null)
            {
                return HttpNotFound();
            }
            return View(typeFilm);
        }

        // GET: Admin/TypeFilms/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/TypeFilms/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "TypId,NameT,Status")] TypeFilm typeFilm)
        {
            if (ModelState.IsValid)
            {
                db.TypeFilms.Add(typeFilm);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(typeFilm);
        }

        // GET: Admin/TypeFilms/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TypeFilm typeFilm = db.TypeFilms.Find(id);
            if (typeFilm == null)
            {
                return HttpNotFound();
            }
            return View(typeFilm);
        }

        // POST: Admin/TypeFilms/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "TypId,NameT,Status")] TypeFilm typeFilm)
        {
            if (ModelState.IsValid)
            {
                db.Entry(typeFilm).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(typeFilm);
        }

        // GET: Admin/TypeFilms/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TypeFilm typeFilm = db.TypeFilms.Find(id);
            if (typeFilm == null)
            {
                return HttpNotFound();
            }
            return View(typeFilm);
        }

        // POST: Admin/TypeFilms/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            TypeFilm typeFilm = db.TypeFilms.Find(id);
            db.TypeFilms.Remove(typeFilm);
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
