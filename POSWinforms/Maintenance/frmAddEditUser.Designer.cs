
namespace POSWinforms.Maintenance
{
    partial class frmAddEditUser
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
            this.metroSetLabel1 = new System.Windows.Forms.Label();
            this.metroSetLabel2 = new System.Windows.Forms.Label();
            this.metroSetLabel3 = new System.Windows.Forms.Label();
            this.metroSetLabel4 = new System.Windows.Forms.Label();
            this.txtStaffID = new MetroSet_UI.Controls.MetroSetTextBox();
            this.txtFirstName = new MetroSet_UI.Controls.MetroSetTextBox();
            this.txtMI = new MetroSet_UI.Controls.MetroSetTextBox();
            this.metroSetLabel5 = new System.Windows.Forms.Label();
            this.metroSetLabel6 = new System.Windows.Forms.Label();
            this.metroSetLabel7 = new System.Windows.Forms.Label();
            this.txtUsername = new MetroSet_UI.Controls.MetroSetTextBox();
            this.txtPassword = new MetroSet_UI.Controls.MetroSetTextBox();
            this.txtLastName = new MetroSet_UI.Controls.MetroSetTextBox();
            this.metroSetLabel8 = new System.Windows.Forms.Label();
            this.txtContactNo = new MetroSet_UI.Controls.MetroSetTextBox();
            this.metroSetLabel9 = new System.Windows.Forms.Label();
            this.metroSetLabel10 = new System.Windows.Forms.Label();
            this.cmbPositions = new MetroSet_UI.Controls.MetroSetComboBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtAddress = new MetroSet_UI.Controls.MetroSetTextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lbTitle = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cbShowPassword = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroSetLabel1
            // 
            this.metroSetLabel1.AutoSize = true;
            this.metroSetLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.metroSetLabel1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroSetLabel1.ForeColor = System.Drawing.Color.White;
            this.metroSetLabel1.Location = new System.Drawing.Point(32, 22);
            this.metroSetLabel1.Name = "metroSetLabel1";
            this.metroSetLabel1.Size = new System.Drawing.Size(52, 17);
            this.metroSetLabel1.TabIndex = 1;
            this.metroSetLabel1.Text = "Staff ID";
            this.metroSetLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // metroSetLabel2
            // 
            this.metroSetLabel2.AutoSize = true;
            this.metroSetLabel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.metroSetLabel2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroSetLabel2.ForeColor = System.Drawing.Color.White;
            this.metroSetLabel2.Location = new System.Drawing.Point(15, 58);
            this.metroSetLabel2.Name = "metroSetLabel2";
            this.metroSetLabel2.Size = new System.Drawing.Size(69, 17);
            this.metroSetLabel2.TabIndex = 1;
            this.metroSetLabel2.Text = "Username";
            this.metroSetLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // metroSetLabel3
            // 
            this.metroSetLabel3.AutoSize = true;
            this.metroSetLabel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.metroSetLabel3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroSetLabel3.ForeColor = System.Drawing.Color.White;
            this.metroSetLabel3.Location = new System.Drawing.Point(18, 94);
            this.metroSetLabel3.Name = "metroSetLabel3";
            this.metroSetLabel3.Size = new System.Drawing.Size(66, 17);
            this.metroSetLabel3.TabIndex = 1;
            this.metroSetLabel3.Text = "Password";
            this.metroSetLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // metroSetLabel4
            // 
            this.metroSetLabel4.AutoSize = true;
            this.metroSetLabel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.metroSetLabel4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroSetLabel4.ForeColor = System.Drawing.Color.White;
            this.metroSetLabel4.Location = new System.Drawing.Point(42, 44);
            this.metroSetLabel4.Name = "metroSetLabel4";
            this.metroSetLabel4.Size = new System.Drawing.Size(44, 17);
            this.metroSetLabel4.TabIndex = 1;
            this.metroSetLabel4.Text = "Name";
            this.metroSetLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtStaffID
            // 
            this.txtStaffID.AutoCompleteCustomSource = null;
            this.txtStaffID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtStaffID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtStaffID.BorderColor = System.Drawing.Color.Black;
            this.txtStaffID.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtStaffID.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txtStaffID.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.txtStaffID.Enabled = false;
            this.txtStaffID.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStaffID.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.txtStaffID.Image = null;
            this.txtStaffID.IsDerivedStyle = false;
            this.txtStaffID.Lines = null;
            this.txtStaffID.Location = new System.Drawing.Point(94, 13);
            this.txtStaffID.MaxLength = 32767;
            this.txtStaffID.Multiline = false;
            this.txtStaffID.Name = "txtStaffID";
            this.txtStaffID.ReadOnly = false;
            this.txtStaffID.Size = new System.Drawing.Size(103, 29);
            this.txtStaffID.Style = MetroSet_UI.Enums.Style.Light;
            this.txtStaffID.StyleManager = null;
            this.txtStaffID.TabIndex = 0;
            this.txtStaffID.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtStaffID.ThemeAuthor = "Narwin";
            this.txtStaffID.ThemeName = "MetroLight";
            this.txtStaffID.UseSystemPasswordChar = false;
            this.txtStaffID.WatermarkText = "";
            // 
            // txtFirstName
            // 
            this.txtFirstName.AutoCompleteCustomSource = null;
            this.txtFirstName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtFirstName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtFirstName.BorderColor = System.Drawing.Color.Black;
            this.txtFirstName.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtFirstName.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txtFirstName.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.txtFirstName.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstName.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.txtFirstName.Image = null;
            this.txtFirstName.IsDerivedStyle = false;
            this.txtFirstName.Lines = null;
            this.txtFirstName.Location = new System.Drawing.Point(316, 35);
            this.txtFirstName.MaxLength = 55;
            this.txtFirstName.Multiline = false;
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.ReadOnly = false;
            this.txtFirstName.Size = new System.Drawing.Size(188, 29);
            this.txtFirstName.Style = MetroSet_UI.Enums.Style.Light;
            this.txtFirstName.StyleManager = null;
            this.txtFirstName.TabIndex = 3;
            this.txtFirstName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtFirstName.ThemeAuthor = "Narwin";
            this.txtFirstName.ThemeName = "MetroLight";
            this.txtFirstName.UseSystemPasswordChar = false;
            this.txtFirstName.WatermarkText = "";
            this.txtFirstName.TextChanged += new System.EventHandler(this.txtFirstName_TextChanged);
            this.txtFirstName.Validating += new System.ComponentModel.CancelEventHandler(this.txtFirstName_Validating);
            // 
            // txtMI
            // 
            this.txtMI.AutoCompleteCustomSource = null;
            this.txtMI.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtMI.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtMI.BorderColor = System.Drawing.Color.Black;
            this.txtMI.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtMI.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txtMI.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.txtMI.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMI.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.txtMI.Image = null;
            this.txtMI.IsDerivedStyle = false;
            this.txtMI.Lines = null;
            this.txtMI.Location = new System.Drawing.Point(546, 35);
            this.txtMI.MaxLength = 5;
            this.txtMI.Multiline = false;
            this.txtMI.Name = "txtMI";
            this.txtMI.ReadOnly = false;
            this.txtMI.Size = new System.Drawing.Size(95, 29);
            this.txtMI.Style = MetroSet_UI.Enums.Style.Light;
            this.txtMI.StyleManager = null;
            this.txtMI.TabIndex = 4;
            this.txtMI.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtMI.ThemeAuthor = "Narwin";
            this.txtMI.ThemeName = "MetroLight";
            this.txtMI.UseSystemPasswordChar = false;
            this.txtMI.WatermarkText = "";
            this.txtMI.TextChanged += new System.EventHandler(this.txtMI_TextChanged);
            this.txtMI.Validating += new System.ComponentModel.CancelEventHandler(this.txtMI_Validating);
            // 
            // metroSetLabel5
            // 
            this.metroSetLabel5.AutoSize = true;
            this.metroSetLabel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.metroSetLabel5.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroSetLabel5.ForeColor = System.Drawing.Color.White;
            this.metroSetLabel5.Location = new System.Drawing.Point(99, 12);
            this.metroSetLabel5.Name = "metroSetLabel5";
            this.metroSetLabel5.Size = new System.Drawing.Size(70, 17);
            this.metroSetLabel5.TabIndex = 1;
            this.metroSetLabel5.Text = "Last name";
            // 
            // metroSetLabel6
            // 
            this.metroSetLabel6.AutoSize = true;
            this.metroSetLabel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.metroSetLabel6.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroSetLabel6.ForeColor = System.Drawing.Color.White;
            this.metroSetLabel6.Location = new System.Drawing.Point(319, 12);
            this.metroSetLabel6.Name = "metroSetLabel6";
            this.metroSetLabel6.Size = new System.Drawing.Size(72, 17);
            this.metroSetLabel6.TabIndex = 1;
            this.metroSetLabel6.Text = "First name";
            // 
            // metroSetLabel7
            // 
            this.metroSetLabel7.AutoSize = true;
            this.metroSetLabel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.metroSetLabel7.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroSetLabel7.ForeColor = System.Drawing.Color.White;
            this.metroSetLabel7.Location = new System.Drawing.Point(549, 12);
            this.metroSetLabel7.Name = "metroSetLabel7";
            this.metroSetLabel7.Size = new System.Drawing.Size(24, 17);
            this.metroSetLabel7.TabIndex = 1;
            this.metroSetLabel7.Text = "MI";
            // 
            // txtUsername
            // 
            this.txtUsername.AutoCompleteCustomSource = null;
            this.txtUsername.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtUsername.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtUsername.BorderColor = System.Drawing.Color.Black;
            this.txtUsername.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtUsername.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txtUsername.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.txtUsername.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.txtUsername.Image = null;
            this.txtUsername.IsDerivedStyle = false;
            this.txtUsername.Lines = null;
            this.txtUsername.Location = new System.Drawing.Point(94, 49);
            this.txtUsername.MaxLength = 20;
            this.txtUsername.Multiline = false;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.ReadOnly = false;
            this.txtUsername.Size = new System.Drawing.Size(188, 29);
            this.txtUsername.Style = MetroSet_UI.Enums.Style.Light;
            this.txtUsername.StyleManager = null;
            this.txtUsername.TabIndex = 0;
            this.txtUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtUsername.ThemeAuthor = "Narwin";
            this.txtUsername.ThemeName = "MetroLight";
            this.txtUsername.UseSystemPasswordChar = false;
            this.txtUsername.WatermarkText = "";
            this.txtUsername.Validating += new System.ComponentModel.CancelEventHandler(this.txtUsername_Validating);
            // 
            // txtPassword
            // 
            this.txtPassword.AutoCompleteCustomSource = null;
            this.txtPassword.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtPassword.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtPassword.BorderColor = System.Drawing.Color.Black;
            this.txtPassword.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtPassword.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txtPassword.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.txtPassword.Image = null;
            this.txtPassword.IsDerivedStyle = false;
            this.txtPassword.Lines = null;
            this.txtPassword.Location = new System.Drawing.Point(94, 85);
            this.txtPassword.MaxLength = 20;
            this.txtPassword.Multiline = false;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.ReadOnly = false;
            this.txtPassword.Size = new System.Drawing.Size(188, 29);
            this.txtPassword.Style = MetroSet_UI.Enums.Style.Light;
            this.txtPassword.StyleManager = null;
            this.txtPassword.TabIndex = 1;
            this.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtPassword.ThemeAuthor = "Narwin";
            this.txtPassword.ThemeName = "MetroLight";
            this.txtPassword.UseSystemPasswordChar = true;
            this.txtPassword.WatermarkText = "";
            this.txtPassword.Validating += new System.ComponentModel.CancelEventHandler(this.txtPassword_Validating);
            // 
            // txtLastName
            // 
            this.txtLastName.AutoCompleteCustomSource = null;
            this.txtLastName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtLastName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtLastName.BorderColor = System.Drawing.Color.Black;
            this.txtLastName.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtLastName.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txtLastName.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.txtLastName.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastName.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.txtLastName.Image = null;
            this.txtLastName.IsDerivedStyle = false;
            this.txtLastName.Lines = null;
            this.txtLastName.Location = new System.Drawing.Point(96, 35);
            this.txtLastName.MaxLength = 55;
            this.txtLastName.Multiline = false;
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.ReadOnly = false;
            this.txtLastName.Size = new System.Drawing.Size(188, 29);
            this.txtLastName.Style = MetroSet_UI.Enums.Style.Light;
            this.txtLastName.StyleManager = null;
            this.txtLastName.TabIndex = 2;
            this.txtLastName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtLastName.ThemeAuthor = "Narwin";
            this.txtLastName.ThemeName = "MetroLight";
            this.txtLastName.UseSystemPasswordChar = false;
            this.txtLastName.WatermarkText = "";
            this.txtLastName.TextChanged += new System.EventHandler(this.txtLastName_TextChanged);
            this.txtLastName.Validating += new System.ComponentModel.CancelEventHandler(this.txtLastName_Validating);
            // 
            // metroSetLabel8
            // 
            this.metroSetLabel8.AutoSize = true;
            this.metroSetLabel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.metroSetLabel8.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroSetLabel8.ForeColor = System.Drawing.Color.White;
            this.metroSetLabel8.Location = new System.Drawing.Point(29, 75);
            this.metroSetLabel8.Name = "metroSetLabel8";
            this.metroSetLabel8.Size = new System.Drawing.Size(57, 17);
            this.metroSetLabel8.TabIndex = 5;
            this.metroSetLabel8.Text = "Address";
            this.metroSetLabel8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtContactNo
            // 
            this.txtContactNo.AutoCompleteCustomSource = null;
            this.txtContactNo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtContactNo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtContactNo.BorderColor = System.Drawing.Color.Black;
            this.txtContactNo.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtContactNo.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txtContactNo.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.txtContactNo.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContactNo.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.txtContactNo.Image = null;
            this.txtContactNo.IsDerivedStyle = false;
            this.txtContactNo.Lines = null;
            this.txtContactNo.Location = new System.Drawing.Point(96, 142);
            this.txtContactNo.MaxLength = 15;
            this.txtContactNo.Multiline = false;
            this.txtContactNo.Name = "txtContactNo";
            this.txtContactNo.ReadOnly = false;
            this.txtContactNo.Size = new System.Drawing.Size(188, 29);
            this.txtContactNo.Style = MetroSet_UI.Enums.Style.Light;
            this.txtContactNo.StyleManager = null;
            this.txtContactNo.TabIndex = 6;
            this.txtContactNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtContactNo.ThemeAuthor = "Narwin";
            this.txtContactNo.ThemeName = "MetroLight";
            this.txtContactNo.UseSystemPasswordChar = false;
            this.txtContactNo.WatermarkText = "";
            this.txtContactNo.TextChanged += new System.EventHandler(this.txtContactNo_TextChanged);
            this.txtContactNo.Validating += new System.ComponentModel.CancelEventHandler(this.txtContactNo_Validating);
            // 
            // metroSetLabel9
            // 
            this.metroSetLabel9.AutoSize = true;
            this.metroSetLabel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.metroSetLabel9.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroSetLabel9.ForeColor = System.Drawing.Color.White;
            this.metroSetLabel9.Location = new System.Drawing.Point(6, 151);
            this.metroSetLabel9.Name = "metroSetLabel9";
            this.metroSetLabel9.Size = new System.Drawing.Size(80, 17);
            this.metroSetLabel9.TabIndex = 7;
            this.metroSetLabel9.Text = "Contact No.";
            this.metroSetLabel9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // metroSetLabel10
            // 
            this.metroSetLabel10.AutoSize = true;
            this.metroSetLabel10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.metroSetLabel10.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroSetLabel10.ForeColor = System.Drawing.Color.White;
            this.metroSetLabel10.Location = new System.Drawing.Point(29, 182);
            this.metroSetLabel10.Name = "metroSetLabel10";
            this.metroSetLabel10.Size = new System.Drawing.Size(57, 17);
            this.metroSetLabel10.TabIndex = 9;
            this.metroSetLabel10.Text = "Position";
            this.metroSetLabel10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmbPositions
            // 
            this.cmbPositions.AllowDrop = true;
            this.cmbPositions.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.cmbPositions.BackColor = System.Drawing.Color.Transparent;
            this.cmbPositions.BackgroundColor = System.Drawing.Color.Snow;
            this.cmbPositions.BorderColor = System.Drawing.Color.Black;
            this.cmbPositions.CausesValidation = false;
            this.cmbPositions.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.cmbPositions.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.cmbPositions.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.cmbPositions.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbPositions.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPositions.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPositions.FormattingEnabled = true;
            this.cmbPositions.IsDerivedStyle = false;
            this.cmbPositions.ItemHeight = 20;
            this.cmbPositions.Location = new System.Drawing.Point(96, 177);
            this.cmbPositions.Name = "cmbPositions";
            this.cmbPositions.SelectedItemBackColor = System.Drawing.Color.DodgerBlue;
            this.cmbPositions.SelectedItemForeColor = System.Drawing.Color.White;
            this.cmbPositions.Size = new System.Drawing.Size(188, 26);
            this.cmbPositions.Style = MetroSet_UI.Enums.Style.Light;
            this.cmbPositions.StyleManager = null;
            this.cmbPositions.TabIndex = 7;
            this.cmbPositions.ThemeAuthor = "Narwin";
            this.cmbPositions.ThemeName = "MetroLight";
            this.cmbPositions.Validating += new System.ComponentModel.CancelEventHandler(this.cmbPositions_Validating);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // txtAddress
            // 
            this.txtAddress.AutoCompleteCustomSource = null;
            this.txtAddress.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtAddress.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtAddress.BorderColor = System.Drawing.Color.Black;
            this.txtAddress.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtAddress.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txtAddress.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.txtAddress.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.txtAddress.Image = null;
            this.txtAddress.IsDerivedStyle = false;
            this.txtAddress.Lines = null;
            this.txtAddress.Location = new System.Drawing.Point(96, 71);
            this.txtAddress.MaxLength = 255;
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.ReadOnly = false;
            this.txtAddress.Size = new System.Drawing.Size(545, 65);
            this.txtAddress.Style = MetroSet_UI.Enums.Style.Light;
            this.txtAddress.StyleManager = null;
            this.txtAddress.TabIndex = 5;
            this.txtAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtAddress.ThemeAuthor = "Narwin";
            this.txtAddress.ThemeName = "MetroLight";
            this.txtAddress.UseSystemPasswordChar = false;
            this.txtAddress.WatermarkText = "";
            this.txtAddress.Validating += new System.ComponentModel.CancelEventHandler(this.txtAddress_Validating);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(449, 391);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(92, 40);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(547, 391);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(93, 40);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.ForeColor = System.Drawing.Color.White;
            this.lbTitle.Location = new System.Drawing.Point(8, 7);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(78, 21);
            this.lbTitle.TabIndex = 17;
            this.lbTitle.Text = "Add User";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.lbTitle);
            this.panel1.Location = new System.Drawing.Point(-3, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(654, 35);
            this.panel1.TabIndex = 18;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.Controls.Add(this.cbShowPassword);
            this.panel2.Controls.Add(this.txtStaffID);
            this.panel2.Controls.Add(this.metroSetLabel1);
            this.panel2.Controls.Add(this.metroSetLabel2);
            this.panel2.Controls.Add(this.metroSetLabel3);
            this.panel2.Controls.Add(this.txtUsername);
            this.panel2.Controls.Add(this.txtPassword);
            this.panel2.Location = new System.Drawing.Point(-2, 39);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(718, 125);
            this.panel2.TabIndex = 19;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel3.Controls.Add(this.metroSetLabel5);
            this.panel3.Controls.Add(this.metroSetLabel4);
            this.panel3.Controls.Add(this.metroSetLabel6);
            this.panel3.Controls.Add(this.txtAddress);
            this.panel3.Controls.Add(this.metroSetLabel7);
            this.panel3.Controls.Add(this.cmbPositions);
            this.panel3.Controls.Add(this.txtFirstName);
            this.panel3.Controls.Add(this.metroSetLabel10);
            this.panel3.Controls.Add(this.txtMI);
            this.panel3.Controls.Add(this.txtContactNo);
            this.panel3.Controls.Add(this.txtLastName);
            this.panel3.Controls.Add(this.metroSetLabel9);
            this.panel3.Controls.Add(this.metroSetLabel8);
            this.panel3.Location = new System.Drawing.Point(-2, 169);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(718, 216);
            this.panel3.TabIndex = 20;
            // 
            // cbShowPassword
            // 
            this.cbShowPassword.AutoSize = true;
            this.cbShowPassword.Location = new System.Drawing.Point(288, 87);
            this.cbShowPassword.Name = "cbShowPassword";
            this.cbShowPassword.Size = new System.Drawing.Size(141, 24);
            this.cbShowPassword.TabIndex = 2;
            this.cbShowPassword.Text = "Show Password";
            this.cbShowPassword.UseVisualStyleBackColor = true;
            this.cbShowPassword.CheckedChanged += new System.EventHandler(this.cbShowPassword_CheckedChanged);
            // 
            // frmAddEditUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(650, 441);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAddEditUser";
            this.Padding = new System.Windows.Forms.Padding(11, 70, 11, 12);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User Modal";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmAddEditUser_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private MetroSet_UI.Controls.MetroSetComboBox cmbPositions;
        private MetroSet_UI.Controls.MetroSetTextBox txtContactNo;
        private MetroSet_UI.Controls.MetroSetTextBox txtLastName;
        private MetroSet_UI.Controls.MetroSetTextBox txtPassword;
        private MetroSet_UI.Controls.MetroSetTextBox txtMI;
        private MetroSet_UI.Controls.MetroSetTextBox txtFirstName;
        private MetroSet_UI.Controls.MetroSetTextBox txtUsername;
        private MetroSet_UI.Controls.MetroSetTextBox txtStaffID;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private MetroSet_UI.Controls.MetroSetTextBox txtAddress;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label metroSetLabel10;
        private System.Windows.Forms.Label metroSetLabel9;
        private System.Windows.Forms.Label metroSetLabel8;
        private System.Windows.Forms.Label metroSetLabel7;
        private System.Windows.Forms.Label metroSetLabel6;
        private System.Windows.Forms.Label metroSetLabel5;
        private System.Windows.Forms.Label metroSetLabel4;
        private System.Windows.Forms.Label metroSetLabel3;
        private System.Windows.Forms.Label metroSetLabel2;
        private System.Windows.Forms.Label metroSetLabel1;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.CheckBox cbShowPassword;
    }
}