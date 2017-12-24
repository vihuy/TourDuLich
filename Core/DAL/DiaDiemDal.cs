using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.DAL
{
    public class DiaDiemDal
    {
        TourDuLichEntities db = new TourDuLichEntities();
        public IEnumerable layDiaDiemTheoMaTinhThanh(int MaTinhThanh )
        {
            var linq = from dd in db.DiaDiems
                       where dd.TinhThanh == MaTinhThanh
                       select new { dd.MaDD, dd.Ten };
            return linq.ToList();
        }

        public IEnumerable <object> layDiaDiemTheoTour(int MaTour)
        {
            var linq = from t in db.Tours
                       join t_diadiem in db.

        }
    }
}
