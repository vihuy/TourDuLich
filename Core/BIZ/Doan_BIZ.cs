using Core.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.BIZ
{
    public class Doan_BIZ
    {
        Doan_DAL doan_dal = new Doan_DAL();
        public List<Doan> TimDoan(string TimDoan)
        {
            TimDoan = TimDoan != null ? TimDoan : "";
            return doan_dal.TimDoan(TimDoan);
        }
        public Doan Lay_Doan(int? MaDoan)
        {
            return doan_dal.Lay_Doan(Convert.ToInt32(MaDoan));
        }
    }
}
