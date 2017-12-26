using Core.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.BIZ
{
    public class QuanLi_Doan_BIZ
    {
        QuanLi_Doan doanDAL = new QuanLi_Doan();
        QuanLi_DangKy_DAL dangKyDAL = new QuanLi_DangKy_DAL();

        public void LuuDoan(string TenDoan, string listId, int time)
        {
            var sessionList = new List<int>();
            string[] dsId = listId.Split(';');
            for (int i = 0; i < dsId.Length - 1; i++)
            {
                sessionList.Add(Int32.Parse(dsId[i].Trim()));
            }

            //Lưu đoàn để sinh ID 
            Doan doan = new Doan();
            doan.Ten = TenDoan;
            doan.SLKhach = sessionList.Count();
            doan.MaThoiGianTour = time;
            doan.TnhTrang = 1;
            doanDAL.ThemDoan(doan);

            foreach (int MaKH in sessionList)
            {
                DangKi dk = new DangKi();
                dk.MaDoan = doan.MaDoan;
                dk.MaKH = MaKH;
                dk.MaThoiGian = time;
                dk.NgayDK = DateTime.Now.Date;
                dangKyDAL.ThemDangKi(dk);
            }
        }

        public List<Doan> layDSDoan()
        {
            return doanDAL.layDSDoan();
        }

    }
}
