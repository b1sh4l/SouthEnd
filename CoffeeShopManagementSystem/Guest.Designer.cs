
namespace CoffeeShopManagementSystem
{
    partial class Guest
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Guest));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.pnlOrder = new System.Windows.Forms.Panel();
            this.pnlBil = new System.Windows.Forms.Panel();
            this.lblQty = new System.Windows.Forms.Label();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.lblItemName = new System.Windows.Forms.Label();
            this.lblCQty = new System.Windows.Forms.Label();
            this.lblCTotalPrice = new System.Windows.Forms.Label();
            this.lblBDTtp = new System.Windows.Forms.Label();
            this.lblCItemName = new System.Windows.Forms.Label();
            this.lblCMobileNo = new System.Windows.Forms.Label();
            this.lblMobileNo = new System.Windows.Forms.Label();
            this.lblYourBill = new System.Windows.Forms.Label();
            this.btnAddItems = new System.Windows.Forms.Button();
            this.pnlGrandTotal = new System.Windows.Forms.Panel();
            this.lblGrandTotal = new System.Windows.Forms.Label();
            this.lblBDT = new System.Windows.Forms.Label();
            this.txtEnterMobileNo = new System.Windows.Forms.TextBox();
            this.lblEnterMobileNo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPlaceOrder = new System.Windows.Forms.Button();
            this.pnlFood = new System.Windows.Forms.Panel();
            this.lblPriceSandwich = new System.Windows.Forms.Label();
            this.lblBDTsd = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblSandwichAndDesserts = new System.Windows.Forms.Label();
            this.lblQuantitySandwichAndDesserts = new System.Windows.Forms.Label();
            this.cmbSandwichAndDesserts = new System.Windows.Forms.ComboBox();
            this.cmbQuantitySandwichAndDesserts = new System.Windows.Forms.ComboBox();
            this.pnlFrozenDrinks = new System.Windows.Forms.Panel();
            this.lblPriceFrozenDrinks = new System.Windows.Forms.Label();
            this.lblBDTfBvg = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblFrozenDrinks = new System.Windows.Forms.Label();
            this.lblQuantityFrozenDrinks = new System.Windows.Forms.Label();
            this.cmbFrozenDrinks = new System.Windows.Forms.ComboBox();
            this.cmbQuantityFrozenDrinks = new System.Windows.Forms.ComboBox();
            this.pnlHotBeverage = new System.Windows.Forms.Panel();
            this.lblPriceHotBvg = new System.Windows.Forms.Label();
            this.lblBDThBVG = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblHotBeverages = new System.Windows.Forms.Label();
            this.lblQuantityHotBeverages = new System.Windows.Forms.Label();
            this.cmbHotBeverges = new System.Windows.Forms.ComboBox();
            this.cmbQuantityHotBeverages = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.pnlOrder.SuspendLayout();
            this.pnlBil.SuspendLayout();
            this.pnlGrandTotal.SuspendLayout();
            this.pnlFood.SuspendLayout();
            this.pnlFrozenDrinks.SuspendLayout();
            this.pnlHotBeverage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Info;
            this.panel1.Controls.Add(this.btnLogOut);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Location = new System.Drawing.Point(0, 108);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(199, 573);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnLogOut
            // 
            this.btnLogOut.Location = new System.Drawing.Point(52, 392);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(75, 23);
            this.btnLogOut.TabIndex = 12;
            this.btnLogOut.Text = "LogOut";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(52, 430);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 13;
            this.btnExit.Text = "EXIT";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pnlOrder
            // 
            this.pnlOrder.BackColor = System.Drawing.SystemColors.Info;
            this.pnlOrder.Controls.Add(this.pnlBil);
            this.pnlOrder.Controls.Add(this.btnAddItems);
            this.pnlOrder.Controls.Add(this.pnlGrandTotal);
            this.pnlOrder.Controls.Add(this.txtEnterMobileNo);
            this.pnlOrder.Controls.Add(this.lblEnterMobileNo);
            this.pnlOrder.Controls.Add(this.label1);
            this.pnlOrder.Controls.Add(this.btnPlaceOrder);
            this.pnlOrder.Controls.Add(this.pnlFood);
            this.pnlOrder.Controls.Add(this.pnlFrozenDrinks);
            this.pnlOrder.Controls.Add(this.pnlHotBeverage);
            this.pnlOrder.Location = new System.Drawing.Point(196, 108);
            this.pnlOrder.Name = "pnlOrder";
            this.pnlOrder.Size = new System.Drawing.Size(683, 573);
            this.pnlOrder.TabIndex = 1;
            this.pnlOrder.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // pnlBil
            // 
            this.pnlBil.Controls.Add(this.lblQty);
            this.pnlBil.Controls.Add(this.lblTotalPrice);
            this.pnlBil.Controls.Add(this.lblItemName);
            this.pnlBil.Controls.Add(this.lblCQty);
            this.pnlBil.Controls.Add(this.lblCTotalPrice);
            this.pnlBil.Controls.Add(this.lblBDTtp);
            this.pnlBil.Controls.Add(this.lblCItemName);
            this.pnlBil.Controls.Add(this.lblCMobileNo);
            this.pnlBil.Controls.Add(this.lblMobileNo);
            this.pnlBil.Controls.Add(this.lblYourBill);
            this.pnlBil.Location = new System.Drawing.Point(3, 367);
            this.pnlBil.Name = "pnlBil";
            this.pnlBil.Size = new System.Drawing.Size(403, 194);
            this.pnlBil.TabIndex = 23;
            // 
            // lblQty
            // 
            this.lblQty.AutoSize = true;
            this.lblQty.Font = new System.Drawing.Font("Azo Sans", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblQty.Location = new System.Drawing.Point(101, 114);
            this.lblQty.Name = "lblQty";
            this.lblQty.Size = new System.Drawing.Size(72, 15);
            this.lblQty.TabIndex = 1;
            this.lblQty.Text = "Quantity - ";
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Font = new System.Drawing.Font("Azo Sans", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTotalPrice.Location = new System.Drawing.Point(101, 93);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(72, 15);
            this.lblTotalPrice.TabIndex = 1;
            this.lblTotalPrice.Text = "TotalPrice-";
            // 
            // lblItemName
            // 
            this.lblItemName.AutoSize = true;
            this.lblItemName.Font = new System.Drawing.Font("Azo Sans", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblItemName.Location = new System.Drawing.Point(101, 71);
            this.lblItemName.Name = "lblItemName";
            this.lblItemName.Size = new System.Drawing.Size(81, 15);
            this.lblItemName.TabIndex = 1;
            this.lblItemName.Text = "Item Name- ";
            // 
            // lblCQty
            // 
            this.lblCQty.AutoSize = true;
            this.lblCQty.Font = new System.Drawing.Font("Azo Sans", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCQty.Location = new System.Drawing.Point(203, 114);
            this.lblCQty.Name = "lblCQty";
            this.lblCQty.Size = new System.Drawing.Size(27, 15);
            this.lblCQty.TabIndex = 1;
            this.lblCQty.Text = "qty";
            // 
            // lblCTotalPrice
            // 
            this.lblCTotalPrice.AutoSize = true;
            this.lblCTotalPrice.Font = new System.Drawing.Font("Azo Sans", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCTotalPrice.Location = new System.Drawing.Point(238, 93);
            this.lblCTotalPrice.Name = "lblCTotalPrice";
            this.lblCTotalPrice.Size = new System.Drawing.Size(65, 15);
            this.lblCTotalPrice.TabIndex = 1;
            this.lblCTotalPrice.Text = "totalprice";
            // 
            // lblBDTtp
            // 
            this.lblBDTtp.AutoSize = true;
            this.lblBDTtp.Font = new System.Drawing.Font("Azo Sans", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblBDTtp.Location = new System.Drawing.Point(203, 93);
            this.lblBDTtp.Name = "lblBDTtp";
            this.lblBDTtp.Size = new System.Drawing.Size(33, 15);
            this.lblBDTtp.TabIndex = 1;
            this.lblBDTtp.Text = "BDT";
            // 
            // lblCItemName
            // 
            this.lblCItemName.AutoSize = true;
            this.lblCItemName.Font = new System.Drawing.Font("Azo Sans", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCItemName.Location = new System.Drawing.Point(203, 71);
            this.lblCItemName.Name = "lblCItemName";
            this.lblCItemName.Size = new System.Drawing.Size(68, 15);
            this.lblCItemName.TabIndex = 1;
            this.lblCItemName.Text = "itemname";
            // 
            // lblCMobileNo
            // 
            this.lblCMobileNo.AutoSize = true;
            this.lblCMobileNo.Font = new System.Drawing.Font("Azo Sans", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCMobileNo.Location = new System.Drawing.Point(203, 49);
            this.lblCMobileNo.Name = "lblCMobileNo";
            this.lblCMobileNo.Size = new System.Drawing.Size(64, 15);
            this.lblCMobileNo.TabIndex = 1;
            this.lblCMobileNo.Text = "mobileno";
            // 
            // lblMobileNo
            // 
            this.lblMobileNo.AutoSize = true;
            this.lblMobileNo.Font = new System.Drawing.Font("Azo Sans", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMobileNo.Location = new System.Drawing.Point(101, 49);
            this.lblMobileNo.Name = "lblMobileNo";
            this.lblMobileNo.Size = new System.Drawing.Size(76, 15);
            this.lblMobileNo.TabIndex = 1;
            this.lblMobileNo.Text = "Mobile No- ";
            // 
            // lblYourBill
            // 
            this.lblYourBill.AutoSize = true;
            this.lblYourBill.Font = new System.Drawing.Font("Azo Sans", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblYourBill.Location = new System.Drawing.Point(19, 25);
            this.lblYourBill.Name = "lblYourBill";
            this.lblYourBill.Size = new System.Drawing.Size(67, 15);
            this.lblYourBill.TabIndex = 0;
            this.lblYourBill.Text = "Your Bill - ";
            // 
            // btnAddItems
            // 
            this.btnAddItems.Location = new System.Drawing.Point(9, 198);
            this.btnAddItems.Name = "btnAddItems";
            this.btnAddItems.Size = new System.Drawing.Size(108, 23);
            this.btnAddItems.TabIndex = 22;
            this.btnAddItems.Text = "Add To Cart";
            this.btnAddItems.UseVisualStyleBackColor = true;
            this.btnAddItems.Click += new System.EventHandler(this.btnAddItems_Click);
            // 
            // pnlGrandTotal
            // 
            this.pnlGrandTotal.BackColor = System.Drawing.Color.LightCoral;
            this.pnlGrandTotal.Controls.Add(this.lblGrandTotal);
            this.pnlGrandTotal.Controls.Add(this.lblBDT);
            this.pnlGrandTotal.Location = new System.Drawing.Point(479, 254);
            this.pnlGrandTotal.Name = "pnlGrandTotal";
            this.pnlGrandTotal.Size = new System.Drawing.Size(154, 29);
            this.pnlGrandTotal.TabIndex = 21;
            // 
            // lblGrandTotal
            // 
            this.lblGrandTotal.AutoSize = true;
            this.lblGrandTotal.Font = new System.Drawing.Font("Azo Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblGrandTotal.Location = new System.Drawing.Point(77, 6);
            this.lblGrandTotal.Name = "lblGrandTotal";
            this.lblGrandTotal.Size = new System.Drawing.Size(37, 18);
            this.lblGrandTotal.TabIndex = 19;
            this.lblGrandTotal.Text = "0.00";
            // 
            // lblBDT
            // 
            this.lblBDT.AutoSize = true;
            this.lblBDT.Font = new System.Drawing.Font("Azo Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblBDT.Location = new System.Drawing.Point(38, 6);
            this.lblBDT.Name = "lblBDT";
            this.lblBDT.Size = new System.Drawing.Size(38, 18);
            this.lblBDT.TabIndex = 20;
            this.lblBDT.Text = "BDT";
            // 
            // txtEnterMobileNo
            // 
            this.txtEnterMobileNo.Location = new System.Drawing.Point(479, 198);
            this.txtEnterMobileNo.Multiline = true;
            this.txtEnterMobileNo.Name = "txtEnterMobileNo";
            this.txtEnterMobileNo.Size = new System.Drawing.Size(154, 33);
            this.txtEnterMobileNo.TabIndex = 10;
            // 
            // lblEnterMobileNo
            // 
            this.lblEnterMobileNo.AutoSize = true;
            this.lblEnterMobileNo.Font = new System.Drawing.Font("Azo Sans", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblEnterMobileNo.Location = new System.Drawing.Point(370, 207);
            this.lblEnterMobileNo.Name = "lblEnterMobileNo";
            this.lblEnterMobileNo.Size = new System.Drawing.Size(103, 15);
            this.lblEnterMobileNo.TabIndex = 18;
            this.lblEnterMobileNo.Text = "Enter Mobile No";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Azo Sans", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(370, 262);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Grand Total";
            // 
            // btnPlaceOrder
            // 
            this.btnPlaceOrder.Font = new System.Drawing.Font("Azo Sans", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPlaceOrder.Location = new System.Drawing.Point(545, 316);
            this.btnPlaceOrder.Name = "btnPlaceOrder";
            this.btnPlaceOrder.Size = new System.Drawing.Size(88, 27);
            this.btnPlaceOrder.TabIndex = 11;
            this.btnPlaceOrder.Text = "Place Order";
            this.btnPlaceOrder.UseVisualStyleBackColor = true;
            this.btnPlaceOrder.Click += new System.EventHandler(this.btnPlaceOrder_Click);
            // 
            // pnlFood
            // 
            this.pnlFood.BackColor = System.Drawing.Color.Ivory;
            this.pnlFood.Controls.Add(this.lblPriceSandwich);
            this.pnlFood.Controls.Add(this.lblBDTsd);
            this.pnlFood.Controls.Add(this.label5);
            this.pnlFood.Controls.Add(this.lblSandwichAndDesserts);
            this.pnlFood.Controls.Add(this.lblQuantitySandwichAndDesserts);
            this.pnlFood.Controls.Add(this.cmbSandwichAndDesserts);
            this.pnlFood.Controls.Add(this.cmbQuantitySandwichAndDesserts);
            this.pnlFood.Location = new System.Drawing.Point(3, 129);
            this.pnlFood.Name = "pnlFood";
            this.pnlFood.Size = new System.Drawing.Size(668, 46);
            this.pnlFood.TabIndex = 15;
            // 
            // lblPriceSandwich
            // 
            this.lblPriceSandwich.AutoSize = true;
            this.lblPriceSandwich.Font = new System.Drawing.Font("Azo Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPriceSandwich.Location = new System.Drawing.Point(614, 14);
            this.lblPriceSandwich.Name = "lblPriceSandwich";
            this.lblPriceSandwich.Size = new System.Drawing.Size(37, 18);
            this.lblPriceSandwich.TabIndex = 21;
            this.lblPriceSandwich.Text = "0.00";
            // 
            // lblBDTsd
            // 
            this.lblBDTsd.AutoSize = true;
            this.lblBDTsd.Font = new System.Drawing.Font("Azo Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblBDTsd.Location = new System.Drawing.Point(570, 14);
            this.lblBDTsd.Name = "lblBDTsd";
            this.lblBDTsd.Size = new System.Drawing.Size(38, 18);
            this.lblBDTsd.TabIndex = 21;
            this.lblBDTsd.Text = "BDT";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Azo Sans", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(527, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Price";
            // 
            // lblSandwichAndDesserts
            // 
            this.lblSandwichAndDesserts.AutoSize = true;
            this.lblSandwichAndDesserts.Font = new System.Drawing.Font("Azo Sans", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSandwichAndDesserts.Location = new System.Drawing.Point(19, 16);
            this.lblSandwichAndDesserts.Name = "lblSandwichAndDesserts";
            this.lblSandwichAndDesserts.Size = new System.Drawing.Size(123, 15);
            this.lblSandwichAndDesserts.TabIndex = 0;
            this.lblSandwichAndDesserts.Text = "Sandwich-Desserts";
            // 
            // lblQuantitySandwichAndDesserts
            // 
            this.lblQuantitySandwichAndDesserts.AutoSize = true;
            this.lblQuantitySandwichAndDesserts.Font = new System.Drawing.Font("Azo Sans", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblQuantitySandwichAndDesserts.Location = new System.Drawing.Point(342, 12);
            this.lblQuantitySandwichAndDesserts.Name = "lblQuantitySandwichAndDesserts";
            this.lblQuantitySandwichAndDesserts.Size = new System.Drawing.Size(61, 15);
            this.lblQuantitySandwichAndDesserts.TabIndex = 0;
            this.lblQuantitySandwichAndDesserts.Text = "Quantity";
            // 
            // cmbSandwichAndDesserts
            // 
            this.cmbSandwichAndDesserts.Font = new System.Drawing.Font("Azo Sans", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbSandwichAndDesserts.FormattingEnabled = true;
            this.cmbSandwichAndDesserts.Location = new System.Drawing.Point(159, 12);
            this.cmbSandwichAndDesserts.Name = "cmbSandwichAndDesserts";
            this.cmbSandwichAndDesserts.Size = new System.Drawing.Size(141, 23);
            this.cmbSandwichAndDesserts.TabIndex = 7;
            // 
            // cmbQuantitySandwichAndDesserts
            // 
            this.cmbQuantitySandwichAndDesserts.Font = new System.Drawing.Font("Azo Sans", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbQuantitySandwichAndDesserts.FormattingEnabled = true;
            this.cmbQuantitySandwichAndDesserts.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cmbQuantitySandwichAndDesserts.Location = new System.Drawing.Point(409, 9);
            this.cmbQuantitySandwichAndDesserts.Name = "cmbQuantitySandwichAndDesserts";
            this.cmbQuantitySandwichAndDesserts.Size = new System.Drawing.Size(65, 23);
            this.cmbQuantitySandwichAndDesserts.TabIndex = 8;
            this.cmbQuantitySandwichAndDesserts.SelectedIndexChanged += new System.EventHandler(this.cmbQuantitySandwichAndDesserts_SelectedIndexChanged);
            // 
            // pnlFrozenDrinks
            // 
            this.pnlFrozenDrinks.BackColor = System.Drawing.Color.Ivory;
            this.pnlFrozenDrinks.Controls.Add(this.lblPriceFrozenDrinks);
            this.pnlFrozenDrinks.Controls.Add(this.lblBDTfBvg);
            this.pnlFrozenDrinks.Controls.Add(this.label2);
            this.pnlFrozenDrinks.Controls.Add(this.lblFrozenDrinks);
            this.pnlFrozenDrinks.Controls.Add(this.lblQuantityFrozenDrinks);
            this.pnlFrozenDrinks.Controls.Add(this.cmbFrozenDrinks);
            this.pnlFrozenDrinks.Controls.Add(this.cmbQuantityFrozenDrinks);
            this.pnlFrozenDrinks.Location = new System.Drawing.Point(3, 66);
            this.pnlFrozenDrinks.Name = "pnlFrozenDrinks";
            this.pnlFrozenDrinks.Size = new System.Drawing.Size(668, 57);
            this.pnlFrozenDrinks.TabIndex = 14;
            // 
            // lblPriceFrozenDrinks
            // 
            this.lblPriceFrozenDrinks.AutoSize = true;
            this.lblPriceFrozenDrinks.Font = new System.Drawing.Font("Azo Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPriceFrozenDrinks.Location = new System.Drawing.Point(614, 18);
            this.lblPriceFrozenDrinks.Name = "lblPriceFrozenDrinks";
            this.lblPriceFrozenDrinks.Size = new System.Drawing.Size(37, 18);
            this.lblPriceFrozenDrinks.TabIndex = 21;
            this.lblPriceFrozenDrinks.Text = "0.00";
            // 
            // lblBDTfBvg
            // 
            this.lblBDTfBvg.AutoSize = true;
            this.lblBDTfBvg.Font = new System.Drawing.Font("Azo Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblBDTfBvg.Location = new System.Drawing.Point(570, 20);
            this.lblBDTfBvg.Name = "lblBDTfBvg";
            this.lblBDTfBvg.Size = new System.Drawing.Size(38, 18);
            this.lblBDTfBvg.TabIndex = 21;
            this.lblBDTfBvg.Text = "BDT";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Azo Sans", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(527, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Price";
            // 
            // lblFrozenDrinks
            // 
            this.lblFrozenDrinks.AutoSize = true;
            this.lblFrozenDrinks.Font = new System.Drawing.Font("Azo Sans", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFrozenDrinks.Location = new System.Drawing.Point(24, 23);
            this.lblFrozenDrinks.Name = "lblFrozenDrinks";
            this.lblFrozenDrinks.Size = new System.Drawing.Size(90, 15);
            this.lblFrozenDrinks.TabIndex = 0;
            this.lblFrozenDrinks.Text = "Frozen Drinks";
            // 
            // lblQuantityFrozenDrinks
            // 
            this.lblQuantityFrozenDrinks.AutoSize = true;
            this.lblQuantityFrozenDrinks.Font = new System.Drawing.Font("Azo Sans", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblQuantityFrozenDrinks.Location = new System.Drawing.Point(342, 20);
            this.lblQuantityFrozenDrinks.Name = "lblQuantityFrozenDrinks";
            this.lblQuantityFrozenDrinks.Size = new System.Drawing.Size(61, 15);
            this.lblQuantityFrozenDrinks.TabIndex = 0;
            this.lblQuantityFrozenDrinks.Text = "Quantity";
            // 
            // cmbFrozenDrinks
            // 
            this.cmbFrozenDrinks.Font = new System.Drawing.Font("Azo Sans", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbFrozenDrinks.FormattingEnabled = true;
            this.cmbFrozenDrinks.Location = new System.Drawing.Point(159, 20);
            this.cmbFrozenDrinks.Name = "cmbFrozenDrinks";
            this.cmbFrozenDrinks.Size = new System.Drawing.Size(141, 23);
            this.cmbFrozenDrinks.TabIndex = 4;
            // 
            // cmbQuantityFrozenDrinks
            // 
            this.cmbQuantityFrozenDrinks.Font = new System.Drawing.Font("Azo Sans", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbQuantityFrozenDrinks.FormattingEnabled = true;
            this.cmbQuantityFrozenDrinks.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cmbQuantityFrozenDrinks.Location = new System.Drawing.Point(409, 17);
            this.cmbQuantityFrozenDrinks.Name = "cmbQuantityFrozenDrinks";
            this.cmbQuantityFrozenDrinks.Size = new System.Drawing.Size(65, 23);
            this.cmbQuantityFrozenDrinks.TabIndex = 5;
            this.cmbQuantityFrozenDrinks.SelectedIndexChanged += new System.EventHandler(this.cmbQuantityFrozenDrinks_SelectedIndexChanged);
            // 
            // pnlHotBeverage
            // 
            this.pnlHotBeverage.BackColor = System.Drawing.Color.Ivory;
            this.pnlHotBeverage.Controls.Add(this.lblPriceHotBvg);
            this.pnlHotBeverage.Controls.Add(this.lblBDThBVG);
            this.pnlHotBeverage.Controls.Add(this.lblPrice);
            this.pnlHotBeverage.Controls.Add(this.lblHotBeverages);
            this.pnlHotBeverage.Controls.Add(this.lblQuantityHotBeverages);
            this.pnlHotBeverage.Controls.Add(this.cmbHotBeverges);
            this.pnlHotBeverage.Controls.Add(this.cmbQuantityHotBeverages);
            this.pnlHotBeverage.Location = new System.Drawing.Point(3, 8);
            this.pnlHotBeverage.Name = "pnlHotBeverage";
            this.pnlHotBeverage.Size = new System.Drawing.Size(668, 52);
            this.pnlHotBeverage.TabIndex = 13;
            // 
            // lblPriceHotBvg
            // 
            this.lblPriceHotBvg.AutoSize = true;
            this.lblPriceHotBvg.Font = new System.Drawing.Font("Azo Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPriceHotBvg.Location = new System.Drawing.Point(614, 20);
            this.lblPriceHotBvg.Name = "lblPriceHotBvg";
            this.lblPriceHotBvg.Size = new System.Drawing.Size(37, 18);
            this.lblPriceHotBvg.TabIndex = 21;
            this.lblPriceHotBvg.Text = "0.00";
            // 
            // lblBDThBVG
            // 
            this.lblBDThBVG.AutoSize = true;
            this.lblBDThBVG.Font = new System.Drawing.Font("Azo Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblBDThBVG.Location = new System.Drawing.Point(570, 20);
            this.lblBDThBVG.Name = "lblBDThBVG";
            this.lblBDThBVG.Size = new System.Drawing.Size(38, 18);
            this.lblBDThBVG.TabIndex = 21;
            this.lblBDThBVG.Text = "BDT";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Azo Sans", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPrice.Location = new System.Drawing.Point(527, 23);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(37, 15);
            this.lblPrice.TabIndex = 4;
            this.lblPrice.Text = "Price";
            // 
            // lblHotBeverages
            // 
            this.lblHotBeverages.AutoSize = true;
            this.lblHotBeverages.Font = new System.Drawing.Font("Azo Sans", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblHotBeverages.Location = new System.Drawing.Point(19, 24);
            this.lblHotBeverages.Name = "lblHotBeverages";
            this.lblHotBeverages.Size = new System.Drawing.Size(95, 15);
            this.lblHotBeverages.TabIndex = 0;
            this.lblHotBeverages.Text = "Hot Beverages";
            // 
            // lblQuantityHotBeverages
            // 
            this.lblQuantityHotBeverages.AutoSize = true;
            this.lblQuantityHotBeverages.Font = new System.Drawing.Font("Azo Sans", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblQuantityHotBeverages.Location = new System.Drawing.Point(342, 23);
            this.lblQuantityHotBeverages.Name = "lblQuantityHotBeverages";
            this.lblQuantityHotBeverages.Size = new System.Drawing.Size(61, 15);
            this.lblQuantityHotBeverages.TabIndex = 0;
            this.lblQuantityHotBeverages.Text = "Quantity";
            // 
            // cmbHotBeverges
            // 
            this.cmbHotBeverges.Font = new System.Drawing.Font("Azo Sans", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbHotBeverges.FormattingEnabled = true;
            this.cmbHotBeverges.Location = new System.Drawing.Point(159, 16);
            this.cmbHotBeverges.Name = "cmbHotBeverges";
            this.cmbHotBeverges.Size = new System.Drawing.Size(141, 23);
            this.cmbHotBeverges.TabIndex = 1;
            // 
            // cmbQuantityHotBeverages
            // 
            this.cmbQuantityHotBeverages.Font = new System.Drawing.Font("Azo Sans", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbQuantityHotBeverages.FormattingEnabled = true;
            this.cmbQuantityHotBeverages.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cmbQuantityHotBeverages.Location = new System.Drawing.Point(409, 20);
            this.cmbQuantityHotBeverages.Name = "cmbQuantityHotBeverages";
            this.cmbQuantityHotBeverages.Size = new System.Drawing.Size(65, 23);
            this.cmbQuantityHotBeverages.TabIndex = 2;
            this.cmbQuantityHotBeverages.SelectedIndexChanged += new System.EventHandler(this.cmbQuantityHotBeverages_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(879, 110);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // Guest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 681);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pnlOrder);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Guest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Guest";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Guest_FormClosed);
            this.Load += new System.EventHandler(this.Guest_Load);
            this.panel1.ResumeLayout(false);
            this.pnlOrder.ResumeLayout(false);
            this.pnlOrder.PerformLayout();
            this.pnlBil.ResumeLayout(false);
            this.pnlBil.PerformLayout();
            this.pnlGrandTotal.ResumeLayout(false);
            this.pnlGrandTotal.PerformLayout();
            this.pnlFood.ResumeLayout(false);
            this.pnlFood.PerformLayout();
            this.pnlFrozenDrinks.ResumeLayout(false);
            this.pnlFrozenDrinks.PerformLayout();
            this.pnlHotBeverage.ResumeLayout(false);
            this.pnlHotBeverage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlOrder;
        private System.Windows.Forms.Button btnPlaceOrder;
        private System.Windows.Forms.Panel pnlFood;
        private System.Windows.Forms.Label lblSandwichAndDesserts;
        private System.Windows.Forms.Label lblQuantitySandwichAndDesserts;
        private System.Windows.Forms.ComboBox cmbSandwichAndDesserts;
        private System.Windows.Forms.ComboBox cmbQuantitySandwichAndDesserts;
        private System.Windows.Forms.Panel pnlFrozenDrinks;
        private System.Windows.Forms.Label lblFrozenDrinks;
        private System.Windows.Forms.Label lblQuantityFrozenDrinks;
        private System.Windows.Forms.ComboBox cmbFrozenDrinks;
        private System.Windows.Forms.ComboBox cmbQuantityFrozenDrinks;
        private System.Windows.Forms.Panel pnlHotBeverage;
        private System.Windows.Forms.Label lblHotBeverages;
        private System.Windows.Forms.Label lblQuantityHotBeverages;
        private System.Windows.Forms.ComboBox cmbHotBeverges;
        private System.Windows.Forms.ComboBox cmbQuantityHotBeverages;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtEnterMobileNo;
        private System.Windows.Forms.Label lblEnterMobileNo;
        private System.Windows.Forms.Label lblYourBill;
        private System.Windows.Forms.Panel pnlGrandTotal;
        private System.Windows.Forms.Label lblGrandTotal;
        private System.Windows.Forms.Label lblBDT;
        private System.Windows.Forms.Label lblPriceSandwich;
        private System.Windows.Forms.Label lblBDTsd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblPriceFrozenDrinks;
        private System.Windows.Forms.Label lblBDTfBvg;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblPriceHotBvg;
        private System.Windows.Forms.Label lblBDThBVG;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Button btnAddItems;
        private System.Windows.Forms.Panel pnlBil;
        private System.Windows.Forms.Label lblQty;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.Label lblItemName;
        private System.Windows.Forms.Label lblCQty;
        private System.Windows.Forms.Label lblCTotalPrice;
        private System.Windows.Forms.Label lblBDTtp;
        private System.Windows.Forms.Label lblCItemName;
        private System.Windows.Forms.Label lblCMobileNo;
        private System.Windows.Forms.Label lblMobileNo;
    }
}