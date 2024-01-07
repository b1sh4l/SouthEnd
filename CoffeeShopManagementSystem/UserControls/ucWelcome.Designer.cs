
namespace CoffeeShopManagementSystem.UserControls
{
    partial class ucWelcome
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
            this.lblWelcomeAdmin = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblWelcomeAdmin
            // 
            this.lblWelcomeAdmin.AutoSize = true;
            this.lblWelcomeAdmin.Font = new System.Drawing.Font("Azo Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblWelcomeAdmin.Location = new System.Drawing.Point(183, 289);
            this.lblWelcomeAdmin.Name = "lblWelcomeAdmin";
            this.lblWelcomeAdmin.Size = new System.Drawing.Size(171, 23);
            this.lblWelcomeAdmin.TabIndex = 1;
            this.lblWelcomeAdmin.Text = "WELCOME ADMIN";
            this.lblWelcomeAdmin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ucWelcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.Controls.Add(this.lblWelcomeAdmin);
            this.Name = "ucWelcome";
            this.Size = new System.Drawing.Size(543, 657);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWelcomeAdmin;
    }
}
