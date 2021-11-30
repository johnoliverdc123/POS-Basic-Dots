
namespace POSWinforms.Maintenance
{
    partial class frmAddEditItem
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
            this.metroSetControlBox1 = new MetroSet_UI.Controls.MetroSetControlBox();
            this.metroSetLabel1 = new MetroSet_UI.Controls.MetroSetLabel();
            this.metroSetLabel2 = new MetroSet_UI.Controls.MetroSetLabel();
            this.metroSetLabel3 = new MetroSet_UI.Controls.MetroSetLabel();
            this.metroSetLabel4 = new MetroSet_UI.Controls.MetroSetLabel();
            this.metroSetLabel5 = new MetroSet_UI.Controls.MetroSetLabel();
            this.cmbCategory = new MetroSet_UI.Controls.MetroSetComboBox();
            this.txtCode = new MetroSet_UI.Controls.MetroSetTextBox();
            this.txtDescription = new MetroSet_UI.Controls.MetroSetTextBox();
            this.txtSize = new MetroSet_UI.Controls.MetroSetTextBox();
            this.txtQuantity = new MetroSet_UI.Controls.MetroSetTextBox();
            this.txtUnitPrice = new MetroSet_UI.Controls.MetroSetTextBox();
            this.metroSetLabel6 = new MetroSet_UI.Controls.MetroSetLabel();
            this.txtReProduceLevel = new MetroSet_UI.Controls.MetroSetTextBox();
            this.metroSetLabel7 = new MetroSet_UI.Controls.MetroSetLabel();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnSave = new System.Windows.Forms.Button();
            this.lbTitle = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroSetControlBox1
            // 
            this.metroSetControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroSetControlBox1.CloseHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.metroSetControlBox1.CloseHoverForeColor = System.Drawing.Color.White;
            this.metroSetControlBox1.CloseNormalForeColor = System.Drawing.Color.Gray;
            this.metroSetControlBox1.DisabledForeColor = System.Drawing.Color.DimGray;
            this.metroSetControlBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.metroSetControlBox1.IsDerivedStyle = true;
            this.metroSetControlBox1.Location = new System.Drawing.Point(526, 5);
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
            this.metroSetLabel1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroSetLabel1.IsDerivedStyle = false;
            this.metroSetLabel1.Location = new System.Drawing.Point(21, 16);
            this.metroSetLabel1.Name = "metroSetLabel1";
            this.metroSetLabel1.Size = new System.Drawing.Size(67, 17);
            this.metroSetLabel1.Style = MetroSet_UI.Enums.Style.Custom;
            this.metroSetLabel1.StyleManager = null;
            this.metroSetLabel1.TabIndex = 1;
            this.metroSetLabel1.Text = "Category:";
            this.metroSetLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.metroSetLabel1.ThemeAuthor = null;
            this.metroSetLabel1.ThemeName = null;
            // 
            // metroSetLabel2
            // 
            this.metroSetLabel2.AutoSize = true;
            this.metroSetLabel2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroSetLabel2.IsDerivedStyle = false;
            this.metroSetLabel2.Location = new System.Drawing.Point(45, 50);
            this.metroSetLabel2.Name = "metroSetLabel2";
            this.metroSetLabel2.Size = new System.Drawing.Size(42, 17);
            this.metroSetLabel2.Style = MetroSet_UI.Enums.Style.Custom;
            this.metroSetLabel2.StyleManager = null;
            this.metroSetLabel2.TabIndex = 2;
            this.metroSetLabel2.Text = "Code:";
            this.metroSetLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.metroSetLabel2.ThemeAuthor = null;
            this.metroSetLabel2.ThemeName = null;
            // 
            // metroSetLabel3
            // 
            this.metroSetLabel3.AutoSize = true;
            this.metroSetLabel3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroSetLabel3.IsDerivedStyle = false;
            this.metroSetLabel3.Location = new System.Drawing.Point(8, 86);
            this.metroSetLabel3.Name = "metroSetLabel3";
            this.metroSetLabel3.Size = new System.Drawing.Size(79, 17);
            this.metroSetLabel3.Style = MetroSet_UI.Enums.Style.Custom;
            this.metroSetLabel3.StyleManager = null;
            this.metroSetLabel3.TabIndex = 3;
            this.metroSetLabel3.Text = "Description:";
            this.metroSetLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.metroSetLabel3.ThemeAuthor = null;
            this.metroSetLabel3.ThemeName = null;
            // 
            // metroSetLabel4
            // 
            this.metroSetLabel4.AutoSize = true;
            this.metroSetLabel4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroSetLabel4.IsDerivedStyle = false;
            this.metroSetLabel4.Location = new System.Drawing.Point(53, 123);
            this.metroSetLabel4.Name = "metroSetLabel4";
            this.metroSetLabel4.Size = new System.Drawing.Size(34, 17);
            this.metroSetLabel4.Style = MetroSet_UI.Enums.Style.Custom;
            this.metroSetLabel4.StyleManager = null;
            this.metroSetLabel4.TabIndex = 4;
            this.metroSetLabel4.Text = "Size:";
            this.metroSetLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.metroSetLabel4.ThemeAuthor = null;
            this.metroSetLabel4.ThemeName = null;
            // 
            // metroSetLabel5
            // 
            this.metroSetLabel5.AutoSize = true;
            this.metroSetLabel5.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroSetLabel5.IsDerivedStyle = false;
            this.metroSetLabel5.Location = new System.Drawing.Point(37, 159);
            this.metroSetLabel5.Name = "metroSetLabel5";
            this.metroSetLabel5.Size = new System.Drawing.Size(50, 17);
            this.metroSetLabel5.Style = MetroSet_UI.Enums.Style.Custom;
            this.metroSetLabel5.StyleManager = null;
            this.metroSetLabel5.TabIndex = 5;
            this.metroSetLabel5.Text = "Stocks:";
            this.metroSetLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.metroSetLabel5.ThemeAuthor = null;
            this.metroSetLabel5.ThemeName = null;
            // 
            // cmbCategory
            // 
            this.cmbCategory.AllowDrop = true;
            this.cmbCategory.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.cmbCategory.BackColor = System.Drawing.Color.Transparent;
            this.cmbCategory.BackgroundColor = System.Drawing.Color.Snow;
            this.cmbCategory.BorderColor = System.Drawing.Color.Black;
            this.cmbCategory.CausesValidation = false;
            this.cmbCategory.DisabledBackColor = System.Drawing.Color.White;
            this.cmbCategory.DisabledBorderColor = System.Drawing.Color.White;
            this.cmbCategory.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cmbCategory.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategory.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.IsDerivedStyle = false;
            this.cmbCategory.ItemHeight = 20;
            this.cmbCategory.Location = new System.Drawing.Point(97, 12);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.SelectedItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.cmbCategory.SelectedItemForeColor = System.Drawing.Color.White;
            this.cmbCategory.Size = new System.Drawing.Size(144, 26);
            this.cmbCategory.Style = MetroSet_UI.Enums.Style.Light;
            this.cmbCategory.StyleManager = null;
            this.cmbCategory.TabIndex = 0;
            this.cmbCategory.ThemeAuthor = null;
            this.cmbCategory.ThemeName = null;
            this.cmbCategory.SelectedIndexChanged += new System.EventHandler(this.cmbCategory_SelectedIndexChanged);
            this.cmbCategory.Validating += new System.ComponentModel.CancelEventHandler(this.cmbCategory_Validating);
            // 
            // txtCode
            // 
            this.txtCode.AutoCompleteCustomSource = null;
            this.txtCode.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtCode.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtCode.BorderColor = System.Drawing.Color.Black;
            this.txtCode.DisabledBackColor = System.Drawing.Color.White;
            this.txtCode.DisabledBorderColor = System.Drawing.Color.White;
            this.txtCode.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCode.Enabled = false;
            this.txtCode.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCode.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.txtCode.Image = null;
            this.txtCode.IsDerivedStyle = false;
            this.txtCode.Lines = null;
            this.txtCode.Location = new System.Drawing.Point(97, 45);
            this.txtCode.MaxLength = 32767;
            this.txtCode.Multiline = false;
            this.txtCode.Name = "txtCode";
            this.txtCode.ReadOnly = false;
            this.txtCode.Size = new System.Drawing.Size(144, 29);
            this.txtCode.Style = MetroSet_UI.Enums.Style.Light;
            this.txtCode.StyleManager = null;
            this.txtCode.TabIndex = 1;
            this.txtCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtCode.ThemeAuthor = null;
            this.txtCode.ThemeName = null;
            this.txtCode.UseSystemPasswordChar = false;
            this.txtCode.WatermarkText = "";
            // 
            // txtDescription
            // 
            this.txtDescription.AutoCompleteCustomSource = null;
            this.txtDescription.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtDescription.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtDescription.BorderColor = System.Drawing.Color.Black;
            this.txtDescription.DisabledBackColor = System.Drawing.Color.White;
            this.txtDescription.DisabledBorderColor = System.Drawing.Color.White;
            this.txtDescription.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtDescription.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.txtDescription.Image = null;
            this.txtDescription.IsDerivedStyle = false;
            this.txtDescription.Lines = null;
            this.txtDescription.Location = new System.Drawing.Point(97, 81);
            this.txtDescription.MaxLength = 255;
            this.txtDescription.Multiline = false;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.ReadOnly = false;
            this.txtDescription.Size = new System.Drawing.Size(523, 29);
            this.txtDescription.Style = MetroSet_UI.Enums.Style.Light;
            this.txtDescription.StyleManager = null;
            this.txtDescription.TabIndex = 2;
            this.txtDescription.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtDescription.ThemeAuthor = null;
            this.txtDescription.ThemeName = null;
            this.txtDescription.UseSystemPasswordChar = false;
            this.txtDescription.WatermarkText = "";
            this.txtDescription.Validating += new System.ComponentModel.CancelEventHandler(this.txtDescription_Validating);
            // 
            // txtSize
            // 
            this.txtSize.AutoCompleteCustomSource = null;
            this.txtSize.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtSize.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtSize.BorderColor = System.Drawing.Color.Black;
            this.txtSize.DisabledBackColor = System.Drawing.Color.White;
            this.txtSize.DisabledBorderColor = System.Drawing.Color.White;
            this.txtSize.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtSize.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSize.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.txtSize.Image = null;
            this.txtSize.IsDerivedStyle = false;
            this.txtSize.Lines = null;
            this.txtSize.Location = new System.Drawing.Point(97, 117);
            this.txtSize.MaxLength = 100;
            this.txtSize.Multiline = false;
            this.txtSize.Name = "txtSize";
            this.txtSize.ReadOnly = false;
            this.txtSize.Size = new System.Drawing.Size(171, 29);
            this.txtSize.Style = MetroSet_UI.Enums.Style.Light;
            this.txtSize.StyleManager = null;
            this.txtSize.TabIndex = 3;
            this.txtSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtSize.ThemeAuthor = null;
            this.txtSize.ThemeName = null;
            this.txtSize.UseSystemPasswordChar = false;
            this.txtSize.WatermarkText = "";
            this.txtSize.Validating += new System.ComponentModel.CancelEventHandler(this.txtSize_Validating);
            // 
            // txtQuantity
            // 
            this.txtQuantity.AutoCompleteCustomSource = null;
            this.txtQuantity.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtQuantity.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtQuantity.BorderColor = System.Drawing.Color.Black;
            this.txtQuantity.DisabledBackColor = System.Drawing.Color.White;
            this.txtQuantity.DisabledBorderColor = System.Drawing.Color.White;
            this.txtQuantity.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtQuantity.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantity.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.txtQuantity.Image = null;
            this.txtQuantity.IsDerivedStyle = false;
            this.txtQuantity.Lines = null;
            this.txtQuantity.Location = new System.Drawing.Point(97, 153);
            this.txtQuantity.MaxLength = 10;
            this.txtQuantity.Multiline = false;
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.ReadOnly = false;
            this.txtQuantity.Size = new System.Drawing.Size(171, 29);
            this.txtQuantity.Style = MetroSet_UI.Enums.Style.Light;
            this.txtQuantity.StyleManager = null;
            this.txtQuantity.TabIndex = 5;
            this.txtQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtQuantity.ThemeAuthor = null;
            this.txtQuantity.ThemeName = null;
            this.txtQuantity.UseSystemPasswordChar = false;
            this.txtQuantity.WatermarkText = "";
            this.txtQuantity.TextChanged += new System.EventHandler(this.txtQuantity_TextChanged);
            this.txtQuantity.Validating += new System.ComponentModel.CancelEventHandler(this.txtQuantity_Validating);
            // 
            // txtUnitPrice
            // 
            this.txtUnitPrice.AutoCompleteCustomSource = null;
            this.txtUnitPrice.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtUnitPrice.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtUnitPrice.BorderColor = System.Drawing.Color.Black;
            this.txtUnitPrice.DisabledBackColor = System.Drawing.Color.White;
            this.txtUnitPrice.DisabledBorderColor = System.Drawing.Color.White;
            this.txtUnitPrice.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtUnitPrice.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUnitPrice.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.txtUnitPrice.Image = null;
            this.txtUnitPrice.IsDerivedStyle = false;
            this.txtUnitPrice.Lines = null;
            this.txtUnitPrice.Location = new System.Drawing.Point(449, 115);
            this.txtUnitPrice.MaxLength = 10;
            this.txtUnitPrice.Multiline = false;
            this.txtUnitPrice.Name = "txtUnitPrice";
            this.txtUnitPrice.ReadOnly = false;
            this.txtUnitPrice.Size = new System.Drawing.Size(171, 29);
            this.txtUnitPrice.Style = MetroSet_UI.Enums.Style.Light;
            this.txtUnitPrice.StyleManager = null;
            this.txtUnitPrice.TabIndex = 4;
            this.txtUnitPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtUnitPrice.ThemeAuthor = null;
            this.txtUnitPrice.ThemeName = null;
            this.txtUnitPrice.UseSystemPasswordChar = false;
            this.txtUnitPrice.WatermarkText = "";
            this.txtUnitPrice.TextChanged += new System.EventHandler(this.txtUnitPrice_TextChanged);
            this.txtUnitPrice.Validating += new System.ComponentModel.CancelEventHandler(this.txtUnitPrice_Validating);
            // 
            // metroSetLabel6
            // 
            this.metroSetLabel6.AutoSize = true;
            this.metroSetLabel6.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroSetLabel6.IsDerivedStyle = false;
            this.metroSetLabel6.Location = new System.Drawing.Point(399, 121);
            this.metroSetLabel6.Name = "metroSetLabel6";
            this.metroSetLabel6.Size = new System.Drawing.Size(40, 17);
            this.metroSetLabel6.Style = MetroSet_UI.Enums.Style.Custom;
            this.metroSetLabel6.StyleManager = null;
            this.metroSetLabel6.TabIndex = 11;
            this.metroSetLabel6.Text = "Price:";
            this.metroSetLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.metroSetLabel6.ThemeAuthor = null;
            this.metroSetLabel6.ThemeName = null;
            // 
            // txtReProduceLevel
            // 
            this.txtReProduceLevel.AutoCompleteCustomSource = null;
            this.txtReProduceLevel.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtReProduceLevel.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtReProduceLevel.BorderColor = System.Drawing.Color.Black;
            this.txtReProduceLevel.DisabledBackColor = System.Drawing.Color.White;
            this.txtReProduceLevel.DisabledBorderColor = System.Drawing.Color.White;
            this.txtReProduceLevel.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtReProduceLevel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReProduceLevel.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.txtReProduceLevel.Image = null;
            this.txtReProduceLevel.IsDerivedStyle = false;
            this.txtReProduceLevel.Lines = null;
            this.txtReProduceLevel.Location = new System.Drawing.Point(449, 151);
            this.txtReProduceLevel.MaxLength = 10;
            this.txtReProduceLevel.Multiline = false;
            this.txtReProduceLevel.Name = "txtReProduceLevel";
            this.txtReProduceLevel.ReadOnly = false;
            this.txtReProduceLevel.Size = new System.Drawing.Size(171, 29);
            this.txtReProduceLevel.Style = MetroSet_UI.Enums.Style.Light;
            this.txtReProduceLevel.StyleManager = null;
            this.txtReProduceLevel.TabIndex = 6;
            this.txtReProduceLevel.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtReProduceLevel.ThemeAuthor = null;
            this.txtReProduceLevel.ThemeName = null;
            this.txtReProduceLevel.UseSystemPasswordChar = false;
            this.txtReProduceLevel.WatermarkText = "";
            this.txtReProduceLevel.TextChanged += new System.EventHandler(this.txtReProduceLevel_TextChanged);
            this.txtReProduceLevel.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtReProduceLevel_KeyDown);
            this.txtReProduceLevel.Validating += new System.ComponentModel.CancelEventHandler(this.txtReProduceLevel_Validating);
            // 
            // metroSetLabel7
            // 
            this.metroSetLabel7.AutoSize = true;
            this.metroSetLabel7.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroSetLabel7.IsDerivedStyle = false;
            this.metroSetLabel7.Location = new System.Drawing.Point(347, 157);
            this.metroSetLabel7.Name = "metroSetLabel7";
            this.metroSetLabel7.Size = new System.Drawing.Size(92, 17);
            this.metroSetLabel7.Style = MetroSet_UI.Enums.Style.Custom;
            this.metroSetLabel7.StyleManager = null;
            this.metroSetLabel7.TabIndex = 13;
            this.metroSetLabel7.Text = "Restock Level:";
            this.metroSetLabel7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.metroSetLabel7.ThemeAuthor = null;
            this.metroSetLabel7.ThemeName = null;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(536, 238);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(83, 26);
            this.btnSave.TabIndex = 14;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.ForeColor = System.Drawing.Color.White;
            this.lbTitle.Location = new System.Drawing.Point(6, 7);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(79, 21);
            this.lbTitle.TabIndex = 15;
            this.lbTitle.Text = "Add Item";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.lbTitle);
            this.panel1.Controls.Add(this.metroSetControlBox1);
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(633, 35);
            this.panel1.TabIndex = 19;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.Controls.Add(this.cmbCategory);
            this.panel2.Controls.Add(this.txtReProduceLevel);
            this.panel2.Controls.Add(this.metroSetLabel1);
            this.panel2.Controls.Add(this.metroSetLabel7);
            this.panel2.Controls.Add(this.metroSetLabel2);
            this.panel2.Controls.Add(this.txtUnitPrice);
            this.panel2.Controls.Add(this.metroSetLabel3);
            this.panel2.Controls.Add(this.metroSetLabel6);
            this.panel2.Controls.Add(this.metroSetLabel4);
            this.panel2.Controls.Add(this.txtQuantity);
            this.panel2.Controls.Add(this.metroSetLabel5);
            this.panel2.Controls.Add(this.txtSize);
            this.panel2.Controls.Add(this.txtCode);
            this.panel2.Controls.Add(this.txtDescription);
            this.panel2.Location = new System.Drawing.Point(-1, 40);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(634, 192);
            this.panel2.TabIndex = 20;
            // 
            // frmAddEditItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(630, 270);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAddEditItem";
            this.Padding = new System.Windows.Forms.Padding(10, 70, 10, 12);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Item Modal";
            this.Load += new System.EventHandler(this.frmAddEditItem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private MetroSet_UI.Controls.MetroSetControlBox metroSetControlBox1;
        private MetroSet_UI.Controls.MetroSetTextBox txtReProduceLevel;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel7;
        private MetroSet_UI.Controls.MetroSetTextBox txtUnitPrice;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel6;
        private MetroSet_UI.Controls.MetroSetTextBox txtQuantity;
        private MetroSet_UI.Controls.MetroSetTextBox txtSize;
        private MetroSet_UI.Controls.MetroSetTextBox txtDescription;
        private MetroSet_UI.Controls.MetroSetTextBox txtCode;
        private MetroSet_UI.Controls.MetroSetComboBox cmbCategory;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel5;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel4;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel3;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel2;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}