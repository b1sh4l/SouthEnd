using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CoffeeShopManagementSystem.UserControls
{
    public partial class ucInventory : UserControl
    {
        private static ucInventory instance;
        public static ucInventory Instance
        {
            get
            {
                if (instance == null)
                    instance = new ucInventory();
                return instance;
            }
        }
        private DataAccess Da { get; set; }
        public ucInventory()
        {
            InitializeComponent();
            this.Da = new DataAccess();
        }

        private void PopulateGridView(string sql = "select * from inventory;")
        {
            var ds = this.Da.ExecuteQuery(sql);

            this.dgvInventory.AutoGenerateColumns = false;
            this.dgvInventory.DataSource = ds.Tables[0];
        }

        private void txtKeyword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnFilter.PerformClick();
            }
        }

        private bool IsValidToSaveData()
        {
            if (String.IsNullOrEmpty(this.txtItemId.Text) || String.IsNullOrEmpty(this.txtItemName.Text) ||
                String.IsNullOrEmpty(this.cmbUnitOfMeasure.Text) || String.IsNullOrEmpty(this.txtQuantityInStock.Text) ||
                String.IsNullOrEmpty(this.txtUnitPrice.Text) || String.IsNullOrWhiteSpace(this.dtmLastRestockDate.Text))
            {
                return false;
            }
            else
                return true;
        }

        private void RefreshContent()
        {
            this.txtItemId.Clear();
            this.txtItemName.Clear();
            this.cmbUnitOfMeasure.SelectedIndex = -1;
            this.txtQuantityInStock.Clear();
            this.txtUnitPrice.Text = "";
            this.dtmLastRestockDate.Text = "";

            this.cmbFilterBy.SelectedIndex = -1;
            this.txtKeyword.Clear();
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "select * from inventory where " +this.cmbFilterBy.Text+" = +'"+this.txtKeyword.Text+"';";
                this.PopulateGridView(sql);
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has occured: " + exc.Message);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.RefreshContent();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                var id = this.dgvInventory.CurrentRow.Cells[0].Value.ToString();
                var name = this.dgvInventory.CurrentRow.Cells[1].Value.ToString();

                var sql = "delete from inventory where ItemID = '" + id + "';";
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

        private void ucInventory_Load(object sender, EventArgs e)
        {
            var query1 = "select * from inventorycolumnlist;";                   //popupalting filterby combo box
            var ds1 = this.Da.ExecuteQuery(query1);
            cmbFilterBy.DataSource = ds1.Tables[0];
            cmbFilterBy.DisplayMember = "ColumnName";
            cmbFilterBy.ValueMember = "Id";

            this.PopulateGridView();

        }

        private void txtKeyword_TextChanged(object sender, EventArgs e)
        {
            var sql = "select * from inventory where ItemName like '" + this.txtKeyword.Text + "%';";
            this.PopulateGridView(sql);
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                if (!this.IsValidToSaveData())
                {
                    MessageBox.Show("Invalid opration. Please fill up all the information");
                    return;
                }

               
                    var sql = @"insert into inventory (ItemID, ItemName, UnitOfMeasure, QuantityInStock, UnitPrice,LastRestockDate ) values('" + this.txtItemId.Text + "','" + this.txtItemName.Text + "','" + this.cmbUnitOfMeasure.Text + "'," + this.txtQuantityInStock.Text + "," + this.txtUnitPrice.Text + ",'" + this.dtmLastRestockDate.Text + "');";
                    int count = this.Da.ExecuteDMLQuery(sql);

                    if (count == 1)
                        MessageBox.Show("Data insertion successfull");
                    else
                        MessageBox.Show("Data insertion failed");
                

                this.PopulateGridView();
                this.RefreshContent();
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has occured: " + exc.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (!this.IsValidToSaveData())
                {
                    MessageBox.Show("Invalid opration. Please fill up all the information");
                    return;
                }

                var query = "select * from inventory where ItemID = '" + this.txtItemId.Text + "';";
                var ds = this.Da.ExecuteQuery(query);

                if (ds.Tables[0].Rows.Count == 1)
                {
                    //update
                    var sql = @"update inventory
                                set ItemName = '" + this.txtItemName.Text + @"',
                                UnitOfMeasure = '" + this.cmbUnitOfMeasure.Text + @"', 
                                QuantityInStock = " + this.txtQuantityInStock.Text + @",
                                UnitPrice = '" + this.txtUnitPrice.Text + @"',
                                LastRestockDate = '" + this.dtmLastRestockDate.Text + @"'
                                where ItemID = '" + this.txtItemId.Text + "';";
                    int count = this.Da.ExecuteDMLQuery(sql);

                    if (count == 1)
                        MessageBox.Show("Data updated successfully");
                    else
                        MessageBox.Show("Data upgradation failed");
                }

                this.PopulateGridView();
                this.RefreshContent();
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has occured: " + exc.Message);
            }
        }
    }
    }

