using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.DAL
{
    public class ThemChiPhi_DAL
    {
        public Database<Tour> dbtour;
        public Database<Doan> dbdoan;
        public Database<CTDoan> dbctdoan;
        public Database<DiaDiem> dbdd;
        public Database<Doan_DiaDiem> dbdoan_dd;
        public Database<Doan_KhachSan> dbdoan_ks;
        public Database<Doan_PhuongTien> dbdoan_pt;
        public Database<Doan_QuanAn> dbdoan_qa;
        public Database<Doan_ChiPhiKhac> dbdoan_cpkhac;

        public List<Tour> TimTour(string TimTour)
        {
            dbtour = new Database<Tour>();
            return dbtour.Search(x => x.Ten.Contains(TimTour)).ToList();
        }
        public List<Doan> Lay_Doan_Tour(string TimDoan)
        {
            dbdoan = new Database<Doan>();
            return dbdoan.Search(x => x.Ten.Contains(TimDoan)).ToList();
        }
        public Doan Lay_Doan_CTDoan(CTDoan ctdoan)
        {
            dbdoan = new Database<Doan>();
            return dbdoan.GetSingle(x => x.MaDoan == ctdoan.MaDoan);
        }
        public List<DiaDiem> Lay_DD_Doan(int MaDoan)
        {
            dbdoan_dd = new Database<Doan_DiaDiem>();
            dbdd = new Database<DiaDiem>();
            List<Doan_DiaDiem> MaDiaDiem = dbdoan_dd.Search(x => x.MaDoan == MaDoan).ToList();
            List<int> mdd = new List<int>();
            foreach (Doan_DiaDiem ddd in MaDiaDiem)
            {
                mdd.Add(ddd.MaDD);
            }
            return dbdd.Search(x => mdd.Contains(x.MaDD)).ToList();
        }
        public CTDoan Lay_CTDoan (int MaDoan)
        {
            dbctdoan = new Database<CTDoan>();
            return dbctdoan.GetSingle(x => x.MaDoan == MaDoan);
        }
        public void CapNhat_CTDoan (CTDoan ctdoan)
        {
            dbctdoan = new Database<CTDoan>();
            dbctdoan.Update(ctdoan);
        }
        public void ThemChiPhi_Doan_CPKS (Doan_KhachSan doan_ks)
        {
            dbdoan_ks = new Database<Doan_KhachSan>();
            dbdoan_ks.Insert(doan_ks);
        }
        public void ThemChiPhi_Doan_CPKS (Doan_KhachSan[] doan_ks)
        {
            foreach (Doan_KhachSan d_ks in doan_ks)
            {
                ThemChiPhi_Doan_CPKS(d_ks);
                dbdoan_ks.Detach(d_ks);
            }
        }
        public void ThemChiPhi_Doan_CPPT(Doan_PhuongTien doan_pt)
        {
            dbdoan_pt = new Database<Doan_PhuongTien>();
            dbdoan_pt.Insert(doan_pt);
        }
        public void ThemChiPhi_Doan_CPPT(Doan_PhuongTien[] doan_pt)
        {
            foreach (Doan_PhuongTien d_pt in doan_pt)
            {
                ThemChiPhi_Doan_CPPT(d_pt);
            }
        }
        public void ThemChiPhi_Doan_CPQA(Doan_QuanAn doan_qa)
        {
            dbdoan_qa = new Database<Doan_QuanAn>();
            dbdoan_qa.Insert(doan_qa);
        }
        public void ThemChiPhi_Doan_CPQA(Doan_QuanAn[] doan_qa)
        {
            foreach (Doan_QuanAn d_qa in doan_qa)
            {
                ThemChiPhi_Doan_CPQA(d_qa);
            }
        }
        public void ThemChiPhi_Doan_CPKhac(Doan_ChiPhiKhac doan_cpkhac)
        {
            dbdoan_cpkhac = new Database<Doan_ChiPhiKhac>();
            dbdoan_cpkhac.Insert(doan_cpkhac);
        }
        public void ThemChiPhi_Doan_CPKhac(Doan_ChiPhiKhac[] doan_cpkhac)
        {
            foreach (Doan_ChiPhiKhac d_cpk in doan_cpkhac)
            {
                ThemChiPhi_Doan_CPKhac(d_cpk);
            }
        }
    }
}
