
namespace POSWinforms.Transaction
{
    partial class frmTransaction
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lbPosition = new MetroSet_UI.Controls.MetroSetLabel();
            this.lbUser = new MetroSet_UI.Controls.MetroSetLabel();
            this.metroSetLabel1 = new MetroSet_UI.Controls.MetroSetLabel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.lbCustomerNo = new MetroSet_UI.Controls.MetroSetLabel();
            this.metroSetLabel3 = new MetroSet_UI.Controls.MetroSetLabel();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.lbTime = new MetroSet_UI.Controls.MetroSetLabel();
            this.lbDate = new MetroSet_UI.Controls.MetroSetLabel();
            this.tableLayoutPanel9 = new System.Windows.Forms.TableLayoutPanel();
            this.lbTotal = new MetroSet_UI.Controls.MetroSetLabel();
            this.metroSetLabel4 = new MetroSet_UI.Controls.MetroSetLabel();
            this.tableLayoutPanel10 = new System.Windows.Forms.TableLayoutPanel();
            this.dgvCart = new System.Windows.Forms.DataGridView();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextDgvCart = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Delete = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel11 = new System.Windows.Forms.TableLayoutPanel();
            this.btnClose = new MetroSet_UI.Controls.MetroSetButton();
            this.btnPayment = new MetroSet_UI.Controls.MetroSetButton();
            this.btnDiscountItem = new MetroSet_UI.Controls.MetroSetButton();
            this.btnRemoveItem = new MetroSet_UI.Controls.MetroSetButton();
            this.btnAddItem = new MetroSet_UI.Controls.MetroSetButton();
            this.btnNewTransaction = new MetroSet_UI.Controls.MetroSetButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel8.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.tableLayoutPanel9.SuspendLayout();
            this.tableLayoutPanel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCart)).BeginInit();
            this.contextDgvCart.SuspendLayout();
            this.tableLayoutPanel11.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.86694F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.13306F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.metroSetLabel1, 0, 0);
            this.tableLayoutPanel1.ForeColor = System.Drawing.Color.Maroon;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(9, 47);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1177, 49);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.lbPosition, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.lbUser, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(836, 2);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(339, 45);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // lbPosition
            // 
            this.lbPosition.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbPosition.Font = new System.Drawing.Font("Perpetua Titling MT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPosition.IsDerivedStyle = false;
            this.lbPosition.Location = new System.Drawing.Point(2, 22);
            this.lbPosition.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbPosition.Name = "lbPosition";
            this.lbPosition.Size = new System.Drawing.Size(335, 23);
            this.lbPosition.Style = MetroSet_UI.Enums.Style.Custom;
            this.lbPosition.StyleManager = null;
            this.lbPosition.TabIndex = 1;
            this.lbPosition.Text = "Position:";
            this.lbPosition.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbPosition.ThemeAuthor = "Narwin";
            this.lbPosition.ThemeName = "MetroLite";
            // 
            // lbUser
            // 
            this.lbUser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbUser.Font = new System.Drawing.Font("Perpetua Titling MT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUser.IsDerivedStyle = false;
            this.lbUser.Location = new System.Drawing.Point(2, 0);
            this.lbUser.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbUser.Name = "lbUser";
            this.lbUser.Size = new System.Drawing.Size(335, 22);
            this.lbUser.Style = MetroSet_UI.Enums.Style.Custom;
            this.lbUser.StyleManager = null;
            this.lbUser.TabIndex = 0;
            this.lbUser.Text = "User:";
            this.lbUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbUser.ThemeAuthor = "Narwin";
            this.lbUser.ThemeName = "MetroLite";
            // 
            // metroSetLabel1
            // 
            this.metroSetLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroSetLabel1.Font = new System.Drawing.Font("Perpetua Titling MT", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroSetLabel1.IsDerivedStyle = false;
            this.metroSetLabel1.Location = new System.Drawing.Point(2, 0);
            this.metroSetLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroSetLabel1.Name = "metroSetLabel1";
            this.metroSetLabel1.Size = new System.Drawing.Size(830, 49);
            this.metroSetLabel1.Style = MetroSet_UI.Enums.Style.Custom;
            this.metroSetLabel1.StyleManager = null;
            this.metroSetLabel1.TabIndex = 1;
            this.metroSetLabel1.Text = "Basic Dots Printing Services";
            this.metroSetLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroSetLabel1.ThemeAuthor = null;
            this.metroSetLabel1.ThemeName = null;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.94919F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.05082F));
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel4, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel9, 1, 0);
            this.tableLayoutPanel3.ForeColor = System.Drawing.Color.Maroon;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(9, 100);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1177, 92);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel5, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel6, 0, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(2, 2);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 13F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(831, 88);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 0.9673519F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 99.03265F));
            this.tableLayoutPanel5.Controls.Add(this.tableLayoutPanel8, 1, 0);
            this.tableLayoutPanel5.Location = new System.Drawing.Point(2, 46);
            this.tableLayoutPanel5.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(827, 40);
            this.tableLayoutPanel5.TabIndex = 0;
            // 
            // tableLayoutPanel8
            // 
            this.tableLayoutPanel8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel8.ColumnCount = 2;
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.66298F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 69.33701F));
            this.tableLayoutPanel8.Controls.Add(this.lbCustomerNo, 0, 0);
            this.tableLayoutPanel8.Controls.Add(this.metroSetLabel3, 0, 0);
            this.tableLayoutPanel8.Location = new System.Drawing.Point(9, 2);
            this.tableLayoutPanel8.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            this.tableLayoutPanel8.RowCount = 1;
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel8.Size = new System.Drawing.Size(816, 36);
            this.tableLayoutPanel8.TabIndex = 1;
            // 
            // lbCustomerNo
            // 
            this.lbCustomerNo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbCustomerNo.Font = new System.Drawing.Font("Perpetua Titling MT", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCustomerNo.IsDerivedStyle = false;
            this.lbCustomerNo.Location = new System.Drawing.Point(252, 0);
            this.lbCustomerNo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbCustomerNo.Name = "lbCustomerNo";
            this.lbCustomerNo.Padding = new System.Windows.Forms.Padding(0, 0, 0, 6);
            this.lbCustomerNo.Size = new System.Drawing.Size(562, 36);
            this.lbCustomerNo.Style = MetroSet_UI.Enums.Style.Custom;
            this.lbCustomerNo.StyleManager = null;
            this.lbCustomerNo.TabIndex = 4;
            this.lbCustomerNo.Text = "1";
            this.lbCustomerNo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lbCustomerNo.ThemeAuthor = "Narwin";
            this.lbCustomerNo.ThemeName = "MetroLite";
            // 
            // metroSetLabel3
            // 
            this.metroSetLabel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroSetLabel3.Font = new System.Drawing.Font("Perpetua Titling MT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroSetLabel3.IsDerivedStyle = false;
            this.metroSetLabel3.Location = new System.Drawing.Point(2, 0);
            this.metroSetLabel3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroSetLabel3.Name = "metroSetLabel3";
            this.metroSetLabel3.Padding = new System.Windows.Forms.Padding(0, 0, 0, 6);
            this.metroSetLabel3.Size = new System.Drawing.Size(246, 36);
            this.metroSetLabel3.Style = MetroSet_UI.Enums.Style.Custom;
            this.metroSetLabel3.StyleManager = null;
            this.metroSetLabel3.TabIndex = 3;
            this.metroSetLabel3.Text = "Customer No.:";
            this.metroSetLabel3.ThemeAuthor = "Narwin";
            this.metroSetLabel3.ThemeName = "MetroLite";
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel6.ColumnCount = 2;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Controls.Add(this.lbTime, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.lbDate, 0, 0);
            this.tableLayoutPanel6.Location = new System.Drawing.Point(2, 2);
            this.tableLayoutPanel6.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 1;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(827, 40);
            this.tableLayoutPanel6.TabIndex = 1;
            // 
            // lbTime
            // 
            this.lbTime.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbTime.Font = new System.Drawing.Font("Perpetua Titling MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTime.IsDerivedStyle = false;
            this.lbTime.Location = new System.Drawing.Point(415, 0);
            this.lbTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTime.Name = "lbTime";
            this.lbTime.Padding = new System.Windows.Forms.Padding(0, 0, 0, 6);
            this.lbTime.Size = new System.Drawing.Size(410, 40);
            this.lbTime.Style = MetroSet_UI.Enums.Style.Custom;
            this.lbTime.StyleManager = null;
            this.lbTime.TabIndex = 2;
            this.lbTime.Text = "Time:";
            this.lbTime.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lbTime.ThemeAuthor = "Narwin";
            this.lbTime.ThemeName = "MetroLite";
            // 
            // lbDate
            // 
            this.lbDate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbDate.Font = new System.Drawing.Font("Perpetua Titling MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDate.IsDerivedStyle = false;
            this.lbDate.Location = new System.Drawing.Point(2, 0);
            this.lbDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbDate.Name = "lbDate";
            this.lbDate.Padding = new System.Windows.Forms.Padding(0, 0, 0, 6);
            this.lbDate.Size = new System.Drawing.Size(409, 40);
            this.lbDate.Style = MetroSet_UI.Enums.Style.Custom;
            this.lbDate.StyleManager = null;
            this.lbDate.TabIndex = 1;
            this.lbDate.Text = "Date:";
            this.lbDate.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lbDate.ThemeAuthor = "Narwin";
            this.lbDate.ThemeName = "MetroLite";
            // 
            // tableLayoutPanel9
            // 
            this.tableLayoutPanel9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel9.ColumnCount = 1;
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel9.Controls.Add(this.lbTotal, 0, 1);
            this.tableLayoutPanel9.Controls.Add(this.metroSetLabel4, 0, 0);
            this.tableLayoutPanel9.Location = new System.Drawing.Point(837, 2);
            this.tableLayoutPanel9.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel9.Name = "tableLayoutPanel9";
            this.tableLayoutPanel9.RowCount = 2;
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 29.62963F));
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70.37037F));
            this.tableLayoutPanel9.Size = new System.Drawing.Size(338, 88);
            this.tableLayoutPanel9.TabIndex = 1;
            // 
            // lbTotal
            // 
            this.lbTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbTotal.Font = new System.Drawing.Font("Perpetua Titling MT", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotal.IsDerivedStyle = false;
            this.lbTotal.Location = new System.Drawing.Point(2, 26);
            this.lbTotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Padding = new System.Windows.Forms.Padding(0, 0, 6, 6);
            this.lbTotal.Size = new System.Drawing.Size(334, 62);
            this.lbTotal.Style = MetroSet_UI.Enums.Style.Custom;
            this.lbTotal.StyleManager = null;
            this.lbTotal.TabIndex = 5;
            this.lbTotal.Text = "0.00";
            this.lbTotal.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.lbTotal.ThemeAuthor = "Narwin";
            this.lbTotal.ThemeName = "MetroLite";
            // 
            // metroSetLabel4
            // 
            this.metroSetLabel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroSetLabel4.Font = new System.Drawing.Font("Perpetua Titling MT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroSetLabel4.IsDerivedStyle = false;
            this.metroSetLabel4.Location = new System.Drawing.Point(2, 0);
            this.metroSetLabel4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.metroSetLabel4.Name = "metroSetLabel4";
            this.metroSetLabel4.Size = new System.Drawing.Size(334, 26);
            this.metroSetLabel4.Style = MetroSet_UI.Enums.Style.Custom;
            this.metroSetLabel4.StyleManager = null;
            this.metroSetLabel4.TabIndex = 1;
            this.metroSetLabel4.Text = "Total:";
            this.metroSetLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.metroSetLabel4.ThemeAuthor = "Narwin";
            this.metroSetLabel4.ThemeName = "MetroLite";
            // 
            // tableLayoutPanel10
            // 
            this.tableLayoutPanel10.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel10.ColumnCount = 2;
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.90755F));
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.09245F));
            this.tableLayoutPanel10.Controls.Add(this.dgvCart, 0, 0);
            this.tableLayoutPanel10.Controls.Add(this.tableLayoutPanel11, 1, 0);
            this.tableLayoutPanel10.Location = new System.Drawing.Point(9, 196);
            this.tableLayoutPanel10.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel10.Name = "tableLayoutPanel10";
            this.tableLayoutPanel10.RowCount = 1;
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel10.Size = new System.Drawing.Size(1177, 398);
            this.tableLayoutPanel10.TabIndex = 2;
            // 
            // dgvCart
            // 
            this.dgvCart.AllowUserToAddRows = false;
            this.dgvCart.AllowUserToDeleteRows = false;
            this.dgvCart.AllowUserToResizeRows = false;
            this.dgvCart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCart.BackgroundColor = System.Drawing.Color.PeachPuff;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCart.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCart.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.dgvCart.ContextMenuStrip = this.contextDgvCart;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCart.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCart.Location = new System.Drawing.Point(2, 2);
            this.dgvCart.Margin = new System.Windows.Forms.Padding(2);
            this.dgvCart.MultiSelect = false;
            this.dgvCart.Name = "dgvCart";
            this.dgvCart.RowHeadersVisible = false;
            this.dgvCart.RowTemplate.Height = 30;
            this.dgvCart.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCart.Size = new System.Drawing.Size(830, 394);
            this.dgvCart.TabIndex = 0;
            this.dgvCart.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCart_CellClick);
            this.dgvCart.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCart_CellMouseEnter);
            this.dgvCart.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCart_CellValueChanged);
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Item Code";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 138;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Item Description";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 350;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Quantity";
            this.Column4.Name = "Column4";
            this.Column4.Width = 137;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Price";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 138;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Discount";
            this.Column6.Name = "Column6";
            this.Column6.Width = 138;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Total";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 138;
            // 
            // contextDgvCart
            // 
            this.contextDgvCart.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Delete});
            this.contextDgvCart.Name = "contextDgvCart";
            this.contextDgvCart.Size = new System.Drawing.Size(172, 26);
            // 
            // Delete
            // 
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(171, 22);
            this.Delete.Text = "Remove from Cart";
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // tableLayoutPanel11
            // 
            this.tableLayoutPanel11.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel11.ColumnCount = 1;
            this.tableLayoutPanel11.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel11.Controls.Add(this.btnClose, 0, 5);
            this.tableLayoutPanel11.Controls.Add(this.btnPayment, 0, 4);
            this.tableLayoutPanel11.Controls.Add(this.btnDiscountItem, 0, 3);
            this.tableLayoutPanel11.Controls.Add(this.btnRemoveItem, 0, 2);
            this.tableLayoutPanel11.Controls.Add(this.btnAddItem, 0, 1);
            this.tableLayoutPanel11.Controls.Add(this.btnNewTransaction, 0, 0);
            this.tableLayoutPanel11.Location = new System.Drawing.Point(836, 2);
            this.tableLayoutPanel11.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel11.Name = "tableLayoutPanel11";
            this.tableLayoutPanel11.RowCount = 6;
            this.tableLayoutPanel11.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66955F));
            this.tableLayoutPanel11.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66609F));
            this.tableLayoutPanel11.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66609F));
            this.tableLayoutPanel11.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66609F));
            this.tableLayoutPanel11.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66609F));
            this.tableLayoutPanel11.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66609F));
            this.tableLayoutPanel11.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 13F));
            this.tableLayoutPanel11.Size = new System.Drawing.Size(339, 394);
            this.tableLayoutPanel11.TabIndex = 1;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.DisabledBackColor = System.Drawing.Color.RosyBrown;
            this.btnClose.DisabledBorderColor = System.Drawing.Color.RosyBrown;
            this.btnClose.DisabledForeColor = System.Drawing.Color.Gray;
            this.btnClose.Font = new System.Drawing.Font("Perpetua Titling MT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.HoverBorderColor = System.Drawing.Color.Salmon;
            this.btnClose.HoverColor = System.Drawing.Color.Salmon;
            this.btnClose.HoverTextColor = System.Drawing.Color.Maroon;
            this.btnClose.IsDerivedStyle = false;
            this.btnClose.Location = new System.Drawing.Point(2, 327);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2);
            this.btnClose.Name = "btnClose";
            this.btnClose.NormalBorderColor = System.Drawing.Color.Sienna;
            this.btnClose.NormalColor = System.Drawing.Color.MistyRose;
            this.btnClose.NormalTextColor = System.Drawing.Color.Maroon;
            this.btnClose.PressBorderColor = System.Drawing.Color.Tomato;
            this.btnClose.PressColor = System.Drawing.Color.Tomato;
            this.btnClose.PressTextColor = System.Drawing.Color.White;
            this.btnClose.Size = new System.Drawing.Size(335, 65);
            this.btnClose.Style = MetroSet_UI.Enums.Style.Light;
            this.btnClose.StyleManager = null;
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "Close";
            this.btnClose.ThemeAuthor = "Narwin";
            this.btnClose.ThemeName = "MetroLite";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnPayment
            // 
            this.btnPayment.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPayment.DisabledBackColor = System.Drawing.Color.RosyBrown;
            this.btnPayment.DisabledBorderColor = System.Drawing.Color.RosyBrown;
            this.btnPayment.DisabledForeColor = System.Drawing.Color.Gray;
            this.btnPayment.Font = new System.Drawing.Font("Perpetua Titling MT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPayment.HoverBorderColor = System.Drawing.Color.Salmon;
            this.btnPayment.HoverColor = System.Drawing.Color.Salmon;
            this.btnPayment.HoverTextColor = System.Drawing.Color.Maroon;
            this.btnPayment.IsDerivedStyle = false;
            this.btnPayment.Location = new System.Drawing.Point(2, 262);
            this.btnPayment.Margin = new System.Windows.Forms.Padding(2);
            this.btnPayment.Name = "btnPayment";
            this.btnPayment.NormalBorderColor = System.Drawing.Color.Sienna;
            this.btnPayment.NormalColor = System.Drawing.Color.MistyRose;
            this.btnPayment.NormalTextColor = System.Drawing.Color.Maroon;
            this.btnPayment.PressBorderColor = System.Drawing.Color.Tomato;
            this.btnPayment.PressColor = System.Drawing.Color.Tomato;
            this.btnPayment.PressTextColor = System.Drawing.Color.White;
            this.btnPayment.Size = new System.Drawing.Size(335, 61);
            this.btnPayment.Style = MetroSet_UI.Enums.Style.Light;
            this.btnPayment.StyleManager = null;
            this.btnPayment.TabIndex = 5;
            this.btnPayment.Text = "Payment";
            this.btnPayment.ThemeAuthor = "Narwin";
            this.btnPayment.ThemeName = "MetroLite";
            this.btnPayment.Click += new System.EventHandler(this.btnPayment_Click);
            // 
            // btnDiscountItem
            // 
            this.btnDiscountItem.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDiscountItem.DisabledBackColor = System.Drawing.Color.RosyBrown;
            this.btnDiscountItem.DisabledBorderColor = System.Drawing.Color.RosyBrown;
            this.btnDiscountItem.DisabledForeColor = System.Drawing.Color.Gray;
            this.btnDiscountItem.Enabled = false;
            this.btnDiscountItem.Font = new System.Drawing.Font("Perpetua Titling MT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDiscountItem.HoverBorderColor = System.Drawing.Color.Salmon;
            this.btnDiscountItem.HoverColor = System.Drawing.Color.Salmon;
            this.btnDiscountItem.HoverTextColor = System.Drawing.Color.Maroon;
            this.btnDiscountItem.IsDerivedStyle = false;
            this.btnDiscountItem.Location = new System.Drawing.Point(2, 197);
            this.btnDiscountItem.Margin = new System.Windows.Forms.Padding(2);
            this.btnDiscountItem.Name = "btnDiscountItem";
            this.btnDiscountItem.NormalBorderColor = System.Drawing.Color.Sienna;
            this.btnDiscountItem.NormalColor = System.Drawing.Color.MistyRose;
            this.btnDiscountItem.NormalTextColor = System.Drawing.Color.Maroon;
            this.btnDiscountItem.PressBorderColor = System.Drawing.Color.Tomato;
            this.btnDiscountItem.PressColor = System.Drawing.Color.Tomato;
            this.btnDiscountItem.PressTextColor = System.Drawing.Color.White;
            this.btnDiscountItem.Size = new System.Drawing.Size(335, 61);
            this.btnDiscountItem.Style = MetroSet_UI.Enums.Style.Light;
            this.btnDiscountItem.StyleManager = null;
            this.btnDiscountItem.TabIndex = 4;
            this.btnDiscountItem.Text = "Discount";
            this.btnDiscountItem.ThemeAuthor = "Narwin";
            this.btnDiscountItem.ThemeName = "MetroLite";
            this.btnDiscountItem.Click += new System.EventHandler(this.btnDiscountItem_Click);
            // 
            // btnRemoveItem
            // 
            this.btnRemoveItem.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemoveItem.DisabledBackColor = System.Drawing.Color.RosyBrown;
            this.btnRemoveItem.DisabledBorderColor = System.Drawing.Color.RosyBrown;
            this.btnRemoveItem.DisabledForeColor = System.Drawing.Color.Gray;
            this.btnRemoveItem.Enabled = false;
            this.btnRemoveItem.Font = new System.Drawing.Font("Perpetua Titling MT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveItem.HoverBorderColor = System.Drawing.Color.Salmon;
            this.btnRemoveItem.HoverColor = System.Drawing.Color.Salmon;
            this.btnRemoveItem.HoverTextColor = System.Drawing.Color.Maroon;
            this.btnRemoveItem.IsDerivedStyle = false;
            this.btnRemoveItem.Location = new System.Drawing.Point(2, 132);
            this.btnRemoveItem.Margin = new System.Windows.Forms.Padding(2);
            this.btnRemoveItem.Name = "btnRemoveItem";
            this.btnRemoveItem.NormalBorderColor = System.Drawing.Color.Sienna;
            this.btnRemoveItem.NormalColor = System.Drawing.Color.MistyRose;
            this.btnRemoveItem.NormalTextColor = System.Drawing.Color.Maroon;
            this.btnRemoveItem.PressBorderColor = System.Drawing.Color.Tomato;
            this.btnRemoveItem.PressColor = System.Drawing.Color.Tomato;
            this.btnRemoveItem.PressTextColor = System.Drawing.Color.White;
            this.btnRemoveItem.Size = new System.Drawing.Size(335, 61);
            this.btnRemoveItem.Style = MetroSet_UI.Enums.Style.Light;
            this.btnRemoveItem.StyleManager = null;
            this.btnRemoveItem.TabIndex = 3;
            this.btnRemoveItem.Text = "Remove";
            this.btnRemoveItem.ThemeAuthor = "Narwin";
            this.btnRemoveItem.ThemeName = "MetroLite";
            this.btnRemoveItem.Click += new System.EventHandler(this.btnRemoveItem_Click);
            // 
            // btnAddItem
            // 
            this.btnAddItem.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddItem.DisabledBackColor = System.Drawing.Color.RosyBrown;
            this.btnAddItem.DisabledBorderColor = System.Drawing.Color.RosyBrown;
            this.btnAddItem.DisabledForeColor = System.Drawing.Color.Gray;
            this.btnAddItem.Font = new System.Drawing.Font("Perpetua Titling MT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddItem.HoverBorderColor = System.Drawing.Color.Salmon;
            this.btnAddItem.HoverColor = System.Drawing.Color.Salmon;
            this.btnAddItem.HoverTextColor = System.Drawing.Color.Maroon;
            this.btnAddItem.IsDerivedStyle = false;
            this.btnAddItem.Location = new System.Drawing.Point(2, 67);
            this.btnAddItem.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.NormalBorderColor = System.Drawing.Color.Sienna;
            this.btnAddItem.NormalColor = System.Drawing.Color.MistyRose;
            this.btnAddItem.NormalTextColor = System.Drawing.Color.Maroon;
            this.btnAddItem.PressBorderColor = System.Drawing.Color.Tomato;
            this.btnAddItem.PressColor = System.Drawing.Color.Tomato;
            this.btnAddItem.PressTextColor = System.Drawing.Color.White;
            this.btnAddItem.Size = new System.Drawing.Size(335, 61);
            this.btnAddItem.Style = MetroSet_UI.Enums.Style.Light;
            this.btnAddItem.StyleManager = null;
            this.btnAddItem.TabIndex = 2;
            this.btnAddItem.Text = "Add Item";
            this.btnAddItem.ThemeAuthor = "Narwin";
            this.btnAddItem.ThemeName = "MetroLite";
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // btnNewTransaction
            // 
            this.btnNewTransaction.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNewTransaction.DisabledBackColor = System.Drawing.Color.RosyBrown;
            this.btnNewTransaction.DisabledBorderColor = System.Drawing.Color.RosyBrown;
            this.btnNewTransaction.DisabledForeColor = System.Drawing.Color.Gray;
            this.btnNewTransaction.Font = new System.Drawing.Font("Perpetua Titling MT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewTransaction.HoverBorderColor = System.Drawing.Color.Salmon;
            this.btnNewTransaction.HoverColor = System.Drawing.Color.Salmon;
            this.btnNewTransaction.HoverTextColor = System.Drawing.Color.Maroon;
            this.btnNewTransaction.IsDerivedStyle = false;
            this.btnNewTransaction.Location = new System.Drawing.Point(2, 2);
            this.btnNewTransaction.Margin = new System.Windows.Forms.Padding(2);
            this.btnNewTransaction.Name = "btnNewTransaction";
            this.btnNewTransaction.NormalBorderColor = System.Drawing.Color.Sienna;
            this.btnNewTransaction.NormalColor = System.Drawing.Color.MistyRose;
            this.btnNewTransaction.NormalTextColor = System.Drawing.Color.Maroon;
            this.btnNewTransaction.PressBorderColor = System.Drawing.Color.Tomato;
            this.btnNewTransaction.PressColor = System.Drawing.Color.Tomato;
            this.btnNewTransaction.PressTextColor = System.Drawing.Color.White;
            this.btnNewTransaction.Size = new System.Drawing.Size(335, 61);
            this.btnNewTransaction.Style = MetroSet_UI.Enums.Style.Light;
            this.btnNewTransaction.StyleManager = null;
            this.btnNewTransaction.TabIndex = 0;
            this.btnNewTransaction.Text = "New Transaction";
            this.btnNewTransaction.ThemeAuthor = "Narwin";
            this.btnNewTransaction.ThemeName = "MetroLite";
            this.btnNewTransaction.Click += new System.EventHandler(this.btnNewTransaction_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmTransaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1195, 604);
            this.Controls.Add(this.tableLayoutPanel10);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(1195, 604);
            this.Name = "frmTransaction";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Transaction";
            this.Load += new System.EventHandler(this.frmTransaction_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel8.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel9.ResumeLayout(false);
            this.tableLayoutPanel10.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCart)).EndInit();
            this.contextDgvCart.ResumeLayout(false);
            this.tableLayoutPanel11.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel10;
        private System.Windows.Forms.DataGridView dgvCart;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel11;
        private MetroSet_UI.Controls.MetroSetButton btnClose;
        private MetroSet_UI.Controls.MetroSetButton btnPayment;
        private MetroSet_UI.Controls.MetroSetButton btnDiscountItem;
        private MetroSet_UI.Controls.MetroSetButton btnRemoveItem;
        private MetroSet_UI.Controls.MetroSetButton btnAddItem;
        private MetroSet_UI.Controls.MetroSetButton btnNewTransaction;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private MetroSet_UI.Controls.MetroSetLabel lbTime;
        private MetroSet_UI.Controls.MetroSetLabel lbDate;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel9;
        private MetroSet_UI.Controls.MetroSetLabel lbTotal;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private MetroSet_UI.Controls.MetroSetLabel lbPosition;
        private MetroSet_UI.Controls.MetroSetLabel lbUser;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.ContextMenuStrip contextDgvCart;
        private System.Windows.Forms.ToolStripMenuItem Delete;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel8;
        private MetroSet_UI.Controls.MetroSetLabel lbCustomerNo;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel3;
    }
}