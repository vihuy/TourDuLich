using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Core;
using Core.BIZ;

namespace WebApp.Controllers
{
    public class ThemChiPhiController : Controller
    {
        private TourDuLichEntities db = new TourDuLichEntities();
        ThemChiPhi_BIZ themcp_biz = new ThemChiPhi_BIZ();
        // GET: ThemChiPhi
        public ActionResult Index(string TimTour)
        {
            return View(themcp_biz.TimTour(TimTour));
        }
        public ActionResult Doan_Tour(string TimDoan)
        {
            return View(themcp_biz.Lay_Doan_Tour(TimDoan));
        }
        /*public ActionResult ThemChiPhi_Doan(int MaDoan, string LoaiChiPhi)
        {
            LoaiChiPhi = LoaiChiPhi != null ? LoaiChiPhi : "";
            ViewBag.MaDoan = MaDoan;
            string view = "";
            if (LoaiChiPhi == "CPKS") return RedirectToAction("ThemChiPhi_Doan_CPKS", "ThemChiPhi");
            return View(view);
        }
        [HttpPost]
        public ActionResult ThemChiPhi_Doan(int LoaiChiPhi, int MaDoan)
        {
            if (LoaiChiPhi == 0)
            {
                ViewBag.MaDoan = MaDoan;
                return View("ThemChiPhi_Doan_CPKS");
            }
            if (LoaiChiPhi == 1)
            {
                ViewBag.MaDoan = MaDoan;
                return View("ThemChiPhi_Doan_CPBA");
            }
            if (LoaiChiPhi == 2)
            {
                ViewBag.MaDoan = MaDoan;
                return View("ThemChiPhi_Doan_CPPT");
            }
            if (LoaiChiPhi == 3)
            {
                ViewBag.MaDoan = MaDoan;
                return View("ThemChiPhi_Doan_CPKhac");
            }
            return View();
        }*/
        public ActionResult ThemChiPhi_Doan_CPKS(int MaDoan)
        {
            ViewBag.MaDD = new SelectList(themcp_biz.Lay_DD_Doan(MaDoan), "MaDD", "Ten");
            ViewBag.MaDoan = MaDoan;
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult ThemChiPhi_Doan_CPKS(int MaDoan, [Bind(Prefix = "cpks")] Doan_KhachSan[] doan_ks)
        {
            if(ModelState.IsValid)
            {
                themcp_biz.ThemChiPhi_Doan_CPKS(MaDoan, doan_ks);
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}