using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.DAL
{
    public class QuanLi_Tour_DAL
    {
        TourDuLichEntities db = new TourDuLichEntities();

        public IEnumerable LayTatCaDoan()
        {
            return db.Doans.ToList();
        }
    }
}
