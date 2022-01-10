using POSWinforms.Models;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace POSWinforms.Expenses
{
    public partial class frmAddEditExpenseType : Form
    {

        tblExpenseType selectedItem = null;

        public frmAddEditExpenseType()
        {
            InitializeComponent();

            LoadAllExpenseType();
        }

        private void LoadAllExpenseType()
        {
            dgvExpenseTypes.Rows.Clear();

            var expenseTypes = (from s in DatabaseHelper.db.tblExpenseTypes
                                select s).ToList();

            foreach(var item in expenseTypes)
            {
                dgvExpenseTypes.Rows.Add(
                        item.ID,
                        item.Type
                    );
            }

            dgvExpenseTypes.ClearSelection();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(txtType.Text.Length > 3)
            {
                var isExisting = DatabaseHelper.db.tblExpenseTypes.FirstOrDefault(x => x.Type.Equals(txtType.Text));
                if(isExisting != null)
                {
                    MessageBox.Show("Expense Type is already existing in the database", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var newExpenseType = new tblExpenseType
                {
                    Type = txtType.Text
                };

                var newLog = new tblHistoryLog
                {
                    Action = $"{DatabaseHelper.user.LastName}({DatabaseHelper.user.ID}) " +
                        $"added expense type ({txtType.Text}).",
                    Type = LogType.EXPENSE_TYPE.ToString(),
                    Date = new DateTimeOffset(DateTime.Now).ToUnixTimeMilliseconds(),
                    EditBy = $"{DatabaseHelper.user.FirstName} {DatabaseHelper.user.LastName}"
                };

                DatabaseHelper.db.tblHistoryLogs.InsertOnSubmit(newLog);
                DatabaseHelper.db.tblExpenseTypes.InsertOnSubmit(newExpenseType);
                DatabaseHelper.db.SubmitChanges();
                MessageBox.Show($"Expense Type {txtType.Text} added successfully", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadAllExpenseType();
                clearFields();
            } 
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            this.dgvExpenseTypes.CellClick += new DataGridViewCellEventHandler(this.dgvExpenseTypes_CellClick);
            

            if(btnUpdate.Text.Equals("Save"))
            {
                selectedItem.Type = txtType.Text;

                var newLog = new tblHistoryLog
                {
                    Action = $"{DatabaseHelper.user.LastName}({DatabaseHelper.user.ID}) " +
                        $"updated expense type ({selectedItem.Type}).",
                    Type = LogType.EXPENSE_TYPE.ToString(),
                    Date = new DateTimeOffset(DateTime.Now).ToUnixTimeMilliseconds(),
                    EditBy = $"{DatabaseHelper.user.FirstName} {DatabaseHelper.user.LastName}"
                };

                DatabaseHelper.db.tblHistoryLogs.InsertOnSubmit(newLog);
                DatabaseHelper.db.SubmitChanges();
                MessageBox.Show($"Expense Type {selectedItem.Type} updated successfully", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadAllExpenseType();
                btnUpdate.Text = "Update";
                selectedItem = null;

                this.dgvExpenseTypes.CellClick -= new DataGridViewCellEventHandler(this.dgvExpenseTypes_CellClick);
                btnAdd.Enabled = true;
                btnDelete.Enabled = true;
                clearFields();
            } else if(btnUpdate.Text.Equals("Update"))
            {
                btnUpdate.Text = "Save";
                btnAdd.Enabled = false;
                btnDelete.Enabled = false;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var newLog = new tblHistoryLog
            {
                Action = $"{DatabaseHelper.user.LastName}({DatabaseHelper.user.ID}) " +
                        $"deleted expense type ({selectedItem.Type}).",
                Type = LogType.EXPENSE_TYPE.ToString(),
                Date = new DateTimeOffset(DateTime.Now).ToUnixTimeMilliseconds(),
                EditBy = $"{DatabaseHelper.user.FirstName} {DatabaseHelper.user.LastName}"
            };

            DatabaseHelper.db.tblHistoryLogs.InsertOnSubmit(newLog);
            DatabaseHelper.db.tblExpenseTypes.DeleteOnSubmit(selectedItem);
            DatabaseHelper.db.SubmitChanges();
            MessageBox.Show($"Expense Type {selectedItem.Type} deleted successfully", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadAllExpenseType();
            selectedItem = null;
            clearFields();
        }

        private void dgvExpenseTypes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                var id = Convert.ToInt64(dgvExpenseTypes.Rows[e.RowIndex].Cells[0].Value.ToString());

                selectedItem = DatabaseHelper.db.tblExpenseTypes.FirstOrDefault(x => x.ID == id);

                txtID.Text = selectedItem.ID.ToString();
                txtType.Text = selectedItem.Type;
            }
        }

        private void clearFields()
        {
            txtID.Clear();
            txtType.Clear();
        }
    }
}
