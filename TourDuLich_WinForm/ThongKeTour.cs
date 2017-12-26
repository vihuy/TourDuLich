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
<<<<<<< HEAD
using Core.Common;
using System.Collections;
=======
>>>>>>> 40ac28184ded5cd16c479530fa6d5f537ac86221
using System.Globalization;

namespace TourDuLich_WinForm
{
    public partial class ThongKeTour : Form
    {
<<<<<<< HEAD
        private SoLanDiTourModel dsThongKe;
        ThongKe_BIZ thongke_biz = new ThongKe_BIZ();
        QuanLi_GiaTour_BIZ gia_tour_biz = new QuanLi_GiaTour_BIZ();
        Tour_BIZ tour_biz = new Tour_BIZ();
        public ThongKeTour()
        {
            InitializeComponent();
            layDSTour();
            layDSLoaiHinh();
            layDSDiaDiem();

=======
        QuanLi_GiaTour_BIZ bus_gia_tour = new QuanLi_GiaTour_BIZ();
        ThongKe_DoanhSoTour_BIZ doanhso_tour = new ThongKe_DoanhSoTour_BIZ();
        public ThongKeTour()
        {
            InitializeComponent();
            layDSNhanVien();
            LayDSTour_DST();
>>>>>>> 40ac28184ded5cd16c479530fa6d5f537ac86221

        }
        public void layDSDiaDiem()
        {
            DiaDiem_BIZ diadiem_biz = new DiaDiem_BIZ();

            IEnumerable diadiem = diadiem_biz.GetList();
            cboDiemBD_themTour.DataSource = diadiem;
            cboDiemBD_themTour.DisplayMember = "Ten";
            cboDiemBD_themTour.ValueMember = "MaDD";
            cboDiemKT_themTour.DataSource = diadiem;
            cboDiemKT_themTour.DisplayMember = "Ten";
            cboDiemKT_themTour.ValueMember = "MaDD";



        }


        public void layDSTour()
        {
            Tour_BIZ tour_biz = new Tour_BIZ();

            dgvTour_TKTH.DataSource = tour_biz.GetList();


        }
        public void layDSLoaiHinh()
        {
            LoaiHinhDuLich_BIZ loaihinhdulich_biz = new LoaiHinhDuLich_BIZ();

            IEnumerable tour = loaihinhdulich_biz.GetList();
            cboLoaiHinh_themTour.DataSource = tour;
            cboLoaiHinh_themTour.DisplayMember = "Ten";
            cboLoaiHinh_themTour.ValueMember = "MaLHDL";



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

        private void bunifuCustomLabel7_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void btnThemGiaTour_Click(object sender, EventArgs e)
        {
            MessageBox.Show(txtGiaTour_themTour.text);
            if (txtGiaTour_themTour.text == "")
            {
                MessageBox.Show("Chưa thêm giá tour !!!", "Thông báo");

            }
            else
            {
               
                dgvGiaTour_themTour.Rows.Add(new object[] { dtBatDau_ThemTour.Value.ToString("dd / MM / yyyy"), dtKetThuc_ThemTour.Value.ToString("dd / MM / yyyy"), txtGiaTour_themTour.text, "Xóa" });
                dtBatDau_ThemTour.Value = dtBatDau_ThemTour.Value.Date.AddDays(1);
                dtKetThuc_ThemTour.Value = dtBatDau_ThemTour.Value.Date.AddDays(1);
            }
        }

        private void tblGiaTour_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void btnLuuTatCa_themTour_Click(object sender, EventArgs e)
        {
            if (txtGiaTour_themTour.text == "" || txtSoNgay_themTour.text == "" || txtTenTour_themTour.text == "")
            {
                MessageBox.Show("Vui lòng khai báo đầy đủ Thông tin tour !!!!", "Thông báo");
            }
            else if (dgvGiaTour_themTour.RowCount <= 0)
            {
                MessageBox.Show("Vui lòng nhập giá cho tour hiện tại...", "Thông báo");
            }
            else
            {
                Tour tour = new Tour();
                tour.Ten = txtTenTour_themTour.Text;
                tour.SLNgay = int.Parse(txtSoNgay_themTour.Text);
                tour.LoaiHinhDL = Convert.ToInt32(cboLoaiHinh_themTour.SelectedValue);
                tour.DiemKhoiHanh = Convert.ToInt32(cboDiemBD_themTour.SelectedValue);
                tour.DiemKetThuc = Convert.ToInt32(cboDiemKT_themTour.SelectedValue);
                tour.TrangThai = true;
                List<Tour_Gia> listGiaTour = new List<Tour_Gia>();
                for (int i = 0; i < dgvGiaTour_themTour.Rows.Count; i++)
                {
                    Tour_Gia giaTour = new Tour_Gia();
                    giaTour.TGBD = DateTime.ParseExact(dgvGiaTour_themTour.Rows[i].Cells[0].Value.ToString(), "dd / MM / yyyy", CultureInfo.CurrentCulture);
                    giaTour.TGKT = DateTime.ParseExact(dgvGiaTour_themTour.Rows[i].Cells[1].Value.ToString(), "dd / MM / yyyy", CultureInfo.CurrentCulture);
                    giaTour.Gia = int.Parse(dgvGiaTour_themTour.Rows[i].Cells[2].Value.ToString());
                    giaTour.TrangThai = true;
                    listGiaTour.Add(giaTour);
                }
                int maTour = tour_biz.ThemTourMoi(tour, listGiaTour);
                MessageBox.Show("Thêm thành công !!!");
            }
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
