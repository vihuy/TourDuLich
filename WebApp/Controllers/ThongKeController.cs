using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Core;
using WebApp.Models;

namespace WebApp.Controllers
{
    public class ThongKeController : Controller
    {
        private TourDuLichEntities db = new TourDuLichEntities();
        // GET: ThongKe
        public ActionResult Index(DateTime? NgayDi, DateTime? NgayVe)
        {
            var _NgayDi = NgayDi.GetValueOrDefault(DateTime.MinValue);
            var _NgayVe = NgayVe.GetValueOrDefault(DateTime.MaxValue);
            ViewBag.NgayDi = _NgayDi.ToString("yyyy-MM-dd");
            ViewBag.NgayVe = _NgayVe.ToString("yyyy-MM-dd");
            return View(db.ThoiGianDoans.Where(x => (x.NgayDi >= _NgayDi && x.NgayVe <= _NgayVe)).ToList());
        }
        public ActionResult Details_CTDoan(int? MaDoan)
        {
            if (MaDoan == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            CTDoan ctdoan = db.CTDoans.FirstOrDefault(x => x.MaDoan == MaDoan);

            if (ctdoan == null)
            {
                return HttpNotFound();
            }
            return View(ctdoan);
        }
        //GET: ThongKe/Details_Doan_CPKS/5
        public ActionResult Details_Doan_CPKS(int? MaDoan)
        {
            if (MaDoan == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            List<Doan_KhachSan> doan_ks = db.Doan_KhachSan.Where(x => x.MaDoan == MaDoan).ToList();
            CTDoan ctdoan = db.CTDoans.FirstOrDefault(x => x.MaDoan == MaDoan);
            ThongKeChiPhiViewModel tkcpvm = new ThongKeChiPhiViewModel();
            tkcpvm.CTDoan = ctdoan;
            tkcpvm.Doan_KhachSan = doan_ks;
            if (tkcpvm.Doan_KhachSan == null)
            {
                return HttpNotFound();
            }
            return View(tkcpvm);
        }
        //GET: ThongKe/Details_Doan_CPBA/5
        public ActionResult Details_Doan_CPBA(int? MaDoan)
        {
            if (MaDoan == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            List<Doan_QuanAn> doan_qa = db.Doan_QuanAn.Where(x => x.MaDoan == MaDoan).ToList();
            CTDoan ctdoan = db.CTDoans.FirstOrDefault(x => x.MaDoan == MaDoan);
            ThongKeChiPhiViewModel tkcpvm = new ThongKeChiPhiViewModel();
            tkcpvm.CTDoan = ctdoan;
            tkcpvm.Doan_QuanAn = doan_qa;
            if (tkcpvm.Doan_QuanAn == null)
            {
                return HttpNotFound();
            }
            return View(tkcpvm);
        }
        //GET: ThongKe/Details_Doan_CPPT/5
        public ActionResult Details_Doan_CPPT(int? MaDoan)
        {
            if (MaDoan == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            List<Doan_PhuongTien> doan_pt = db.Doan_PhuongTien.Where(x => x.MaDoan == MaDoan).ToList();
            CTDoan ctdoan = db.CTDoans.FirstOrDefault(x => x.MaDoan == MaDoan);
            ThongKeChiPhiViewModel tkcpvm = new ThongKeChiPhiViewModel();
            tkcpvm.CTDoan = ctdoan;
            tkcpvm.Doan_PhuongTien = doan_pt;
            if (tkcpvm.Doan_PhuongTien == null)
            {
                return HttpNotFound();
            }
            return View(tkcpvm);
        }
        //GET: ThongKe/Details_Doan_CPKhac/5
        public ActionResult Details_Doan_CPKhac(int? MaDoan)
        {
            if (MaDoan == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            List<Doan_ChiPhiKhac> doan_cpkhac = db.Doan_ChiPhiKhac.Where(x => x.MaDoan == MaDoan).ToList();
            CTDoan ctdoan = db.CTDoans.FirstOrDefault(x => x.MaDoan == MaDoan);
            ThongKeChiPhiViewModel tkcpvm = new ThongKeChiPhiViewModel();
            tkcpvm.CTDoan = ctdoan;
            tkcpvm.Doan_ChiPhiKhac = doan_cpkhac;
            if (tkcpvm.Doan_ChiPhiKhac == null)
            {
                return HttpNotFound();
            }
            return View(tkcpvm);
        }
    }
}