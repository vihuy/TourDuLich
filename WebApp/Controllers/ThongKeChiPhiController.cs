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
using System.Globalization;
using Core.BIZ;

namespace WebApp.Controllers
{
    public class ThongKeChiPhiController : Controller
    {
        private TourDuLichEntities db = new TourDuLichEntities();
        ThongKeChiPhi_BIZ tkcp_biz = new ThongKeChiPhi_BIZ();
        // GET: ThongKe
        public ActionResult Index(DateTime? NgayDi, DateTime? NgayVe)
        {
            var _NgayDi = NgayDi.GetValueOrDefault(DateTime.MinValue);
            var _NgayVe = NgayVe.GetValueOrDefault(DateTime.MaxValue);
            ViewBag.NgayDi = _NgayDi.ToString("yyyy-MM-dd");
            ViewBag.NgayVe = _NgayVe.ToString("yyyy-MM-dd");
            return View(tkcp_biz.Lay_DS_Doan(_NgayDi, _NgayVe));
        }
        public ActionResult Details_CTDoan(int? MaDoan)
        {
            if (MaDoan == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            
            CTDoan ctdoan = tkcp_biz.Lay_CTDoan(int.Parse(MaDoan.ToString()));

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
            List<Doan_KhachSan> doan_ks = tkcp_biz.Lay_Doan_KS(int.Parse(MaDoan.ToString()));
            CTDoan ctdoan = tkcp_biz.Lay_CTDoan(int.Parse(MaDoan.ToString()));
            ThongKeChiPhiViewModel tkcpvm = new ThongKeChiPhiViewModel();
            tkcpvm.CTDoan = ctdoan;
            tkcpvm.Doan_KhachSan = doan_ks;
            if (tkcpvm.Doan_KhachSan == null)
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
            List<Doan_PhuongTien> doan_pt = tkcp_biz.Lay_Doan_PT(int.Parse(MaDoan.ToString()));
            CTDoan ctdoan = tkcp_biz.Lay_CTDoan(int.Parse(MaDoan.ToString()));
            ThongKeChiPhiViewModel tkcpvm = new ThongKeChiPhiViewModel();
            tkcpvm.CTDoan = ctdoan;
            tkcpvm.Doan_PhuongTien = doan_pt;
            if (tkcpvm.Doan_PhuongTien == null)
            {
                return HttpNotFound();
            }
            return View(tkcpvm);
        }
        //GET: ThongKe/Details_Doan_CPBA/5
        public ActionResult Details_Doan_CPQA(int? MaDoan)
        {
            if (MaDoan == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            List<Doan_QuanAn> doan_qa = tkcp_biz.Lay_Doan_QA(int.Parse(MaDoan.ToString()));
            CTDoan ctdoan = tkcp_biz.Lay_CTDoan(int.Parse(MaDoan.ToString()));
            ThongKeChiPhiViewModel tkcpvm = new ThongKeChiPhiViewModel();
            tkcpvm.CTDoan = ctdoan;
            tkcpvm.Doan_QuanAn = doan_qa;
            if (tkcpvm.Doan_QuanAn == null)
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
            List<Doan_ChiPhiKhac> doan_cpkhac = tkcp_biz.Lay_Doan_CPKhac(int.Parse(MaDoan.ToString()));
            CTDoan ctdoan = tkcp_biz.Lay_CTDoan(int.Parse(MaDoan.ToString()));
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