using Core.DAL;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.BIZ
{
    public class LoaiHinhDuLich_BIZ
    {
        LoaiHinhDuLich_DAL loaihinh_dal = new LoaiHinhDuLich_DAL();
        public IEnumerable GetList()
        {
            return loaihinh_dal.getList();
        }
    }
}
