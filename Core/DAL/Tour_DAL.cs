using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.DAL
{
    public class Tour_DAL
    {

        Database<Tour> tour_db;
        public Tour_DAL()
        {
            tour_db = new Database<Tour>();

        }
        public IEnumerable getList()
        {
            return tour_db.GetList();
        }
    }
}
