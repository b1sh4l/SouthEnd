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
    public partial class User : Form
    {
        private Form1 Fl { get; set; }
        public User()
        {
            InitializeComponent();
        }

        

        private void User_Load(object sender, EventArgs e)
        {
            ucWelcomeUser ucW = new ucWelcomeUser();
            pnlControl.Controls.Clear();
            pnlControl.Controls.Add(ucW);
            ucW.Visible = true;
            ucW.BringToFront();
        }

        private void btnOrders_Click(object sender, EventArgs e)
        {
            ucOrder ucO = new ucOrder();
            pnlControl.Controls.Clear();
            pnlControl.Controls.Add(ucO);
            ucO.Visible = true;
            ucO.BringToFront();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            Form1 fm = new Form1();
            fm.Show();
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void User_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
