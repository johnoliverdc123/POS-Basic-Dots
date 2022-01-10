namespace POSWinforms.Expenses
{
    partial class frmExpenses
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
            this.dgvExpenses = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbSortOrder = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddExpense = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.rbCustom = new System.Windows.Forms.RadioButton();
            this.dtpToDate = new System.Windows.Forms.DateTimePicker();
            this.rbMonthly = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.rbWeekly = new System.Windows.Forms.RadioButton();
            this.dtpFromDate = new System.Windows.Forms.DateTimePicker();
            this.rbDaily = new System.Windows.Forms.RadioButton();
            this.txtSearchById = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnPrint = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExpenses)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvExpenses
            // 
            this.dgvExpenses.AllowUserToAddRows = false;
            this.dgvExpenses.AllowUserToDeleteRows = false;
            this.dgvExpenses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvExpenses.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dgvExpenses.Location = new System.Drawing.Point(12, 125);
            this.dgvExpenses.Name = "dgvExpenses";
            this.dgvExpenses.ReadOnly = true;
            this.dgvExpenses.Size = new System.Drawing.Size(776, 313);
            this.dgvExpenses.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Purpose";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Type";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Cost";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Date";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Made By";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // cmbSortOrder
            // 
            this.cmbSortOrder.FormattingEnabled = true;
            this.cmbSortOrder.Location = new System.Drawing.Point(667, 98);
            this.cmbSortOrder.Name = "cmbSortOrder";
            this.cmbSortOrder.Size = new System.Drawing.Size(121, 21);
            this.cmbSortOrder.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(606, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Sort Order";
            // 
            // btnAddExpense
            // 
            this.btnAddExpense.Location = new System.Drawing.Point(686, 444);
            this.btnAddExpense.Name = "btnAddExpense";
            this.btnAddExpense.Size = new System.Drawing.Size(102, 23);
            this.btnAddExpense.TabIndex = 7;
            this.btnAddExpense.Text = "Add Expense";
            this.btnAddExpense.UseVisualStyleBackColor = true;
            this.btnAddExpense.Click += new System.EventHandler(this.btnAddExpense_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnSearch);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.rbCustom);
            this.panel2.Controls.Add(this.dtpToDate);
            this.panel2.Controls.Add(this.rbMonthly);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.rbWeekly);
            this.panel2.Controls.Add(this.dtpFromDate);
            this.panel2.Controls.Add(this.rbDaily);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(724, 60);
            this.panel2.TabIndex = 16;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(515, 9);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(177, 23);
            this.btnSearch.TabIndex = 15;
            this.btnSearch.Text = "Get Report From These Dates";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(280, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "To:";
            // 
            // rbCustom
            // 
            this.rbCustom.AutoSize = true;
            this.rbCustom.Location = new System.Drawing.Point(192, 3);
            this.rbCustom.Name = "rbCustom";
            this.rbCustom.Size = new System.Drawing.Size(60, 17);
            this.rbCustom.TabIndex = 3;
            this.rbCustom.TabStop = true;
            this.rbCustom.Text = "Custom";
            this.rbCustom.UseVisualStyleBackColor = true;
            this.rbCustom.CheckedChanged += new System.EventHandler(this.rbCustom_CheckedChanged);
            // 
            // dtpToDate
            // 
            this.dtpToDate.Enabled = false;
            this.dtpToDate.Location = new System.Drawing.Point(309, 29);
            this.dtpToDate.Name = "dtpToDate";
            this.dtpToDate.Size = new System.Drawing.Size(200, 20);
            this.dtpToDate.TabIndex = 13;
            // 
            // rbMonthly
            // 
            this.rbMonthly.AutoSize = true;
            this.rbMonthly.Location = new System.Drawing.Point(124, 3);
            this.rbMonthly.Name = "rbMonthly";
            this.rbMonthly.Size = new System.Drawing.Size(62, 17);
            this.rbMonthly.TabIndex = 2;
            this.rbMonthly.TabStop = true;
            this.rbMonthly.Text = "Monthly";
            this.rbMonthly.UseVisualStyleBackColor = true;
            this.rbMonthly.CheckedChanged += new System.EventHandler(this.rbMonthly_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(270, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "From:";
            // 
            // rbWeekly
            // 
            this.rbWeekly.AutoSize = true;
            this.rbWeekly.Location = new System.Drawing.Point(57, 3);
            this.rbWeekly.Name = "rbWeekly";
            this.rbWeekly.Size = new System.Drawing.Size(61, 17);
            this.rbWeekly.TabIndex = 1;
            this.rbWeekly.TabStop = true;
            this.rbWeekly.Text = "Weekly";
            this.rbWeekly.UseVisualStyleBackColor = true;
            this.rbWeekly.CheckedChanged += new System.EventHandler(this.rbWeekly_CheckedChanged);
            // 
            // dtpFromDate
            // 
            this.dtpFromDate.Enabled = false;
            this.dtpFromDate.Location = new System.Drawing.Point(309, 3);
            this.dtpFromDate.Name = "dtpFromDate";
            this.dtpFromDate.Size = new System.Drawing.Size(200, 20);
            this.dtpFromDate.TabIndex = 11;
            // 
            // rbDaily
            // 
            this.rbDaily.AutoSize = true;
            this.rbDaily.Location = new System.Drawing.Point(3, 3);
            this.rbDaily.Name = "rbDaily";
            this.rbDaily.Size = new System.Drawing.Size(48, 17);
            this.rbDaily.TabIndex = 0;
            this.rbDaily.TabStop = true;
            this.rbDaily.Text = "Daily";
            this.rbDaily.UseVisualStyleBackColor = true;
            this.rbDaily.CheckedChanged += new System.EventHandler(this.rbDaily_CheckedChanged);
            // 
            // txtSearchById
            // 
            this.txtSearchById.Location = new System.Drawing.Point(91, 94);
            this.txtSearchById.Name = "txtSearchById";
            this.txtSearchById.Size = new System.Drawing.Size(145, 20);
            this.txtSearchById.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Search By ID:";
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(578, 444);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(102, 23);
            this.btnPrint.TabIndex = 19;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // frmExpenses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 485);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.txtSearchById);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnAddExpense);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbSortOrder);
            this.Controls.Add(this.dgvExpenses);
            this.Name = "frmExpenses";
            this.Text = "Expenses";
            ((System.ComponentModel.ISupportInitialize)(this.dgvExpenses)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvExpenses;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.ComboBox cmbSortOrder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddExpense;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rbCustom;
        private System.Windows.Forms.DateTimePicker dtpToDate;
        private System.Windows.Forms.RadioButton rbMonthly;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rbWeekly;
        private System.Windows.Forms.DateTimePicker dtpFromDate;
        private System.Windows.Forms.RadioButton rbDaily;
        private System.Windows.Forms.TextBox txtSearchById;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnPrint;
    }
}