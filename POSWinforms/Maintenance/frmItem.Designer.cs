
namespace POSWinforms.Maintenance
{
    partial class frmItem
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
            this.txtSearch = new MetroSet_UI.Controls.MetroSetTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.metroSetControlBox1 = new MetroSet_UI.Controls.MetroSetControlBox();
            this.dgvItems = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnStockIn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbSearchFilter = new System.Windows.Forms.ComboBox();
            this.btnActivateDeactivate = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.columnItemNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStocks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIsActive = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSold = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRestockLvl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtSearch
            // 
            this.txtSearch.AutoCompleteCustomSource = null;
            this.txtSearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtSearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtSearch.BorderColor = System.Drawing.Color.Black;
            this.txtSearch.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtSearch.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txtSearch.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.txtSearch.Image = null;
            this.txtSearch.IsDerivedStyle = false;
            this.txtSearch.Lines = null;
            this.txtSearch.Location = new System.Drawing.Point(71, 12);
            this.txtSearch.MaxLength = 32767;
            this.txtSearch.Multiline = false;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.ReadOnly = false;
            this.txtSearch.Size = new System.Drawing.Size(317, 33);
            this.txtSearch.Style = MetroSet_UI.Enums.Style.Light;
            this.txtSearch.StyleManager = null;
            this.txtSearch.TabIndex = 4;
            this.txtSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtSearch.ThemeAuthor = null;
            this.txtSearch.ThemeName = null;
            this.txtSearch.UseSystemPasswordChar = false;
            this.txtSearch.WatermarkText = "";
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGreen;
            this.panel1.Location = new System.Drawing.Point(294, 105);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(40, 40);
            this.panel1.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.OrangeRed;
            this.panel2.Location = new System.Drawing.Point(601, 105);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(40, 40);
            this.panel2.TabIndex = 7;
            // 
            // metroSetControlBox1
            // 
            this.metroSetControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroSetControlBox1.CloseHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.metroSetControlBox1.CloseHoverForeColor = System.Drawing.Color.White;
            this.metroSetControlBox1.CloseNormalForeColor = System.Drawing.Color.Gray;
            this.metroSetControlBox1.DisabledForeColor = System.Drawing.Color.DimGray;
            this.metroSetControlBox1.IsDerivedStyle = true;
            this.metroSetControlBox1.Location = new System.Drawing.Point(1111, 3);
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
            this.metroSetControlBox1.TabIndex = 10;
            this.metroSetControlBox1.Text = "metroSetControlBox1";
            this.metroSetControlBox1.ThemeAuthor = null;
            this.metroSetControlBox1.ThemeName = null;
            // 
            // dgvItems
            // 
            this.dgvItems.AllowUserToAddRows = false;
            this.dgvItems.AllowUserToDeleteRows = false;
            this.dgvItems.AllowUserToResizeRows = false;
            this.dgvItems.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgvItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnItemNo,
            this.Column2,
            this.Column3,
            this.Column5,
            this.Column6,
            this.colStocks,
            this.colIsActive,
            this.Column4,
            this.colSold,
            this.colRestockLvl});
            this.dgvItems.GridColor = System.Drawing.Color.White;
            this.dgvItems.Location = new System.Drawing.Point(15, 151);
            this.dgvItems.MultiSelect = false;
            this.dgvItems.Name = "dgvItems";
            this.dgvItems.ReadOnly = true;
            this.dgvItems.RowHeadersVisible = false;
            this.dgvItems.RowTemplate.Height = 30;
            this.dgvItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvItems.Size = new System.Drawing.Size(1183, 281);
            this.dgvItems.TabIndex = 11;
            this.dgvItems.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvItems_CellClick);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.btnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(399, 14);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(86, 26);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnUpdate.Enabled = false;
            this.btnUpdate.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnUpdate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.btnUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(490, 14);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(86, 26);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnStockIn
            // 
            this.btnStockIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnStockIn.Enabled = false;
            this.btnStockIn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnStockIn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.btnStockIn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.btnStockIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStockIn.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStockIn.ForeColor = System.Drawing.Color.White;
            this.btnStockIn.Location = new System.Drawing.Point(581, 14);
            this.btnStockIn.Name = "btnStockIn";
            this.btnStockIn.Size = new System.Drawing.Size(86, 26);
            this.btnStockIn.TabIndex = 2;
            this.btnStockIn.Text = "Stock In";
            this.btnStockIn.UseVisualStyleBackColor = false;
            this.btnStockIn.Click += new System.EventHandler(this.btnStockIn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(15, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 17);
            this.label1.TabIndex = 109;
            this.label1.Text = "Search";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(340, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 17);
            this.label2.TabIndex = 110;
            this.label2.Text = "Item is on Stable Level";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(647, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 17);
            this.label3.TabIndex = 111;
            this.label3.Text = "Item is on Critical Level";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(7, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 21);
            this.label4.TabIndex = 112;
            this.label4.Text = "Item";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(996, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 17);
            this.label5.TabIndex = 113;
            this.label5.Text = "Search by";
            // 
            // cmbSearchFilter
            // 
            this.cmbSearchFilter.BackColor = System.Drawing.Color.White;
            this.cmbSearchFilter.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSearchFilter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cmbSearchFilter.FormattingEnabled = true;
            this.cmbSearchFilter.Items.AddRange(new object[] {
            "Active",
            "Not Active"});
            this.cmbSearchFilter.Location = new System.Drawing.Point(1069, 13);
            this.cmbSearchFilter.Name = "cmbSearchFilter";
            this.cmbSearchFilter.Size = new System.Drawing.Size(130, 29);
            this.cmbSearchFilter.TabIndex = 3;
            this.cmbSearchFilter.SelectedIndexChanged += new System.EventHandler(this.cmbSearchFilter_SelectedIndexChanged);
            // 
            // btnActivateDeactivate
            // 
            this.btnActivateDeactivate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnActivateDeactivate.Enabled = false;
            this.btnActivateDeactivate.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnActivateDeactivate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.btnActivateDeactivate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.btnActivateDeactivate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActivateDeactivate.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActivateDeactivate.ForeColor = System.Drawing.Color.White;
            this.btnActivateDeactivate.Location = new System.Drawing.Point(1112, 452);
            this.btnActivateDeactivate.Name = "btnActivateDeactivate";
            this.btnActivateDeactivate.Size = new System.Drawing.Size(86, 26);
            this.btnActivateDeactivate.TabIndex = 5;
            this.btnActivateDeactivate.Text = "Deactivate";
            this.btnActivateDeactivate.UseVisualStyleBackColor = false;
            this.btnActivateDeactivate.Click += new System.EventHandler(this.btnActivateDeactivate_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel3.Location = new System.Drawing.Point(-1, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1223, 32);
            this.panel3.TabIndex = 114;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel4.Controls.Add(this.txtSearch);
            this.panel4.Controls.Add(this.cmbSearchFilter);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.btnStockIn);
            this.panel4.Controls.Add(this.btnAdd);
            this.panel4.Controls.Add(this.btnUpdate);
            this.panel4.Location = new System.Drawing.Point(-1, 37);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1223, 409);
            this.panel4.TabIndex = 115;
            // 
            // columnItemNo
            // 
            this.columnItemNo.HeaderText = "Item Number";
            this.columnItemNo.Name = "columnItemNo";
            this.columnItemNo.ReadOnly = true;
            this.columnItemNo.Width = 169;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Item Code";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 168;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Item Description";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 350;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Size";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 168;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Price";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 169;
            // 
            // colStocks
            // 
            this.colStocks.HeaderText = "Stocks";
            this.colStocks.Name = "colStocks";
            this.colStocks.ReadOnly = true;
            this.colStocks.Width = 168;
            // 
            // colIsActive
            // 
            this.colIsActive.HeaderText = "Is Active";
            this.colIsActive.Name = "colIsActive";
            this.colIsActive.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Supplier Information";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // colSold
            // 
            this.colSold.HeaderText = "Sold";
            this.colSold.Name = "colSold";
            this.colSold.ReadOnly = true;
            // 
            // colRestockLvl
            // 
            this.colRestockLvl.HeaderText = "Restock Level";
            this.colRestockLvl.Name = "colRestockLvl";
            this.colRestockLvl.ReadOnly = true;
            this.colRestockLvl.Width = 169;
            // 
            // frmItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1214, 487);
            this.Controls.Add(this.btnActivateDeactivate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvItems);
            this.Controls.Add(this.metroSetControlBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmItem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Items";
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroSet_UI.Controls.MetroSetTextBox txtSearch;
        private MetroSet_UI.Controls.MetroSetControlBox metroSetControlBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvItems;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnStockIn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbSearchFilter;
        private System.Windows.Forms.Button btnActivateDeactivate;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnItemNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStocks;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIsActive;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSold;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRestockLvl;
    }
}