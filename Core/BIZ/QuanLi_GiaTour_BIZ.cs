using Core.DAL;
using System;
using System.Collections.Generic;
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
        public List<Tour> dsTour()
        {
            return ql_gia.dsTour();
        }
    }
}
