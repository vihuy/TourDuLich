using Core.DAL;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.BIZ
{
    public class QuanLi_KhachHang_BIZ
    {
        QuanLi_KhachHang_DAL khachHang_DAL = new QuanLi_KhachHang_DAL();

        public void ThemKhachHang(KhachHang kh)
        {
            khachHang_DAL.ThemKhachHang(kh);
        }

        public IEnumerable LayTatCaKhachHang()
        {
            return khachHang_DAL.LayTatCaKhachHang();
        }

        public List<KhachHang> LayDanhSachKhachDangKyTheoMa(List<int> KhachHangs)
        {
            List<KhachHang> list = new List<KhachHang>();
            foreach(int item in KhachHangs)
            {
                KhachHang kh = khachHang_DAL.layKhachHangTheoMa(item);
                list.Add(kh);
            }
            return list;
        }

        
    }
}
