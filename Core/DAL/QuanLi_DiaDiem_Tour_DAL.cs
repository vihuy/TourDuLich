using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.DAL
{
    public class QuanLi_DiaDiem_Tour_DAL
    {
        TourDuLichEntities db = new TourDuLichEntities();

        /*public IEnumerable layTenDoan()
        {
            return db.Doans.Select(n => new { n.MaDoan, n.Ten }).ToList();
        }*/

        public IEnumerable layTenTour()
        {
            return db.Tours.Select(n => new { n.MaTour, n.Ten }).ToList();
        }

        public IEnumerable layTenLoaiHinh()
        {
            return db.Tours.Select(n => new { n.LoaiHinhDL }).ToList();
        }

        public IEnumerable layLoaiHinhTheoTour(int MaTour)
        {
            var query = from d in db.Tours
                        where d.MaTour == MaTour
                        join lh in db.LoaiHinhDLs on d.LoaiHinhDL equals lh.MaLHDL
                        select new
                        {
                            //LoaiHinhDL = lh.MaLHDL,
                            LoaiHinhDL = lh.Ten
                        };
             return query.ToList();
        }
        public IEnumerable layLoaiHinh()
        {
            var query = db.LoaiHinhDLs.Select( x=>  new {x.MaLHDL, x.Ten});
                      
            return query.ToList();
        }

        public IEnumerable laySoLuongNgay()
        {
            var query = db.Tours.Select(x => new { x.SLNgay });
            return query.ToList();
        }

        public IEnumerable layDiemKhoiHanh()
        {
            var query = db.DiaDiems.Select(x => new { x.MaDD, x.Ten});
            return query.ToList();
        }

        public IEnumerable layDiemKetThuc()
        {
            var query = db.DiaDiems.Select(x => new { x.MaDD, x.Ten });
            return query.ToList();
        }

        public IEnumerable layDiaDiem()
        {
            var query = db.DiaDiems.Select(x => new { x.MaDD, x.Ten });
            return query.ToList();
        }
    }

        /*public IEnumerable layTourTheoDoan(int MaDoan)
        {
            var query = from d in db.Doans
                        where d.MaDoan == MaDoan
                        join tg in db.Tour_Gia on d.MaTourGia equals tg.MaTourGia
                        join t in db.Tours on tg.MaTour equals t.MaTour
                        select new
                        {
                            MaTour = t.MaTour,
                            TenTour = t.Ten
                        };
            return query.ToList();          
        }*/


        /*public IEnumerable layDiaDiaTheoTour(int MaDoan, int MaTour)
        {
            var q = from d in db.Doans 
                    where d.MaDoan == MaDoan
                    join doanDD in db.Doan_DiaDiem on d.MaDoan equals doanDD.MaDoan
                    join diadiem in db.DiaDiems on doanDD.MaDD equals diadiem.MaDD
                    join tour in db.Tours on diadiem.ma
                    select new
                    {
                        MaDoan = t.,
                       
                        //MaDD = m.MaDD,
                        Ten = m.Ten,
                        GhiChu = md.GhiChu
                    };
            return q.ToList();
        }*/
    
}
