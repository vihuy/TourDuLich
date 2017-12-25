using Core.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.BIZ
{
    public class ThongKeChiPhi_BIZ
    {
        ThongKeChiPhi_DAL tkcp_dal = new ThongKeChiPhi_DAL();
        public List<ThoiGianDoan> Lay_DS_Doan(DateTime NgayDi, DateTime NgayVe)
        {
            return tkcp_dal.Lay_DS_Doan(NgayDi, NgayVe);
        }
        public CTDoan Lay_CTDoan(int MaDoan)
        {
            return tkcp_dal.Lay_CTDoan(MaDoan);
        }
        public List<Doan_KhachSan> Lay_Doan_KS(int MaDoan)
        {
            return tkcp_dal.Lay_Doan_KS(MaDoan);
        }
        public List<Doan_PhuongTien> Lay_Doan_PT(int MaDoan)
        {
            return tkcp_dal.Lay_Doan_PT(MaDoan);
        }
        public List<Doan_QuanAn> Lay_Doan_QA(int MaDoan)
        {
            return tkcp_dal.Lay_Doan_QA(MaDoan);
        }
        public List<Doan_ChiPhiKhac> Lay_Doan_CPKhac(int MaDoan)
        {
            return tkcp_dal.Lay_Doan_CPKhac(MaDoan);
        }
    }
}
