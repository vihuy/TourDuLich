using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.DAL
{
    public class LoaiHinhDuLich_DAL
    {
        Database<LoaiHinhDL> loaihinh_db;
        public LoaiHinhDuLich_DAL()
        {
            loaihinh_db = new Database<LoaiHinhDL>();

        }
        public IEnumerable getList()
        {
            return loaihinh_db.GetList();
        }
    }
}
