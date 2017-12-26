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
        Database<Tour_Gia> giatour_db;
        public Tour_DAL()
        {
            tour_db = new Database<Tour>();

        }
        public IEnumerable getList()
        {
            return tour_db.GetList();
        }
        public int ThemTourMoi(Tour tour, List<Tour_Gia> listGiaTour)
        {
            var addedTour = tour_db.Insert(tour);
            SaveChange();
            listGiaTour.ForEach(x =>
            {
                x.MaTour = tour.MaTour;
                giatour_db.Insert(x);
            });
            SaveChange();
            return tour.MaTour;
        }

        private void SaveChange()
        {
            
            tour_db.Commit();
        }
    }
}
