
namespace CoffeeShopManagementSystem.UserControls
{
    partial class ucOrder
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
            this.lblOrders = new System.Windows.Forms.Label();
            this.dgvOrder = new System.Windows.Forms.DataGridView();
            this.CustomerMobileNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderedItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblEnterMobileNo = new System.Windows.Forms.Label();
            this.txtMobileNo = new System.Windows.Forms.TextBox();
            this.btnBlockGuest = new System.Windows.Forms.Button();
            this.btnUnblockGuest = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlSearch = new System.Windows.Forms.Panel();
            this.lblSearch = new System.Windows.Forms.Label();
            this.cmbFilterBy = new System.Windows.Forms.ComboBox();
            this.lblKeyword = new System.Windows.Forms.Label();
            this.btnFilter = new System.Windows.Forms.Button();
            this.lblFilterBy = new System.Windows.Forms.Label();
            this.txtKeyword = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).BeginInit();
            this.panel1.SuspendLayout();
            this.pnlSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblOrders
            // 
            this.lblOrders.AutoSize = true;
            this.lblOrders.Font = new System.Drawing.Font("Azo Sans", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.lblOrders.Location = new System.Drawing.Point(23, 18);
            this.lblOrders.Name = "lblOrders";
            this.lblOrders.Size = new System.Drawing.Size(94, 25);
            this.lblOrders.TabIndex = 10;
            this.lblOrders.Text = "ORDERS";
            // 
            // dgvOrder
            // 
            this.dgvOrder.AllowUserToAddRows = false;
            this.dgvOrder.AllowUserToDeleteRows = false;
            this.dgvOrder.BackgroundColor = System.Drawing.Color.Ivory;
            this.dgvOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrder.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CustomerMobileNo,
            this.OrderedItem,
            this.Qty,
            this.TotalPrice,
            this.OrderDate});
            this.dgvOrder.Location = new System.Drawing.Point(23, 58);
            this.dgvOrder.Name = "dgvOrder";
            this.dgvOrder.ReadOnly = true;
            this.dgvOrder.RowTemplate.Height = 25;
            this.dgvOrder.Size = new System.Drawing.Size(503, 233);
            this.dgvOrder.TabIndex = 11;
            // 
            // CustomerMobileNo
            // 
            this.CustomerMobileNo.DataPropertyName = "CustomerMobileNo";
            this.CustomerMobileNo.HeaderText = "Cutomer Mobile No";
            this.CustomerMobileNo.Name = "CustomerMobileNo";
            this.CustomerMobileNo.ReadOnly = true;
            // 
            // OrderedItem
            // 
            this.OrderedItem.DataPropertyName = "OrderedItem";
            this.OrderedItem.HeaderText = "Items";
            this.OrderedItem.Name = "OrderedItem";
            this.OrderedItem.ReadOnly = true;
            this.OrderedItem.Width = 150;
            // 
            // Qty
            // 
            this.Qty.DataPropertyName = "Qty";
            this.Qty.HeaderText = "Quantity";
            this.Qty.Name = "Qty";
            this.Qty.ReadOnly = true;
            this.Qty.Width = 60;
            // 
            // TotalPrice
            // 
            this.TotalPrice.DataPropertyName = "TotalPrice";
            this.TotalPrice.HeaderText = "Total Price";
            this.TotalPrice.Name = "TotalPrice";
            this.TotalPrice.ReadOnly = true;
            this.TotalPrice.Width = 50;
            // 
            // OrderDate
            // 
            this.OrderDate.DataPropertyName = "OrderDate";
            this.OrderDate.HeaderText = "Order Date";
            this.OrderDate.Name = "OrderDate";
            this.OrderDate.ReadOnly = true;
            // 
            // lblEnterMobileNo
            // 
            this.lblEnterMobileNo.AutoSize = true;
            this.lblEnterMobileNo.Font = new System.Drawing.Font("Azo Sans", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblEnterMobileNo.Location = new System.Drawing.Point(3, 30);
            this.lblEnterMobileNo.Name = "lblEnterMobileNo";
            this.lblEnterMobileNo.Size = new System.Drawing.Size(103, 15);
            this.lblEnterMobileNo.TabIndex = 12;
            this.lblEnterMobileNo.Text = "Enter Mobile No";
            // 
            // txtMobileNo
            // 
            this.txtMobileNo.Font = new System.Drawing.Font("Azo Sans", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtMobileNo.Location = new System.Drawing.Point(112, 27);
            this.txtMobileNo.Name = "txtMobileNo";
            this.txtMobileNo.Size = new System.Drawing.Size(112, 23);
            this.txtMobileNo.TabIndex = 4;
            // 
            // btnBlockGuest
            // 
            this.btnBlockGuest.Font = new System.Drawing.Font("Azo Sans", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBlockGuest.Location = new System.Drawing.Point(248, 25);
            this.btnBlockGuest.Name = "btnBlockGuest";
            this.btnBlockGuest.Size = new System.Drawing.Size(104, 25);
            this.btnBlockGuest.TabIndex = 5;
            this.btnBlockGuest.Text = "BLOCK GUEST";
            this.btnBlockGuest.UseVisualStyleBackColor = true;
            this.btnBlockGuest.Click += new System.EventHandler(this.btnBlockGuest_Click);
            // 
            // btnUnblockGuest
            // 
            this.btnUnblockGuest.Font = new System.Drawing.Font("Azo Sans", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnUnblockGuest.Location = new System.Drawing.Point(358, 25);
            this.btnUnblockGuest.Name = "btnUnblockGuest";
            this.btnUnblockGuest.Size = new System.Drawing.Size(122, 25);
            this.btnUnblockGuest.TabIndex = 6;
            this.btnUnblockGuest.Text = "UNBLOCK GUEST";
            this.btnUnblockGuest.UseVisualStyleBackColor = true;
            this.btnUnblockGuest.Click += new System.EventHandler(this.btnUnblockGuest_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Ivory;
            this.panel1.Controls.Add(this.btnUnblockGuest);
            this.panel1.Controls.Add(this.txtMobileNo);
            this.panel1.Controls.Add(this.btnBlockGuest);
            this.panel1.Controls.Add(this.lblEnterMobileNo);
            this.panel1.Location = new System.Drawing.Point(23, 501);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(503, 70);
            this.panel1.TabIndex = 16;
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
            this.pnlSearch.Location = new System.Drawing.Point(23, 310);
            this.pnlSearch.Name = "pnlSearch";
            this.pnlSearch.Size = new System.Drawing.Size(500, 170);
            this.pnlSearch.TabIndex = 17;
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
            this.cmbFilterBy.TabIndex = 1;
            // 
            // lblKeyword
            // 
            this.lblKeyword.AutoSize = true;
            this.lblKeyword.Font = new System.Drawing.Font("Azo Sans", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblKeyword.Location = new System.Drawing.Point(265, 62);
            this.lblKeyword.Name = "lblKeyword";
            this.lblKeyword.Size = new System.Drawing.Size(61, 15);
            this.lblKeyword.TabIndex = 1;
            this.lblKeyword.Text = "Keyword";
            // 
            // btnFilter
            // 
            this.btnFilter.Font = new System.Drawing.Font("Azo Sans", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnFilter.Location = new System.Drawing.Point(191, 119);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(85, 25);
            this.btnFilter.TabIndex = 3;
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
            this.txtKeyword.Location = new System.Drawing.Point(343, 59);
            this.txtKeyword.Name = "txtKeyword";
            this.txtKeyword.Size = new System.Drawing.Size(112, 23);
            this.txtKeyword.TabIndex = 2;
            this.txtKeyword.TextChanged += new System.EventHandler(this.txtKeyword_TextChanged);
            this.txtKeyword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtKeyword_KeyDown);
            // 
            // ucOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.Controls.Add(this.pnlSearch);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvOrder);
            this.Controls.Add(this.lblOrders);
            this.Name = "ucOrder";
            this.Size = new System.Drawing.Size(543, 657);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlSearch.ResumeLayout(false);
            this.pnlSearch.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOrders;
        private System.Windows.Forms.DataGridView dgvOrder;
        private System.Windows.Forms.Label lblEnterMobileNo;
        private System.Windows.Forms.TextBox txtMobileNo;
        private System.Windows.Forms.Button btnBlockGuest;
        private System.Windows.Forms.Button btnUnblockGuest;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.ComboBox cmbFilterBy;
        private System.Windows.Forms.Label lblKeyword;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.Label lblFilterBy;
        private System.Windows.Forms.TextBox txtKeyword;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerMobileNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderedItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderDate;
    }
}
