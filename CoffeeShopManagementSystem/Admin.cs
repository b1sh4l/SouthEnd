using CoffeeShopManagementSystem.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CoffeeShopManagementSystem
{
    
    public partial class Admin : Form
    {
        private Form1 Fl { get; set; }
        public Admin()
        {
            InitializeComponent();
        }

    

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            Form1 fm = new Form1();
            fm.Show();
            this.Hide();
        }

        private void Admin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        private void Admin_Load(object sender, EventArgs e)
        {
            ucWelcome ucW = new ucWelcome();
            pnlControl.Controls.Clear();
            pnlControl.Controls.Add(ucW);
            ucW.Visible = true;
            ucW.BringToFront();
        }

        private void btnInventory_Click(object sender, EventArgs e)
        {
            ucInventory ucI = new ucInventory();
            pnlControl.Controls.Clear();
            pnlControl.Controls.Add(ucI);
            ucI.Visible = true;
            ucI.BringToFront();
        }

        private void btnEmployees_Click(object sender, EventArgs e)
        {
            ucEmployee ucE = new ucEmployee();
            pnlControl.Controls.Clear();
            pnlControl.Controls.Add(ucE);
            ucE.Visible = true;
            ucE.BringToFront();
        }

        private void btnOrders_Click(object sender, EventArgs e)
        {
            ucOrder ucO = new ucOrder();
            pnlControl.Controls.Clear();
            pnlControl.Controls.Add(ucO);
            ucO.Visible = true;
            ucO.BringToFront();
        }
    }
}
