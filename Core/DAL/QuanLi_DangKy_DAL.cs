using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.DAL
{
    public class QuanLi_DangKy_DAL
    {
        TourDuLichEntities db = new TourDuLichEntities();

        public void ThemDangKi(DangKi dk)
        {
            try
            {
                db.DangKis.Add(dk);
                db.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
