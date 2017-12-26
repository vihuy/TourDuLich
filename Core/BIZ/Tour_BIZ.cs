using Core.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.BIZ
{
    public class Tour_BIZ
    {
        Tour_DAL tour_dal = new Tour_DAL();
        public List<Tour> TimTour (string TimTour)
        {
            TimTour = TimTour != null ? TimTour : "";
            return tour_dal.TimTour(TimTour);
        }
        public Tour Lay_Tour(int? MaTour)
        {
            return tour_dal.Lay_Tour(Convert.ToInt32(MaTour));
        }
    }
}
