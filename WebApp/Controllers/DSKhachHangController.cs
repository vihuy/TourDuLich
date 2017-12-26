using Core;
using Core.BIZ;
using Core.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApp.Controllers
{
    
    public class DSKhachHangController : Controller
    {
        QuanLi_Doan dal_doan = new QuanLi_Doan();
        QuanLi_KhachHang_BIZ khachHang_BIZ = new QuanLi_KhachHang_BIZ();

        // GET: DSKhachHang
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult ThemKhachHang()
        {
            return View();
        }

        [HttpPost]
        public ActionResult ThemKhachHang(KhachHang kh)
        {
            kh.TrangThai = true;
            kh.MaKH = 0;
            khachHang_BIZ.ThemKhachHang(kh);
            return RedirectToAction("ThemKhachHang");
        }

        public ActionResult Loadlencmb()
        {
            ViewBag.DS_Doan = new SelectList(dal_doan.layDSDoan().ToList(), "MaDoan", "Ten") ;
            return View();
        }
    }
}