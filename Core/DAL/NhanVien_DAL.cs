using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.DAL
{
    public class NhanVien_DAL
    {
        Database<NhanVien> nhanvien_db;
        public NhanVien_DAL()
        {
            nhanvien_db = new Database<NhanVien>();
        
        }
        public IEnumerable getList()
        {
            return nhanvien_db.GetList();
        }
    }
}
