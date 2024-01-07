
namespace CoffeeShopManagementSystem.UserControls
{
    partial class ucInventory
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pnlInventoryList = new System.Windows.Forms.Panel();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.lblAddNewItem = new System.Windows.Forms.Label();
            this.txtQuantityInStock = new System.Windows.Forms.TextBox();
            this.cmbUnitOfMeasure = new System.Windows.Forms.ComboBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnInsert = new System.Windows.Forms.Button();
            this.dtmLastRestockDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUnitPrice = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtItemName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtItemId = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pnlSearch = new System.Windows.Forms.Panel();
            this.lblSearch = new System.Windows.Forms.Label();
            this.cmbFilterBy = new System.Windows.Forms.ComboBox();
            this.lblKeyword = new System.Windows.Forms.Label();
            this.btnFilter = new System.Windows.Forms.Button();
            this.lblFilterBy = new System.Windows.Forms.Label();
            this.txtKeyword = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dgvInventory = new System.Windows.Forms.DataGridView();
            this.ItemId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitOfMeasure = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuantityInStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastRestockDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.pnlInventoryList.SuspendLayout();
            this.pnlSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventory)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlInventoryList
            // 
            this.pnlInventoryList.BackColor = System.Drawing.Color.Ivory;
            this.pnlInventoryList.Controls.Add(this.btnUpdate);
            this.pnlInventoryList.Controls.Add(this.lblAddNewItem);
            this.pnlInventoryList.Controls.Add(this.txtQuantityInStock);
            this.pnlInventoryList.Controls.Add(this.cmbUnitOfMeasure);
            this.pnlInventoryList.Controls.Add(this.btnClear);
            this.pnlInventoryList.Controls.Add(this.label1);
            this.pnlInventoryList.Controls.Add(this.btnInsert);
            this.pnlInventoryList.Controls.Add(this.dtmLastRestockDate);
            this.pnlInventoryList.Controls.Add(this.label2);
            this.pnlInventoryList.Controls.Add(this.txtUnitPrice);
            this.pnlInventoryList.Controls.Add(this.label3);
            this.pnlInventoryList.Controls.Add(this.label4);
            this.pnlInventoryList.Controls.Add(this.txtItemName);
            this.pnlInventoryList.Controls.Add(this.label5);
            this.pnlInventoryList.Controls.Add(this.txtItemId);
            this.pnlInventoryList.Controls.Add(this.label6);
            this.pnlInventoryList.Location = new System.Drawing.Point(3, 3);
            this.pnlInventoryList.Name = "pnlInventoryList";
            this.pnlInventoryList.Size = new System.Drawing.Size(537, 222);
            this.pnlInventoryList.TabIndex = 6;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Azo Sans", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnUpdate.Location = new System.Drawing.Point(219, 188);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(85, 25);
            this.btnUpdate.TabIndex = 10;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // lblAddNewItem
            // 
            this.lblAddNewItem.AutoSize = true;
            this.lblAddNewItem.Font = new System.Drawing.Font("Azo Sans", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.lblAddNewItem.Location = new System.Drawing.Point(12, 14);
            this.lblAddNewItem.Name = "lblAddNewItem";
            this.lblAddNewItem.Size = new System.Drawing.Size(164, 25);
            this.lblAddNewItem.TabIndex = 9;
            this.lblAddNewItem.Text = "ADD NEW ITEM";
            // 
            // txtQuantityInStock
            // 
            this.txtQuantityInStock.Font = new System.Drawing.Font("Azo Sans", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtQuantityInStock.Location = new System.Drawing.Point(414, 53);
            this.txtQuantityInStock.Name = "txtQuantityInStock";
            this.txtQuantityInStock.Size = new System.Drawing.Size(112, 23);
            this.txtQuantityInStock.TabIndex = 4;
            // 
            // cmbUnitOfMeasure
            // 
            this.cmbUnitOfMeasure.Font = new System.Drawing.Font("Azo Sans", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbUnitOfMeasure.FormattingEnabled = true;
            this.cmbUnitOfMeasure.Items.AddRange(new object[] {
            "kg",
            "liter"});
            this.cmbUnitOfMeasure.Location = new System.Drawing.Point(137, 132);
            this.cmbUnitOfMeasure.Name = "cmbUnitOfMeasure";
            this.cmbUnitOfMeasure.Size = new System.Drawing.Size(112, 23);
            this.cmbUnitOfMeasure.TabIndex = 3;
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Azo Sans", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnClear.Location = new System.Drawing.Point(333, 188);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(85, 25);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "CLEAR";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Azo Sans", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Item Id";
            // 
            // btnInsert
            // 
            this.btnInsert.Font = new System.Drawing.Font("Azo Sans", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnInsert.Location = new System.Drawing.Point(107, 188);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(85, 25);
            this.btnInsert.TabIndex = 7;
            this.btnInsert.Text = "INSERT";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // dtmLastRestockDate
            // 
            this.dtmLastRestockDate.CustomFormat = "dd-MM-yyyy";
            this.dtmLastRestockDate.Font = new System.Drawing.Font("Azo Sans", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtmLastRestockDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtmLastRestockDate.Location = new System.Drawing.Point(414, 135);
            this.dtmLastRestockDate.Name = "dtmLastRestockDate";
            this.dtmLastRestockDate.Size = new System.Drawing.Size(112, 23);
            this.dtmLastRestockDate.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Azo Sans", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Item Name";
            // 
            // txtUnitPrice
            // 
            this.txtUnitPrice.Font = new System.Drawing.Font("Azo Sans", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtUnitPrice.Location = new System.Drawing.Point(414, 88);
            this.txtUnitPrice.Name = "txtUnitPrice";
            this.txtUnitPrice.Size = new System.Drawing.Size(112, 23);
            this.txtUnitPrice.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Azo Sans", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(12, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "Unit of Measure";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Azo Sans", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(289, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 15);
            this.label4.TabIndex = 1;
            this.label4.Text = "Quantity in Stock";
            // 
            // txtItemName
            // 
            this.txtItemName.Font = new System.Drawing.Font("Azo Sans", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtItemName.Location = new System.Drawing.Point(137, 91);
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.Size = new System.Drawing.Size(112, 23);
            this.txtItemName.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Azo Sans", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(289, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 15);
            this.label5.TabIndex = 1;
            this.label5.Text = "Unit Price";
            // 
            // txtItemId
            // 
            this.txtItemId.Font = new System.Drawing.Font("Azo Sans", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtItemId.Location = new System.Drawing.Point(137, 53);
            this.txtItemId.Name = "txtItemId";
            this.txtItemId.Size = new System.Drawing.Size(112, 23);
            this.txtItemId.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Azo Sans", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(286, 135);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 15);
            this.label6.TabIndex = 1;
            this.label6.Text = "Last Restock Date";
            // 
            // pnlSearch
            // 
            this.pnlSearch.BackColor = System.Drawing.Color.Ivory;
            this.pnlSearch.Controls.Add(this.lblSearch);
            this.pnlSearch.Controls.Add(this.cmbFilterBy);
            this.pnlSearch.Controls.Add(this.lblKeyword);
            this.pnlSearch.Controls.Add(this.btnFilter);
            this.pnlSearch.Controls.Add(this.lblFilterBy);
            this.pnlSearch.Controls.Add(this.txtKeyword);
            this.pnlSearch.Location = new System.Drawing.Point(3, 231);
            this.pnlSearch.Name = "pnlSearch";
            this.pnlSearch.Size = new System.Drawing.Size(249, 180);
            this.pnlSearch.TabIndex = 7;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Azo Sans", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.lblSearch.Location = new System.Drawing.Point(29, 15);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(92, 25);
            this.lblSearch.TabIndex = 0;
            this.lblSearch.Text = "SEARCH";
            // 
            // cmbFilterBy
            // 
            this.cmbFilterBy.Font = new System.Drawing.Font("Azo Sans", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbFilterBy.FormattingEnabled = true;
            this.cmbFilterBy.Location = new System.Drawing.Point(107, 59);
            this.cmbFilterBy.Name = "cmbFilterBy";
            this.cmbFilterBy.Size = new System.Drawing.Size(112, 23);
            this.cmbFilterBy.TabIndex = 9;
            // 
            // lblKeyword
            // 
            this.lblKeyword.AutoSize = true;
            this.lblKeyword.Font = new System.Drawing.Font("Azo Sans", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblKeyword.Location = new System.Drawing.Point(29, 100);
            this.lblKeyword.Name = "lblKeyword";
            this.lblKeyword.Size = new System.Drawing.Size(61, 15);
            this.lblKeyword.TabIndex = 1;
            this.lblKeyword.Text = "Keyword";
            this.toolTip1.SetToolTip(this.lblKeyword, "Search By Item Name");
            // 
            // btnFilter
            // 
            this.btnFilter.Font = new System.Drawing.Font("Azo Sans", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnFilter.Location = new System.Drawing.Point(36, 139);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(85, 25);
            this.btnFilter.TabIndex = 11;
            this.btnFilter.Text = "FILTER";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // lblFilterBy
            // 
            this.lblFilterBy.AutoSize = true;
            this.lblFilterBy.Font = new System.Drawing.Font("Azo Sans", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFilterBy.Location = new System.Drawing.Point(29, 62);
            this.lblFilterBy.Name = "lblFilterBy";
            this.lblFilterBy.Size = new System.Drawing.Size(55, 15);
            this.lblFilterBy.TabIndex = 1;
            this.lblFilterBy.Text = "Filter By";
            // 
            // txtKeyword
            // 
            this.txtKeyword.Font = new System.Drawing.Font("Azo Sans", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtKeyword.Location = new System.Drawing.Point(107, 97);
            this.txtKeyword.Name = "txtKeyword";
            this.txtKeyword.Size = new System.Drawing.Size(112, 23);
            this.txtKeyword.TabIndex = 10;
            this.txtKeyword.TextChanged += new System.EventHandler(this.txtKeyword_TextChanged);
            this.txtKeyword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtKeyword_KeyDown);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Azo Sans", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDelete.Location = new System.Drawing.Point(444, 362);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(85, 41);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.Text = "DELETE";
            this.toolTip1.SetToolTip(this.btnDelete, "Click Id/Item on the GridView");
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // dgvInventory
            // 
            this.dgvInventory.AllowUserToAddRows = false;
            this.dgvInventory.AllowUserToDeleteRows = false;
            this.dgvInventory.BackgroundColor = System.Drawing.Color.Ivory;
            this.dgvInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInventory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ItemId,
            this.ItemName,
            this.UnitOfMeasure,
            this.QuantityInStock,
            this.UnitPrice,
            this.LastRestockDate});
            this.dgvInventory.Location = new System.Drawing.Point(3, 417);
            this.dgvInventory.Name = "dgvInventory";
            this.dgvInventory.ReadOnly = true;
            this.dgvInventory.RowTemplate.Height = 25;
            this.dgvInventory.Size = new System.Drawing.Size(537, 237);
            this.dgvInventory.TabIndex = 9;
            // 
            // ItemId
            // 
            this.ItemId.DataPropertyName = "ItemID";
            this.ItemId.HeaderText = "ID";
            this.ItemId.Name = "ItemId";
            this.ItemId.ReadOnly = true;
            this.ItemId.ToolTipText = "Id of Item";
            this.ItemId.Width = 50;
            // 
            // ItemName
            // 
            this.ItemName.DataPropertyName = "ItemName";
            this.ItemName.HeaderText = "Item";
            this.ItemName.Name = "ItemName";
            this.ItemName.ReadOnly = true;
            this.ItemName.ToolTipText = "Name of Item";
            // 
            // UnitOfMeasure
            // 
            this.UnitOfMeasure.DataPropertyName = "UnitOfMeasure";
            this.UnitOfMeasure.HeaderText = "Unit";
            this.UnitOfMeasure.Name = "UnitOfMeasure";
            this.UnitOfMeasure.ReadOnly = true;
            this.UnitOfMeasure.ToolTipText = "Unit Used";
            this.UnitOfMeasure.Width = 50;
            // 
            // QuantityInStock
            // 
            this.QuantityInStock.DataPropertyName = "QuantityInStock";
            this.QuantityInStock.HeaderText = "Quantity";
            this.QuantityInStock.Name = "QuantityInStock";
            this.QuantityInStock.ReadOnly = true;
            this.QuantityInStock.ToolTipText = "Quantity In Stock";
            // 
            // UnitPrice
            // 
            this.UnitPrice.DataPropertyName = "UnitPrice";
            this.UnitPrice.HeaderText = "Unit Price";
            this.UnitPrice.Name = "UnitPrice";
            this.UnitPrice.ReadOnly = true;
            this.UnitPrice.ToolTipText = "Price of a single item";
            // 
            // LastRestockDate
            // 
            this.LastRestockDate.DataPropertyName = "LastRestockDate";
            this.LastRestockDate.HeaderText = "Last Restock";
            this.LastRestockDate.Name = "LastRestockDate";
            this.LastRestockDate.ReadOnly = true;
            // 
            // ucInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.Controls.Add(this.dgvInventory);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.pnlSearch);
            this.Controls.Add(this.pnlInventoryList);
            this.Name = "ucInventory";
            this.Size = new System.Drawing.Size(543, 657);
            this.Load += new System.EventHandler(this.ucInventory_Load);
            this.pnlInventoryList.ResumeLayout(false);
            this.pnlInventoryList.PerformLayout();
            this.pnlSearch.ResumeLayout(false);
            this.pnlSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventory)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlInventoryList;
        private System.Windows.Forms.TextBox txtQuantityInStock;
        private System.Windows.Forms.ComboBox cmbUnitOfMeasure;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.DateTimePicker dtmLastRestockDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUnitPrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtItemName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtItemId;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel pnlSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.ComboBox cmbFilterBy;
        private System.Windows.Forms.Label lblKeyword;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.Label lblFilterBy;
        private System.Windows.Forms.TextBox txtKeyword;
        private System.Windows.Forms.Label lblAddNewItem;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView dgvInventory;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitOfMeasure;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuantityInStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastRestockDate;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}
