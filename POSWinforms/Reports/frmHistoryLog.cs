using POSWinforms.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Linq.SqlClient;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace POSWinforms.Reports
{
    public partial class frmHistoryLog : Form
    {

        private List<tblHistoryLog> historyLogList = new List<tblHistoryLog>();

        private List<DateTime> datesToEvaluate = new List<DateTime>();

        private DateTime startDate = DateTime.Now;

        public frmHistoryLog()
        {
            InitializeComponent();

            cmbSortOrder.SelectedIndex = 0;
            dtpToDate.MinDate = startDate.AddDays(1);
        }

        private void loadAllHistoryLog(string searchById, string sortOrder, List<DateTime> dates)
        {
            historyLogList.Clear();
            dgvHistoryLog.Rows.Clear();

            
            if (sortOrder != null && !sortOrder.Equals("None"))
            {
                if (searchById != null)
                {
                    historyLogList = (from s in DatabaseHelper.db.tblHistoryLogs
                                      where dates.Contains((new DateTime(1970, 1, 1, 0, 0, 0)).AddMilliseconds(s.Date).Date) &&
                                      s.Type.ToLower().Equals(sortOrder.ToLower()) &&
                                      SqlMethods.Like(s.ID.ToString(), $"%{searchById}%")
                                      select s).ToList();
                } 
                else
                {
                    historyLogList = (from s in DatabaseHelper.db.tblHistoryLogs
                                      where dates.Contains((new DateTime(1970, 1, 1, 0, 0, 0)).AddMilliseconds(s.Date).Date) &&
                                      s.Type.ToLower().Equals(sortOrder.ToLower())
                                      select s).ToList();
                }

            }
            else
            {
                if(searchById != null)
                {
                    historyLogList = (from s in DatabaseHelper.db.tblHistoryLogs
                                      where dates.Contains((new DateTime(1970, 1, 1, 0, 0, 0)).AddMilliseconds(s.Date).Date) &&
                                      SqlMethods.Like(s.ID.ToString(), $"%{searchById}%")
                                      select s).ToList();
                } else
                {
                    historyLogList = (from s in DatabaseHelper.db.tblHistoryLogs
                                      where dates.Contains((new DateTime(1970, 1, 1, 0, 0, 0)).AddMilliseconds(s.Date).Date)
                                      select s).ToList();
                }
            }

            historyLogList = historyLogList.OrderByDescending(h => h.Date).ToList();

            foreach (var item in historyLogList)
            {
                var dateFromStamp = (new DateTime(1970, 1, 1, 0, 0, 0)).AddMilliseconds(item.Date).ToLocalTime();

                var supplierInfo = "";
                if(sortOrder != null && sortOrder.Equals(LogType.PRODUCT.ToString()))
                {
                    supplierInfo = item.SupplierInformation;
                }

                dgvHistoryLog.Rows.Add(
                        item.ID,
                        item.Action,
                        item.Type,
                        dateFromStamp,
                        item.EditBy,
                        supplierInfo
                    );
            }

            dgvHistoryLog.ClearSelection();
        }

        private void dtpFromDate_ValueChanged(object sender, EventArgs e)
        {
            startDate = dtpFromDate.Value;
            dtpToDate.MinDate = startDate.AddDays(1);
        }

        private void rbDaily_CheckedChanged(object sender, EventArgs e)
        {
            if (rbDaily.Checked)
            {
                datesToEvaluate.Clear();

                var today = DateTime.Now;
                for (var dt = today.AddDays(-100).Date; dt < today.AddDays(100).Date; dt = dt.AddDays(1))
                {
                    datesToEvaluate.Add(dt);
                }

                foreach (var date in datesToEvaluate)
                {
                    Console.WriteLine(date);
                }

                generateReport();
            }
        }

        private void rbWeekly_CheckedChanged(object sender, EventArgs e)
        {
            if (rbWeekly.Checked)
            {
                datesToEvaluate.Clear();

                DateTime today = DateTime.Today;
                int currentDayOfWeek = (int)today.DayOfWeek;
                DateTime sunday = today.AddDays(-currentDayOfWeek);
                DateTime monday = sunday.AddDays(1);
                datesToEvaluate = Enumerable.Range(0, 7).Select(days => monday.AddDays(days)).ToList();

                foreach (var date in datesToEvaluate)
                {
                    Console.WriteLine(date);
                }

                generateReport();
            }
        }

        private void rbMonthly_CheckedChanged(object sender, EventArgs e)
        {
            if (rbMonthly.Checked)
            {
                datesToEvaluate.Clear();

                var today = DateTime.Now;
                datesToEvaluate = GetDatesInThisMonth(today.Year, today.Month);

                foreach (var date in datesToEvaluate)
                {
                    Console.WriteLine(date);
                }

                generateReport();
            }
        }

        private void rbCustom_CheckedChanged(object sender, EventArgs e)
        {
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

        private void generateReport()
        {
            if (txtSearchById.Text.Length > 3 && Int64.TryParse(txtSearchById.Text, out long id))
            {
                loadAllHistoryLog(id.ToString(), cmbSortOrder.SelectedItem.ToString(), datesToEvaluate);
            }
            else
            {
                loadAllHistoryLog(null, cmbSortOrder.SelectedItem.ToString(), datesToEvaluate);
            }
        }

        private List<DateTime> GetDatesInThisMonth(int year, int month)
        {
            return Enumerable.Range(1, DateTime.DaysInMonth(year, month))  // Days: 1, 2 ... 31 etc.
                             .Select(day => new DateTime(year, month, day, 0, 0, 0)) // Map each day to a date
                             .ToList(); // Load dates into a list
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if(dgvHistoryLog.Rows.Count > 0)
            {
                DGVPrinter printer = new DGVPrinter();
                printer.Title = "History Logs Report";
                printer.SubTitle = string.Format("Date: {0}", DateTime.Now.ToString("MM/dd/yyyy hh:mm:ss tt"));
                printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
                printer.PageNumbers = true;
                printer.PageNumberInHeader = false;
                printer.PorportionalColumns = true;
                printer.HeaderCellAlignment = StringAlignment.Near;
                printer.PrintDataGridView(dgvHistoryLog);
            }
        }
    }
}
