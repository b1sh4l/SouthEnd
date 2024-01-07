
namespace CoffeeShopManagementSystem.UserControls
{
    partial class ucEmployee
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
            this.btnRemoveEmployee = new System.Windows.Forms.Button();
            this.pnlSearch = new System.Windows.Forms.Panel();
            this.lblSearch = new System.Windows.Forms.Label();
            this.cmbFilterBy = new System.Windows.Forms.ComboBox();
            this.lblKeyword = new System.Windows.Forms.Label();
            this.btnFilter = new System.Windows.Forms.Button();
            this.lblFilterBy = new System.Windows.Forms.Label();
            this.txtKeyword = new System.Windows.Forms.TextBox();
            this.pnlInventoryList = new System.Windows.Forms.Panel();
            this.lblAddNewEmployee = new System.Windows.Forms.Label();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.cmbJob = new System.Windows.Forms.ComboBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblEmployeeId = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.dtmJoiningDate = new System.Windows.Forms.DateTimePicker();
            this.lblEmployeeName = new System.Windows.Forms.Label();
            this.txtMobileNo = new System.Windows.Forms.TextBox();
            this.lblJob = new System.Windows.Forms.Label();
            this.lblSalary = new System.Windows.Forms.Label();
            this.txtEmployeeName = new System.Windows.Forms.TextBox();
            this.lblMobileNo = new System.Windows.Forms.Label();
            this.txtEmployeeId = new System.Windows.Forms.TextBox();
            this.lblJoiningDate = new System.Windows.Forms.Label();
            this.dgvEmployee = new System.Windows.Forms.DataGridView();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.EmployeeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployeeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Job = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Salary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.JoiningDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlSearch.SuspendLayout();
            this.pnlInventoryList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRemoveEmployee
            // 
            this.btnRemoveEmployee.Font = new System.Drawing.Font("Azo Sans", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnRemoveEmployee.Location = new System.Drawing.Point(384, 362);
            this.btnRemoveEmployee.Name = "btnRemoveEmployee";
            this.btnRemoveEmployee.Size = new System.Drawing.Size(145, 41);
            this.btnRemoveEmployee.TabIndex = 12;
            this.btnRemoveEmployee.Text = "REMOVE EMPLOYEE";
            this.toolTip1.SetToolTip(this.btnRemoveEmployee, "Click Id/Name on the GridView");
            this.btnRemoveEmployee.UseVisualStyleBackColor = true;
            this.btnRemoveEmployee.Click += new System.EventHandler(this.btnRemoveEmployee_Click);
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
            this.pnlSearch.TabIndex = 10;
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
            this.toolTip1.SetToolTip(this.lblKeyword, "Serch By Employee Name");
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
            // pnlInventoryList
            // 
            this.pnlInventoryList.BackColor = System.Drawing.Color.Ivory;
            this.pnlInventoryList.Controls.Add(this.lblAddNewEmployee);
            this.pnlInventoryList.Controls.Add(this.txtSalary);
            this.pnlInventoryList.Controls.Add(this.cmbJob);
            this.pnlInventoryList.Controls.Add(this.btnClear);
            this.pnlInventoryList.Controls.Add(this.lblEmployeeId);
            this.pnlInventoryList.Controls.Add(this.btnSave);
            this.pnlInventoryList.Controls.Add(this.dtmJoiningDate);
            this.pnlInventoryList.Controls.Add(this.lblEmployeeName);
            this.pnlInventoryList.Controls.Add(this.txtMobileNo);
            this.pnlInventoryList.Controls.Add(this.lblJob);
            this.pnlInventoryList.Controls.Add(this.lblSalary);
            this.pnlInventoryList.Controls.Add(this.txtEmployeeName);
            this.pnlInventoryList.Controls.Add(this.lblMobileNo);
            this.pnlInventoryList.Controls.Add(this.txtEmployeeId);
            this.pnlInventoryList.Controls.Add(this.lblJoiningDate);
            this.pnlInventoryList.Location = new System.Drawing.Point(3, 3);
            this.pnlInventoryList.Name = "pnlInventoryList";
            this.pnlInventoryList.Size = new System.Drawing.Size(537, 222);
            this.pnlInventoryList.TabIndex = 9;
            // 
            // lblAddNewEmployee
            // 
            this.lblAddNewEmployee.AutoSize = true;
            this.lblAddNewEmployee.Font = new System.Drawing.Font("Azo Sans", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.lblAddNewEmployee.Location = new System.Drawing.Point(12, 14);
            this.lblAddNewEmployee.Name = "lblAddNewEmployee";
            this.lblAddNewEmployee.Size = new System.Drawing.Size(222, 25);
            this.lblAddNewEmployee.TabIndex = 9;
            this.lblAddNewEmployee.Text = "ADD NEW EMPLOYEE";
            // 
            // txtSalary
            // 
            this.txtSalary.Font = new System.Drawing.Font("Azo Sans", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSalary.Location = new System.Drawing.Point(414, 53);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(112, 23);
            this.txtSalary.TabIndex = 4;
            // 
            // cmbJob
            // 
            this.cmbJob.Font = new System.Drawing.Font("Azo Sans", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbJob.FormattingEnabled = true;
            this.cmbJob.Location = new System.Drawing.Point(137, 132);
            this.cmbJob.Name = "cmbJob";
            this.cmbJob.Size = new System.Drawing.Size(112, 23);
            this.cmbJob.TabIndex = 3;
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Azo Sans", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnClear.Location = new System.Drawing.Point(289, 188);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(85, 25);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "CLEAR";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblEmployeeId
            // 
            this.lblEmployeeId.AutoSize = true;
            this.lblEmployeeId.Font = new System.Drawing.Font("Azo Sans", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblEmployeeId.Location = new System.Drawing.Point(12, 56);
            this.lblEmployeeId.Name = "lblEmployeeId";
            this.lblEmployeeId.Size = new System.Drawing.Size(81, 15);
            this.lblEmployeeId.TabIndex = 1;
            this.lblEmployeeId.Text = "Employee ID";
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Azo Sans", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSave.Location = new System.Drawing.Point(164, 188);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(85, 25);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dtmJoiningDate
            // 
            this.dtmJoiningDate.CustomFormat = "dd-MM-yyyy";
            this.dtmJoiningDate.Font = new System.Drawing.Font("Azo Sans", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtmJoiningDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtmJoiningDate.Location = new System.Drawing.Point(414, 135);
            this.dtmJoiningDate.Name = "dtmJoiningDate";
            this.dtmJoiningDate.Size = new System.Drawing.Size(112, 23);
            this.dtmJoiningDate.TabIndex = 6;
            // 
            // lblEmployeeName
            // 
            this.lblEmployeeName.AutoSize = true;
            this.lblEmployeeName.Font = new System.Drawing.Font("Azo Sans", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblEmployeeName.Location = new System.Drawing.Point(12, 91);
            this.lblEmployeeName.Name = "lblEmployeeName";
            this.lblEmployeeName.Size = new System.Drawing.Size(104, 15);
            this.lblEmployeeName.TabIndex = 1;
            this.lblEmployeeName.Text = "Employee Name";
            // 
            // txtMobileNo
            // 
            this.txtMobileNo.Font = new System.Drawing.Font("Azo Sans", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtMobileNo.Location = new System.Drawing.Point(414, 88);
            this.txtMobileNo.Name = "txtMobileNo";
            this.txtMobileNo.Size = new System.Drawing.Size(112, 23);
            this.txtMobileNo.TabIndex = 5;
            // 
            // lblJob
            // 
            this.lblJob.AutoSize = true;
            this.lblJob.Font = new System.Drawing.Font("Azo Sans", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblJob.Location = new System.Drawing.Point(12, 135);
            this.lblJob.Name = "lblJob";
            this.lblJob.Size = new System.Drawing.Size(28, 15);
            this.lblJob.TabIndex = 1;
            this.lblJob.Text = "Job";
            // 
            // lblSalary
            // 
            this.lblSalary.AutoSize = true;
            this.lblSalary.Font = new System.Drawing.Font("Azo Sans", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSalary.Location = new System.Drawing.Point(289, 56);
            this.lblSalary.Name = "lblSalary";
            this.lblSalary.Size = new System.Drawing.Size(43, 15);
            this.lblSalary.TabIndex = 1;
            this.lblSalary.Text = "Salary";
            // 
            // txtEmployeeName
            // 
            this.txtEmployeeName.Font = new System.Drawing.Font("Azo Sans", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtEmployeeName.Location = new System.Drawing.Point(137, 91);
            this.txtEmployeeName.Name = "txtEmployeeName";
            this.txtEmployeeName.Size = new System.Drawing.Size(112, 23);
            this.txtEmployeeName.TabIndex = 2;
            // 
            // lblMobileNo
            // 
            this.lblMobileNo.AutoSize = true;
            this.lblMobileNo.Font = new System.Drawing.Font("Azo Sans", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMobileNo.Location = new System.Drawing.Point(289, 94);
            this.lblMobileNo.Name = "lblMobileNo";
            this.lblMobileNo.Size = new System.Drawing.Size(68, 15);
            this.lblMobileNo.TabIndex = 1;
            this.lblMobileNo.Text = "Mobile No";
            // 
            // txtEmployeeId
            // 
            this.txtEmployeeId.Font = new System.Drawing.Font("Azo Sans", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtEmployeeId.Location = new System.Drawing.Point(137, 53);
            this.txtEmployeeId.Name = "txtEmployeeId";
            this.txtEmployeeId.Size = new System.Drawing.Size(112, 23);
            this.txtEmployeeId.TabIndex = 1;
            // 
            // lblJoiningDate
            // 
            this.lblJoiningDate.AutoSize = true;
            this.lblJoiningDate.Font = new System.Drawing.Font("Azo Sans", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblJoiningDate.Location = new System.Drawing.Point(286, 135);
            this.lblJoiningDate.Name = "lblJoiningDate";
            this.lblJoiningDate.Size = new System.Drawing.Size(82, 15);
            this.lblJoiningDate.TabIndex = 1;
            this.lblJoiningDate.Text = "Joining Date";
            // 
            // dgvEmployee
            // 
            this.dgvEmployee.AllowUserToAddRows = false;
            this.dgvEmployee.AllowUserToDeleteRows = false;
            this.dgvEmployee.BackgroundColor = System.Drawing.Color.Ivory;
            this.dgvEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployee.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EmployeeId,
            this.EmployeeName,
            this.Job,
            this.Salary,
            this.JoiningDate});
            this.dgvEmployee.Location = new System.Drawing.Point(3, 417);
            this.dgvEmployee.Name = "dgvEmployee";
            this.dgvEmployee.ReadOnly = true;
            this.dgvEmployee.RowTemplate.Height = 25;
            this.dgvEmployee.Size = new System.Drawing.Size(537, 237);
            this.dgvEmployee.TabIndex = 12;
            // 
            // EmployeeId
            // 
            this.EmployeeId.DataPropertyName = "EmployeeId";
            this.EmployeeId.HeaderText = "ID";
            this.EmployeeId.Name = "EmployeeId";
            this.EmployeeId.ReadOnly = true;
            this.EmployeeId.ToolTipText = "Id of Employee";
            this.EmployeeId.Width = 50;
            // 
            // EmployeeName
            // 
            this.EmployeeName.DataPropertyName = "EmployeeName";
            this.EmployeeName.HeaderText = "Name";
            this.EmployeeName.Name = "EmployeeName";
            this.EmployeeName.ReadOnly = true;
            this.EmployeeName.ToolTipText = "Name of the Employee";
            this.EmployeeName.Width = 150;
            // 
            // Job
            // 
            this.Job.DataPropertyName = "Job";
            this.Job.HeaderText = "Job";
            this.Job.Name = "Job";
            this.Job.ReadOnly = true;
            this.Job.ToolTipText = "Designation";
            // 
            // Salary
            // 
            this.Salary.DataPropertyName = "Salary";
            this.Salary.HeaderText = "Salary";
            this.Salary.Name = "Salary";
            this.Salary.ReadOnly = true;
            this.Salary.Width = 60;
            // 
            // JoiningDate
            // 
            this.JoiningDate.DataPropertyName = "JoiningDate";
            this.JoiningDate.HeaderText = "Joining Date";
            this.JoiningDate.Name = "JoiningDate";
            this.JoiningDate.ReadOnly = true;
            this.JoiningDate.Width = 150;
            // 
            // ucEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.Controls.Add(this.dgvEmployee);
            this.Controls.Add(this.btnRemoveEmployee);
            this.Controls.Add(this.pnlSearch);
            this.Controls.Add(this.pnlInventoryList);
            this.Name = "ucEmployee";
            this.Size = new System.Drawing.Size(543, 657);
            this.Load += new System.EventHandler(this.ucEmployee_Load);
            this.pnlSearch.ResumeLayout(false);
            this.pnlSearch.PerformLayout();
            this.pnlInventoryList.ResumeLayout(false);
            this.pnlInventoryList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRemoveEmployee;
        private System.Windows.Forms.Panel pnlSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.ComboBox cmbFilterBy;
        private System.Windows.Forms.Label lblKeyword;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.Label lblFilterBy;
        private System.Windows.Forms.TextBox txtKeyword;
        private System.Windows.Forms.Panel pnlInventoryList;
        private System.Windows.Forms.Label lblAddNewEmployee;
        private System.Windows.Forms.TextBox txtSalary;
        private System.Windows.Forms.ComboBox cmbJob;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblEmployeeId;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DateTimePicker dtmJoiningDate;
        private System.Windows.Forms.Label lblEmployeeName;
        private System.Windows.Forms.TextBox txtMobileNo;
        private System.Windows.Forms.Label lblJob;
        private System.Windows.Forms.Label lblSalary;
        private System.Windows.Forms.TextBox txtEmployeeName;
        private System.Windows.Forms.Label lblMobileNo;
        private System.Windows.Forms.TextBox txtEmployeeId;
        private System.Windows.Forms.Label lblJoiningDate;
        private System.Windows.Forms.DataGridView dgvEmployee;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeId;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Job;
        private System.Windows.Forms.DataGridViewTextBoxColumn Salary;
        private System.Windows.Forms.DataGridViewTextBoxColumn JoiningDate;
    }
}
