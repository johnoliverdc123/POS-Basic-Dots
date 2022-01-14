namespace POSWinforms.Expenses
{
    partial class frmAddExpense
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtPurpose = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbExpenseType = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCost = new System.Windows.Forms.TextBox();
            this.btnAddExpense = new System.Windows.Forms.Button();
            this.epPurposeDesc = new System.Windows.Forms.ErrorProvider(this.components);
            this.epType = new System.Windows.Forms.ErrorProvider(this.components);
            this.epCost = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnAddExpenseType = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.epPurposeDesc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epCost)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Purpose Description:";
            // 
            // txtPurpose
            // 
            this.txtPurpose.Location = new System.Drawing.Point(151, 23);
            this.txtPurpose.MaxLength = 255;
            this.txtPurpose.Multiline = true;
            this.txtPurpose.Name = "txtPurpose";
            this.txtPurpose.Size = new System.Drawing.Size(317, 83);
            this.txtPurpose.TabIndex = 1;
            this.txtPurpose.Validating += new System.ComponentModel.CancelEventHandler(this.txtPurpose_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(83, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Type:";
            // 
            // cmbExpenseType
            // 
            this.cmbExpenseType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbExpenseType.FormattingEnabled = true;
            this.cmbExpenseType.Location = new System.Drawing.Point(151, 124);
            this.cmbExpenseType.Name = "cmbExpenseType";
            this.cmbExpenseType.Size = new System.Drawing.Size(121, 24);
            this.cmbExpenseType.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(86, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Cost:";
            // 
            // txtCost
            // 
            this.txtCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCost.Location = new System.Drawing.Point(151, 159);
            this.txtCost.MaxLength = 12;
            this.txtCost.Name = "txtCost";
            this.txtCost.Size = new System.Drawing.Size(161, 22);
            this.txtCost.TabIndex = 5;
            this.txtCost.Validating += new System.ComponentModel.CancelEventHandler(this.txtCost_Validating);
            // 
            // btnAddExpense
            // 
            this.btnAddExpense.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddExpense.Location = new System.Drawing.Point(365, 200);
            this.btnAddExpense.Name = "btnAddExpense";
            this.btnAddExpense.Size = new System.Drawing.Size(103, 23);
            this.btnAddExpense.TabIndex = 6;
            this.btnAddExpense.Text = "Add Expense";
            this.btnAddExpense.UseVisualStyleBackColor = true;
            this.btnAddExpense.Click += new System.EventHandler(this.btnAddExpense_Click);
            // 
            // epPurposeDesc
            // 
            this.epPurposeDesc.ContainerControl = this;
            // 
            // epType
            // 
            this.epType.ContainerControl = this;
            // 
            // epCost
            // 
            this.epCost.ContainerControl = this;
            // 
            // btnAddExpenseType
            // 
            this.btnAddExpenseType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddExpenseType.Location = new System.Drawing.Point(288, 123);
            this.btnAddExpenseType.Name = "btnAddExpenseType";
            this.btnAddExpenseType.Size = new System.Drawing.Size(140, 25);
            this.btnAddExpenseType.TabIndex = 7;
            this.btnAddExpenseType.Text = "Add Expense Type";
            this.btnAddExpenseType.UseVisualStyleBackColor = true;
            this.btnAddExpenseType.Click += new System.EventHandler(this.btnAddExpenseType_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.btnAddExpenseType);
            this.panel1.Controls.Add(this.btnAddExpense);
            this.panel1.Controls.Add(this.txtCost);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.cmbExpenseType);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtPurpose);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(507, 242);
            this.panel1.TabIndex = 8;
            // 
            // frmAddExpense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 273);
            this.Controls.Add(this.panel1);
            this.Name = "frmAddExpense";
            this.Text = "Add Expense";
            ((System.ComponentModel.ISupportInitialize)(this.epPurposeDesc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epCost)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPurpose;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbExpenseType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCost;
        private System.Windows.Forms.Button btnAddExpense;
        private System.Windows.Forms.ErrorProvider epPurposeDesc;
        private System.Windows.Forms.ErrorProvider epType;
        private System.Windows.Forms.ErrorProvider epCost;
        private System.Windows.Forms.Button btnAddExpenseType;
        private System.Windows.Forms.Panel panel1;
    }
}