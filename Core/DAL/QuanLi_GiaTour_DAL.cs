using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.DAL
{
    public class QuanLi_GiaTour_DAL
    {

        TourDuLichEntities db = new TourDuLichEntities();

        // danh sách Tour 
        public IEnumerable ds_Tour()
        {
            //List<Tour> tours = db.Tours.Select(x => new {x.MaTour, x.Ten,x.DiemKhoiHanh, x.DiemKetThuc});

            return db.Tours.Select(x => new { x.MaTour, x.Ten, x.DiemKhoiHanh, x.DiemKetThuc}).ToList();
        }

        // danh sách giá Tour
        public List<Tour_Gia> dsGia_Tour()
        {
            List<Tour_Gia> gia_tour = db.Tour_Gia.ToList();
           
            return gia_tour;
        }

        // lấy tên tour theo mã
        public IEnumerable layTenTour()
        {
            return db.Tours.Select(x => new { x.MaTour,x.Ten}).ToList();
        }


        public IEnumerable dsDoan()
        {
            var list = db.Doans.Select(n => new { n.MaDoan, n.Ten, n.MaTourGia }).Where(n => n.MaDoan == 2).ToList();
            return list;
        }
        public IEnumerable laySoLuongDoan_theoTour123()
        {
            // Dem số lượng đoàn tham gia 1 tour
            /*var list = (from tour in db.Tour_Gia
                        join doan in db.Doans on tour.MaTourGia equals doan.MaTourGia
                        group tour by tour.MaTour into t
                        select t);*/
            //var list = db.Tour_Gia.Select( x => new {x.MaTour, x.Tour}).ToList();
            //var list = db.Doans.Select( x => new { x.MaTourGia, } ).ToList();

            var list = db.Doans.GroupBy(c => c.Tour_Gia.MaTour).ToList();
            return list;
        }

        // Xem bảng giá tour hiện tại




    }
}
