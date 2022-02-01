
namespace POSWinforms.Transaction
{
    partial class frmSelectItem
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSelectItem));
            this.metroSetControlBox1 = new MetroSet_UI.Controls.MetroSetControlBox();
            this.metroSetLabel1 = new System.Windows.Forms.Label();
            this.metroSetLabel2 = new System.Windows.Forms.Label();
            this.metroSetLabel3 = new System.Windows.Forms.Label();
            this.metroSetLabel4 = new System.Windows.Forms.Label();
            this.metroSetLabel5 = new System.Windows.Forms.Label();
            this.metroSetLabel6 = new System.Windows.Forms.Label();
            this.txtItemDescription = new MetroSet_UI.Controls.MetroSetTextBox();
            this.txtItemCode = new MetroSet_UI.Controls.MetroSetTextBox();
            this.txtUnitPrice = new MetroSet_UI.Controls.MetroSetTextBox();
            this.txtTotal = new MetroSet_UI.Controls.MetroSetTextBox();
            this.metroSetLabel7 = new System.Windows.Forms.Label();
            this.quantitySelector = new System.Windows.Forms.NumericUpDown();
            this.discountSelector = new System.Windows.Forms.NumericUpDown();
            this.btnSelectItem = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnAddToCart = new System.Windows.Forms.Button();
            this.lbAvailStock = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDesignPrice = new MetroSet_UI.Controls.MetroSetTextBox();
            this.txtDiscountedTotal = new MetroSet_UI.Controls.MetroSetTextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.quantitySelector)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.discountSelector)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroSetControlBox1
            // 
            this.metroSetControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroSetControlBox1.CloseHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.metroSetControlBox1.CloseHoverForeColor = System.Drawing.Color.White;
            this.metroSetControlBox1.CloseNormalForeColor = System.Drawing.Color.Gray;
            this.metroSetControlBox1.DisabledForeColor = System.Drawing.Color.DimGray;
            this.metroSetControlBox1.IsDerivedStyle = true;
            this.metroSetControlBox1.Location = new System.Drawing.Point(327, 11);
            this.metroSetControlBox1.Margin = new System.Windows.Forms.Padding(2);
            this.metroSetControlBox1.MaximizeBox = false;
            this.metroSetControlBox1.MaximizeHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.metroSetControlBox1.MaximizeHoverForeColor = System.Drawing.Color.Gray;
            this.metroSetControlBox1.MaximizeNormalForeColor = System.Drawing.Color.Gray;
            this.metroSetControlBox1.MinimizeBox = true;
            this.metroSetControlBox1.MinimizeHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.metroSetControlBox1.MinimizeHoverForeColor = System.Drawing.Color.Gray;
            this.metroSetControlBox1.MinimizeNormalForeColor = System.Drawing.Color.Gray;
            this.metroSetControlBox1.Name = "metroSetControlBox1";
            this.metroSetControlBox1.Size = new System.Drawing.Size(100, 25);
            this.metroSetControlBox1.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetControlBox1.StyleManager = null;
            this.metroSetControlBox1.TabIndex = 0;
            this.metroSetControlBox1.Text = "metroSetControlBox1";
            this.metroSetControlBox1.ThemeAuthor = null;
            this.metroSetControlBox1.ThemeName = null;
            // 
            // metroSetLabel1
            // 
            this.metroSetLabel1.AutoSize = true;
            this.metroSetLabel1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroSetLabel1.Location = new System.Drawing.Point(53, 27);
            this.metroSetLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroSetLabel1.Name = "metroSetLabel1";
            this.metroSetLabel1.Size = new System.Drawing.Size(92, 21);
            this.metroSetLabel1.TabIndex = 1;
            this.metroSetLabel1.Text = "Item Code:";
            // 
            // metroSetLabel2
            // 
            this.metroSetLabel2.AutoSize = true;
            this.metroSetLabel2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroSetLabel2.Location = new System.Drawing.Point(4, 61);
            this.metroSetLabel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroSetLabel2.Name = "metroSetLabel2";
            this.metroSetLabel2.Size = new System.Drawing.Size(141, 21);
            this.metroSetLabel2.TabIndex = 2;
            this.metroSetLabel2.Text = "Item Description:";
            // 
            // metroSetLabel3
            // 
            this.metroSetLabel3.AutoSize = true;
            this.metroSetLabel3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroSetLabel3.Location = new System.Drawing.Point(56, 96);
            this.metroSetLabel3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroSetLabel3.Name = "metroSetLabel3";
            this.metroSetLabel3.Size = new System.Drawing.Size(89, 21);
            this.metroSetLabel3.TabIndex = 3;
            this.metroSetLabel3.Text = "Unit Price:";
            // 
            // metroSetLabel4
            // 
            this.metroSetLabel4.AutoSize = true;
            this.metroSetLabel4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroSetLabel4.Location = new System.Drawing.Point(64, 164);
            this.metroSetLabel4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroSetLabel4.Name = "metroSetLabel4";
            this.metroSetLabel4.Size = new System.Drawing.Size(81, 21);
            this.metroSetLabel4.TabIndex = 4;
            this.metroSetLabel4.Text = "Quantity:";
            // 
            // metroSetLabel5
            // 
            this.metroSetLabel5.AutoSize = true;
            this.metroSetLabel5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroSetLabel5.Location = new System.Drawing.Point(63, 199);
            this.metroSetLabel5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroSetLabel5.Name = "metroSetLabel5";
            this.metroSetLabel5.Size = new System.Drawing.Size(82, 21);
            this.metroSetLabel5.TabIndex = 5;
            this.metroSetLabel5.Text = "Discount:";
            // 
            // metroSetLabel6
            // 
            this.metroSetLabel6.AutoSize = true;
            this.metroSetLabel6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroSetLabel6.Location = new System.Drawing.Point(93, 233);
            this.metroSetLabel6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroSetLabel6.Name = "metroSetLabel6";
            this.metroSetLabel6.Size = new System.Drawing.Size(52, 21);
            this.metroSetLabel6.TabIndex = 6;
            this.metroSetLabel6.Text = "Total:";
            // 
            // txtItemDescription
            // 
            this.txtItemDescription.AutoCompleteCustomSource = null;
            this.txtItemDescription.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtItemDescription.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtItemDescription.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txtItemDescription.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtItemDescription.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txtItemDescription.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.txtItemDescription.Enabled = false;
            this.txtItemDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtItemDescription.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.txtItemDescription.Image = null;
            this.txtItemDescription.IsDerivedStyle = false;
            this.txtItemDescription.Lines = null;
            this.txtItemDescription.Location = new System.Drawing.Point(149, 52);
            this.txtItemDescription.Margin = new System.Windows.Forms.Padding(2);
            this.txtItemDescription.MaxLength = 32767;
            this.txtItemDescription.Multiline = false;
            this.txtItemDescription.Name = "txtItemDescription";
            this.txtItemDescription.ReadOnly = false;
            this.txtItemDescription.Size = new System.Drawing.Size(175, 30);
            this.txtItemDescription.Style = MetroSet_UI.Enums.Style.Light;
            this.txtItemDescription.StyleManager = null;
            this.txtItemDescription.TabIndex = 7;
            this.txtItemDescription.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtItemDescription.ThemeAuthor = null;
            this.txtItemDescription.ThemeName = null;
            this.txtItemDescription.UseSystemPasswordChar = false;
            this.txtItemDescription.WatermarkText = "";
            // 
            // txtItemCode
            // 
            this.txtItemCode.AutoCompleteCustomSource = null;
            this.txtItemCode.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtItemCode.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtItemCode.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txtItemCode.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtItemCode.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txtItemCode.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.txtItemCode.Enabled = false;
            this.txtItemCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtItemCode.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.txtItemCode.Image = null;
            this.txtItemCode.IsDerivedStyle = false;
            this.txtItemCode.Lines = null;
            this.txtItemCode.Location = new System.Drawing.Point(149, 18);
            this.txtItemCode.Margin = new System.Windows.Forms.Padding(2);
            this.txtItemCode.MaxLength = 32767;
            this.txtItemCode.Multiline = false;
            this.txtItemCode.Name = "txtItemCode";
            this.txtItemCode.ReadOnly = false;
            this.txtItemCode.Size = new System.Drawing.Size(82, 30);
            this.txtItemCode.Style = MetroSet_UI.Enums.Style.Light;
            this.txtItemCode.StyleManager = null;
            this.txtItemCode.TabIndex = 8;
            this.txtItemCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtItemCode.ThemeAuthor = null;
            this.txtItemCode.ThemeName = null;
            this.txtItemCode.UseSystemPasswordChar = false;
            this.txtItemCode.WatermarkText = "";
            // 
            // txtUnitPrice
            // 
            this.txtUnitPrice.AutoCompleteCustomSource = null;
            this.txtUnitPrice.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtUnitPrice.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtUnitPrice.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txtUnitPrice.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtUnitPrice.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txtUnitPrice.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.txtUnitPrice.Enabled = false;
            this.txtUnitPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtUnitPrice.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.txtUnitPrice.Image = null;
            this.txtUnitPrice.IsDerivedStyle = false;
            this.txtUnitPrice.Lines = null;
            this.txtUnitPrice.Location = new System.Drawing.Point(149, 87);
            this.txtUnitPrice.Margin = new System.Windows.Forms.Padding(2);
            this.txtUnitPrice.MaxLength = 32767;
            this.txtUnitPrice.Multiline = false;
            this.txtUnitPrice.Name = "txtUnitPrice";
            this.txtUnitPrice.ReadOnly = false;
            this.txtUnitPrice.Size = new System.Drawing.Size(82, 30);
            this.txtUnitPrice.Style = MetroSet_UI.Enums.Style.Light;
            this.txtUnitPrice.StyleManager = null;
            this.txtUnitPrice.TabIndex = 9;
            this.txtUnitPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtUnitPrice.ThemeAuthor = null;
            this.txtUnitPrice.ThemeName = null;
            this.txtUnitPrice.UseSystemPasswordChar = false;
            this.txtUnitPrice.WatermarkText = "";
            // 
            // txtTotal
            // 
            this.txtTotal.AutoCompleteCustomSource = null;
            this.txtTotal.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtTotal.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtTotal.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txtTotal.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtTotal.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txtTotal.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.txtTotal.Enabled = false;
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtTotal.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.txtTotal.Image = null;
            this.txtTotal.IsDerivedStyle = false;
            this.txtTotal.Lines = null;
            this.txtTotal.Location = new System.Drawing.Point(149, 224);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(2);
            this.txtTotal.MaxLength = 32767;
            this.txtTotal.Multiline = false;
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = false;
            this.txtTotal.Size = new System.Drawing.Size(108, 30);
            this.txtTotal.Style = MetroSet_UI.Enums.Style.Light;
            this.txtTotal.StyleManager = null;
            this.txtTotal.TabIndex = 12;
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtTotal.ThemeAuthor = null;
            this.txtTotal.ThemeName = null;
            this.txtTotal.UseSystemPasswordChar = false;
            this.txtTotal.WatermarkText = "";
            // 
            // metroSetLabel7
            // 
            this.metroSetLabel7.AutoSize = true;
            this.metroSetLabel7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroSetLabel7.Location = new System.Drawing.Point(235, 192);
            this.metroSetLabel7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroSetLabel7.Name = "metroSetLabel7";
            this.metroSetLabel7.Size = new System.Drawing.Size(31, 25);
            this.metroSetLabel7.TabIndex = 13;
            this.metroSetLabel7.Text = "%";
            // 
            // quantitySelector
            // 
            this.quantitySelector.BackColor = System.Drawing.Color.Snow;
            this.quantitySelector.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantitySelector.Location = new System.Drawing.Point(149, 155);
            this.quantitySelector.Margin = new System.Windows.Forms.Padding(2);
            this.quantitySelector.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.quantitySelector.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.quantitySelector.Name = "quantitySelector";
            this.quantitySelector.Size = new System.Drawing.Size(82, 30);
            this.quantitySelector.TabIndex = 1;
            this.quantitySelector.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.quantitySelector.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.quantitySelector.ValueChanged += new System.EventHandler(this.quantitySelector_ValueChanged);
            this.quantitySelector.KeyDown += new System.Windows.Forms.KeyEventHandler(this.quantitySelector_KeyDown);
            // 
            // discountSelector
            // 
            this.discountSelector.BackColor = System.Drawing.Color.Snow;
            this.discountSelector.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.discountSelector.Location = new System.Drawing.Point(149, 190);
            this.discountSelector.Margin = new System.Windows.Forms.Padding(2);
            this.discountSelector.Name = "discountSelector";
            this.discountSelector.Size = new System.Drawing.Size(82, 30);
            this.discountSelector.TabIndex = 2;
            this.discountSelector.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.discountSelector.ValueChanged += new System.EventHandler(this.discountSelector_ValueChanged);
            this.discountSelector.KeyDown += new System.Windows.Forms.KeyEventHandler(this.discountSelector_KeyDown);
            // 
            // btnSelectItem
            // 
            this.btnSelectItem.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectItem.ForeColor = System.Drawing.Color.Maroon;
            this.btnSelectItem.Image = ((System.Drawing.Image)(resources.GetObject("btnSelectItem.Image")));
            this.btnSelectItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSelectItem.Location = new System.Drawing.Point(235, 16);
            this.btnSelectItem.Margin = new System.Windows.Forms.Padding(2);
            this.btnSelectItem.Name = "btnSelectItem";
            this.btnSelectItem.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.btnSelectItem.Size = new System.Drawing.Size(142, 32);
            this.btnSelectItem.TabIndex = 0;
            this.btnSelectItem.Text = "Select Item";
            this.btnSelectItem.UseVisualStyleBackColor = true;
            this.btnSelectItem.Click += new System.EventHandler(this.btnSelectItem_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnAddToCart
            // 
            this.btnAddToCart.BackColor = System.Drawing.Color.LightCoral;
            this.btnAddToCart.Enabled = false;
            this.btnAddToCart.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.btnAddToCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddToCart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddToCart.ForeColor = System.Drawing.Color.Black;
            this.btnAddToCart.Location = new System.Drawing.Point(272, 385);
            this.btnAddToCart.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddToCart.Name = "btnAddToCart";
            this.btnAddToCart.Size = new System.Drawing.Size(155, 38);
            this.btnAddToCart.TabIndex = 3;
            this.btnAddToCart.Text = "Add To Cart";
            this.btnAddToCart.UseVisualStyleBackColor = false;
            this.btnAddToCart.Click += new System.EventHandler(this.btnAddToCart_Click);
            // 
            // lbAvailStock
            // 
            this.lbAvailStock.AutoSize = true;
            this.lbAvailStock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbAvailStock.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAvailStock.Location = new System.Drawing.Point(235, 164);
            this.lbAvailStock.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbAvailStock.Name = "lbAvailStock";
            this.lbAvailStock.Size = new System.Drawing.Size(161, 21);
            this.lbAvailStock.TabIndex = 113;
            this.lbAvailStock.Text = "(Available Stocks - )";
            this.lbAvailStock.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.txtDiscountedTotal);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtDesignPrice);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lbAvailStock);
            this.panel1.Controls.Add(this.btnSelectItem);
            this.panel1.Controls.Add(this.discountSelector);
            this.panel1.Controls.Add(this.quantitySelector);
            this.panel1.Controls.Add(this.metroSetLabel7);
            this.panel1.Controls.Add(this.txtTotal);
            this.panel1.Controls.Add(this.txtUnitPrice);
            this.panel1.Controls.Add(this.txtItemCode);
            this.panel1.Controls.Add(this.txtItemDescription);
            this.panel1.Controls.Add(this.metroSetLabel6);
            this.panel1.Controls.Add(this.metroSetLabel5);
            this.panel1.Controls.Add(this.metroSetLabel4);
            this.panel1.Controls.Add(this.metroSetLabel3);
            this.panel1.Controls.Add(this.metroSetLabel2);
            this.panel1.Controls.Add(this.metroSetLabel1);
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(4, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(423, 330);
            this.panel1.TabIndex = 114;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 130);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 21);
            this.label1.TabIndex = 114;
            this.label1.Text = "Design Price:";
            // 
            // txtDesignPrice
            // 
            this.txtDesignPrice.AutoCompleteCustomSource = null;
            this.txtDesignPrice.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtDesignPrice.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtDesignPrice.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txtDesignPrice.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtDesignPrice.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txtDesignPrice.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.txtDesignPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtDesignPrice.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.txtDesignPrice.Image = null;
            this.txtDesignPrice.IsDerivedStyle = false;
            this.txtDesignPrice.Lines = null;
            this.txtDesignPrice.Location = new System.Drawing.Point(149, 121);
            this.txtDesignPrice.Margin = new System.Windows.Forms.Padding(2);
            this.txtDesignPrice.MaxLength = 32767;
            this.txtDesignPrice.Multiline = false;
            this.txtDesignPrice.Name = "txtDesignPrice";
            this.txtDesignPrice.ReadOnly = false;
            this.txtDesignPrice.Size = new System.Drawing.Size(82, 30);
            this.txtDesignPrice.Style = MetroSet_UI.Enums.Style.Light;
            this.txtDesignPrice.StyleManager = null;
            this.txtDesignPrice.TabIndex = 115;
            this.txtDesignPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtDesignPrice.ThemeAuthor = null;
            this.txtDesignPrice.ThemeName = null;
            this.txtDesignPrice.UseSystemPasswordChar = false;
            this.txtDesignPrice.WatermarkText = "";
            // 
            // txtDiscountedTotal
            // 
            this.txtDiscountedTotal.AutoCompleteCustomSource = null;
            this.txtDiscountedTotal.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtDiscountedTotal.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtDiscountedTotal.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txtDiscountedTotal.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtDiscountedTotal.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txtDiscountedTotal.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.txtDiscountedTotal.Enabled = false;
            this.txtDiscountedTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtDiscountedTotal.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.txtDiscountedTotal.Image = null;
            this.txtDiscountedTotal.IsDerivedStyle = false;
            this.txtDiscountedTotal.Lines = null;
            this.txtDiscountedTotal.Location = new System.Drawing.Point(149, 258);
            this.txtDiscountedTotal.Margin = new System.Windows.Forms.Padding(2);
            this.txtDiscountedTotal.MaxLength = 32767;
            this.txtDiscountedTotal.Multiline = false;
            this.txtDiscountedTotal.Name = "txtDiscountedTotal";
            this.txtDiscountedTotal.ReadOnly = false;
            this.txtDiscountedTotal.Size = new System.Drawing.Size(108, 30);
            this.txtDiscountedTotal.Style = MetroSet_UI.Enums.Style.Light;
            this.txtDiscountedTotal.StyleManager = null;
            this.txtDiscountedTotal.TabIndex = 117;
            this.txtDiscountedTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtDiscountedTotal.ThemeAuthor = null;
            this.txtDiscountedTotal.ThemeName = null;
            this.txtDiscountedTotal.UseSystemPasswordChar = false;
            this.txtDiscountedTotal.WatermarkText = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(2, 267);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 21);
            this.label2.TabIndex = 116;
            this.label2.Text = "Discounted Total:";
            // 
            // frmSelectItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(440, 434);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnAddToCart);
            this.Controls.Add(this.metroSetControlBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmSelectItem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Select Item";
            this.Load += new System.EventHandler(this.frmAddItem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.quantitySelector)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.discountSelector)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private MetroSet_UI.Controls.MetroSetControlBox metroSetControlBox1;
        private System.Windows.Forms.Button btnSelectItem;
        private System.Windows.Forms.NumericUpDown discountSelector;
        private System.Windows.Forms.NumericUpDown quantitySelector;
        private System.Windows.Forms.Label metroSetLabel7;
        private MetroSet_UI.Controls.MetroSetTextBox txtTotal;
        private MetroSet_UI.Controls.MetroSetTextBox txtUnitPrice;
        private MetroSet_UI.Controls.MetroSetTextBox txtItemCode;
        private MetroSet_UI.Controls.MetroSetTextBox txtItemDescription;
        private System.Windows.Forms.Label metroSetLabel6;
        private System.Windows.Forms.Label metroSetLabel5;
        private System.Windows.Forms.Label metroSetLabel4;
        private System.Windows.Forms.Label metroSetLabel3;
        private System.Windows.Forms.Label metroSetLabel2;
        private System.Windows.Forms.Label metroSetLabel1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnAddToCart;
        private System.Windows.Forms.Label lbAvailStock;
        private System.Windows.Forms.Panel panel1;
        private MetroSet_UI.Controls.MetroSetTextBox txtDiscountedTotal;
        private System.Windows.Forms.Label label2;
        private MetroSet_UI.Controls.MetroSetTextBox txtDesignPrice;
        private System.Windows.Forms.Label label1;
    }
}