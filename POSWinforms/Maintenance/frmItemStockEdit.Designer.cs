
namespace POSWinforms.Maintenance
{
    partial class frmItemStockEdit
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
            this.txtQuantity = new MetroSet_UI.Controls.MetroSetTextBox();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSupplierInformation = new MetroSet_UI.Controls.MetroSetTextBox();
            this.SuspendLayout();
            // 
            // txtQuantity
            // 
            this.txtQuantity.AutoCompleteCustomSource = null;
            this.txtQuantity.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtQuantity.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtQuantity.BorderColor = System.Drawing.Color.Sienna;
            this.txtQuantity.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtQuantity.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txtQuantity.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.txtQuantity.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantity.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.txtQuantity.Image = null;
            this.txtQuantity.IsDerivedStyle = false;
            this.txtQuantity.Lines = null;
            this.txtQuantity.Location = new System.Drawing.Point(18, 93);
            this.txtQuantity.Margin = new System.Windows.Forms.Padding(2);
            this.txtQuantity.MaxLength = 32767;
            this.txtQuantity.Multiline = false;
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.ReadOnly = false;
            this.txtQuantity.Size = new System.Drawing.Size(289, 30);
            this.txtQuantity.Style = MetroSet_UI.Enums.Style.Light;
            this.txtQuantity.StyleManager = null;
            this.txtQuantity.TabIndex = 1;
            this.txtQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtQuantity.ThemeAuthor = "Narwin";
            this.txtQuantity.ThemeName = "MetroLite";
            this.txtQuantity.UseSystemPasswordChar = false;
            this.txtQuantity.WatermarkText = "";
            // 
            // btnConfirm
            // 
            this.btnConfirm.BackColor = System.Drawing.Color.MistyRose;
            this.btnConfirm.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirm.ForeColor = System.Drawing.Color.Maroon;
            this.btnConfirm.Location = new System.Drawing.Point(147, 262);
            this.btnConfirm.Margin = new System.Windows.Forms.Padding(2);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(74, 33);
            this.btnConfirm.TabIndex = 107;
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
            this.btnCancel.Location = new System.Drawing.Point(226, 262);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(81, 33);
            this.btnCancel.TabIndex = 108;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(292, 21);
            this.label1.TabIndex = 109;
            this.label1.Text = "How many stocks would you like to add?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(243, 21);
            this.label2.TabIndex = 110;
            this.label2.Text = "Enter Supplier Information below:";
            // 
            // txtSupplierInformation
            // 
            this.txtSupplierInformation.AutoCompleteCustomSource = null;
            this.txtSupplierInformation.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtSupplierInformation.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtSupplierInformation.BorderColor = System.Drawing.Color.Sienna;
            this.txtSupplierInformation.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtSupplierInformation.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txtSupplierInformation.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.txtSupplierInformation.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSupplierInformation.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.txtSupplierInformation.Image = null;
            this.txtSupplierInformation.IsDerivedStyle = false;
            this.txtSupplierInformation.Lines = null;
            this.txtSupplierInformation.Location = new System.Drawing.Point(19, 169);
            this.txtSupplierInformation.Margin = new System.Windows.Forms.Padding(2);
            this.txtSupplierInformation.MaxLength = 32767;
            this.txtSupplierInformation.Multiline = false;
            this.txtSupplierInformation.Name = "txtSupplierInformation";
            this.txtSupplierInformation.ReadOnly = false;
            this.txtSupplierInformation.Size = new System.Drawing.Size(289, 30);
            this.txtSupplierInformation.Style = MetroSet_UI.Enums.Style.Light;
            this.txtSupplierInformation.StyleManager = null;
            this.txtSupplierInformation.TabIndex = 111;
            this.txtSupplierInformation.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtSupplierInformation.ThemeAuthor = "Narwin";
            this.txtSupplierInformation.ThemeName = "MetroLite";
            this.txtSupplierInformation.UseSystemPasswordChar = false;
            this.txtSupplierInformation.WatermarkText = "";
            // 
            // frmItemStockEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(326, 306);
            this.Controls.Add(this.txtSupplierInformation);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.txtQuantity);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmItemStockEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stock In";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroSet_UI.Controls.MetroSetTextBox txtQuantity;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private MetroSet_UI.Controls.MetroSetTextBox txtSupplierInformation;
    }
}