using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.DAL
{
    public class QuanLi_ThoiGianTour_DAL
    {
        TourDuLichEntities db = new TourDuLichEntities();

        public IEnumerable<object> LayThoiGianTourTheoMaTour(int MaTour)
        {

            List<object> listSelect = new List<object>();
            var listThoiGian = db.ThoiGianTours.Where(x => x.MaTour == MaTour).ToList();
            listThoiGian.ForEach(x => {
                listSelect.Add(new
                {
                    MaThoiGian = x.MaThoiGianTour,
                    ThoiGian = x.NgayDi.Value.ToString("dd / MM / yyyy") + " -- " + x.NgayVe.Value.ToString("dd / MM / yyyy")
                });
            });
            return listSelect as IEnumerable<object>;
        }

        public ThoiGianTour LayThoiGianTourTheoMa(int MaThoiGianTour)
        {
            return db.ThoiGianTours.FirstOrDefault(n => n.MaThoiGianTour == MaThoiGianTour);
        }
    }
}
