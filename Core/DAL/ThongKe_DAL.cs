using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.DAL
{
    public class ThongKe_DAL
    {
        TourDuLichEntities db = new TourDuLichEntities();
        public void ThongKe_DoanKhach_Tour(DateTime Ngaybd, DateTime Ngaykt, string MaTour)
        {
            
        }

        // Thống kê số lần nhân viên đi tour trong khoảng tg
        public void ThongKe_NhanVien_Tour(DateTime ngaybd, DateTime Ngaykt,int manv)
        {
            //var list = (from tour in db.Tours
            //            join tour_gia in db.Tour_Gia on tour.MaTour equals tour_gia.MaTour
            //            join doan in db.Doans on tour_gia.MaTourGia equals doan.MaTourGia
            //            join phancong in db.PhanCongs on doan.MaDoan equals phancong.MaDoan
            //            where phancong.MaNV == manv
            //            select new { phancong.MaNV});

           
            // Kiểm tra ngày đi phải lớn hơn ngày chọn bắt đầu và ngày về của đoàn phải nhỏ hơn ngày kết thúc.
            var list = db.Doans.Select(x => new {x => }).ToList();







        }
    }
}
