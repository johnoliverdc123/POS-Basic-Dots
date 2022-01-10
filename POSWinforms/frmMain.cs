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

        private List<tblOrderDetail> soldItems = new List<tblOrderDetail>();

        public frmMain()
        {
            InitializeComponent();

            timer1.Start();
            string date = DateTime.Now.ToString("dddd MMMM dd, yyyy  hh:mm:ss tt");
            lbTime.Text = date;

            if(DatabaseHelper.user.Position.ToLower().Contains("admin") || DatabaseHelper.user.Position.ToLower().Equals("manager"))
            {
                // Nothing.
            }
            else if (DatabaseHelper.user.Position.ToLower().Contains("inventory"))
            {
                btnUser.Visible = false;

                btnPosition.Visible = false;

                btnTransaction.Visible = false;

                btnOrders.Visible = false;

                btnHistoryLog.Visible = false;

                btnReports.Visible = false;
            }
            else if (DatabaseHelper.user.Position.Equals("Cashier"))
            {
                btnUser.Visible = false;

                btnItem.Visible = false;

                btnCategory.Visible = false;

                btnPosition.Visible = false;

                btnReports.Visible = false;

                dgvItems.CellDoubleClick -= new System.Windows.Forms.DataGridViewCellEventHandler(dgvItems_CellDoubleClick);
            } 
            else
            {
                btnUser.Visible = false;

                btnItem.Visible = false;

                btnCategory.Visible = false;

                btnPosition.Visible = false;

                btnReports.Visible = false;

                dgvItems.CellDoubleClick -= new System.Windows.Forms.DataGridViewCellEventHandler(dgvItems_CellDoubleClick);
            }

            loadEverything();
        }

        private void loadEverything()
        {
            loadAllItems();
            loadFastTrackItems();
            loadSlowTrackItems();
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

        private void loadFastTrackItems()
        {
            dgvFastTrackItems.Rows.Clear();

            
            soldItems = (from s in DatabaseHelper.db.tblOrderDetails
                            where s.DateSold.Date == DateTime.Now.Date
                            select s).ToList();

            foreach (var item in soldItems)
            {
                var soldQuantities = (from s in DatabaseHelper.db.tblOrderDetails
                                      where s.ItemCode == item.ItemCode
                                      select s.Quantity).Sum(x => x);

                dgvFastTrackItems.Rows.Add(
                    item.ID,
                    item.ItemCode,
                    item.ItemDescription,
                    item.Size,
                    soldQuantities
                    );
            }

            dgvFastTrackItems.ClearSelection();
        }

        private void loadSlowTrackItems()
        {
            dgvSlowTrackItems.Rows.Clear();

            soldItems = (from s in DatabaseHelper.db.tblOrderDetails
                            where s.DateSold.Date == DateTime.Now.Date
                         select s).ToList();

            var allItems = (from s in DatabaseHelper.db.tblItems
                            where s.isActive == 1
                            select s).ToList();

            var slowTrackItems = allItems.Where(x => soldItems.All(y => y.ItemCode != x.ItemCode));

            foreach(var item in slowTrackItems)
            {
                dgvSlowTrackItems.Rows.Add(
                    item.ID,
                    item.ItemCode,
                    item.ItemDescription,
                    item.Size,
                    0
                    );
            }

            dgvSlowTrackItems.ClearSelection();
        }

        private void loadTotalSalesAndTransactionCountToday()
        {
            var totalSalesAndTransactionsList = (from order in DatabaseHelper.db.tblOrders
                                                 where order.Date.Date == DateTime.Now.Date
                                                 select order).ToList();

            var totalSales = totalSalesAndTransactionsList.Sum(x => x.Total + x.ServiceFee);
            var totalTransactionCount = totalSalesAndTransactionsList.Count();

            Console.WriteLine($"Sales: {totalSales}");
            Console.WriteLine($"Transaction: {totalTransactionCount}");
            Console.WriteLine($"Date: {DateTime.Now}");

            lbTotalSales.Text = totalSales?.ToString("C2");
            lbTransactions.Text = totalTransactionCount.ToString("0");
        }

        private void loadTotalExpensesToday()
        {
            var totalExpenses = (from s in DatabaseHelper.db.tblExpenses
                                 where s.Date.Date == DateTime.Now.Date
                                 select s).ToList().Sum(x => x.Cost);

            Console.WriteLine($"Expense: {totalExpenses}");
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
            
                new frmItem().ShowDialog();
                loadEverything();
        }

        private void transactionToolStripMenuItem_Click(object sender, EventArgs e)
        {
                new frmTransaction().ShowDialog();
                loadEverything();

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

        private void frmMain_Load(object sender, EventArgs e)
        {

        }
    }
}
