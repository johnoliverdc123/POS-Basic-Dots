using POSWinforms.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace POSWinforms.Reports
{
    public partial class frmHistoryLog : Form
    {

        private List<tblHistoryLog> historyLogList = new List<tblHistoryLog>();

        private DateTime startDate = DateTime.Now;

        public frmHistoryLog()
        {
            InitializeComponent();

            cmbSortOrder.SelectedIndex = 0;
            dtpToDate.MinDate = startDate.AddDays(1);

            loadAllHistoryLog(null);
        }

        private void loadAllHistoryLog(string sortOrder)
        {
            historyLogList.Clear();
            dgvHistoryLog.Rows.Clear();

            
            if (sortOrder != null && !sortOrder.Equals("None"))
            {
                historyLogList = (from s in DatabaseHelper.db.tblHistoryLogs
                            where s.Type.ToLower().Equals(sortOrder.ToLower())
                            select s).ToList();

            }
            else
            {
                historyLogList = (from s in DatabaseHelper.db.tblHistoryLogs
                            select s).ToList();
            }

            historyLogList = historyLogList.OrderByDescending(h => h.Date).ToList();

            foreach (var item in historyLogList)
            {
                var dateFromStamp = (new DateTime(1970, 1, 1, 0, 0, 0)).AddMilliseconds(item.Date).ToLocalTime();

                dgvHistoryLog.Rows.Add(
                        item.ID,
                        item.Action,
                        item.Type,
                        dateFromStamp,
                        item.EditBy
                    );
            }

            dgvHistoryLog.ClearSelection();
        }

        private void loadAllHistoryLogWithDateRange(string sortOrder)
        {
            historyLogList.Clear();
            dgvHistoryLog.Rows.Clear();

            var startDateLong = new DateTimeOffset(dtpFromDate.Value).ToUnixTimeMilliseconds();
            var toDateLong = new DateTimeOffset(dtpFromDate.Value).ToUnixTimeMilliseconds();

            if (sortOrder != null && !sortOrder.Equals("None"))
            {
                historyLogList = (from s in DatabaseHelper.db.tblHistoryLogs
                                  where s.Type.ToLower().Equals(sortOrder.ToLower()) &&
                                  ((new DateTime(1970, 1, 1, 0, 0, 0)).AddMilliseconds(s.Date).Date >=
                                    dtpFromDate.Value.Date &&
                                    (new DateTime(1970, 1, 1, 0, 0, 0)).AddMilliseconds(s.Date).Date <= 
                                    dtpToDate.Value.Date)
                                  select s).ToList();
            }
            else
            {
                historyLogList = (from s in DatabaseHelper.db.tblHistoryLogs
                                  where ((new DateTime(1970, 1, 1, 0, 0, 0)).AddMilliseconds(s.Date).Date >=
                                    dtpFromDate.Value.Date &&
                                    (new DateTime(1970, 1, 1, 0, 0, 0)).AddMilliseconds(s.Date).Date <=
                                    dtpToDate.Value.Date)
                                  select s).ToList();
            }

            historyLogList = historyLogList.OrderByDescending(h => h.Date).ToList();

            foreach (var item in historyLogList)
            {
                var dateFromStamp = (new DateTime(1970, 1, 1, 0, 0, 0)).AddMilliseconds(item.Date).ToLocalTime();

                dgvHistoryLog.Rows.Add(
                        item.ID,
                        item.Action,
                        item.Type,
                        dateFromStamp,
                        item.EditBy
                    );
            }

            dgvHistoryLog.ClearSelection();
        }

        private void cmbSortOrder_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbSortOrder.SelectedIndex > 0)
            {
                loadAllHistoryLog(cmbSortOrder.SelectedItem.ToString());
            } else
            {
                loadAllHistoryLog(null);
            }
        }

        private void btnWithSortOrder_Click(object sender, EventArgs e)
        {
            loadAllHistoryLogWithDateRange(cmbSortOrder.SelectedItem.ToString());
        }

        private void btnWithoutSortOrder_Click(object sender, EventArgs e)
        {
            cmbSortOrder.SelectedIndex = 0;
            loadAllHistoryLogWithDateRange(null);
        }

        private void dtpFromDate_ValueChanged(object sender, EventArgs e)
        {
            startDate = dtpFromDate.Value;
            dtpToDate.MinDate = startDate.AddDays(1);
        }
    }
}
