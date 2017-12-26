using Core.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.BIZ
{
    public class KhachHang_BIZ
    {
        KhachHang_DAL kh_dal = new KhachHang_DAL();
        public List<KhachHang> TimKhachHang (string TimKhachHang)
        {
            TimKhachHang = TimKhachHang != null ? TimKhachHang : "";
            return kh_dal.TimKhachHang(TimKhachHang);
        }
        public KhachHang Lay_KhachHang (int? MaKH)
        {
            return kh_dal.Lay_KhachHang(Convert.ToInt32(MaKH));
        }
    }
}
