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

namespace POSWinforms.Expenses
{
    public partial class frmExpenses : Form
    {
        private DateTime startDate = DateTime.Now;

        private List<tblExpense> expenseList = new List<tblExpense>();


        public frmExpenses()
        {
            InitializeComponent();

            cmbSortOrder.SelectedIndex = 0;
            dtpToDate.MinDate = startDate.AddDays(1);

            loadAllExpenses(null);
        }

        private void loadAllExpenses(string sortOrder)
        {
            expenseList.Clear();
            dgvExpenses.Rows.Clear();


            if (sortOrder != null && !sortOrder.Equals("None"))
            {
                expenseList = (from s in DatabaseHelper.db.tblExpenses
                                  where s.Type.ToLower().Equals(sortOrder.ToLower())
                                  select s).ToList();

            }
            else
            {
                expenseList = (from s in DatabaseHelper.db.tblExpenses
                                  select s).ToList();
            }

            expenseList = expenseList.OrderByDescending(e => e.Date).ToList();

            foreach (var item in expenseList)
            {
                var dateFromStamp = (new DateTime(1970, 1, 1)).AddMilliseconds(item.Date).AddHours(8);

                dgvExpenses.Rows.Add(
                        item.ID,
                        item.Purpose,
                        item.Type,
                        item.Cost,
                        dateFromStamp,
                        item.PaidBy
                    );
            }

            dgvExpenses.ClearSelection();
        }

        private void loadAllExpensesWithDateRange(string sortOrder)
        {
            expenseList.Clear();
            dgvExpenses.Rows.Clear();

            var startDateLong = new DateTimeOffset(dtpFromDate.Value).ToUnixTimeMilliseconds();
            var toDateLong = new DateTimeOffset(dtpToDate.Value).ToUnixTimeMilliseconds();

            if (sortOrder != null && !sortOrder.Equals("None"))
            {
                expenseList = (from s in DatabaseHelper.db.tblExpenses
                               where s.Type.ToLower().Equals(sortOrder.ToLower()) &&
                               ((new DateTime(1970, 1, 1, 0, 0, 0)).AddMilliseconds(s.Date).Date >=
                                    dtpFromDate.Value.Date &&
                                    (new DateTime(1970, 1, 1, 0, 0, 0)).AddMilliseconds(s.Date).Date <=
                                    dtpToDate.Value.Date)
                               select s).ToList();
            }
            else
            {
                expenseList = (from s in DatabaseHelper.db.tblExpenses
                               where ((new DateTime(1970, 1, 1, 0, 0, 0)).AddMilliseconds(s.Date).Date >=
                                    dtpFromDate.Value.Date &&
                                    (new DateTime(1970, 1, 1, 0, 0, 0)).AddMilliseconds(s.Date).Date <=
                                    dtpToDate.Value.Date)
                               select s).ToList();
            }

            expenseList = expenseList.OrderByDescending(e => e.Date).ToList();

            foreach (var item in expenseList)
            {
                var dateFromStamp = (new DateTime(1970, 1, 1, 0, 0, 0)).AddMilliseconds(item.Date).ToLocalTime();

                dgvExpenses.Rows.Add(
                        item.ID,
                        item.Purpose,
                        item.Type,
                        item.Cost,
                        dateFromStamp,
                        item.PaidBy
                    );
            }

            dgvExpenses.ClearSelection();
        }

        private void dtpFromDate_ValueChanged(object sender, EventArgs e)
        {
            startDate = dtpFromDate.Value;
            dtpToDate.MinDate = startDate.AddDays(1);
        }

        private void btnAddExpense_Click(object sender, EventArgs e)
        {
            new frmAddExpense().ShowDialog();
            cmbSortOrder.SelectedIndex = 0;
            loadAllExpenses(null);
        }

        private void cmbSortOrder_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadAllExpenses(cmbSortOrder.SelectedItem.ToString());
        }

        private void btnWithSortOrder_Click(object sender, EventArgs e)
        {
            loadAllExpensesWithDateRange(cmbSortOrder.SelectedItem.ToString());
        }

        private void btnWithoutSortOrder_Click(object sender, EventArgs e)
        {
            cmbSortOrder.SelectedIndex = 0;
            loadAllExpensesWithDateRange(null);
        }
    }
}
