using Core;
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
    public partial class QuanLi_Tour : Form
    {

        QuanLi_GiaTour_BIZ bus_gia_tour = new QuanLi_GiaTour_BIZ();
        public QuanLi_Tour()
        {
            InitializeComponent();
            LayDS_Tour();
        }

        private void QuanLi_Tour_Load(object sender, EventArgs e)
        {

        }
        public void LayDS_Tour()
        {
            //List<Tour> list = new List<Tour>();
            //list = bus_gia_tour.dsTour();
            IEnumerable tour = bus_gia_tour.dsTour();
            dgvTour.DataSource = tour;

        }
    }
}
