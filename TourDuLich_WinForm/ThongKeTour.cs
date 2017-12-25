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
using Core.Common;

namespace TourDuLich_WinForm
{
    public partial class ThongKeTour : Form
    {
        private SoLanDiTourModel dsThongKe;
        ThongKe_BIZ thongke_biz = new ThongKe_BIZ();
        QuanLi_GiaTour_BIZ bus_gia_tour = new QuanLi_GiaTour_BIZ();
        public ThongKeTour()
        {
            InitializeComponent();
            layDSNhanVien();


        }

        public void layDSNhanVien()
        {
            NhanVien_BIZ nhanvien_biz = new NhanVien_BIZ();
           
            //dgvNhanVien.DataSource = nhanvien_biz.GetList();


        }
        

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ThongKeTour_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tourDuLichDataSet2.Tour' table. You can move, or remove it, as needed.
            this.tourTableAdapter.Fill(this.tourDuLichDataSet2.Tour);



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
            dsThongKe = thongke_biz.ThongKeSoLan_DiTour(dtNgaybd, dtNgaykt);
            dgvNhanVien.DataSource = dsThongKe.ListNhanVien;

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvNhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvNhanVien_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvNhanVien.SelectedRows)
            {
                int maNhanVien = int.Parse(row.Cells[0].Value.ToString());
                for (int i = 0; i < dsThongKe.ListNhanVien.Count; i++)
                {
                    if (dsThongKe.ListNhanVien[i].MaNV == maNhanVien)
                    {
                        string soLanDi = dsThongKe.SoLanDi[i] + " lần";
                        lblSoLanDi.Text = soLanDi;
                        dgvDoan_ThongKe.DataSource = dsThongKe.ListDoanDaDi[i];
                        break;
                    }
                }
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void dgvGia_Tour_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
