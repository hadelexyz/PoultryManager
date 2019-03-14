using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;

namespace PoultryManager
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
            label2.Text = DateTime.Now.ToLongDateString();
            sidePanel.Height = btnHome.Height;
            sidePanel.Top = btnHome.Top;
        }

        private void Home_Load(object sender, EventArgs e)
        {
            feeding1.Visible = false;
            sales1.Visible = false;
            expenses1.Visible = false;
            egg_Collection1.Visible = false;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            feeding1.Visible = false;
            sales1.Visible = false;
            expenses1.Visible = false;
            egg_Collection1.Visible = false;
            sidePanel.Height = btnHome.Height;
            sidePanel.Top = btnHome.Top;
        }

        private void btnFeeding_Click(object sender, EventArgs e)
        {
            feeding1.Visible = true;
            feeding1.BringToFront();
            sidePanel.Height = btnFeeding.Height;
            sidePanel.Top = btnFeeding.Top;
        }

        private void btnEggColl_Click(object sender, EventArgs e)
        {
            egg_Collection1.Visible = true;
            egg_Collection1.BringToFront();
            sidePanel.Height = btnEggColl.Height;
            sidePanel.Top = btnEggColl.Top;
        }

        private void btnSales_Click(object sender, EventArgs e)
        {
            sales1.Visible = true;
            sales1.BringToFront();
            sidePanel.Height = btnSales.Height;
            sidePanel.Top = btnSales.Top;
        }

        private void btnExpense_Click(object sender, EventArgs e)
        {
            expenses1.Visible = true;
            expenses1.BringToFront();
            sidePanel.Height = btnExpense.Height;
            sidePanel.Top = btnExpense.Top;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            feeding1.Visible = true;
            feeding1.BringToFront();
            sidePanel.Height = btnFeeding.Height;
            sidePanel.Top = btnFeeding.Top;
        }

        private void btnHomeEgg_Click(object sender, EventArgs e)
        {
            egg_Collection1.Visible = true;
            egg_Collection1.BringToFront();
            sidePanel.Height = btnEggColl.Height;
            sidePanel.Top = btnEggColl.Top;
        }

        private void btnHomeReport_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Test");
        }

        private void btnHomeSales_Click(object sender, EventArgs e)
        {
            sales1.Visible = true;
            sales1.BringToFront();
            sidePanel.Height = btnSales.Height;
            sidePanel.Top = btnSales.Top;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
