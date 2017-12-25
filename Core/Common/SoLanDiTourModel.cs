using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Common
{
    public class SoLanDiTourModel
    {
        public List<NhanVien> ListNhanVien { get; set; }
        public List<int> SoLanDi { get; set; }
        public List<List<Doan>> ListDoanDaDi { get; set; }
    }
}
