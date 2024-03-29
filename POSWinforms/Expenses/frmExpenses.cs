﻿using POSWinforms.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Linq.SqlClient;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace POSWinforms.Expenses
{
    public partial class frmExpenses : Form
    {
        private List<tblExpense> expenseList = new List<tblExpense>();

        private List<DateTime> datesToEvaluate = new List<DateTime>();

        private DateTime startDate = DateTime.Now;

        private decimal total = 0;

        public frmExpenses()
        {
            InitializeComponent();

            LoadExpenseTypes();

            dtpFromDate.MaxDate = startDate;
            dtpToDate.MaxDate = startDate;
            dtpFromDate.Value = startDate.AddDays(-1);
        }

        private void LoadExpenseTypes()
        {

            var expenseTypeList = (from s in DatabaseHelper.db.tblExpenseTypes select s).ToList();

            cmbSortOrder.Items.Clear();

            cmbSortOrder.Items.Add("None");

            foreach (var type in expenseTypeList)
            {
                cmbSortOrder.Items.Add(type.Type);
            }

            cmbSortOrder.SelectedIndex = 0;
        }

        private void loadAllExpenses(string searchedId, string sortOrder)
        {
            expenseList.Clear();
            dgvExpenses.Rows.Clear();


            if (sortOrder != null && !sortOrder.Equals("None"))
            {
                if (searchedId != null)
                {
                    expenseList = (from s in DatabaseHelper.db.tblExpenses
                                   where datesToEvaluate.Contains(s.Date.Date) &&
                                   s.Type.ToLower().Equals(sortOrder.ToLower()) &&
                                   SqlMethods.Like(s.ID.ToString(), $"%{searchedId}%")
                                   select s).ToList();
                } else
                {
                    expenseList = (from s in DatabaseHelper.db.tblExpenses
                                   where datesToEvaluate.Contains(s.Date.Date) &&
                                   s.Type.ToLower().Equals(sortOrder.ToLower())
                                   select s).ToList();
                }

            }
            else
            {
                if (searchedId != null)
                {
                    expenseList = (from s in DatabaseHelper.db.tblExpenses
                                   where datesToEvaluate.Contains(s.Date.Date) &&
                                   SqlMethods.Like(s.ID.ToString(), $"%{searchedId}%")
                                   select s).ToList();
                } else
                {
                    expenseList = (from s in DatabaseHelper.db.tblExpenses
                                   where datesToEvaluate.Contains(s.Date.Date)
                                   select s).ToList();
                }
            }

            expenseList = expenseList.OrderByDescending(e => e.Date).ToList();
            total = expenseList.Sum(x => x.Cost);
            txtTotal.Text = total.ToString("C2");

            foreach (var item in expenseList)
            {

                dgvExpenses.Rows.Add(
                        item.ID,
                        item.Purpose,
                        item.Type,
                        item.Cost.ToString("C2"),
                        item.Date,
                        item.PaidBy
                    );
            }

            dgvExpenses.ClearSelection();
        }

        private void dtpFromDate_ValueChanged(object sender, EventArgs e)
        {
            startDate = dtpFromDate.Value;
            dtpToDate.Value = startDate.AddDays(1);
        }

        private void btnAddExpense_Click(object sender, EventArgs e)
        {
            new frmAddExpense().ShowDialog();
            LoadExpenseTypes();
        }

        private void rbDaily_CheckedChanged(object sender, EventArgs e)
        {
            txtTotal.Text = "0";

            if (rbDaily.Checked)
            {
                datesToEvaluate.Clear();

                var today = DateTime.Now;
                datesToEvaluate.Add(today.Date);

                foreach (var date in datesToEvaluate)
                {
                    Console.WriteLine(date);
                }

                generateReports();
            }
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

                foreach (var date in datesToEvaluate)
                {
                    Console.WriteLine(date);
                }

                generateReports();
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

                foreach (var date in datesToEvaluate)
                {
                    Console.WriteLine(date);
                }

                generateReports();
            }
        }

        private List<DateTime> GetDatesInThisMonth(int year, int month)
        {
            return Enumerable.Range(1, DateTime.DaysInMonth(year, month))  // Days: 1, 2 ... 31 etc.
                             .Select(day => new DateTime(year, month, day, 0, 0, 0)) // Map each day to a date
                             .ToList(); // Load dates into a list
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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (dtpFromDate.Enabled && dtpToDate.Enabled)
            {
                datesToEvaluate.Clear();
                for (var dt = dtpFromDate.Value.Date; dt <= dtpToDate.Value.Date; dt = dt.AddDays(1))
                {
                    datesToEvaluate.Add(dt.Date);
                }
            }

            generateReports();
        }

        private void generateReports()
        {
            if (dtpFromDate.Value < dtpToDate.Value)
            {
                if (txtSearchById.Text.Length > 3 && Int64.TryParse(txtSearchById.Text, out long id))
                {
                    loadAllExpenses(id.ToString(), cmbSortOrder.SelectedItem.ToString());
                }
                else
                {
                    loadAllExpenses(null, cmbSortOrder.SelectedItem.ToString());
                }
            }
            else
            {
                MessageBox.Show("To date time should be greater than From date", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if(dgvExpenses.Rows.Count > 0)
            {
                DGVPrinter printer = new DGVPrinter();
                printer.Title = "Expenses Report";
                printer.SubTitle = string.Format("Date: {0}", DateTime.Now.ToString("MM/dd/yyyy hh:mm:ss tt"));
                printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
                printer.PageNumbers = true;
                printer.PageNumberInHeader = false;
                printer.PorportionalColumns = true;
                printer.HeaderCellAlignment = StringAlignment.Near;
                printer.PrintDataGridView(dgvExpenses);
            }
        }
    }
}
