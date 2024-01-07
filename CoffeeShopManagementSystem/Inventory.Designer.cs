
namespace CoffeeShopManagementSystem
{
    partial class Inventory
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtItemId = new System.Windows.Forms.TextBox();
            this.txtItemName = new System.Windows.Forms.TextBox();
            this.txtQuantityInStock = new System.Windows.Forms.TextBox();
            this.txtUnitPrice = new System.Windows.Forms.TextBox();
            this.dtmLastRestockDate = new System.Windows.Forms.DateTimePicker();
            this.cmbUnitOfMeasure = new System.Windows.Forms.ComboBox();
            this.pnlInventoryList = new System.Windows.Forms.Panel();
            this.pnlSearch = new System.Windows.Forms.Panel();
            this.lblSearch = new System.Windows.Forms.Label();
            this.cmbFilterBy = new System.Windows.Forms.ComboBox();
            this.lblKeyword = new System.Windows.Forms.Label();
            this.btnFilter = new System.Windows.Forms.Button();
            this.lblFilterBy = new System.Windows.Forms.Label();
            this.txtKeyword = new System.Windows.Forms.TextBox();
            this.pnlInventoryList.SuspendLayout();
            this.pnlSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Azo Sans", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSave.Location = new System.Drawing.Point(164, 164);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(85, 25);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Azo Sans", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnClear.Location = new System.Drawing.Point(289, 164);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(85, 25);
            this.btnClear.TabIndex = 0;
            this.btnClear.Text = "CLEAR";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Azo Sans", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDelete.Location = new System.Drawing.Point(12, 221);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(85, 70);
            this.btnDelete.TabIndex = 0;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Azo Sans", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Item Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Azo Sans", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Item Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Azo Sans", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(12, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "Unit of Measure";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Azo Sans", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(289, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 15);
            this.label4.TabIndex = 1;
            this.label4.Text = "Quantity in Stock";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Azo Sans", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(289, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 15);
            this.label5.TabIndex = 1;
            this.label5.Text = "Unit Price";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Azo Sans", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(289, 111);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 15);
            this.label6.TabIndex = 1;
            this.label6.Text = "Last Restock Date";
            // 
            // txtItemId
            // 
            this.txtItemId.Font = new System.Drawing.Font("Azo Sans", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtItemId.Location = new System.Drawing.Point(137, 29);
            this.txtItemId.Name = "txtItemId";
            this.txtItemId.Size = new System.Drawing.Size(112, 23);
            this.txtItemId.TabIndex = 2;
            // 
            // txtItemName
            // 
            this.txtItemName.Font = new System.Drawing.Font("Azo Sans", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtItemName.Location = new System.Drawing.Point(137, 67);
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.Size = new System.Drawing.Size(112, 23);
            this.txtItemName.TabIndex = 2;
            // 
            // txtQuantityInStock
            // 
            this.txtQuantityInStock.Font = new System.Drawing.Font("Azo Sans", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtQuantityInStock.Location = new System.Drawing.Point(414, 29);
            this.txtQuantityInStock.Name = "txtQuantityInStock";
            this.txtQuantityInStock.Size = new System.Drawing.Size(112, 23);
            this.txtQuantityInStock.TabIndex = 2;
            // 
            // txtUnitPrice
            // 
            this.txtUnitPrice.Font = new System.Drawing.Font("Azo Sans", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtUnitPrice.Location = new System.Drawing.Point(414, 67);
            this.txtUnitPrice.Name = "txtUnitPrice";
            this.txtUnitPrice.Size = new System.Drawing.Size(112, 23);
            this.txtUnitPrice.TabIndex = 2;
            // 
            // dtmLastRestockDate
            // 
            this.dtmLastRestockDate.CustomFormat = "dd-MM-yyyy";
            this.dtmLastRestockDate.Font = new System.Drawing.Font("Azo Sans", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtmLastRestockDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtmLastRestockDate.Location = new System.Drawing.Point(414, 105);
            this.dtmLastRestockDate.Name = "dtmLastRestockDate";
            this.dtmLastRestockDate.Size = new System.Drawing.Size(112, 23);
            this.dtmLastRestockDate.TabIndex = 3;
            // 
            // cmbUnitOfMeasure
            // 
            this.cmbUnitOfMeasure.Font = new System.Drawing.Font("Azo Sans", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbUnitOfMeasure.FormattingEnabled = true;
            this.cmbUnitOfMeasure.Location = new System.Drawing.Point(137, 108);
            this.cmbUnitOfMeasure.Name = "cmbUnitOfMeasure";
            this.cmbUnitOfMeasure.Size = new System.Drawing.Size(112, 23);
            this.cmbUnitOfMeasure.TabIndex = 4;
            // 
            // pnlInventoryList
            // 
            this.pnlInventoryList.BackColor = System.Drawing.Color.Ivory;
            this.pnlInventoryList.Controls.Add(this.txtQuantityInStock);
            this.pnlInventoryList.Controls.Add(this.cmbUnitOfMeasure);
            this.pnlInventoryList.Controls.Add(this.btnClear);
            this.pnlInventoryList.Controls.Add(this.label1);
            this.pnlInventoryList.Controls.Add(this.btnSave);
            this.pnlInventoryList.Controls.Add(this.dtmLastRestockDate);
            this.pnlInventoryList.Controls.Add(this.label2);
            this.pnlInventoryList.Controls.Add(this.txtUnitPrice);
            this.pnlInventoryList.Controls.Add(this.label3);
            this.pnlInventoryList.Controls.Add(this.label4);
            this.pnlInventoryList.Controls.Add(this.txtItemName);
            this.pnlInventoryList.Controls.Add(this.label5);
            this.pnlInventoryList.Controls.Add(this.txtItemId);
            this.pnlInventoryList.Controls.Add(this.label6);
            this.pnlInventoryList.Location = new System.Drawing.Point(12, 12);
            this.pnlInventoryList.Name = "pnlInventoryList";
            this.pnlInventoryList.Size = new System.Drawing.Size(558, 203);
            this.pnlInventoryList.TabIndex = 5;
            this.pnlInventoryList.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlInventoryList_Paint);
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
            this.pnlSearch.Location = new System.Drawing.Point(576, 12);
            this.pnlSearch.Name = "pnlSearch";
            this.pnlSearch.Size = new System.Drawing.Size(291, 203);
            this.pnlSearch.TabIndex = 6;
            this.pnlSearch.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlSearch_Paint);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Azo Sans", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lblSearch.Location = new System.Drawing.Point(96, 4);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(92, 25);
            this.lblSearch.TabIndex = 0;
            this.lblSearch.Text = "SEARCH";
            // 
            // cmbFilterBy
            // 
            this.cmbFilterBy.Font = new System.Drawing.Font("Azo Sans", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbFilterBy.FormattingEnabled = true;
            this.cmbFilterBy.Location = new System.Drawing.Point(141, 59);
            this.cmbFilterBy.Name = "cmbFilterBy";
            this.cmbFilterBy.Size = new System.Drawing.Size(112, 23);
            this.cmbFilterBy.TabIndex = 4;
            // 
            // lblKeyword
            // 
            this.lblKeyword.AutoSize = true;
            this.lblKeyword.Font = new System.Drawing.Font("Azo Sans", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblKeyword.Location = new System.Drawing.Point(52, 101);
            this.lblKeyword.Name = "lblKeyword";
            this.lblKeyword.Size = new System.Drawing.Size(61, 15);
            this.lblKeyword.TabIndex = 1;
            this.lblKeyword.Text = "Keyword";
            // 
            // btnFilter
            // 
            this.btnFilter.Font = new System.Drawing.Font("Azo Sans", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnFilter.Location = new System.Drawing.Point(103, 164);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(85, 25);
            this.btnFilter.TabIndex = 0;
            this.btnFilter.Text = "FILTER";
            this.btnFilter.UseVisualStyleBackColor = true;
            // 
            // lblFilterBy
            // 
            this.lblFilterBy.AutoSize = true;
            this.lblFilterBy.Font = new System.Drawing.Font("Azo Sans", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFilterBy.Location = new System.Drawing.Point(52, 62);
            this.lblFilterBy.Name = "lblFilterBy";
            this.lblFilterBy.Size = new System.Drawing.Size(55, 15);
            this.lblFilterBy.TabIndex = 1;
            this.lblFilterBy.Text = "Filter By";
            // 
            // txtKeyword
            // 
            this.txtKeyword.Font = new System.Drawing.Font("Azo Sans", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtKeyword.Location = new System.Drawing.Point(141, 98);
            this.txtKeyword.Name = "txtKeyword";
            this.txtKeyword.Size = new System.Drawing.Size(112, 23);
            this.txtKeyword.TabIndex = 2;
            // 
            // Inventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(879, 681);
            this.Controls.Add(this.pnlSearch);
            this.Controls.Add(this.pnlInventoryList);
            this.Controls.Add(this.btnDelete);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Inventory";
            this.Text = "Inventory";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Inventory_FormClosed);
            this.Load += new System.EventHandler(this.Inventory_Load);
            this.pnlInventoryList.ResumeLayout(false);
            this.pnlInventoryList.PerformLayout();
            this.pnlSearch.ResumeLayout(false);
            this.pnlSearch.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtItemId;
        private System.Windows.Forms.TextBox txtItemName;
        private System.Windows.Forms.TextBox txtQuantityInStock;
        private System.Windows.Forms.TextBox txtUnitPrice;
        private System.Windows.Forms.DateTimePicker dtmLastRestockDate;
        private System.Windows.Forms.ComboBox cmbUnitOfMeasure;
        private System.Windows.Forms.Panel pnlInventoryList;
        private System.Windows.Forms.Panel pnlSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Label lblKeyword;
        private System.Windows.Forms.Label lblFilterBy;
        private System.Windows.Forms.TextBox txtKeyword;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.ComboBox cmbFilterBy;
    }
}