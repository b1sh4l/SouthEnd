using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeShopManagementSystem
{
    public partial class Form1 : Form
    {
        private DataAccess Da { get; set; }
        public Form1()
        {
            InitializeComponent();
            this.Da = new DataAccess();
        }


        private void btnLogInAsGuest_Click(object sender, EventArgs e)
        {
            Guest gu = new Guest();
            gu.Show();
            this.Hide();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            var query = "select * from systemAdministration where Username = '" + this.txtUsername.Text + "' and Password = '" + this.txtPassword.Text + "';";
            var ds = this.Da.ExecuteQuery(query);
            if (ds.Tables[0].Rows.Count == 1)
            {
                this.Hide();
                //MessageBox.Show("Login Valid");
                
                if (ds.Tables[0].Rows[0][4].ToString().Trim() == "admin")
                {
                    Admin ad = new Admin();
                    ad.Show();
                   // MessageBox.Show("Admin");
                }
                else if (ds.Tables[0].Rows[0][4].ToString().Trim() == "user")
                {
                    User us = new User();
                    us.Show();
                }

            }

            else
            {
                MessageBox.Show("Invalid Username or Password!");
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void txtUsername_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtPassword.Focus();
            }
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogIn.PerformClick();
            }
        }
    }
}
