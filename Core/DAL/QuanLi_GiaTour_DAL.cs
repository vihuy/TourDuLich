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
       
        
       
    }
}
