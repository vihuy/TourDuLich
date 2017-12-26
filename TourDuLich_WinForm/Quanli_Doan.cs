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
    public partial class Quanli_Doan : Form
    {
        QuanLi_GiaTour_BIZ bus_tour = new QuanLi_GiaTour_BIZ();
        

        public Quanli_Doan()
        {
            InitializeComponent();
            DSDoan();
        }

        public void DSDoan()
        {
            IEnumerable doans = bus_tour.dsDoan();
            dgvDoan.DataSource = doans; 


        }
        private void Quanli_Doan_Load(object sender, EventArgs e)
        {

        }
    }
}
