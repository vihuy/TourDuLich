using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity.Core;
using Core.BIZ;
using Core;
using System.Globalization;

namespace TourDuLich_WinForm
{
    public partial class ThongKeTour : Form
    {
        QuanLi_GiaTour_BIZ bus_gia_tour = new QuanLi_GiaTour_BIZ();
        ThongKe_DoanhSoTour_BIZ doanhso_tour = new ThongKe_DoanhSoTour_BIZ();
        public ThongKeTour()
        {
            InitializeComponent();
            layDSNhanVien();
            LayDSTour_DST();

        }

        public void layDSNhanVien()
        {
            NhanVien_BIZ nhanvien_biz = new NhanVien_BIZ();
            cboTenNhanVien.DataSource = nhanvien_biz.GetList();
            cboTenNhanVien.DisplayMember = "HoTen";
            cboTenNhanVien.ValueMember = "MaNV";


        }
        

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ThongKeTour_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnXemBangGia_Tour_Click(object sender, EventArgs e)
        {
            TourGia_BIZ tour_gia = new TourGia_BIZ();
            DateTime thoigian = dtThoiGian_Tour.Value;
            dgvGia_Tour.DataSource = tour_gia.getList(thoigian);


        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnTimKiem_TKTH_Click(object sender, EventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void btnThongKe_NV_Tour_Click(object sender, EventArgs e)
        {
            DateTime dtNgaybd = dtNgayBD_NV.Value;
            DateTime dtNgaykt = dtNgayKT_NV.Value;
            int manv = int.Parse(cboTenNhanVien.SelectedValue.ToString());
            MessageBox.Show("" + manv);
        }
        
        public void LayDSTour_DST()
        {
            dtaGridVDSTour_DST.DataSource = doanhso_tour.Tour_List();
        }
        /*public void AutoComplete_DSTour()
        {
            try
            {
                txtTenTour_DST.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                txtTenTour_DST.AutoCompleteSource = AutoCompleteSource.CustomSource;
                AutoCompleteStringCollection auto = new AutoCompleteStringCollection();
                int _sl = dtaGridVDSTour_DST.RowCount - 1;
                for (int i = 0; i < _sl; i++)
                {
                    string _tentour;
                    _tentour = dtaGridVDSTour_DST.Rows[0].Cells["Ten"].Value.ToString();
                    auto.Add(_tentour);
                }
                txtTenTour_DST.AutoCompleteCustomSource = auto;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }*/

        private void btnLayDL_DSTour_Click(object sender, EventArgs e)
        {
            DateTime NgayBD = dtNgayBD_DST.Value;
            DateTime NgayKT = dtNgayKT_DST.Value;
            string TenTour = txtTenTour_DST.Text;
            dtaGridVDSTour_DST.DataSource = doanhso_tour.Tour_List_Condition(NgayBD, NgayKT, TenTour);
        }

        private void btnThongKe_DSTour_Click(object sender, EventArgs e)
        {
            List<int> MaTour = new List<int>();
            int _sl = dtaGridVDSTour_DST.SelectedRows.Count;
            for(int i = 0; i < _sl; i++)
            {
                MaTour.Add(int.Parse(dtaGridVDSTour_DST.SelectedRows[i].Cells[0].Value.ToString()));
                Console.WriteLine(dtaGridVDSTour_DST.SelectedRows[i].Cells[0].Value.ToString());
            }
            DateTime NgayBD = dtNgayBD_DST.Value;
            DateTime NgayKT = dtNgayKT_DST.Value;
            dtaGridVCTDST_DST.DataSource = doanhso_tour.Doan_List_TourList(NgayBD, NgayKT, MaTour);


            int _sldt = dtaGridVCTDST_DST.RowCount;
            int gia = 0, slkhach = 0, thanhtien = 0, tong = 0;
            for (int i = 0; i < _sldt; i++)
            {
                gia = int.Parse(dtaGridVCTDST_DST.Rows[i].Cells["Gia"].Value.ToString());
                slkhach = int.Parse(dtaGridVCTDST_DST.Rows[i].Cells["SLKhach"].Value.ToString());
                thanhtien = gia * slkhach;
                tong += thanhtien;
            }
            lbTDT.Text = tong.ToString("C", CultureInfo.GetCultureInfo("vi-VN"));
        }
    }
}
