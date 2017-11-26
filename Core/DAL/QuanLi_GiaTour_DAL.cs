using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.DAL
{
    public class QuanLi_GiaTour_DAL
    {
        TourDuLichEntities db = new TourDuLichEntities();
        // danh sách giá Tour
        public List<Tour_Gia> dsGia_Tour()
        {
            List<Tour_Gia> gia_tour = db.Tour_Gia.ToList();
            return gia_tour;
        }
        // danh sách Tour
        public List<Tour> dsTour()
        {
            List<Tour> tour = db.Tours.ToList();
            return tour;
        }

    }
}
