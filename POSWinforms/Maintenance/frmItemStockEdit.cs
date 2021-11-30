using MetroSet_UI.Forms;
using POSWinforms.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POSWinforms.Maintenance
{
    public partial class frmItemStockEdit : Form
    {

        private tblItem editItemStock;

        public frmItemStockEdit()
        {
            InitializeComponent();
        }

        public void setItemCode(string itemCode)
        {
            editItemStock = (from s in DatabaseHelper.db.tblItems
                              where s.ItemCode.Equals(itemCode)
                              select s).FirstOrDefault();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if(int.TryParse(txtQuantity.Text, out int stockNum))
            {
                editItemStock.Stocks += stockNum;

                var newLog = new tblHistoryLog
                {
                    Action = $"{DatabaseHelper.user.LastName}({DatabaseHelper.user.ID}) " +
                        $"added {stockNum} stocks to item({editItemStock.ItemCode})",
                    Type = LogType.PRODUCT.ToString(),
                    Date = new DateTimeOffset(DateTime.Now).ToUnixTimeMilliseconds(),
                    EditBy = $"{DatabaseHelper.user.FirstName} {DatabaseHelper.user.LastName}"
                };

                DatabaseHelper.db.tblHistoryLogs.InsertOnSubmit(newLog);
                DatabaseHelper.db.SubmitChanges();
                MessageBox.Show(this, "Stocked in successfully!", "INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            else
            {
                MessageBox.Show(this, "Stock should be number!", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtQuantity.Text = "";
            }
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
