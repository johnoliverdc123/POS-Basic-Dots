using POSWinforms.Models;
using System;
using System.ComponentModel;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;

namespace POSWinforms.Expenses
{
    public partial class frmAddExpense : Form
    {
        public frmAddExpense()
        {
            InitializeComponent();

            LoadExpenseTypes();
        }

        private void LoadExpenseTypes()
        {
            
            var expenseTypeList = (from s in DatabaseHelper.db.tblExpenseTypes select s).ToList();

            cmbExpenseType.Items.Clear();

            foreach (var type in expenseTypeList)
            {
                cmbExpenseType.Items.Add(type.Type);
            }

            if (expenseTypeList.Count > 0)
            {
                cmbExpenseType.SelectedIndex = 0;
            }
        }

        private void btnAddExpense_Click(object sender, EventArgs e)
        {
            var newExpense = new tblExpense
            {
                Purpose = txtPurpose.Text,
                Type = cmbExpenseType.SelectedItem.ToString(),
                Cost = Convert.ToDecimal(txtCost.Text),
                Date = DateTime.Now,
                PaidBy = $"{DatabaseHelper.user.FirstName} {DatabaseHelper.user.LastName}"
            };

            var newLog = new tblHistoryLog
            {
                Action = $"{DatabaseHelper.user.LastName}({DatabaseHelper.user.ID}) " +
                        $"added expense({newExpense.Type}) with the cost of {newExpense.Cost} pesos.",
                Type = LogType.EXPENSES.ToString(),
                Date = DateTime.Now,
                EditBy = $"{DatabaseHelper.user.FirstName} {DatabaseHelper.user.LastName}"
            };

            DatabaseHelper.db.tblHistoryLogs.InsertOnSubmit(newLog);
            DatabaseHelper.db.tblExpenses.InsertOnSubmit(newExpense);
            DatabaseHelper.db.SubmitChanges();
            MessageBox.Show("Expense added successfully!", "INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }

        private void txtPurpose_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPurpose.Text))
            {
                e.Cancel = true;
                epPurposeDesc.SetError(txtPurpose, "Please enter the description of this expense!");
            }
            else
            {
                e.Cancel = false;
                epPurposeDesc.SetError(txtPurpose, null);
            }
        }

        private void txtCost_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCost.Text))
            {
                e.Cancel = true;
                epCost.SetError(txtCost, "Please enter cost!");
            }
            else if (!Regex.IsMatch(txtCost.Text, @"^([0-9]{1,7})([.,][0-9]{1,2})?$"))
            {
                e.Cancel = true;
                epCost.SetError(txtCost, "Please input numbers only!");
            }
            else
            {
                e.Cancel = false;
                epCost.SetError(txtCost, null);
            }
        }

        private void btnAddExpenseType_Click(object sender, EventArgs e)
        {
            new frmAddEditExpenseType().ShowDialog();
            LoadExpenseTypes();
        }
    }
}
