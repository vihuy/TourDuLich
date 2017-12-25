using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.DAL
{
   public class ThongKeChiPhi_DAL
    {
        public Database<Doan> dbdoan;
        public Database<CTDoan> dbctdoan;
        public Database<ThoiGianDoan> dbtgdoan;
        public Database<Doan_KhachSan> dbdoan_ks;
        public Database<Doan_PhuongTien> dbdoan_pt;
        public Database<Doan_QuanAn> dbdoan_qa;
        public Database<Doan_ChiPhiKhac> dbdoan_cpkhac;
        public List<ThoiGianDoan> Lay_DS_Doan(DateTime NgayDi, DateTime NgayVe)
        {
            dbtgdoan = new Database<ThoiGianDoan>();
            return dbtgdoan.Search(x => (x.NgayDi >= NgayDi && x.NgayVe <= NgayVe));
        }
        public CTDoan Lay_CTDoan(int MaDoan)
        {
            dbctdoan = new Database<CTDoan>();
            return dbctdoan.GetSingle(x => x.MaDoan == MaDoan);
        }
        public List<Doan_KhachSan> Lay_Doan_KS(int MaDoan)
        {
            dbdoan_ks = new Database<Doan_KhachSan>();
            return dbdoan_ks.Search(x => x.MaDoan == MaDoan);
        }
        public List<Doan_PhuongTien> Lay_Doan_PT(int MaDoan)
        {
            dbdoan_pt = new Database<Doan_PhuongTien>();
            return dbdoan_pt.Search(x => x.MaDoan == MaDoan);
        }
        public List<Doan_QuanAn> Lay_Doan_QA(int MaDoan)
        {
            dbdoan_qa = new Database<Doan_QuanAn>();
            return dbdoan_qa.Search(x => x.MaDoan == MaDoan);
        }
        public List<Doan_ChiPhiKhac> Lay_Doan_CPKhac(int MaDoan)
        {
            dbdoan_cpkhac = new Database<Doan_ChiPhiKhac>();
            return dbdoan_cpkhac.Search(x => x.MaDoan == MaDoan);
        }
    }
}
