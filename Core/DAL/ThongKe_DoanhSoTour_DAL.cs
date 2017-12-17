using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Core.DAL
{
    class ThongKe_DoanhSoTour_DAL
    {
        TourDuLichEntities db = new TourDuLichEntities();
        public IEnumerable Tour_List()
        {
            return db.Tours.Select(n => new { n.MaTour, n.Ten, n.LoaiHinhDL, n.SLNgay }).ToList();
        }
        public IEnumerable Doan_List_Condition(DateTime NgayBD, DateTime NgayKT, string TenTour)
        {
            TenTour = TenTour != null ? TenTour : "";
            NgayBD = NgayBD.Date;
            NgayKT = NgayKT.Date;
            return db.ThoiGianDoans.Where(x => (x.NgayDi >= NgayBD && x.NgayVe <= NgayKT && x.Doan.Tour_Gia.Tour.Ten.Contains(TenTour))).Select(n => new { n.MaDoan, n.Doan.Ten, n.Doan.Tour_Gia.Gia, n.Doan.SLKhach}).ToList();
        }
        public IEnumerable Tour_List_Condition(DateTime NgayBD, DateTime NgayKT, string TenTour)
        {
            TenTour = TenTour != null ? TenTour : "";
            NgayBD = NgayBD.Date;
            NgayKT = NgayKT.Date;
            return db.ThoiGianDoans.Where(x => (x.NgayDi >= NgayBD && x.NgayVe <= NgayKT && x.Doan.Tour_Gia.Tour.Ten.Contains(TenTour))).Select(n => new { n.Doan.Tour_Gia.Tour.MaTour, n.Doan.Tour_Gia.Tour.Ten, n.Doan.Tour_Gia.Tour.LoaiHinhDL, n.Doan.Tour_Gia.Tour.SLNgay }).ToList();
        }
        public IEnumerable Doan_List_TourList(DateTime NgayBD, DateTime NgayKT, List<int> MaTour)
        {
            NgayBD = NgayBD.Date;
            NgayKT = NgayKT.Date;
           return db.ThoiGianDoans.Where(x => (x.NgayDi >= NgayBD && x.NgayVe <= NgayKT && MaTour.Contains(x.Doan.Tour_Gia.MaTour))).Select(n => new { n.MaDoan, n.Doan.Ten, n.Doan.SLKhach, n.NgayDi, n.NgayVe, n.Doan.Tour_Gia.Gia}).ToList();
        }
    }
}
