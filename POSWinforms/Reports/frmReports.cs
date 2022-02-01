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

namespace POSWinforms.Reports
{
    public partial class frmReports : Form
    {
        private List<tblOrder> orderList = new List<tblOrder>();
        private List<tblExpense> expenseList = new List<tblExpense>();

        private DateTime startDate = DateTime.Now;

        private List<DateTime> datesToEvaluate = new List<DateTime>();

        private decimal total = 0;

        public frmReports()
        {
            InitializeComponent();

            dtpFromDate.MaxDate = startDate;
            dtpToDate.MaxDate = startDate;
            dtpFromDate.Value = startDate.AddDays(-1);
            
        }

        private void loadAllProductionAndTransaction(List<DateTime> dates)
        {
            orderList.Clear();

            dgvProdAndTransactions.Rows.Clear();

            if (dates.Count > 0)
            {
                orderList = (from s in DatabaseHelper.db.tblOrders
                             where dates.Contains(s.Date.Date)
                             select s).ToList()
                             .OrderByDescending(o => o.Date) // Order by most recent date.
                             .ToList();
            } else
            {
                MessageBox.Show(this, "Please choose if Daily, Weekly, Monthly, or Custom", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //var prodList = new List<ProductionAndTransaction>();

            //foreach (var item in orderList)
            //{


            //    var transactionsPerDate = orderList.FindAll(o => item.Date == o.Date).Count();
            //    var transactionsGrandTotal = orderList.FindAll(o => item.Date == o.Date)
            //        .Sum(x => x.Total + x.ServiceFee);

            //    var newProd = new ProductionAndTransaction
            //    {
            //        ID = item.ID,
            //        Status = item.Status,
            //        timeStamp = (DateTime)item.Date,
            //        TransactionsGrandTotal = (decimal)transactionsGrandTotal,
            //        TransactionsPerDate = transactionsPerDate
            //    };

            //    prodList.Add(newProd);

            //}

            //prodList = prodList.GroupBy(x => x.timeStamp.Date).Select(y => y.First()).ToList();

            total = orderList.Sum(x => x.Total);
            txtTotal.Text = total.ToString("C2");

            foreach (var item in orderList)
            {
                dgvProdAndTransactions.Rows.Add(
                        item.ID,
                        item.Status,
                        item.Date,
                        item.Total.ToString("C2")
                    );
            }

            dgvProdAndTransactions.ClearSelection();
        }

        private void generateReport()
        {
            if (rbProductionReport.Checked)
            {
                loadAllProductionAndTransaction(datesToEvaluate);
            }
        }

        private void dtpFromDate_ValueChanged(object sender, EventArgs e)
        {
            startDate = dtpFromDate.Value;
            dtpToDate.Value = startDate;
        }

        private void rbCustom_CheckedChanged(object sender, EventArgs e)
        {
            txtTotal.Text = "0";

            if (rbCustom.Checked)
            {
                dtpFromDate.Enabled = true;
                dtpToDate.Enabled = true;
            }
            else
            {
                dtpFromDate.Enabled = false;
                dtpToDate.Enabled = false;
            }
        }

        private void rbDaily_CheckedChanged(object sender, EventArgs e)
        {
            txtTotal.Text = "0";

            if (rbDaily.Checked)
            {
                datesToEvaluate.Clear();

                var today = DateTime.Now;
                datesToEvaluate.Add(today.Date);
                

                foreach(var date in datesToEvaluate)
                {
                    Console.WriteLine(date);
                }

                generateReport();
            }
        }

        private List<DateTime> GetDatesInThisMonth(int year, int month)
        {
            return Enumerable.Range(1, DateTime.DaysInMonth(year, month))  // Days: 1, 2 ... 31 etc.
                             .Select(day => new DateTime(year, month, day, 0, 0, 0)) // Map each day to a date
                             .ToList(); // Load dates into a list
        }

        private void rbWeekly_CheckedChanged(object sender, EventArgs e)
        {
            txtTotal.Text = "0";

            if (rbWeekly.Checked)
            {
                datesToEvaluate.Clear();

                DateTime today = DateTime.Today;
                int currentDayOfWeek = (int)today.DayOfWeek;
                DateTime sunday = today.AddDays(-currentDayOfWeek);
                DateTime monday = sunday.AddDays(-6);
                datesToEvaluate = Enumerable.Range(0, 7).Select(days => monday.AddDays(days)).ToList();

                foreach(var date in datesToEvaluate)
                {
                    Console.WriteLine(date);
                }

                generateReport();
            }
        }

        private void rbMonthly_CheckedChanged(object sender, EventArgs e)
        {
            txtTotal.Text = "0";

            if (rbMonthly.Checked)
            {
                datesToEvaluate.Clear();

                var today = DateTime.Now;
                datesToEvaluate = GetDatesInThisMonth(today.Year, today.Month);

                foreach(var date in datesToEvaluate)
                {
                    Console.WriteLine(date);
                }

                generateReport();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (dtpFromDate.Enabled && dtpToDate.Enabled)
            {
                datesToEvaluate.Clear();
                for (var dt = dtpFromDate.Value.Date; dt <= dtpToDate.Value.Date; dt = dt.AddDays(1))
                {
                    datesToEvaluate.Add(dt);
                }
            }

            generateReport();
        }

        private void rbProductionReport_CheckedChanged(object sender, EventArgs e)
        {
            txtTotal.Text = "0";

            rbDaily.Checked = false;
            rbWeekly.Checked = false;
            rbMonthly.Checked = false;
            rbCustom.Checked = false;

            dgvProdAndTransactions.Rows.Clear();
        }

        private void rbExpensesReport_CheckedChanged(object sender, EventArgs e)
        {
            txtTotal.Text = "0";

            rbDaily.Checked = false;
            rbWeekly.Checked = false;
            rbMonthly.Checked = false;
            rbCustom.Checked = false;

            dgvProdAndTransactions.Rows.Clear();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (rbProductionReport.Checked && dgvProdAndTransactions.Rows.Count > 0)
            {
                DGVPrinter printer = new DGVPrinter();
                printer.Title = "Productions And Transactions Report";
                printer.SubTitle = string.Format("Date: {0}", DateTime.Now.ToString("MM/dd/yyyy hh:mm:ss tt"));
                printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
                printer.PageNumbers = true;
                printer.PageNumberInHeader = false;
                printer.PorportionalColumns = true;
                printer.HeaderCellAlignment = StringAlignment.Near;
                printer.PrintDataGridView(dgvProdAndTransactions);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
