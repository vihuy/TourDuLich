using Core.DAL;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.BIZ
{
    public class NhanVien_BIZ
    {
        NhanVien_DAL nhanvien_dal = new NhanVien_DAL();
        public IEnumerable GetList()
        {
            return nhanvien_dal.getList();
        }
    }
}
