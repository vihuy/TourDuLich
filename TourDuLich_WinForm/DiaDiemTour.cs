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
            IEnumerable tour = bus_tour.layTenTour();
            cmb_TenTour.DataSource = tour;
            cmb_TenTour.DisplayMember = "Ten";
            cmb_TenTour.ValueMember = "MaTour";
        }
        
        public void dsTinhThanh()
        {
            IEnumerable tinhthanh = bus_tinhthanh.layTinhThanh();
            cmb_TinhThanh.DataSource = tinhthanh;
            cmb_TinhThanh.DisplayMember = "Ten";
            cmb_TinhThanh.ValueMember = "MaTT";

        }

        private void cmb_TinhThanh_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int MaTinhThanh = int.Parse(cmb_TinhThanh.SelectedValue.ToString());
                dataGridView_DSDiaDiem.DataSource = bus_tour.layDiaDiemTheoTinhThanh(MaTinhThanh);
            }
            catch(Exception)
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
            try
            {
                DataGridView_DSDiaDiemdaydu.Rows.Clear();
                int MaTour = int.Parse(cmb_TenTour.SelectedValue.ToString());
                foreach (DiaDiemModel item in bus_tour.layDiaDiem(MaTour)) ;
                {

                }
                {

                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
