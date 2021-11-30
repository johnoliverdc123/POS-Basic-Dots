using POSWinforms.Expenses;
using POSWinforms.Maintenance;
using POSWinforms.Models;
using POSWinforms.Reports;
using POSWinforms.Transaction;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace POSWinforms
{
    public partial class frmMain : Form
    {

        private List<tblItem> itemList = new List<tblItem>();

        private tblItem fastTrackItem = null;
        private tblItem slowTrackItem = null;

        public frmMain()
        {
            InitializeComponent();
            timer1.Start();
            string date = DateTime.Now.ToString("dddd MMMM dd, yyyy  hh:mm:ss tt");
            lbTime.Text = date;

            if (DatabaseHelper.user.Position.Equals("Cashier"))
            {
                p1.Visible = false;
                btnUser.Visible = false;

                p2.Visible = false;
                btnItem.Visible = false;

                p3.Visible = false;
                btnCategory.Visible = false;

                p5.Visible = false;
                btnPosition.Visible = false;

                p7.Visible = false;
                btnOrders.Visible = false;

                p9.Visible = false;
                btnReports.Visible = false;
            }
            else if (DatabaseHelper.user.Position.Equals("Inventory"))
            {
                p1.Visible = false;
                btnUser.Visible = false;

                p3.Visible = false;
                btnCategory.Visible = false;

                p4.Visible = false;
                btnExpenses.Visible = false;

                p5.Visible = false;
                btnPosition.Visible = false;

                p6.Visible = false;
                btnTransaction.Visible = false;

                p7.Visible = false;
                btnOrders.Visible = false;

                p8.Visible = false;
                btnHistoryLog.Visible = false;

                p9.Visible = false;
                btnReports.Visible = false;
            }

            loadEverything();
        }

        private void loadEverything()
        {
            loadAllItems();
            loadOneFastAndSlowTrackItem();
            loadTotalSalesAndTransactionCountToday();
            loadTotalExpensesToday();
        }

        private void loadAllItems()
        {
            itemList.Clear();
            dgvItems.Rows.Clear();

            // find all items that are less than the restock level
            itemList = (from s in DatabaseHelper.db.tblItems
                        where s.Stocks < s.ReStockLevel
                        select s).ToList();

            foreach (var item in itemList)
            {
                dgvItems.Rows.Add(
                        item.ItemNumber,
                        item.ItemCode,
                        item.ItemDescription,
                        item.Size,
                        item.Stocks
                    );
            }

            dgvItems.ClearSelection();
        }

        private void loadOneFastAndSlowTrackItem()
        {
            fastTrackItem = null;
            slowTrackItem = null;
            dgvFastTrackItems.Rows.Clear();

            itemList = (from s in DatabaseHelper.db.tblItems
                        select s).ToList();

            fastTrackItem = (from s in itemList where s.Sold == itemList.Max(x => x.Sold) select s).First();
            slowTrackItem = (from s in itemList where s.Sold == itemList.Min(x => x.Sold) select s).First();

            dgvFastTrackItems.Rows.Add(
                fastTrackItem.ID,
                fastTrackItem.ItemCode,
                fastTrackItem.ItemDescription,
                fastTrackItem.Size,
                fastTrackItem.Sold
                );

            if (slowTrackItem.ID != fastTrackItem.ID)
            {

                dgvFastTrackItems.Rows.Add(
                    slowTrackItem.ID,
                    slowTrackItem.ItemCode,
                    slowTrackItem.ItemDescription,
                    slowTrackItem.Size,
                    slowTrackItem.Sold
                    );
            }

            dgvFastTrackItems.ClearSelection();
        }

        private void loadTotalSalesAndTransactionCountToday()
        {
            var totalSalesAndTransactionsList = (from s in DatabaseHelper.db.tblOrders
                              where ((new DateTime(1970, 1, 1)).AddMilliseconds(s.Date).Day ==
                                    DateTime.Now.Day)
                              select s).ToList();

            var totalSales = totalSalesAndTransactionsList.Sum(x => x.Total + x.ServiceFee);
            var totalTransactionCount = totalSalesAndTransactionsList.Count();

            lbTotalSales.Text = totalSales.ToString("C2");
            lbTransactions.Text = totalTransactionCount.ToString("0");
        }

        private void loadTotalExpensesToday()
        {
            var totalExpenses = (from s in DatabaseHelper.db.tblExpenses
                              where ((new DateTime(1970, 1, 1)).AddMilliseconds(s.Date).Day ==
                                    DateTime.Now.Day)
                              select s).ToList().Sum(x => x.Cost);
            lbTotalExpense.Text = totalExpenses.ToString("C2");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string date = DateTime.Now.ToString("dddd MMMM dd, yyyy  hh:mm:ss tt");
            lbTime.Text = date;
        }

        private void userToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new frmUser().ShowDialog();
            loadEverything();
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            var isLoggingOut = MessageBox.Show("Are you sure you want to log out", "Sign Out", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (isLoggingOut == DialogResult.Yes)
            {
                var newLog = new tblHistoryLog
                {
                    Action = $"{DatabaseHelper.user.LastName}({DatabaseHelper.user.ID}) " +
                        $"logged out",
                    Type = LogType.LOGBOOK.ToString(),
                    Date = new DateTimeOffset(DateTime.Now).ToUnixTimeMilliseconds(),
                    EditBy = $"{DatabaseHelper.user.FirstName} {DatabaseHelper.user.LastName}"
                };

                DatabaseHelper.db.tblHistoryLogs.InsertOnSubmit(newLog);
                DatabaseHelper.db.SubmitChanges();
                DatabaseHelper.frmLogin.Show();
            }
            else
            {
                e.Cancel = true;
            }

        }

        private void positionToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new frmPosition().ShowDialog();
            loadEverything();
        }

        private void categoryToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new frmCategory().ShowDialog();
            loadEverything();
        }

        private void itemToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (DatabaseHelper.user.Position.Equals("Manager") ||
                DatabaseHelper.user.Position.Equals("Inventory"))
            {
                new frmItem().ShowDialog();
                loadEverything();
            }
            else
            {
                MessageBox.Show("You are not authorized to access this form.", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void transactionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DatabaseHelper.user.Position.Equals("Manager") ||
                DatabaseHelper.user.Position.Equals("Cashier"))
            {
                new frmTransaction().ShowDialog();
                loadEverything();
            }
            else
            {
                MessageBox.Show("You are not authorized to access this form.", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void ordersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmOrders().ShowDialog();
            loadEverything();
        }

        private void btnExpenses_Click(object sender, EventArgs e)
        {
            new frmExpenses().ShowDialog();
            loadEverything();
        }

        private void btnHistoryLog_Click(object sender, EventArgs e)
        {
            new frmHistoryLog().ShowDialog();
            loadEverything();
        }

        private void dgvItems_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var itemCode = dgvItems.Rows[e.RowIndex].Cells[1].Value.ToString();
                if (itemCode.Length > 0)
                {
                    var frm = new frmItemStockEdit();
                    frm.setItemCode(itemCode);
                    frm.ShowDialog();
                    loadEverything();
                }
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            new frmReports().ShowDialog();
            loadEverything();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            var isLoggingOut = MessageBox.Show("Are you sure you want to log out", "Sign Out", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (isLoggingOut == DialogResult.Yes)
            {
                var newLog = new tblHistoryLog
                {
                    Action = $"{DatabaseHelper.user.LastName}({DatabaseHelper.user.ID}) " +
                        $"logged out",
                    Type = LogType.LOGBOOK.ToString(),
                    Date = new DateTimeOffset(DateTime.Now).ToUnixTimeMilliseconds(),
                    EditBy = $"{DatabaseHelper.user.FirstName} {DatabaseHelper.user.LastName}"
                };

                DatabaseHelper.db.tblHistoryLogs.InsertOnSubmit(newLog);
                DatabaseHelper.db.SubmitChanges();
                DatabaseHelper.frmLogin.Show();
                this.Hide();
            }
        }
    }
}
