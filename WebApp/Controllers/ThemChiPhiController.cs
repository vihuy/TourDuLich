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
        // GET: ThemChiPhi
        public ActionResult Index(string TimTour)
        {
            ThemChiPhi_BIZ themcp_biz = new ThemChiPhi_BIZ();
            return View(themcp_biz.TimTour(TimTour));
        }
        public ActionResult Doan_Tour(string TimDoan)
        {
            ThemChiPhi_BIZ themcp_biz = new ThemChiPhi_BIZ();
            return View(themcp_biz.Lay_Doan_Tour(TimDoan));
        }
        public ActionResult ThemChiPhi_Doan_CPKS(int MaDoan)
        {
            ThemChiPhi_BIZ themcp_biz = new ThemChiPhi_BIZ();
            ViewBag.MaDD = new SelectList(themcp_biz.Lay_DD_Doan(MaDoan), "MaDD", "Ten");
            ViewBag.Tong = 1;
            ViewBag.MaDoan = MaDoan;
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult ThemChiPhi_Doan_CPKS(int MaDoan, [Bind(Prefix = "cpks")] Doan_KhachSan[] doan_ks)
        {
            ThemChiPhi_BIZ themcp_biz = new ThemChiPhi_BIZ();
            if (ModelState.IsValid)
            {
                themcp_biz.CapNhat_CTDoan(themcp_biz.ThemChiPhi_Doan_CPKS(MaDoan, doan_ks));
                ViewBag.MaDD = new SelectList(themcp_biz.Lay_DD_Doan(MaDoan), "MaDD", "Ten");
                ViewBag.MaDoan = MaDoan;
                return RedirectToAction("Index");
            }
            ViewBag.MaDD = new SelectList(themcp_biz.Lay_DD_Doan(MaDoan), "MaDD", "Ten");
            ViewBag.MaDoan = MaDoan;
            return View();
        }
        public ActionResult ThemChiPhi_Doan_CPPT(int MaDoan)
        {
            ThemChiPhi_BIZ themcp_biz = new ThemChiPhi_BIZ();
            ViewBag.MaDoan = MaDoan;
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult ThemChiPhi_Doan_CPPT(int MaDoan, [Bind(Prefix = "cppt")] Doan_PhuongTien[] doan_pt)
        {
            ThemChiPhi_BIZ themcp_biz = new ThemChiPhi_BIZ();
            if (ModelState.IsValid)
            {
                themcp_biz.ThemChiPhi_Doan_CPPT(MaDoan, doan_pt);
                return RedirectToAction("Index");
            }
            return View();
        }
        public ActionResult ThemChiPhi_Doan_CPQA(int MaDoan)
        {
            ThemChiPhi_BIZ themcp_biz = new ThemChiPhi_BIZ();
            ViewBag.MaDD = new SelectList(themcp_biz.Lay_DD_Doan(MaDoan), "MaDD", "Ten");
            ViewBag.MaDoan = MaDoan;
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult ThemChiPhi_Doan_CPQA(int MaDoan, [Bind(Prefix = "cpqa")] Doan_QuanAn[] doan_qa)
        {
            ThemChiPhi_BIZ themcp_biz = new ThemChiPhi_BIZ();
            if (ModelState.IsValid)
            {
                themcp_biz.ThemChiPhi_Doan_CPQA(MaDoan, doan_qa);
                return RedirectToAction("Index");
            }
            return View();
        }
        public ActionResult ThemChiPhi_Doan_CPKhac(int MaDoan)
        {
            ThemChiPhi_BIZ themcp_biz = new ThemChiPhi_BIZ();
            ViewBag.MaDoan = MaDoan;
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult ThemChiPhi_Doan_CPKhac(int MaDoan, [Bind(Prefix = "cpkhac")] Doan_ChiPhiKhac[] doan_cpkhac)
        {
            ThemChiPhi_BIZ themcp_biz = new ThemChiPhi_BIZ();
            if (ModelState.IsValid)
            {
                themcp_biz.ThemChiPhi_Doan_CPKhac(MaDoan, doan_cpkhac);
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}