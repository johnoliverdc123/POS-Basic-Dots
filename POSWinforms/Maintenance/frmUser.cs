using MetroSet_UI.Forms;
using POSWinforms.Maintenance;
using POSWinforms.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace POSWinforms
{
    public partial class frmUser : Form
    {

        private string username = "";
        private List<tblUser> userList = new List<tblUser>();

        private tblUser selectedUser = null;

        public frmUser()
        {
            InitializeComponent();

            cmbSearchFilter.SelectedIndex = 0;
            LoadAllUsers(null);
        }

        private void LoadAllUsers(string searchedUser)
        {
            var searchFilter = 0;
            if (cmbSearchFilter.SelectedIndex == 0)
                searchFilter = 1;


            userList.Clear();

            // Search dito yung mga active or not active users para yon lang yung lumabas sa datagrid.
            if (searchedUser == null)
            {
                userList = (from s in DatabaseHelper.db.tblUsers
                            where s.isActive == searchFilter
                            select s).ToList();
            }
            else
            {
                userList = (from s in DatabaseHelper.db.tblUsers
                            where s.isActive == searchFilter &&
                            SqlMethods.Like(s.FirstName, "%" + searchedUser + "%") ||
                            SqlMethods.Like(s.LastName, "%" + searchedUser + "%") ||
                            SqlMethods.Like(s.MiddleName, "%" + searchedUser + "%") ||
                            SqlMethods.Like(s.Position, "%" + searchedUser + "%") ||
                            SqlMethods.Like(s.Username, "%" + searchedUser + "%")
                            select s).ToList();
            }
            dgvUsers.Rows.Clear();
            foreach (var user in userList)
            {
                string fullName = $"{user.LastName}, {user.FirstName} {user.MiddleName}".Trim();
                dgvUsers.Rows.Add(
                        user.ID,
                        fullName,
                        user.Position,
                        user.Username,
                        user.Address,
                        user.ContactNo,
                        user.isActive
                    );
            }
            dgvUsers.ClearSelection();
            btnUpdate.Enabled = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var frm = new frmAddEditUser();
            frm.addUser();
            frm.ShowDialog();
            LoadAllUsers(null);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            tblUser user = userList.Where(x => x.Username.Equals(username)).FirstOrDefault();

            if (user != null)
            {
                var frm = new frmAddEditUser();
                frm.updateUser(user);
                frm.ShowDialog();
                LoadAllUsers(null);
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Text.Length == 0)
            {
                LoadAllUsers(null);
            }
            else if (txtSearch.Text.Length > 0)
            {
                LoadAllUsers(txtSearch.Text);
            }
        }

        private void dgvUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                username = dgvUsers.Rows[e.RowIndex].Cells["colUsername"].Value.ToString();
                string userId = dgvUsers.Rows[e.RowIndex].Cells["colID"].Value.ToString();
                selectedUser = userList.Find(u => u.ID == Convert.ToInt64(userId));

                var position = dgvUsers.Rows[e.RowIndex].Cells["colPosition"].Value.ToString().ToLower();
                Console.WriteLine(position);
                var isManager = !position.Equals("manager") && !position.Equals("admin");

                btnUpdate.Enabled = true;
                btnActiveDeactivate.Enabled = isManager;
            }
            else
            {
                selectedUser = null;
            }
        }

        private void cmbSearchFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSearchFilter.SelectedIndex == 1)
                btnActiveDeactivate.Text = "Activate";
            else
                btnActiveDeactivate.Text = "Deactivate";

            LoadAllUsers(null);
        }

        private void btnActiveDeactivate_Click(object sender, EventArgs e)
        {
            if (btnActiveDeactivate.Text.Equals("Activate"))
            {
                // Activate inactive users.
                if (selectedUser != null)
                {
                    if (MessageBox.Show("Do you want to activate this user?", "QUESTION", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                        == DialogResult.Yes)
                    {

                        if (selectedUser.isActive == 0)
                        {
                            selectedUser.isActive = 1;

                            var newLog = new tblHistoryLog
                            {
                                Action = $"{DatabaseHelper.user.LastName}({DatabaseHelper.user.ID}) " +
                                $"activated user({selectedUser.ID}) {selectedUser.FirstName} {selectedUser.LastName}",
                                Type = LogType.USER.ToString(),
                                Date = new DateTimeOffset(DateTime.Now).ToUnixTimeMilliseconds(),
                                EditBy = $"{DatabaseHelper.user.FirstName} {DatabaseHelper.user.LastName}"
                            };

                            DatabaseHelper.db.tblHistoryLogs.InsertOnSubmit(newLog);
                            DatabaseHelper.db.SubmitChanges();

                            MessageBox.Show("User activated successfully!", "INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("User failed to deactivate. Please try again.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

                }
                else
                {
                    MessageBox.Show("User cannot be empty.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (btnActiveDeactivate.Text.Equals("Deactivate"))
            {
                // Deactivate resigned users.
                if (selectedUser != null)
                {
                    if (selectedUser.ID == DatabaseHelper.user.ID)
                    {
                        MessageBox.Show("You cannot deactivate yourself.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    if (selectedUser.isActive == 1)
                    {
                        selectedUser.isActive = 0;

                        var newLog = new tblHistoryLog
                        {
                            Action = $"{DatabaseHelper.user.LastName}({DatabaseHelper.user.ID}) " +
                                $"deactivated user({selectedUser.ID}) {selectedUser.FirstName} {selectedUser.LastName}",
                            Type = LogType.USER.ToString(),
                            Date = new DateTimeOffset(DateTime.Now).ToUnixTimeMilliseconds(),
                            EditBy = $"{DatabaseHelper.user.FirstName} {DatabaseHelper.user.LastName}"
                        };

                        DatabaseHelper.db.tblHistoryLogs.InsertOnSubmit(newLog);
                        DatabaseHelper.db.SubmitChanges();

                        MessageBox.Show("User deactivated successfully!", "INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("User failed to deactivate. Please try again.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("User cannot be empty.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            LoadAllUsers(null);
        }
    }
}
