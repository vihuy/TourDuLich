using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.DAL
{
    public class DiaDiem_DAL
    {
        Database<DiaDiem> diadiem_db;
        public DiaDiem_DAL()
        {
            diadiem_db = new Database<DiaDiem>();

        }
        public IEnumerable getList()
        {
            return diadiem_db.GetList();
        }

    }
}
