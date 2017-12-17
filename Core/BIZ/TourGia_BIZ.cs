using Core.DAL;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.BIZ
{
    public class TourGia_BIZ
    {
        TourGia_DAL tour_gia = new TourGia_DAL();
        public IEnumerable getList(DateTime dt)
        {
            return tour_gia.GetList(dt);
        }
    }
}
