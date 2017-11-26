using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Core;

namespace WebApp.Controllers
{
    public class DoansController : Controller
    {
        private TourDuLichEntities db = new TourDuLichEntities();

        // GET: Doans
        public ActionResult Index(string TimDoan)
        {
            TimDoan = TimDoan != null ? TimDoan : "";
            return View(db.Doans.Where(x => x.Ten.Contains(TimDoan)).ToList());
        }

        // GET: Doans/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Doan doan = db.Doans.Find(id);
            if (doan == null)
            {
                return HttpNotFound();
            }
            return View(doan);
        }

        // GET: Doans/Create
        public ActionResult Create()
        {
            ViewBag.MaTourGia = new SelectList(db.Tour_Gia, "MaTourGia", "GhiChu");
            ViewBag.TruongDoan = new SelectList(db.NhanViens, "MaNV", "HoTen");
            return View();
        }

        // POST: Doans/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MaDoan,Ten,SLKhach,SLNV,MaTourGia,TruongDoan")] Doan doan)
        {
            if (ModelState.IsValid)
            {
                db.Doans.Add(doan);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.MaTourGia = new SelectList(db.Tour_Gia, "MaTourGia", "GhiChu", doan.MaTourGia);
            ViewBag.TruongDoan = new SelectList(db.NhanViens, "MaNV", "HoTen", doan.TruongDoan);
            return View(doan);
        }

        // GET: Doans/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Doan doan = db.Doans.Find(id);
            if (doan == null)
            {
                return HttpNotFound();
            }
            ViewBag.MaTourGia = new SelectList(db.Tour_Gia, "MaTourGia", "GhiChu", doan.MaTourGia);
            ViewBag.TruongDoan = new SelectList(db.NhanViens, "MaNV", "HoTen", doan.TruongDoan);
            return View(doan);
        }

        // POST: Doans/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MaDoan,Ten,SLKhach,SLNV,MaTourGia,TruongDoan")] Doan doan)
        {
            if (ModelState.IsValid)
            {
                db.Entry(doan).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.MaTourGia = new SelectList(db.Tour_Gia, "MaTourGia", "GhiChu", doan.MaTourGia);
            ViewBag.TruongDoan = new SelectList(db.NhanViens, "MaNV", "HoTen", doan.TruongDoan);
            return View(doan);
        }

        // GET: Doans/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Doan doan = db.Doans.Find(id);
            if (doan == null)
            {
                return HttpNotFound();
            }
            return View(doan);
        }

        // POST: Doans/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Doan doan = db.Doans.Find(id);
            db.Doans.Remove(doan);
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
