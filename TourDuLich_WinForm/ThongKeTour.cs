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

namespace TourDuLich_WinForm
{
    public partial class ThongKeTour : Form
    {
        QuanLi_GiaTour_BIZ bus_gia_tour = new QuanLi_GiaTour_BIZ();
        public ThongKeTour()
        {
            InitializeComponent();
            layDSNhanVien();


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
    }
}
