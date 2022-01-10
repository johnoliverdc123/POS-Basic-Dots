
namespace POSWinforms.Maintenance
{
    partial class frmPayment
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
            this.txtTotal = new MetroSet_UI.Controls.MetroSetTextBox();
            this.txtCash = new MetroSet_UI.Controls.MetroSetTextBox();
            this.txtChange = new MetroSet_UI.Controls.MetroSetTextBox();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtServiceFee = new MetroSet_UI.Controls.MetroSetTextBox();
            this.cmbService = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.epMoney = new System.Windows.Forms.ErrorProvider(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.txtServiceType = new MetroSet_UI.Controls.MetroSetTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.epMoney)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTotal
            // 
            this.txtTotal.AutoCompleteCustomSource = null;
            this.txtTotal.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtTotal.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtTotal.BorderColor = System.Drawing.Color.Sienna;
            this.txtTotal.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtTotal.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txtTotal.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.txtTotal.Enabled = false;
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtTotal.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.txtTotal.Image = null;
            this.txtTotal.IsDerivedStyle = false;
            this.txtTotal.Lines = null;
            this.txtTotal.Location = new System.Drawing.Point(185, 274);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(2);
            this.txtTotal.MaxLength = 32767;
            this.txtTotal.Multiline = false;
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = false;
            this.txtTotal.Size = new System.Drawing.Size(118, 30);
            this.txtTotal.Style = MetroSet_UI.Enums.Style.Light;
            this.txtTotal.StyleManager = null;
            this.txtTotal.TabIndex = 2;
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtTotal.ThemeAuthor = "Narwin";
            this.txtTotal.ThemeName = "MetroLite";
            this.txtTotal.UseSystemPasswordChar = false;
            this.txtTotal.WatermarkText = "";
            // 
            // txtCash
            // 
            this.txtCash.AutoCompleteCustomSource = null;
            this.txtCash.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtCash.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtCash.BorderColor = System.Drawing.Color.Sienna;
            this.txtCash.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtCash.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txtCash.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.txtCash.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtCash.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.txtCash.Image = null;
            this.txtCash.IsDerivedStyle = false;
            this.txtCash.Lines = null;
            this.txtCash.Location = new System.Drawing.Point(185, 313);
            this.txtCash.Margin = new System.Windows.Forms.Padding(2);
            this.txtCash.MaxLength = 10;
            this.txtCash.Multiline = false;
            this.txtCash.Name = "txtCash";
            this.txtCash.ReadOnly = false;
            this.txtCash.Size = new System.Drawing.Size(118, 30);
            this.txtCash.Style = MetroSet_UI.Enums.Style.Light;
            this.txtCash.StyleManager = null;
            this.txtCash.TabIndex = 3;
            this.txtCash.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCash.ThemeAuthor = "Narwin";
            this.txtCash.ThemeName = "MetroLite";
            this.txtCash.UseSystemPasswordChar = false;
            this.txtCash.WatermarkText = "";
            this.txtCash.TextChanged += new System.EventHandler(this.txtCash_TextChanged);
            this.txtCash.Validating += new System.ComponentModel.CancelEventHandler(this.txtCash_Validating);
            // 
            // txtChange
            // 
            this.txtChange.AutoCompleteCustomSource = null;
            this.txtChange.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtChange.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtChange.BorderColor = System.Drawing.Color.Sienna;
            this.txtChange.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtChange.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txtChange.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.txtChange.Enabled = false;
            this.txtChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtChange.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.txtChange.Image = null;
            this.txtChange.IsDerivedStyle = false;
            this.txtChange.Lines = null;
            this.txtChange.Location = new System.Drawing.Point(185, 352);
            this.txtChange.Margin = new System.Windows.Forms.Padding(2);
            this.txtChange.MaxLength = 32767;
            this.txtChange.Multiline = false;
            this.txtChange.Name = "txtChange";
            this.txtChange.ReadOnly = false;
            this.txtChange.Size = new System.Drawing.Size(118, 30);
            this.txtChange.Style = MetroSet_UI.Enums.Style.Light;
            this.txtChange.StyleManager = null;
            this.txtChange.TabIndex = 4;
            this.txtChange.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtChange.ThemeAuthor = "Narwin";
            this.txtChange.ThemeName = "MetroLite";
            this.txtChange.UseSystemPasswordChar = false;
            this.txtChange.WatermarkText = "";
            // 
            // btnConfirm
            // 
            this.btnConfirm.BackColor = System.Drawing.Color.MistyRose;
            this.btnConfirm.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirm.ForeColor = System.Drawing.Color.Maroon;
            this.btnConfirm.Location = new System.Drawing.Point(145, 405);
            this.btnConfirm.Margin = new System.Windows.Forms.Padding(2);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(78, 34);
            this.btnConfirm.TabIndex = 5;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = false;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.MistyRose;
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.Maroon;
            this.btnCancel.Location = new System.Drawing.Point(227, 405);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(76, 34);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(62, 283);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 21);
            this.label1.TabIndex = 113;
            this.label1.Text = "Total Amount:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(130, 322);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 21);
            this.label2.TabIndex = 113;
            this.label2.Text = "Cash:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(108, 361);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 21);
            this.label3.TabIndex = 113;
            this.label3.Text = "Change:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(62, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 21);
            this.label4.TabIndex = 114;
            this.label4.Text = "Have Service:";
            // 
            // txtServiceFee
            // 
            this.txtServiceFee.AutoCompleteCustomSource = null;
            this.txtServiceFee.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtServiceFee.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtServiceFee.BorderColor = System.Drawing.Color.Sienna;
            this.txtServiceFee.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtServiceFee.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txtServiceFee.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.txtServiceFee.Enabled = false;
            this.txtServiceFee.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtServiceFee.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.txtServiceFee.Image = null;
            this.txtServiceFee.IsDerivedStyle = false;
            this.txtServiceFee.Lines = null;
            this.txtServiceFee.Location = new System.Drawing.Point(185, 108);
            this.txtServiceFee.Margin = new System.Windows.Forms.Padding(2);
            this.txtServiceFee.MaxLength = 32767;
            this.txtServiceFee.Multiline = false;
            this.txtServiceFee.Name = "txtServiceFee";
            this.txtServiceFee.ReadOnly = false;
            this.txtServiceFee.Size = new System.Drawing.Size(118, 30);
            this.txtServiceFee.Style = MetroSet_UI.Enums.Style.Light;
            this.txtServiceFee.StyleManager = null;
            this.txtServiceFee.TabIndex = 1;
            this.txtServiceFee.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtServiceFee.ThemeAuthor = "Narwin";
            this.txtServiceFee.ThemeName = "MetroLite";
            this.txtServiceFee.UseSystemPasswordChar = false;
            this.txtServiceFee.WatermarkText = "";
            this.txtServiceFee.TextChanged += new System.EventHandler(this.txtServiceFee_TextChanged);
            this.txtServiceFee.Validating += new System.ComponentModel.CancelEventHandler(this.txtServiceFee_Validating);
            // 
            // cmbService
            // 
            this.cmbService.FormattingEnabled = true;
            this.cmbService.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.cmbService.Location = new System.Drawing.Point(182, 66);
            this.cmbService.Name = "cmbService";
            this.cmbService.Size = new System.Drawing.Size(121, 21);
            this.cmbService.TabIndex = 0;
            this.cmbService.SelectedIndexChanged += new System.EventHandler(this.cmbService_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(75, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 21);
            this.label5.TabIndex = 117;
            this.label5.Text = "Service Fee:";
            // 
            // epMoney
            // 
            this.epMoney.ContainerControl = this;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(65, 151);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 21);
            this.label6.TabIndex = 119;
            this.label6.Text = "Service Type:";
            // 
            // txtServiceType
            // 
            this.txtServiceType.AutoCompleteCustomSource = null;
            this.txtServiceType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtServiceType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtServiceType.BorderColor = System.Drawing.Color.Sienna;
            this.txtServiceType.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtServiceType.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txtServiceType.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.txtServiceType.Enabled = false;
            this.txtServiceType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtServiceType.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.txtServiceType.Image = null;
            this.txtServiceType.IsDerivedStyle = false;
            this.txtServiceType.Lines = null;
            this.txtServiceType.Location = new System.Drawing.Point(185, 142);
            this.txtServiceType.Margin = new System.Windows.Forms.Padding(2);
            this.txtServiceType.MaxLength = 143;
            this.txtServiceType.Multiline = true;
            this.txtServiceType.Name = "txtServiceType";
            this.txtServiceType.ReadOnly = false;
            this.txtServiceType.Size = new System.Drawing.Size(204, 97);
            this.txtServiceType.Style = MetroSet_UI.Enums.Style.Light;
            this.txtServiceType.StyleManager = null;
            this.txtServiceType.TabIndex = 118;
            this.txtServiceType.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtServiceType.ThemeAuthor = "Narwin";
            this.txtServiceType.ThemeName = "MetroLite";
            this.txtServiceType.UseSystemPasswordChar = false;
            this.txtServiceType.WatermarkText = "";
            // 
            // frmPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(400, 449);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtServiceType);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbService);
            this.Controls.Add(this.txtServiceFee);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.txtChange);
            this.Controls.Add(this.txtCash);
            this.Controls.Add(this.txtTotal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(325, 279);
            this.Name = "frmPayment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Payment";
            ((System.ComponentModel.ISupportInitialize)(this.epMoney)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroSet_UI.Controls.MetroSetTextBox txtTotal;
        private MetroSet_UI.Controls.MetroSetTextBox txtCash;
        private MetroSet_UI.Controls.MetroSetTextBox txtChange;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private MetroSet_UI.Controls.MetroSetTextBox txtServiceFee;
        private System.Windows.Forms.ComboBox cmbService;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ErrorProvider epMoney;
        private System.Windows.Forms.Label label6;
        private MetroSet_UI.Controls.MetroSetTextBox txtServiceType;
    }
}