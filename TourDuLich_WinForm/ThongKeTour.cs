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
            LayDSGia_Tour();


        }

        public void LayDSGia_Tour()
        {
            List<Tour_Gia> list = new List<Tour_Gia>();
            list = bus_gia_tour.dsGia_Tour();
            dgvGia_Tour.DataSource = list;

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
    }
}
