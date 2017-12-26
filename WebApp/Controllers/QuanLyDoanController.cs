using Core;
using Core.BIZ;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApp.Controllers
{
    public class QuanLyDoanController : Controller
    {
        QuanLi_KhachHang_BIZ khachHang_BIZ = new QuanLi_KhachHang_BIZ();
        QuanLi_Tour_BIZ tour_BIZ = new QuanLi_Tour_BIZ();
        QuanLi_ThoiGianTour_BIZ thoigiantour_BIZ = new QuanLi_ThoiGianTour_BIZ();
        QuanLi_Doan_BIZ doan_BIZ = new QuanLi_Doan_BIZ();

        // GET: QuanLyDoan
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult TaoDoan()
        {
            ViewBag.DSKhachHang = khachHang_BIZ.LayTatCaKhachHang();
            ViewBag.TourSelectList = new SelectList(tour_BIZ.LayTatCaTour(), "MaTour", "Ten");
            return View();
        }
        public JsonResult LuuDoan(string tenDoan, string listId, int time)
        {
            doan_BIZ.LuuDoan(tenDoan, listId, time);
            return Json(200, JsonRequestBehavior.AllowGet);
            //var sessionList = new List<int>();
            //string[] dsId = listId.Split(';');
            //for (int i = 0; i < dsId.Length - 1; i++)
            //{
            //    sessionList.Add(Int32.Parse(dsId[i].Trim()));
            //}
            //List<KhachHang> list = khachHang_BIZ.LayDanhSachKhachDangKyTheoMa(sessionList);
            //ThoiGianTour thoiGianTour = thoigiantour_BIZ.LayThoiGianTourTheoMa(time);
        }
    }
}