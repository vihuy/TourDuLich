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
    public partial class ThongKe_TinhHinh_Tour : Form
    {
        
        QuanLi_GiaTour_BIZ bus_tour = new QuanLi_GiaTour_BIZ();
        public ThongKe_TinhHinh_Tour()
        {
            InitializeComponent();
            layTenTour();
        }

        public void layTenTour()
        {
            //cboNCC_PN.DataSource = dt;
            //cboNCC_PN.DisplayMember = "TEN";
            //cboNCC_PN.ValueMember = "MANCC";
            IEnumerable tentour = bus_tour.layTenTour();
            cboTenTour_TKTH.DataSource = tentour;
            cboTenTour_TKTH.DisplayMember = "Ten";
            cboTenTour_TKTH.ValueMember = "MaTour";

        }
        private void button1_Click(object sender, EventArgs e)
        {
            DateTime dtngaybd = dtNgayBD_TKTH.Value;
            int maTour = Convert.ToInt32(cboTenTour_TKTH.SelectedValue.ToString());
            MessageBox.Show(dtngaybd.ToString(),maTour.ToString());
        }

        private void ThongKe_TinhHinh_Tour_Load(object sender, EventArgs e)
        {

        }
    }
}
