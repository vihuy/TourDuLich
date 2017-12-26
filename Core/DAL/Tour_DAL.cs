using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.DAL
{
    public class Tour_DAL
    {
        Database<Tour> dbtour;
        public List<Tour> TimTour (string TimTour)
        {
            dbtour = new Database<Tour>();
            return dbtour.Search(x => x.Ten.Contains(TimTour));
        }
        public Tour Lay_Tour (int MaTour)
        {
            dbtour = new Database<Tour>();
            return dbtour.GetSingle(x => x.MaTour == MaTour);
        }
    }
}
