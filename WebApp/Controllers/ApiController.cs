using Core.BIZ;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApp.Controllers
{
    public class ApiController : Controller
    {
        QuanLi_ThoiGianTour_BIZ thoiGianTour_BIZ = new QuanLi_ThoiGianTour_BIZ();

        // GET: Api
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult LayThoiGianTour(int MaTour)
        {
            return Json(thoiGianTour_BIZ.LayThoiGianTourTheoMaTour(MaTour), JsonRequestBehavior.AllowGet);
        }
    }
}