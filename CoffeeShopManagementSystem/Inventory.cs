using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeShopManagementSystem
{
    
    public partial class Inventory : Form
    {
        private DataAccess Da { get; set; }
        public Inventory()
        {
            InitializeComponent();
            this.Da = new DataAccess();
        }

        private void Inventory_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void pnlInventoryList_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlSearch_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void Inventory_Load(object sender, EventArgs e)
        {
            var query = "select * from unit;";                         //Popupalting unit combo box
            var ds = this.Da.ExecuteQuery(query);
            cmbUnitOfMeasure.DataSource = ds.Tables[0];
            cmbUnitOfMeasure.DisplayMember = "UnitName";
            cmbUnitOfMeasure.ValueMember = "UnitId";


            var query1 = "select * from inventoryColumnList;";                   //Popupalting FilterBy combo box
            var ds1 = this.Da.ExecuteQuery(query);
            cmbFilterBy.DataSource = ds1.Tables[0];
            cmbFilterBy.DisplayMember = "InventoryColumnName";
            cmbFilterBy.ValueMember = "InventoryColumnId";
        }
    }
}
