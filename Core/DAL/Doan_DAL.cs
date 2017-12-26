using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.DAL
{
    public class Doan_DAL
    {
        Database<Doan> dbdoan;
        public List<Doan> TimDoan(string TimDoan)
        {
            dbdoan = new Database<Doan>();
            return dbdoan.Search(x => x.Ten.Contains(TimDoan));
        }
        public Doan Lay_Doan(int MaDoan)
        {
            dbdoan = new Database<Doan>();
            return dbdoan.GetSingle(x => x.MaDoan == MaDoan);
        }
    }
}
