using Core.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.BIZ
{
    public class ThemChiPhi_BIZ
    {
        ThemChiPhi_DAL themcp_dal = new ThemChiPhi_DAL();
        public List<Tour> TimTour(string TimTour)
        {
            return themcp_dal.TimTour(TimTour);
        }
        public List<Doan> Lay_Doan_Tour (string TimDoan)
        {
            return themcp_dal.Lay_Doan_Tour(TimDoan);
        }
        public List<DiaDiem> Lay_DD_Doan(int MaDoan)
        {
            return themcp_dal.Lay_DD_Doan(MaDoan);
        }
        public void ThemChiPhi_Doan_CPKS (int MaDoan, Doan_KhachSan[] doan_ks)
        {
            CTDoan ctdoan = themcp_dal.Lay_CTDoan(MaDoan);
            int gia = 0, tong = 0, sl = 0;
            foreach (Doan_KhachSan d_ks in doan_ks)
            {
                gia = d_ks.Gia;
                sl = ctdoan.Doan.SLKhach;
                tong += gia * sl;
            }
        }
    }
}
