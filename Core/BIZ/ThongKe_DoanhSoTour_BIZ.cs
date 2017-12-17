using Core.DAL;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Core.BIZ
{
    public class ThongKe_DoanhSoTour_BIZ
    {
        ThongKe_DoanhSoTour_DAL doanhsotour = new ThongKe_DoanhSoTour_DAL();
        public IEnumerable Tour_List()
        {
            return doanhsotour.Tour_List();
        }
        public IEnumerable Doan_List_Condition(DateTime NgayBD, DateTime NgayKT, string TenTour)
        {
            return doanhsotour.Doan_List_Condition(NgayBD, NgayKT, TenTour);
        }
        public IEnumerable Tour_List_Condition(DateTime NgayBD, DateTime NgayKT, string TenTour)
        {
            return doanhsotour.Tour_List_Condition(NgayBD, NgayKT, TenTour);
        }
        public IEnumerable Doan_List_TourList(DateTime NgayBD, DateTime NgayKT, List<int> MaTour)
        {
            return doanhsotour.Doan_List_TourList(NgayBD, NgayKT, MaTour);
        }
    }
}
