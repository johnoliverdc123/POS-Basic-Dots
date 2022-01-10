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
    public partial class frmAddEditUser : Form
    {

        private string currentUsername = "";
        private tblUser selectedUser;

        private string contactNo = "";

        public frmAddEditUser()
        {
            InitializeComponent();

            var positions = from s in DatabaseHelper.db.tblPositions
                            where s.isActive == 1
                            select s;
            foreach(var pos in positions)
            {
                cmbPositions.Items.Add(pos.PosDescription);
            }
        }

        public void addUser()
        {
            txtStaffID.ReadOnly = true;
            var staffID = (from s in DatabaseHelper.db.tblUsers
                          orderby s.ID descending
                          select s.ID).FirstOrDefault();
            if(staffID > 0)
            {
                long newUser = staffID + 1;
                txtStaffID.Text = newUser.ToString();
            }
            else
            {
                txtStaffID.Text = "1";
            }
        }

        public void updateUser(tblUser user)
        {
            this.selectedUser = user;
            lbTitle.Text = "Update User";
            btnSave.Text = "Update";

            contactNo = user.ContactNo;

            currentUsername = user.Username;
            txtUsername.Enabled = false;
            txtStaffID.Text = user.ID.ToString();
            txtUsername.Text = user.Username;
            txtPassword.Text = user.Password;
            txtFirstName.Text = user.FirstName;
            txtLastName.Text = user.LastName;
            txtMI.Text = user.MiddleName;
            txtAddress.Text = user.Address;
            txtContactNo.Text = contactNo;
            cmbPositions.SelectedIndex = cmbPositions.Items.IndexOf(user.Position);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            saveUser();
        }

        private void saveUser()
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {

                if (btnSave.Text.Equals("Save"))
                {
                    var newUser = new tblUser
                    {
                        ID = long.Parse(txtStaffID.Text),
                        Username = txtUsername.Text,
                        Password = txtPassword.Text,
                        Position = cmbPositions.SelectedItem.ToString(),
                        FirstName = txtFirstName.Text,
                        MiddleName = txtMI.Text,
                        LastName = txtLastName.Text,
                        Address = txtAddress.Text,
                        ContactNo = contactNo,
                        isActive = 1
                    };

                    var newLog = new tblHistoryLog
                    {
                        Action = $"{DatabaseHelper.user.LastName}({DatabaseHelper.user.ID}) " +
                        $"added new user({newUser.ID})",
                        Type = LogType.USER.ToString(),
                        Date = new DateTimeOffset(DateTime.Now).ToUnixTimeMilliseconds(),
                        EditBy = $"{DatabaseHelper.user.FirstName} {DatabaseHelper.user.LastName}"
                    };

                    DatabaseHelper.db.tblHistoryLogs.InsertOnSubmit(newLog);
                    DatabaseHelper.db.tblUsers.InsertOnSubmit(newUser);
                    DatabaseHelper.db.SubmitChanges();
                    MessageBox.Show("User created successfully!", "INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
                else if (btnSave.Text.Equals("Update"))
                {

                    selectedUser.Username = txtUsername.Text;
                    selectedUser.Password = txtPassword.Text;
                    selectedUser.FirstName = txtFirstName.Text;
                    selectedUser.MiddleName = txtMI.Text;
                    selectedUser.LastName = txtLastName.Text;
                    selectedUser.Address = txtAddress.Text;
                    selectedUser.ContactNo = contactNo;
                    selectedUser.Position = cmbPositions.SelectedItem.ToString();

                    var newLog = new tblHistoryLog
                    {
                        Action = $"{DatabaseHelper.user.LastName}({DatabaseHelper.user.ID}) " +
                        $"updated user({selectedUser.ID})",
                        Type = LogType.USER.ToString(),
                        Date = new DateTimeOffset(DateTime.Now).ToUnixTimeMilliseconds(),
                        EditBy = $"{DatabaseHelper.user.FirstName} {DatabaseHelper.user.LastName}"
                    };

                    DatabaseHelper.db.tblHistoryLogs.InsertOnSubmit(newLog);
                    DatabaseHelper.db.SubmitChanges();
                    MessageBox.Show("User updated successfully!", "INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
            }
        }

        private void txtUsername_Validating(object sender, CancelEventArgs e)
        {
            var isUserUnique = (from s in DatabaseHelper.db.tblUsers
                                where s.Username == txtUsername.Text
                                select s).FirstOrDefault();
            if (string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtUsername, "Please enter your username!");
            }
            else if(txtUsername.Text.Length < 4)
            {
                e.Cancel = true;
                errorProvider1.SetError(txtUsername, "Username should be at least 4 characters long!");
            }
            else if (btnSave.Text.Equals("Update"))
            {
                if(isUserUnique != null && !currentUsername.Equals(isUserUnique.Username))
                {
                    e.Cancel = false;
                    txtUsername.Focus();
                    errorProvider1.SetError(txtUsername, "Username already exists, try another!");
                }
                else
                {
                    e.Cancel = false;
                    errorProvider1.SetError(txtUsername, null);
                }
            }
            else if (isUserUnique != null)
            {
                e.Cancel = true;
                errorProvider1.SetError(txtUsername, "Username already exists, try another!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtUsername, null);
            }
        }

        private void txtPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtPassword, "Please enter your password!");
            }
            else if (txtPassword.Text.Length < 8)
            {
                e.Cancel = true;
                errorProvider1.SetError(txtPassword, "Password must be at least 8 characters long!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtPassword, null);
            }
        }

        private void txtLastName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtLastName.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtLastName, "Please enter your last name!");
            }
            else if (Regex.IsMatch(txtLastName.Text, @"^[0-9]+$"))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtLastName, "Please input letters only!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtLastName, null);
            }
        }

        private void txtFirstName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFirstName.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtFirstName, "Please enter your first name!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtFirstName, null);
            }
        }

        private void txtMI_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMI.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtMI, "Please enter your middle initial!");
            }
            else if (Regex.IsMatch(txtMI.Text, @"^[0-9]+$"))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtMI, "Please input letters only!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtMI, null);
            }
        }

        private void txtContactNo_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtContactNo.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtContactNo, "Please enter your contact number!");
            }
            else if(Regex.IsMatch(txtContactNo.Text, @"^[a-zA-Z]+$"))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtContactNo, "Please input numbers only!");
            }
            else if(txtContactNo.Text.Length != 11)
            {
                e.Cancel = true;
                errorProvider1.SetError(txtContactNo, "Contact number should be 11 characters only!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtContactNo, null);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtAddress_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAddress.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtAddress, "Please enter your address!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtAddress, null);
            }
        }

        private void cmbPositions_Validating(object sender, CancelEventArgs e)
        {
            if (cmbPositions.SelectedIndex == -1)
            {
                e.Cancel = true;
                errorProvider1.SetError(cmbPositions, "Please select a position!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(cmbPositions, null);
            }
        }

        private void txtContactNo_TextChanged(object sender, EventArgs e)
        {
            if (long.TryParse(txtContactNo.Text, out long c))
            {
                this.contactNo = txtContactNo.Text;
            }
        }

        private void txtLastName_TextChanged(object sender, EventArgs e)
        {
            if(txtLastName.Text.Length > 0)
            {
                char[] lastCharacter = txtLastName.Text.ToCharArray();
                if(int.TryParse(lastCharacter[lastCharacter.Length - 1].ToString(), out int s))
                {
                    txtLastName.Text = "";
                    errorProvider1.SetError(txtLastName, "Please enter letters only!");
                }
            }
        }

        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {
            if (txtFirstName.Text.Length > 0)
            {
                char[] lastCharacter = txtFirstName.Text.ToCharArray();
                if (int.TryParse(lastCharacter[lastCharacter.Length - 1].ToString(), out int s))
                {
                    txtFirstName.Text = "";
                    errorProvider1.SetError(txtFirstName, "Please enter letters only!");
                }
            }
        }

        private void txtMI_TextChanged(object sender, EventArgs e)
        {
            if (txtMI.Text.Length > 0)
            {
                char[] lastCharacter = txtMI.Text.ToCharArray();
                if (int.TryParse(lastCharacter[lastCharacter.Length - 1].ToString(), out int s))
                {
                    txtMI.Text = "";
                    errorProvider1.SetError(txtMI, "Please enter letters only!");
                }
            }
        }

        private void frmAddEditUser_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                saveUser();
            }
        }

    }
}
