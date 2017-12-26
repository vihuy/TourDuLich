using Core.DAL;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.BIZ
{
    public class QuanLi_GiaTour_BIZ
    {
        QuanLi_GiaTour_DAL ql_gia = new QuanLi_GiaTour_DAL();
        public List<Tour_Gia> dsGia_Tour()
        {
            return ql_gia.dsGia_Tour();
        }
        public IEnumerable dsTour()
        {
            return ql_gia.ds_Tour();

        }
        public IEnumerable layTenTour()
        {
            return ql_gia.layTenTour();
        }

        public IEnumerable dsDoan()
        {
            return ql_gia.dsDoan();
        }


        public IEnumerable laySoLuongDoan_TheoTour()
        {
            return ql_gia.laySoLuongDoan_theoTour123();
        }


    }
}
