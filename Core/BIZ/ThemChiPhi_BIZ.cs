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
        public List<Tour> TimTour(string TimTour)
        {
            ThemChiPhi_DAL themcp_dal = new ThemChiPhi_DAL();
            TimTour = TimTour != null ? TimTour : "";
            return themcp_dal.TimTour(TimTour);
        }
        public List<Doan> Lay_Doan_Tour (string TimDoan)
        {
            ThemChiPhi_DAL themcp_dal = new ThemChiPhi_DAL();
            TimDoan = TimDoan != null ? TimDoan : "";
            return themcp_dal.Lay_Doan_Tour(TimDoan);
        }
        public List<DiaDiem> Lay_DD_Doan(int MaDoan)
        {
            ThemChiPhi_DAL themcp_dal = new ThemChiPhi_DAL();
            return themcp_dal.Lay_DD_Doan(MaDoan);
        }
        public void ThemChiPhi_Doan_CPKS(int MaDoan, Doan_KhachSan[] doan_ks)
        {
            ThemChiPhi_DAL themcp_dal = new ThemChiPhi_DAL();
            CTDoan ctdoan = themcp_dal.Lay_CTDoan(doan_ks[0].MaDoan);
            Doan doan = themcp_dal.Lay_Doan_CTDoan(ctdoan);
            int gia = 0, tong = 0, sl = 0;
            sl = doan.SLKhach;
            tong = ctdoan.TongCPKS;
            foreach (Doan_KhachSan d_ks in doan_ks)
            {
                gia = d_ks.Gia;
                tong += gia * sl;
            }
            ctdoan.TongCPKS = tong;
            themcp_dal.ThemChiPhi_Doan_CPKS(doan_ks);
            themcp_dal.CapNhat_CTDoan(ctdoan);
        }
        public void CapNhat_CTDoan(CTDoan ctdoan)
        {
            ThemChiPhi_DAL themcp_dal = new ThemChiPhi_DAL();
            themcp_dal.CapNhat_CTDoan(ctdoan);
        }
        public void ThemChiPhi_Doan_CPPT(int MaDoan, Doan_PhuongTien[] doan_pt)
        {
            ThemChiPhi_DAL themcp_dal = new ThemChiPhi_DAL();
            CTDoan ctdoan = themcp_dal.Lay_CTDoan(MaDoan);
            int gia = 0, tong = 0;
            tong = ctdoan.TongCPPT;
            foreach (Doan_PhuongTien d_pt in doan_pt)
            {
                gia = d_pt.Gia;
                tong += gia;
            }
            ctdoan.TongCPPT = tong;
            themcp_dal.ThemChiPhi_Doan_CPPT(doan_pt);
            themcp_dal.CapNhat_CTDoan(ctdoan);
        }
        public void ThemChiPhi_Doan_CPQA(int MaDoan, Doan_QuanAn[] doan_qa)
        {
            ThemChiPhi_DAL themcp_dal = new ThemChiPhi_DAL();
            CTDoan ctdoan = themcp_dal.Lay_CTDoan(MaDoan);
            int gia = 0, tong = 0, sl = 0;
            sl = ctdoan.Doan.SLKhach;
            tong = ctdoan.TongCPBA;
            foreach (Doan_QuanAn d_ks in doan_qa)
            {
                gia = d_ks.Gia;
                tong += gia * sl;
            }
            ctdoan.TongCPBA = tong;
            themcp_dal.ThemChiPhi_Doan_CPQA(doan_qa);
            themcp_dal.CapNhat_CTDoan(ctdoan);
        }
        public void ThemChiPhi_Doan_CPKhac(int MaDoan, Doan_ChiPhiKhac[] doan_cpkhac)
        {
            ThemChiPhi_DAL themcp_dal = new ThemChiPhi_DAL();
            CTDoan ctdoan = themcp_dal.Lay_CTDoan(MaDoan);
            int gia = 0, tong = 0, sl = 0;
            sl = ctdoan.Doan.SLKhach;
            tong = ctdoan.TongCPKS;
            foreach (Doan_ChiPhiKhac d_khac in doan_cpkhac)
            {
                gia = d_khac.Gia;
                tong += gia * sl;
            }
            ctdoan.TongCPKS = tong;
            themcp_dal.ThemChiPhi_Doan_CPKhac(doan_cpkhac);
            themcp_dal.CapNhat_CTDoan(ctdoan);
        }
    }
}
