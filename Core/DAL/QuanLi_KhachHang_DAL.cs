using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.DAL
{
    public class QuanLi_KhachHang_DAL
    {
        TourDuLichEntities db = new TourDuLichEntities();

        public void ThemKhachHang(KhachHang kh)
        {
            try
            {
                db.KhachHangs.Add(kh);
                db.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public IEnumerable LayTatCaKhachHang()
        {
            return db.KhachHangs.ToList();
        }

        public KhachHang layKhachHangTheoMa(int MaKH)
        {
            return db.KhachHangs.FirstOrDefault(n => n.MaKH == MaKH);
        }
    }
}
