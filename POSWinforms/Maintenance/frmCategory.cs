﻿using MetroSet_UI.Forms;
using POSWinforms.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POSWinforms.Maintenance
{
    public partial class frmCategory : Form
    {
        private List<tblCategory> allCategories = new List<tblCategory>();
        private string itemCode = "";

        private tblCategory selectedCategory = null;

        public frmCategory()
        {
            InitializeComponent();
            LoadActiveCategories();
        }

        private void txtItemCode_Validating(object sender, CancelEventArgs e)
        {
            if (Regex.IsMatch(txtItemCode.Text, @"^[0-9]+$"))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtItemCode, "Please input letters only!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtItemCode, null);
            }
        }

        private void clearFields()
        {
            txtItemCode.Text = "";
            txtDescription.Text = "";
            btnClose.Text = "Close";
            btnClose.Focus();

            selectedCategory = null;
            btnActivateDeactivate.Text = "Deactivate";
            cbShowDeactivatedItems.Checked = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Save new category here.
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                if (!string.IsNullOrWhiteSpace(txtDescription.Text))
                {
                    var newCategory = new tblCategory
                    {
                        ItemCode = txtItemCode.Text,
                        ItemDescription = txtDescription.Text,
                        isActive = 1
                    };

                    var newLog = new tblHistoryLog
                    {
                        Action = $"{DatabaseHelper.user.LastName}({DatabaseHelper.user.ID}) " +
                    $"added category '{newCategory.ItemDescription}'({newCategory.ItemCode})",
                        Type = LogType.CATEGORY.ToString(),
                        Date = new DateTimeOffset(DateTime.Now).ToUnixTimeMilliseconds(),
                        EditBy = $"{DatabaseHelper.user.FirstName} {DatabaseHelper.user.LastName}"
                    };

                    DatabaseHelper.db.tblHistoryLogs.InsertOnSubmit(newLog);
                    DatabaseHelper.db.tblCategories.InsertOnSubmit(newCategory);
                    DatabaseHelper.db.SubmitChanges();

                    MessageBox.Show(this, "Category added successfully!", "INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnAdd.Text = "Add";
                    clearFields();
                    LoadActiveCategories();
                }
                else
                {
                    MessageBox.Show(this, "Category description should not be empty!", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (btnUpdate.Text.Equals("Update"))
            {
                btnUpdate.Text = "Save";
            }
            else if (btnUpdate.Text.Equals("Save"))
            {
                if (string.IsNullOrWhiteSpace(txtDescription.Text))
                {
                    MessageBox.Show(this, "Please enter new description and do not leave that field empty.", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DialogResult dialogResult = MessageBox.Show(this, "Would you like to update this category?",
                    "QUESTION", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    if (ValidateChildren(ValidationConstraints.Enabled))
                    {
                        if (!string.IsNullOrWhiteSpace(txtDescription.Text))
                        {
                            selectedCategory.ItemDescription = txtDescription.Text;

                            var newLog = new tblHistoryLog
                            {
                                Action = $"{DatabaseHelper.user.LastName}({DatabaseHelper.user.ID}) " +
                    $"updated category({selectedCategory.ItemCode})",
                                Type = LogType.CATEGORY.ToString(),
                                Date = new DateTimeOffset(DateTime.Now).ToUnixTimeMilliseconds(),
                                EditBy = $"{DatabaseHelper.user.FirstName} {DatabaseHelper.user.LastName}"
                            };

                            DatabaseHelper.db.tblHistoryLogs.InsertOnSubmit(newLog);
                            DatabaseHelper.db.SubmitChanges();
                            MessageBox.Show(this, $"Item {selectedCategory.ItemCode} updated successfully!", "INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            btnUpdate.Text = "Update";
                            clearFields();
                            LoadActiveCategories();
                        }
                        else
                        {
                            MessageBox.Show(this, "Category description should not be empty!", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
        }

        private void LoadActiveCategories()
        {
            allCategories.Clear();
            allCategories = (from s in DatabaseHelper.db.tblCategories
                             where s.isActive == 1
                             select s).ToList();
            dgvCategories.Rows.Clear();
            foreach (var category in allCategories)
            {
                dgvCategories.Rows.Add(
                        category.ItemCode,
                        category.ItemDescription,
                        category.isActive
                    );
            }
            dgvCategories.ClearSelection();
        }

        private void LoadDeactivatedCategories()
        {
            allCategories.Clear();
            allCategories = (from s in DatabaseHelper.db.tblCategories
                             where s.isActive == 0
                             select s).ToList();
            dgvCategories.Rows.Clear();
            foreach (var category in allCategories)
            {
                dgvCategories.Rows.Add(
                        category.ItemCode,
                        category.ItemDescription,
                        category.isActive
                    );
            }
            dgvCategories.ClearSelection();
        }

        private void dgvCategories_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                itemCode = dgvCategories.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtItemCode.Text = itemCode;
                txtDescription.Text = dgvCategories.Rows[e.RowIndex].Cells[1].Value.ToString();

                selectedCategory = DatabaseHelper.db.tblCategories.FirstOrDefault(x => x.ItemCode.Equals(itemCode));
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult;
            if (btnAdd.Text.Equals("Save"))
            {
                dialogResult = MessageBox.Show(this, "Would you like to cancel adding new category?",
                   "QUESTION", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    clearFields();
                    btnAdd.Text = "Add";
                    btnClose.Text = "Close";
                }
            }
            else if (btnUpdate.Text.Equals("Save"))
            {
                dialogResult = MessageBox.Show(this, "Would you like to cancel updating category?",
                    "QUESTION", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    clearFields();
                    btnUpdate.Text = "Update";
                    btnClose.Text = "Close";
                }
            }
            else if (btnClose.Text.Equals("Close"))
            {
                if (txtDescription.Text.Length > 0)
                {
                    dialogResult = MessageBox.Show(this, "Would you like to exit?",
                        "QUESTION", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialogResult == DialogResult.Yes)
                    {
                        Close();
                    }
                }
                else
                {
                    Close();
                }
            }
        }

        private void cbShowDeactivatedItems_CheckedChanged(object sender, EventArgs e)
        {
            if (cbShowDeactivatedItems.Checked)
            {
                btnActivateDeactivate.Text = "Activate";
                LoadDeactivatedCategories();
            }
            else
            {
                btnActivateDeactivate.Text = "Deactivate";
                LoadActiveCategories();
            }
        }

        private void btnActivateDeactivate_Click(object sender, EventArgs e)
        {
            if (selectedCategory != null)
            {
                var activeStr = selectedCategory.isActive == 1 ? "Deactivate" : "Activate";

                var dialogResult = MessageBox.Show(this, $"Would you like to {activeStr} this category?",
                             "QUESTION", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    if (selectedCategory.isActive == 1)
                    {
                        selectedCategory.isActive = 0;
                    }
                    else
                    {
                        selectedCategory.isActive = 1;
                    }

                    var newLog = new tblHistoryLog
                    {
                        Action = $"{DatabaseHelper.user.LastName}({DatabaseHelper.user.ID}) " +
                        $"{activeStr}d category({selectedCategory.ItemCode})",
                        Type = LogType.CATEGORY.ToString(),
                        Date = new DateTimeOffset(DateTime.Now).ToUnixTimeMilliseconds(),
                        EditBy = $"{DatabaseHelper.user.FirstName} {DatabaseHelper.user.LastName}"
                    };

                    DatabaseHelper.db.tblHistoryLogs.InsertOnSubmit(newLog);
                    DatabaseHelper.db.SubmitChanges();
                    MessageBox.Show(this, $"Category {activeStr}d successfully!", "INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clearFields();
                    LoadActiveCategories();
                }
            }
        }
    }
}
