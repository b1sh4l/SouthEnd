using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CoffeeShopManagementSystem.UserControls
{
    public partial class ucOrder : UserControl
    {
        private static ucOrder instance;
        public static ucOrder Instance
        {
            get
            {
                if (instance == null)
                    instance = new ucOrder();
                return instance;
            }
        }
        private DataAccess Da { get; set; }
        public ucOrder()
        {
            InitializeComponent();
            this.Da = new DataAccess();

            var query = "select * from orderColumnName;";
            var ds = this.Da.ExecuteQuery(query);
            cmbFilterBy.DataSource = ds.Tables[0];
            cmbFilterBy.DisplayMember = "ColumnName";
            cmbFilterBy.ValueMember = "Id";

            this.PopulateGridView();
        }

        private void PopulateGridView(string sql = "select * from orderManagement;")
        {
            var ds = this.Da.ExecuteQuery(sql);

            this.dgvOrder.AutoGenerateColumns = false;
            this.dgvOrder.DataSource = ds.Tables[0];
        }

        private void txtKeyword_KeyDown(object sender, KeyEventArgs e)
        {
                if (e.KeyCode == Keys.Enter)
                {
                   btnFilter.PerformClick();
                }
            
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "select * from orderManagement where " + this.cmbFilterBy.Text + " = +'" + this.txtKeyword.Text + "';";
                this.PopulateGridView(sql);
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has occured: " + exc.Message);
            }
        }

        private void txtKeyword_TextChanged(object sender, EventArgs e)
        {
            var sql = "select * from orderManagement where CustomerMobileNo like '" + this.txtKeyword.Text + "%';";
            this.PopulateGridView(sql);
        }

        private bool IsValidData()
        {
            if (String.IsNullOrEmpty(this.txtMobileNo.Text))
            {
                return false;
            }
            else
                return true;
        }

        private void btnBlockGuest_Click(object sender, EventArgs e)
        {
            if (!this.IsValidData())
            {
                MessageBox.Show("Invalid opration. Please fill up all the mobile no");
                return;
            }
            var query = "select max(BlockId) from blockedCustomerList;";
            var ds = this.Da.ExecuteQuery(query);
            Int64 id = int.Parse(ds.Tables[0].Rows[0][0].ToString());

            var sql = @"insert into blockedCustomerList values('" + (id+1) + "','" + this.txtMobileNo.Text + "');";
            int count = this.Da.ExecuteDMLQuery(sql);

            if (count == 1)
                MessageBox.Show("The Guest is Blocked");
            else
                MessageBox.Show("The Guest cannot be Blocked");

        }

        private void btnUnblockGuest_Click(object sender, EventArgs e)
        {
            if (!this.IsValidData())
            {
                MessageBox.Show("Invalid opration. Please fill up the mobile no");
                return;
            }
            try
            {
                var sql = "delete from blockedCustomerList where CustomerMobileNo = '" + this.txtMobileNo.Text + "';";
                int count = this.Da.ExecuteDMLQuery(sql);

                if (count == 1)
                    MessageBox.Show(this.txtMobileNo.Text + " has been unblocked successfully");
                else
                    MessageBox.Show("The Guest cannot be Unblocked");
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has occured: " + exc.Message);
            }
        }
    }
}
