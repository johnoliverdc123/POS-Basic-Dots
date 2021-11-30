using MetroSet_UI.Forms;
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

        public frmCategory()
        {
            InitializeComponent();
            LoadAllCategories();
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
            txtItemCode.Enabled = false;
            txtDescription.Enabled = false;
            btnClose.Text = "Close";
            btnClose.Focus();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (btnAdd.Text.Equals("Add"))
            {
                btnAdd.Text = "Save";
                if (btnUpdate.Text.Equals("Save"))
                {
                    btnUpdate.Text = "Update";
                    
                }
                txtItemCode.Text = "";
                txtDescription.Text = "";
                txtItemCode.Enabled = true;
                txtDescription.Enabled = true;
                btnClose.Text = "Cancel";
                dgvCategories.ClearSelection();
                dgvCategories.Enabled = false;
                dgvCategories.CellClick -= new DataGridViewCellEventHandler(dgvCategories_CellClick);
                dgvCategories.ClearSelection();
            }
            else if (btnAdd.Text.Equals("Save"))
            {

                // Save new category here.
                if (ValidateChildren(ValidationConstraints.Enabled))
                {
                    if (!string.IsNullOrWhiteSpace(txtDescription.Text))
                    {
                        var newCategory = new tblCategory
                        {
                            ItemCode = txtItemCode.Text,
                            ItemDescription = txtDescription.Text
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
                        LoadAllCategories();
                    }
                    else
                    {
                        MessageBox.Show(this, "Category description should not be empty!", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if(btnUpdate.Text.Equals("Update"))
            {
                btnUpdate.Text = "Save";
                if (btnAdd.Text.Equals("Save"))
                {
                    btnAdd.Text = "Add";
                }
                txtItemCode.Enabled = false;
                txtDescription.Enabled = true;
                txtItemCode.Text = "";
                txtDescription.Text = "";

                btnClose.Text = "Cancel";
                dgvCategories.Enabled = true;
                dgvCategories.CellClick += new DataGridViewCellEventHandler(dgvCategories_CellClick);
                dgvCategories.Rows[0].Selected = true;
                DataGridViewCellEventArgs f = new DataGridViewCellEventArgs(0, 0);
                dgvCategories_CellClick(sender, f);
            }
            else if (btnUpdate.Text.Equals("Save"))
            {
                if (string.IsNullOrWhiteSpace(txtDescription.Text))
                {
                    MessageBox.Show(this, "Please enter new description and do not leave that field empty.", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                var updateCategory = allCategories.Where(x => x.ItemCode.Equals(itemCode)).FirstOrDefault();
                if (updateCategory != null)
                {
                    DialogResult dialogResult = MessageBox.Show(this, "Would you like to update this category?",
                        "QUESTION", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialogResult == DialogResult.Yes)
                    {
                        if (ValidateChildren(ValidationConstraints.Enabled))
                        {
                            if (!string.IsNullOrWhiteSpace(txtDescription.Text))
                            {
                                updateCategory.ItemDescription = txtDescription.Text;

                                var newLog = new tblHistoryLog
                                {
                                    Action = $"{DatabaseHelper.user.LastName}({DatabaseHelper.user.ID}) " +
                        $"updated category({updateCategory.ItemCode})",
                                    Type = LogType.CATEGORY.ToString(),
                                    Date = new DateTimeOffset(DateTime.Now).ToUnixTimeMilliseconds(),
                                    EditBy = $"{DatabaseHelper.user.FirstName} {DatabaseHelper.user.LastName}"
                                };

                                DatabaseHelper.db.tblHistoryLogs.InsertOnSubmit(newLog);
                                DatabaseHelper.db.SubmitChanges();
                                MessageBox.Show(this, "Item '" + updateCategory.ItemCode + "' successfully!", "INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                btnUpdate.Text = "Update";
                                clearFields();
                                LoadAllCategories();
                            }
                            else
                            {
                                MessageBox.Show(this, "Category description should not be empty!", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                    }
                    
                }
                
                
            }
        }

        private void LoadAllCategories()
        {
            allCategories.Clear();
            allCategories = (from s in DatabaseHelper.db.tblCategories
                                select s).ToList();
            dgvCategories.Rows.Clear();
            foreach(var category in allCategories)
            {
                dgvCategories.Rows.Add(
                        category.ItemCode,
                        category.ItemDescription
                    );
            }
            dgvCategories.ClearSelection();
            dgvCategories.Enabled = false;
        }

        private void dgvCategories_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                itemCode = dgvCategories.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtItemCode.Text = itemCode;
                txtDescription.Text = dgvCategories.Rows[e.RowIndex].Cells[1].Value.ToString();
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
    }
}
