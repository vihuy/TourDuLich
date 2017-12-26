using Core.DAL;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.BIZ
{
    public class Tour_BIZ
    {
       Tour_DAL tour_dal = new Tour_DAL();
        public IEnumerable GetList()
        {
            return tour_dal.getList();
        }

        public int ThemTourMoi(Tour tour,List<Tour_Gia> tour_gia)
        {
            return tour_dal.ThemTourMoi(tour,tour_gia);
        }
    }
}
