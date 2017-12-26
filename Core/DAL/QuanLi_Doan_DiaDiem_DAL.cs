using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.DAL
{
    public class QuanLi_Doan_DiaDiem_DAL
    {
        TourDuLichEntities db = new TourDuLichEntities();

        public void ThemDoanDiaDiem(Doan_DiaDiem ddd)
        {
            try
            {
                db.Doan_DiaDiem.Add(ddd);
                db.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool kiemTraTonTaiDiaDiemCuaDoan(int maDD, int maDoan)
        {
            try
            {
                db.Doan_DiaDiem.First(n => n.MaDD == maDD && n.MaDoan == maDoan);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
