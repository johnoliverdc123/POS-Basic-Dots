namespace POSWinforms.Reports
{
    partial class frmReports
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbExpensesReport = new System.Windows.Forms.RadioButton();
            this.rbProductionReport = new System.Windows.Forms.RadioButton();
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
            this.dgvProdAndTransactions = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvExpenses = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnPrint = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdAndTransactions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExpenses)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rbExpensesReport);
            this.panel1.Controls.Add(this.rbProductionReport);
            this.panel1.Location = new System.Drawing.Point(12, 43);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(441, 26);
            this.panel1.TabIndex = 0;
            // 
            // rbExpensesReport
            // 
            this.rbExpensesReport.AutoSize = true;
            this.rbExpensesReport.Location = new System.Drawing.Point(211, 3);
            this.rbExpensesReport.Name = "rbExpensesReport";
            this.rbExpensesReport.Size = new System.Drawing.Size(106, 17);
            this.rbExpensesReport.TabIndex = 2;
            this.rbExpensesReport.TabStop = true;
            this.rbExpensesReport.Text = "Expenses Report";
            this.rbExpensesReport.UseVisualStyleBackColor = true;
            this.rbExpensesReport.CheckedChanged += new System.EventHandler(this.rbExpensesReport_CheckedChanged);
            // 
            // rbProductionReport
            // 
            this.rbProductionReport.AutoSize = true;
            this.rbProductionReport.Location = new System.Drawing.Point(3, 3);
            this.rbProductionReport.Name = "rbProductionReport";
            this.rbProductionReport.Size = new System.Drawing.Size(202, 17);
            this.rbProductionReport.TabIndex = 0;
            this.rbProductionReport.TabStop = true;
            this.rbProductionReport.Text = "Productions And Transactions Report";
            this.rbProductionReport.UseVisualStyleBackColor = true;
            this.rbProductionReport.CheckedChanged += new System.EventHandler(this.rbProductionReport_CheckedChanged);
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
            this.panel2.Location = new System.Drawing.Point(12, 75);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(724, 60);
            this.panel2.TabIndex = 3;
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
            this.dtpFromDate.ValueChanged += new System.EventHandler(this.dtpFromDate_ValueChanged);
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
            // dgvProdAndTransactions
            // 
            this.dgvProdAndTransactions.AllowUserToAddRows = false;
            this.dgvProdAndTransactions.AllowUserToDeleteRows = false;
            this.dgvProdAndTransactions.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvProdAndTransactions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdAndTransactions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dgvProdAndTransactions.Location = new System.Drawing.Point(12, 187);
            this.dgvProdAndTransactions.Name = "dgvProdAndTransactions";
            this.dgvProdAndTransactions.ReadOnly = true;
            this.dgvProdAndTransactions.Size = new System.Drawing.Size(369, 331);
            this.dgvProdAndTransactions.TabIndex = 4;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 43;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Status";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 62;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Date";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 55;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Total";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 56;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Transaction Count";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 109;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 162);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Productions And Transactions Report";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(388, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Expenses Report";
            // 
            // dgvExpenses
            // 
            this.dgvExpenses.AllowUserToAddRows = false;
            this.dgvExpenses.AllowUserToDeleteRows = false;
            this.dgvExpenses.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvExpenses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvExpenses.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.dgvExpenses.Location = new System.Drawing.Point(388, 187);
            this.dgvExpenses.Name = "dgvExpenses";
            this.dgvExpenses.ReadOnly = true;
            this.dgvExpenses.Size = new System.Drawing.Size(400, 331);
            this.dgvExpenses.TabIndex = 6;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 43;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Type";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 56;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Cost";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 53;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Date";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 55;
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(713, 543);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(75, 23);
            this.btnPrint.TabIndex = 8;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // frmReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 578);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgvExpenses);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvProdAndTransactions);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmReports";
            this.Text = "Reports";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdAndTransactions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExpenses)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rbExpensesReport;
        private System.Windows.Forms.RadioButton rbProductionReport;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton rbCustom;
        private System.Windows.Forms.RadioButton rbMonthly;
        private System.Windows.Forms.RadioButton rbWeekly;
        private System.Windows.Forms.RadioButton rbDaily;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpToDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpFromDate;
        private System.Windows.Forms.DataGridView dgvProdAndTransactions;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvExpenses;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.Button btnPrint;
    }
}