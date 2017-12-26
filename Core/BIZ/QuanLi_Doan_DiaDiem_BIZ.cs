using Core.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.BIZ
{
    public class QuanLi_Doan_DiaDiem_BIZ
    {
        QuanLi_Doan_DiaDiem_DAL doan_DiaDiem_DAL = new QuanLi_Doan_DiaDiem_DAL();

        public void ThemDoanDiaDiem(Doan_DiaDiem ddd)
        {
            doan_DiaDiem_DAL.ThemDoanDiaDiem(ddd);
        }

        public bool kiemTraTonTaiDiaDiemCuaDoan(int maDD, int maDoan)
        {
            return doan_DiaDiem_DAL.kiemTraTonTaiDiaDiemCuaDoan(maDD, maDoan);
        }
    }
}
