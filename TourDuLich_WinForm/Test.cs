using Core.BIZ;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TourDuLich_WinForm
{
    public partial class Test : Form
    {
        QuanLi_DiaDiem_Tour_BIZ bus_tour = new QuanLi_DiaDiem_Tour_BIZ();

        public Test()
        {
            InitializeComponent();
            dsTour();
            dsLoaiHinh();
            dsDiemKhoiHanh();
            dsDiemKetThuc();
            dsDiaDiem();
        }

        public void dsTour()
        {
            IEnumerable tour = bus_tour.layTenTour();
            cmb_TenTour.DataSource = tour;
            cmb_TenTour.DisplayMember = "Ten";
            cmb_TenTour.ValueMember = "MaTour";
        }

        public void dsLoaiHinh()
        {
            IEnumerable loaihinh = bus_tour.layLoaiHinh();
            cmb_LoaiHinh.DataSource = loaihinh;
            cmb_LoaiHinh.DisplayMember ="Ten";
            cmb_LoaiHinh.ValueMember = "MaLHDL";
        }

        public void dsDiemKhoiHanh()
        {
            IEnumerable diadiem = bus_tour.layDiemKhoiHanh();
            cmb_NoiBatDau.DataSource = diadiem;
            cmb_NoiBatDau.DisplayMember = "Ten";
            cmb_NoiBatDau.ValueMember = "MaDD";
        }

        public void dsDiemKetThuc()
        {
            IEnumerable diadiem = bus_tour.layDiemKetThuc();
            cmb_DiemKetThuc.DataSource = diadiem;
            cmb_DiemKetThuc.DisplayMember = "Ten";
            cmb_DiemKetThuc.ValueMember = "MaDD";
        }

        public void dsDiaDiem()
        {
            IEnumerable diadiem = bus_tour.layDiaDiem();
            dataGridView_DSDiaDiem.DataSource = diadiem;
        }
        /*private void cboTenDoan_SelectedIndexChanged(object sender, EventArgs e)
        
            try
            {
                int MaDoan = int.Parse(cboTenDoan.SelectedValue.ToString());
                IEnumerable tour = bus_doan.layTourTheoDoan(MaDoan);
                dataGridView1.DataSource = tour;
            }
            catch (Exception)
            {
            }
        }*/

        private void cmb_TenTour_SelectedIndexChanged(object sender, EventArgs e)
        {

           /* try
            {
                int MaTour = int.Parse(cmb_TenTour.SelectedValue.ToString());
                IEnumerable tour = bus_tour.layTenTour();
                dataGridView_DSDiaDiem.DataSource = tour;
            }
            catch (Exception)
            {
            }*/
        }

        private void cmb_LoaiHinh_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int MaTour = int.Parse(cmb_LoaiHinh.SelectedValue.ToString());
                //IEnumerable loaihinh = bus_tour.layTenLoaiHinh();
                IEnumerable loaihinh = bus_tour.layLoaiHinhTheoTour(MaTour);
                dataGridView_DSDiaDiem.DataSource = loaihinh;
            }
            catch (Exception)
            {
            }
        }

        private void Test_Load(object sender, EventArgs e)
        {

        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            string IPTinhThanh = cmb_TenTour.SelectedIndex.ToString();
        }

        /*private void cmb_SLNgay_SelectedIndexChanged(object sender, EventArgs e)
        {

            try
            {
                int MaTour = int.Parse(cmb_SLNgay.SelectedValue.ToString());
                IEnumerable soluongngay = bus_tour.laySoLuongNgay();
                dataGridView1.DataSource = soluongngay;
            }
            catch (Exception)
            {
            }
        }*/

        private void cmb_NoiBatDau_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int MaTour = int.Parse(cmb_NoiBatDau.SelectedValue.ToString());
                IEnumerable noibatdau = bus_tour.layDiemKhoiHanh();
                dataGridView_DSDiaDiem.DataSource = noibatdau;
            }
            catch (Exception)
            {
            }
        }

        private void cboSoLuongNgay_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*try
            {
                int MaTour = int.Parse(cmb_SLNgay.SelectedValue.ToString());
                IEnumerable soluongngay = bus_tour.laySoLuongNgay();
                dataGridView1.DataSource = soluongngay;
            }
            catch (Exception)
            {
            }*/
        }

        private void cmb_DiemKetThuc_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int MaTour = int.Parse(cmb_DiemKetThuc.SelectedValue.ToString());
                IEnumerable diemketthuc = bus_tour.layDiemKetThuc();
                dataGridView_DSDiaDiem.DataSource = diemketthuc;
            }
            catch (Exception)
            {
            }
        }

        private void dataGridView_DSDiaDiem_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            IEnumerable diadiem = bus_tour.layDiaDiem();
            dataGridView_DSDiaDiem.DataSource = diadiem;
        }



        /*private void laydsdiadiemtourdulich(object sender, EventArgs e)
        {
            int MaDoan = int.Parse(cboTenDoan.SelectedValue.ToString());
            IEnumerable diadiem = bus_doan.layDiaDiaTheoTour(MaDoan);
            dataGridView2.DataSource = diadiem;
        }*/
    }
}
