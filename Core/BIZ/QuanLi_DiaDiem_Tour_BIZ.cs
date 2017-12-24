using Core.DAL;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.BIZ
{
    public class QuanLi_DiaDiem_Tour_BIZ
    {
        //QuanLi_DiaDiem_Tour_DAL dal_doan = new QuanLi_DiaDiem_Tour_DAL();

        QuanLi_DiaDiem_Tour_DAL dal_tour = new QuanLi_DiaDiem_Tour_DAL();
        DiaDiemDal diaDiemDAL = new DiaDiemDal();

        /*public IEnumerable layTenDoan()
        {
            return dal_doan.layTenDoan();
        }*/

        /*public IEnumerable layTourTheoDoan(int MaDoan)
        {
            return dal_doan.layTourTheoDoan(MaDoan);
        }*/

        public IEnumerable layTenTour()
        {
            return dal_tour.layTenTour();
        }

        public IEnumerable layTenLoaiHinh()
        {
            return dal_tour.layTenLoaiHinh();
        }
        public IEnumerable layLoaiHinhTheoTour(int MaTour)
        {
            return dal_tour.layLoaiHinhTheoTour(MaTour);
        }
        // lấy loại hình
        public IEnumerable layLoaiHinh()
        {
            return dal_tour.layLoaiHinh();
        }

        public IEnumerable laySoLuongNgay()
        {
            return dal_tour.laySoLuongNgay();
        }

        public IEnumerable layDiemKhoiHanh()
        {
            return dal_tour.layDiemKhoiHanh();
        }

        public IEnumerable layDiemKetThuc()
        {
            return dal_tour.layDiemKetThuc();
        }

        public IEnumerable layDiaDiem()
        {
            return dal_tour.layDiaDiem();
        }

        public IEnumerable layDiaDiemTheoTinhThanh(int MaTinhThanh)
        {
            return diaDiemDAL.layDiaDiemTheoMaTinhThanh(MaTinhThanh); 
        }

    }
}
