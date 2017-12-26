using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Core;
using Core.BIZ;

namespace WebApp.Controllers
{
    public class ToursController : Controller
    {
        private TourDuLichEntities db = new TourDuLichEntities();
        Tour_BIZ tour_biz = new Tour_BIZ();
        // GET: Tours
        public ActionResult Index(string TimTour)
        {
            return View(tour_biz.TimTour(TimTour));
        }

        // GET: Tours/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tour tour = tour_biz.Lay_Tour(id);
            if (tour == null)
            {
                return HttpNotFound();
            }
            return View(tour);
        }

        // GET: Tours/Create
        public ActionResult Create()
        {
            ViewBag.DiemKetThuc = new SelectList(db.DiaDiems, "MaDD", "Ten");
            ViewBag.DiemKhoiHanh = new SelectList(db.DiaDiems, "MaDD", "Ten");
            ViewBag.LoaiHinhDL = new SelectList(db.LoaiHinhDLs, "MaLHDL", "Ten");
            return View();
        }

        // POST: Tours/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MaTour,Ten,DiemKhoiHanh,DiemKetThuc,SLNgay,LoaiHinhDL,TrangThai,GhiChu")] Tour tour)
        {
            if (ModelState.IsValid)
            {
                db.Tours.Add(tour);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.DiemKetThuc = new SelectList(db.DiaDiems, "MaDD", "Ten", tour.DiemKetThuc);
            ViewBag.DiemKhoiHanh = new SelectList(db.DiaDiems, "MaDD", "Ten", tour.DiemKhoiHanh);
            ViewBag.LoaiHinhDL = new SelectList(db.LoaiHinhDLs, "MaLHDL", "Ten", tour.LoaiHinhDL);
            return View(tour);
        }

        // GET: Tours/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tour tour = db.Tours.Find(id);
            if (tour == null)
            {
                return HttpNotFound();
            }
            ViewBag.DiemKetThuc = new SelectList(db.DiaDiems, "MaDD", "Ten", tour.DiemKetThuc);
            ViewBag.DiemKhoiHanh = new SelectList(db.DiaDiems, "MaDD", "Ten", tour.DiemKhoiHanh);
            ViewBag.LoaiHinhDL = new SelectList(db.LoaiHinhDLs, "MaLHDL", "Ten", tour.LoaiHinhDL);
            return View(tour);
        }

        // POST: Tours/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MaTour,Ten,DiemKhoiHanh,DiemKetThuc,SLNgay,LoaiHinhDL,TrangThai,GhiChu")] Tour tour)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tour).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.DiemKetThuc = new SelectList(db.DiaDiems, "MaDD", "Ten", tour.DiemKetThuc);
            ViewBag.DiemKhoiHanh = new SelectList(db.DiaDiems, "MaDD", "Ten", tour.DiemKhoiHanh);
            ViewBag.LoaiHinhDL = new SelectList(db.LoaiHinhDLs, "MaLHDL", "Ten", tour.LoaiHinhDL);
            return View(tour);
        }

        // GET: Tours/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tour tour = db.Tours.Find(id);
            if (tour == null)
            {
                return HttpNotFound();
            }
            return View(tour);
        }

        // POST: Tours/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Tour tour = db.Tours.Find(id);
            db.Tours.Remove(tour);
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
