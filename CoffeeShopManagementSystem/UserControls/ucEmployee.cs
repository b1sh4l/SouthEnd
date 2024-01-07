using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CoffeeShopManagementSystem.UserControls
{
    public partial class ucEmployee : UserControl
    {
        private static ucEmployee instance;
        public static ucEmployee Instance
        {
            get
            {
                if (instance == null)
                    instance = new ucEmployee();
                return instance;
            }
        }
        private DataAccess Da { get; set; }
        public ucEmployee()
        {
            InitializeComponent();
            this.Da = new DataAccess();
        }
        private void PopulateGridView(string sql = "select * from employee;")
        {
            var ds = this.Da.ExecuteQuery(sql);

            this.dgvEmployee.AutoGenerateColumns = false;
            this.dgvEmployee.DataSource = ds.Tables[0];
        }

        private bool IsValidToSaveData()
        {
            if (String.IsNullOrEmpty(this.txtEmployeeId.Text) || String.IsNullOrEmpty(this.txtEmployeeName.Text) ||
                String.IsNullOrEmpty(this.cmbJob.Text) || String.IsNullOrEmpty(this.txtSalary.Text) ||
                String.IsNullOrEmpty(this.txtMobileNo.Text) || String.IsNullOrWhiteSpace(this.dtmJoiningDate.Text))
            {
                return false;
            }
            else
                return true;
        }

        private void RefreshContent()
        {
            this.txtEmployeeId.Clear();
            this.txtEmployeeName.Clear();
            this.cmbJob.SelectedIndex = -1;
            this.txtSalary.Clear();
            this.txtMobileNo.Clear();
            this.dtmJoiningDate.Text = "";

            this.cmbFilterBy.SelectedIndex = -1;
            this.txtKeyword.Clear();
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
                string sql = "select * from employee where " + this.cmbFilterBy.Text + " = +'" + this.txtKeyword.Text + "';";
                this.PopulateGridView(sql);
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has occured: " + exc.Message);
            }
        }

        private void txtKeyword_TextChanged(object sender, EventArgs e)
        {
            var sql = "select * from employee where EmployeeName like '" + this.txtKeyword.Text + "%';";
            this.PopulateGridView(sql);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            RefreshContent();
        }

        private void ucEmployee_Load(object sender, EventArgs e)
        {
            var query = "select * from employeeJob;";                 
            var ds = this.Da.ExecuteQuery(query);
            cmbJob.DataSource = ds.Tables[0];
            cmbJob.DisplayMember = "JobName";
            cmbJob.ValueMember = "Id";

            var query1 = "select * from employeeColumnName;";            
            var ds1 = this.Da.ExecuteQuery(query1);
            cmbFilterBy.DataSource = ds1.Tables[0];
            cmbFilterBy.DisplayMember = "ColumnName";
            cmbFilterBy.ValueMember = "Id";

            this.PopulateGridView();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (!this.IsValidToSaveData())
                {
                    MessageBox.Show("Invalid opration. Please fill up all the information");
                    return;
                }

                var query = "select * from employee where EmployeeId = '" + this.txtEmployeeId.Text + "';";
                var ds = this.Da.ExecuteQuery(query);

                if (ds.Tables[0].Rows.Count == 1)
                {
                    //update
                    var sql = @"update employee
                                set EmployeeName = '" + this.txtEmployeeName.Text + @"',
                                Job = '" + this.cmbJob.Text + @"', 
                                Salary = " + this.txtSalary.Text + @",
                                JoiningDate = '" + this.dtmJoiningDate.Text + @"',
                                where EmployeeId = '" + this.txtEmployeeId.Text + "';";
                    int count = this.Da.ExecuteDMLQuery(sql);

                    if (count == 1)
                        MessageBox.Show("Data updated successfully");
                    else
                        MessageBox.Show("Data upgradation failed");
                }
                else
                {
                    //insert
                    var sql = @"insert into employee values('" + this.txtEmployeeId.Text + "','" + this.txtEmployeeName.Text + "','" + this.cmbJob.Text +"',"+this.txtSalary.Text+ ",'" + this.dtmJoiningDate.Text+ "');";
                    int count = this.Da.ExecuteDMLQuery(sql);

                    if (count == 1)
                        MessageBox.Show("Data insertion successfull");
                    else
                        MessageBox.Show("Data insertion failed");
                }

                this.PopulateGridView();
                this.RefreshContent();
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has occured: " + exc.Message);
            }
        }

        private void btnRemoveEmployee_Click(object sender, EventArgs e)
        {
            try
            {
                var id = this.dgvEmployee.CurrentRow.Cells[0].Value.ToString();
                var name = this.dgvEmployee.CurrentRow.Cells[1].Value.ToString();

                var sql = "delete from employee where EmployeeId = '" + id + "';";
                int count = this.Da.ExecuteDMLQuery(sql);

                if (count == 1)
                    MessageBox.Show(name + " has been deleted successfully");
                else
                    MessageBox.Show("Data deletion failed");

                this.PopulateGridView();
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has occured: " + exc.Message);
            }
        }
    }
}
