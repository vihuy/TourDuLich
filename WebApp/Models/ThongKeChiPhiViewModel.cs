using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Core;

namespace WebApp.Models
{
    public class ThongKeChiPhiViewModel
    {
        public Tour Tour { get; set; }
        public ThoiGianDoan ThoiGianDoan { get; set; }
        public Doan Doan { get; set; }
        public NhanVien NhanVien { get; set;}
        public CTDoan CTDoan { get; set; }
        public IEnumerable<Doan_KhachSan> Doan_KhachSan { get; set; }
        public IEnumerable<Doan_QuanAn> Doan_QuanAn { get; set; }
        public IEnumerable<Doan_PhuongTien> Doan_PhuongTien { get; set; }
        public IEnumerable<Doan_ChiPhiKhac> Doan_ChiPhiKhac { get; set; }
    }
}