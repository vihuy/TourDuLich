using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.DAL
{
    public class ThemChiPhi_DAL
    {
        private TourDuLichEntities db = new TourDuLichEntities();
        public List<Tour> TimTour(string TimTour)
        {
            TimTour = TimTour != null ? TimTour : "";
            return db.Tours.Where(x => x.Ten.Contains(TimTour)).ToList();
        }
        public List<Doan> Lay_Doan_Tour(string TimDoan)
        {
            TimDoan = TimDoan != null ? TimDoan : "";
            return db.Doans.Where(x => x.Ten.Contains(TimDoan)).ToList();
        }
        public List<DiaDiem> Lay_DD_Doan(int MaDoan)
        {
            List<Doan_DiaDiem> MaDiaDiem = db.Doan_DiaDiem.Where(x => x.MaDoan == MaDoan).ToList();
            List<int> mdd = new List<int>();
            foreach (Doan_DiaDiem ddd in MaDiaDiem)
            {
                mdd.Add(ddd.MaDD);
            }
            return db.DiaDiems.Where(x => mdd.Contains(x.MaDD)).ToList();
        }
        public CTDoan Lay_CTDoan (int MaDoan)
        {
            return db.CTDoans.FirstOrDefault(x => x.MaDoan == MaDoan);
        }
        public void ThemChiPhi_Doan_CPKS(int MaDoan, Doan_KhachSan[] doan_ks)
        {
            CTDoan ctdoan = Lay_CTDoan(MaDoan);
            int gia = 0, tong = 0, sl = 0;
            foreach (Doan_KhachSan d_ks in doan_ks)
            {
                gia = d_ks.Gia;
                sl = ctdoan.Doan.SLKhach;
                tong += gia * sl;
                db.Doan_KhachSan.Add(d_ks);
            }
            ctdoan.TongCPKS = tong;
            db.SaveChanges();
        }
    }
}
