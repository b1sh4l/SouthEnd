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
    public partial class Guest : Form
    {
        private DataAccess Da { get; set; }
        public Guest()
        {
            InitializeComponent();
            this.Da = new DataAccess();
            this.pnlBil.Hide();
        }

        private void Guest_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, e.ClipRectangle, Color.Black, ButtonBorderStyle.Solid);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, e.ClipRectangle, Color.Black, ButtonBorderStyle.Solid);
        }

        private void Guest_Load(object sender, EventArgs e)
        {
            var query = "select * from hotBeverage;";
            var ds = this.Da.ExecuteQuery(query);
            cmbHotBeverges.DataSource = ds.Tables[0];
            cmbHotBeverges.DisplayMember = "BeverageName";
            cmbHotBeverges.ValueMember = "hBeverageId";

            var query1 = "select * from coldBeverage;";
            var ds1 = this.Da.ExecuteQuery(query1);
            cmbFrozenDrinks.DataSource = ds1.Tables[0];
            cmbFrozenDrinks.DisplayMember = "BeverageName";
            cmbFrozenDrinks.ValueMember = "cBeverageId";

            var query2 = "select * from food;";
            var ds2 = this.Da.ExecuteQuery(query2);
            cmbSandwichAndDesserts.DataSource = ds2.Tables[0];
            cmbSandwichAndDesserts.DisplayMember = "FoodName";
            cmbSandwichAndDesserts.ValueMember = "FoodID";
        }

        private void cmbQuantityHotBeverages_SelectedIndexChanged(object sender, EventArgs e)
        {
            var query = "select Price from hotBeverage where BeverageName = '" + cmbHotBeverges.Text + "';";
            var ds = this.Da.ExecuteQuery(query);
            Int64 price = int.Parse(ds.Tables[0].Rows[0][0].ToString());
            string qty = cmbQuantityHotBeverages.SelectedItem.ToString();
            int qty1 = Convert.ToInt32(cmbQuantityHotBeverages.SelectedItem);
            lblPriceHotBvg.Text = (price * qty1).ToString();
        }

        private void cmbQuantityFrozenDrinks_SelectedIndexChanged(object sender, EventArgs e)
        {
            var query = "select Price from coldBeverage where BeverageName = '" + cmbFrozenDrinks.Text + "';";
            var ds = this.Da.ExecuteQuery(query);
            Int64 price = int.Parse(ds.Tables[0].Rows[0][0].ToString());
            string qty = cmbQuantityFrozenDrinks.SelectedItem.ToString();
            int qty1 = Convert.ToInt32(cmbQuantityFrozenDrinks.SelectedItem);
            lblPriceFrozenDrinks.Text = (price * qty1).ToString();

        }

        private void cmbQuantitySandwichAndDesserts_SelectedIndexChanged(object sender, EventArgs e)
        {
            var query = "select Price from food where FoodName = '" + cmbSandwichAndDesserts.Text + "';";
            var ds = this.Da.ExecuteQuery(query);
            Int64 price = int.Parse(ds.Tables[0].Rows[0][0].ToString());
            string qty = cmbQuantitySandwichAndDesserts.SelectedItem.ToString();
            int qty1 = Convert.ToInt32(cmbQuantitySandwichAndDesserts.SelectedItem);
            lblPriceSandwich.Text = (price * qty1).ToString();

        }

        private void btnAddItems_Click(object sender, EventArgs e)
        {   
            int x = Convert.ToInt32(lblPriceHotBvg.Text);
            int y = Convert.ToInt32(lblPriceFrozenDrinks.Text);
            int z = Convert.ToInt32(lblPriceSandwich.Text);
            lblGrandTotal.Text = (x + y + z).ToString();
        }

        private bool IsValidToSaveData()
        {
            if (String.IsNullOrEmpty(this.cmbHotBeverges.Text) || String.IsNullOrEmpty(this.cmbQuantityHotBeverages.Text) ||
                String.IsNullOrEmpty(this.cmbFrozenDrinks.Text) || String.IsNullOrEmpty(this.cmbQuantityFrozenDrinks.Text) ||
                String.IsNullOrEmpty(this.cmbQuantitySandwichAndDesserts.Text) || String.IsNullOrWhiteSpace(this.cmbSandwichAndDesserts.Text)
                || String.IsNullOrWhiteSpace(this.txtEnterMobileNo.Text))
            {
                return false;
            }
            else
                return true;
        }

        private void RefreshContent()
        {
            this.cmbHotBeverges.SelectedIndex = -1;
            this.cmbQuantityHotBeverages.SelectedIndex = -1;
            this.cmbFrozenDrinks.SelectedIndex = -1;
            this.cmbQuantityFrozenDrinks.SelectedIndex = -1;
            this.cmbQuantitySandwichAndDesserts.SelectedIndex = -1;
            this.cmbSandwichAndDesserts.SelectedIndex = -1;
            this.txtEnterMobileNo.Clear();
        }

        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            try
            {
                if (!this.IsValidToSaveData())
                {
                    MessageBox.Show("Please fill up all the information");
                    return;
                }

                var query2 = "select * from blockedCustomerList where CustomerMobileNo = '" + this.txtEnterMobileNo.Text + "';";
                var ds2 = this.Da.ExecuteQuery(query2);
                if (ds2.Tables[0].Rows.Count == 1)
                {
                    MessageBox.Show("You are not allowed to place order. Please contact with manager.");
                    Application.Exit();
                }

                var query = "select * from orderManagement where CustomerMobileNo = '" + this.txtEnterMobileNo.Text + "';";
                var ds = this.Da.ExecuteQuery(query);

                if (ds.Tables[0].Rows.Count == 1)
                {
                    //update
                    var sql = @"update orderManagement
                                set OrderedItem = '" + this.cmbHotBeverges.Text + "," + this.cmbFrozenDrinks.Text + "," + this.cmbSandwichAndDesserts.Text + @"',
                                Qty = '" + this.cmbQuantityHotBeverages.Text + "," + this.cmbQuantityFrozenDrinks.Text + "," + this.cmbQuantitySandwichAndDesserts.Text + @"', 
                                TotalPrice = " + this.lblGrandTotal.Text +  @",
                                OrderDate = SYSDATETIME()
                                where CustomerMobileNo = '" + this.txtEnterMobileNo.Text + "';";
                    int count = this.Da.ExecuteDMLQuery(sql);

                    if (count == 1)
                        MessageBox.Show("Your Order is Placed. Thank you for choosing our service again.");
                    else
                        MessageBox.Show("There was an error while ordering");
                }
                else
                {
                    //insert
                    var sql = @"insert into orderManagement values('" + this.txtEnterMobileNo.Text + "','" + this.cmbHotBeverges.Text +"," +this.cmbFrozenDrinks.Text+ "," +this.cmbSandwichAndDesserts.Text+ "','" + this.cmbQuantityHotBeverages.Text + "," + this.cmbQuantityFrozenDrinks.Text + "," + this.cmbQuantitySandwichAndDesserts.Text + "'," + this.lblGrandTotal.Text + ",SYSDATETIME());";
                    int count = this.Da.ExecuteDMLQuery(sql);

                    if (count == 1)
                        MessageBox.Show("Your Order is Placed");
                    else
                        MessageBox.Show("There was an error while ordering");
                }

               //this.PopulateGridView();
                this.RefreshContent();
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has occured: " + exc.Message);
            }

            this.pnlBil.Show();
            var query1 = "select * from orderManagement where CustomerMobileNo = '" + txtEnterMobileNo.Text + "';";
            var ds1 = this.Da.ExecuteQuery(query1);
            this.lblCMobileNo.Text = ds1.Tables[0].Rows[0][0].ToString();
            this.lblCItemName.Text = ds1.Tables[0].Rows[0][1].ToString();
            this.lblCQty.Text = ds1.Tables[0].Rows[0][2].ToString();
            this.lblCTotalPrice.Text = ds1.Tables[0].Rows[0][3].ToString();
        }
    }
}

