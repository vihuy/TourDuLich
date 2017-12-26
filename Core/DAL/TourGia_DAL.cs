using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.DAL
{
    public class TourGia_DAL
    {
        Database<Tour_Gia> tourgia_db;
        public TourGia_DAL()
        {
            tourgia_db = new Database<Tour_Gia>();
        }

        public IEnumerable GetList(DateTime dt)
        {

            var list = tourgia_db.Search(x => x.TGBD <= dt && x.TGKT >= dt).OrderByDescending(x => x.TGBD).Select(x => new {x.Tour.Ten, x.Gia }).ToList();
            return list;
        }
    }
}
