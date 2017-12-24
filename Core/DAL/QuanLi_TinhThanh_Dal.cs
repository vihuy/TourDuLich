using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.DAL
{
    public class QuanLi_TinhThanh_Dal
    {
        TourDuLichEntities db = new TourDuLichEntities();
        public IEnumerable layTinhThanh()
        {
            var query = db.TinhThanhs.Select(x => new { x.MaTT, x.Ten });
            return query.ToList();
        }
    }
}
