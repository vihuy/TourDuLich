using Core.DAL;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.BIZ
{
    public class QuanLi_ThoiGianTour_BIZ
    {
        QuanLi_ThoiGianTour_DAL thoiGianTour_DAL = new QuanLi_ThoiGianTour_DAL();

        public IEnumerable<object> LayThoiGianTourTheoMaTour(int MaTour)
        {
            return thoiGianTour_DAL.LayThoiGianTourTheoMaTour(MaTour);
        }

        public ThoiGianTour LayThoiGianTourTheoMa(int MaThoiGianTour)
        {
            return thoiGianTour_DAL.LayThoiGianTourTheoMa(MaThoiGianTour);
        }
    }
}
