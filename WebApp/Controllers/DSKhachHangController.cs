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

        // GET: DSKhachHang
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Loadlencmb()
        {
            ViewBag.DS_Doan = new SelectList(dal_doan.layDSDoan().ToList(), "MaDoan", "Ten") ;
            return View();
        }
    }
}