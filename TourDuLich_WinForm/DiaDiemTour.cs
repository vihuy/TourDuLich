using Core;
using Core.BIZ;
using Core.ViewModel;
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
    public partial class DiaDiemTour : Form
    {
        QuanLi_DiaDiem_Tour_BIZ bus_tour = new QuanLi_DiaDiem_Tour_BIZ();
        Quanli_TinhThanh_BIZ bus_tinhthanh = new Quanli_TinhThanh_BIZ();
        QuanLi_DiaDiem_Tour_BIZ bus_diadiem = new QuanLi_DiaDiem_Tour_BIZ();
        QuanLi_Doan_BIZ doan_BIZ = new QuanLi_Doan_BIZ();
        QuanLi_Doan_DiaDiem_BIZ quanLi_Doan_DiaDiem_BIZ = new QuanLi_Doan_DiaDiem_BIZ();

        public DiaDiemTour()
        {
            InitializeComponent();
            dsTour();
            dsTinhThanh();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        public void dsTour()
        {
            IEnumerable doan = doan_BIZ.layDSDoan();
            cmb_TenTour.DataSource = doan;
            cmb_TenTour.DisplayMember = "Ten";
            cmb_TenTour.ValueMember = "MaDoan";
        }
        
        public void dsTinhThanh()
        {
            IEnumerable tinhthanh = bus_tinhthanh.layTinhThanh();
            cmb_TinhThanh.DataSource = tinhthanh;
            cmb_TinhThanh.DisplayMember = "Ten";
            cmb_TinhThanh.ValueMember = "MaTT";

        }

        public void layDSDiaDiem()
        {

            
           
        }

        private void cmb_TinhThanh_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                // lay du lieu tu combobox
                int matinhthanh = Convert.ToInt32(cmb_TinhThanh.SelectedValue);
                IEnumerable diadiem = bus_diadiem.layDiaDiemTheoTinhThanh(matinhthanh);
                dataGridView_DSDiaDiem.DataSource = diadiem;
            }
            catch (Exception)
            {
                
            }
            
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            string MaTinhThanh = cmb_TinhThanh.SelectedValue.ToString();
            string TenTinhThanh = cmb_TinhThanh.Text;
            foreach (DataGridViewRow row in dataGridView_DSDiaDiem.SelectedRows)
            {
                var MaDiaDIem = row.Cells[0].Value.ToString();
                var TenDiaDiem = row.Cells[1].Value.ToString();
                DataGridView_DSDiaDiemdaydu.Rows.Add(new object[] { MaDiaDIem, TenDiaDiem, MaTinhThanh, TenTinhThanh,"Xóa" });
            }
        }

        private void DataGridView_DSDiaDiemdaydu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == DataGridView_DSDiaDiemdaydu.Columns["Xoa"].Index && e.RowIndex >= 0)
            {
                DataGridView_DSDiaDiemdaydu.Rows.RemoveAt(e.RowIndex);
            }
        }

        private void cmb_TenTour_SelectedIndexChanged(object sender, EventArgs e)
        {
            //try
            //{
            //    DataGridView_DSDiaDiemdaydu.Rows.Clear();
            //    int MaTour = int.Parse(cmb_TenTour.SelectedValue.ToString());
            //    //foreach (DiaDiemModel item in bus_tour.layDiaDiem(MaTour)) ;
            //    //{

            //    //}
            //    //{

            //    //}
            //}
            //catch (Exception)
            //{

            //    throw;
            //}
        }

        private void DiaDiemTour_Load(object sender, EventArgs e)
        {

        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in DataGridView_DSDiaDiemdaydu.Rows)
            {
                int MaDD = int.Parse(row.Cells["MaDiaDiem"].Value.ToString());
                int MaDoan = int.Parse(cmb_TenTour.SelectedValue.ToString());
                if (quanLi_Doan_DiaDiem_BIZ.kiemTraTonTaiDiaDiemCuaDoan(MaDD, MaDoan) == false)
                {
                    Doan_DiaDiem doan_dd = new Doan_DiaDiem();
                    doan_dd.MaDD = MaDD;
                    doan_dd.MaDoan = MaDoan;
                    doan_dd.GhiChu = "";
                    quanLi_Doan_DiaDiem_BIZ.ThemDoanDiaDiem(doan_dd);
                }
            }
            MessageBox.Show("Đã lưu");
        }
    }
}
