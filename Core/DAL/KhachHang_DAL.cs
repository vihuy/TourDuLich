using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.DAL
{
    public class KhachHang_DAL
    {
        Database<KhachHang> dbkh;
        public List<KhachHang> TimKhachHang(string TimKhachHang)
        {
            dbkh = new Database<KhachHang>();
            return dbkh.Search(x => x.HoTen.Contains(TimKhachHang)).ToList();
        }
        public KhachHang Lay_KhachHang(int MaKH)
        {
            dbkh = new Database<KhachHang>();
            return dbkh.GetSingle(x => x.MaKH == MaKH);
        }

    }
}
