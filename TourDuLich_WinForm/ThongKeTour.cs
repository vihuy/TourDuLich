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
            layDSTour();


        }

        public void layDSTour()
        {
            Tour_BIZ tour_biz = new Tour_BIZ();

            dgvTour_TKTH.DataSource = tour_biz.GetList();


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
            DateTime dtngaybd = dtNgayBD_TKTH.Value;
            DateTime dtngaykt = dtNgayKT_TKTH.Value;
            int selectedrow = dgvTour_TKTH.CurrentCell.RowIndex;
            int matour = Convert.ToInt32(dgvTour_TKTH.Rows[selectedrow].Cells[0].Value.ToString());
            MessageBox.Show(""+matour);
            TinhHinhHoatDongModel dsThongKe = thongke_biz.ThongKeTinhHinhHoatDong(dtngaybd, dtngaykt, matour);
            string DoanThamGia = dsThongKe.DoanThamQuans + " VND";
            txtDoan_TKTH.Text = DoanThamGia;
            string DoanhThu = dsThongKe.DoanhThuTours + " VND";
            txtDoanhThu_TKTH.Text = DoanhThu;
            string LoiNhuan = dsThongKe.LoiNhuans + "";
            txtTienLoi_TKTH.Text = LoiNhuan;

        }
        //private void UpdateDataForChart(TinhHinhHoatDongModel dsThongKe)
        //{
        //    chartTinhHinh.Series.Clear();

        //    chartTinhHinh.Series.Add("DoanhThu");
        //    chartTinhHinh.Series["DoanhThu"].ChartType = SeriesChartType.Column;
        //    chartTinhHinh.Series["DoanhThu"].LegendText = "Doanh thu";
        //    chartTinhHinh.Series["DoanhThu"].IsVisibleInLegend = true;

        //    chartTinhHinh.Series.Add("LoiNhuan");
        //    chartTinhHinh.Series["LoiNhuan"].ChartType = SeriesChartType.Column;
        //    chartTinhHinh.Series["LoiNhuan"].LegendText = "Lợi nhuận";
        //    chartTinhHinh.Series["LoiNhuan"].IsVisibleInLegend = true;
        //    if (dsThongKe.ThoiGianTours.Count >= 0)
        //    {
        //        for (int i = 0; i < dsThongKe.ThoiGianTours.Count; i++)
        //        {
        //            string thoiGian = dsThongKe.ThoiGianTours[i];
        //            double doanhThu = dsThongKe.DoanhThuTours[i];
        //            double loiNhuan = dsThongKe.LoiNhuans[i];
        //            string doanThamQuan = dsThongKe.DoanThamQuans[i];

        //            DataPoint pointDoanhThu = new DataPoint();
        //            pointDoanhThu.YValues[0] = doanhThu;
        //            pointDoanhThu.IsValueShownAsLabel = true;
        //            pointDoanhThu.AxisLabel = string.Format("Thời gian\n{0}\n{1}", thoiGian, doanThamQuan);
        //            chartTinhHinh.Series["DoanhThu"].Points.Add(pointDoanhThu);
        //            chartTinhHinh.Series["DoanhThu"].IsXValueIndexed = false;

        //            DataPoint pointLoiNhuan = new DataPoint();
        //            pointLoiNhuan.YValues[0] = loiNhuan;
        //            pointLoiNhuan.IsValueShownAsLabel = true;
        //            chartTinhHinh.Series["LoiNhuan"].Points.Add(pointLoiNhuan);
        //        }
        //    }
        //    else
        //    {
        //        MessageBox.Show("Tour du lịch chưa có trạng thái hoạt động nào !!!", "Thông báo");
        //    }
        //}

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

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }


        
    }
}
