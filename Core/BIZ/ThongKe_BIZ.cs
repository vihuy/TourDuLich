using Core.Common;
using Core.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.BIZ
{
    public class ThongKe_BIZ
    {
        ThongKe_DAL thongke_dal = new ThongKe_DAL();
        public SoLanDiTourModel ThongKeSoLan_DiTour(DateTime bd, DateTime kt)
        {
            return thongke_dal.ThongKeSoLan_DiTour(bd,kt);
        }
    }
}
