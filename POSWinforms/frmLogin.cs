using MetroSet_UI.Forms;
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

namespace POSWinforms
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void txtUsername_Leave(object sender, EventArgs e)
        {
            if (txtUsername.Text.Equals(""))
            {
                txtUsername.Text = "Username";
            }
        }

        private void txtUsername_Enter(object sender, EventArgs e)
        {
            if(txtUsername.Text.Equals("Username"))
            {
                txtUsername.Text = "";
            }
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (txtPassword.Text.Equals("Password"))
            {
                txtPassword.UseSystemPasswordChar = true;
                txtPassword.Text = "";
            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text.Equals(""))
            {
                txtPassword.UseSystemPasswordChar = false;
                txtPassword.Text = "Password";
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            loginUser();
        }

        private void loginUser()
        {
            if (txtUsername.Text.Length == 0 || txtPassword.Text.Length == 0
                || txtUsername.Text.Equals("Username") || txtPassword.Text.Equals("Password"))
            {
                MessageBox.Show("Please enter your username and password.", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                var user = (from s in DatabaseHelper.db.tblUsers
                            where s.Username == txtUsername.Text
                            select s).FirstOrDefault();

                if(user.isActive == 0)
                {
                    MessageBox.Show("This account is deactivated. You cannot login anymore.", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                } else if(!user.Position.ToLower().Contains("admin") && !user.Position.ToLower().Contains("manager") && !user.Position.ToLower().Contains("cashier") && !user.Position.ToLower().Contains("inventory"))
                {
                    MessageBox.Show("This position is not part of the company. You cannot login.", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (user != null)
                {
                    if (user.Password.Equals(txtPassword.Text))
                    {
                        DatabaseHelper.user = new User()
                        {
                            ID = user.ID,
                            Address = user.Address,
                            ContactNo = user.ContactNo,
                            FirstName = user.FirstName,
                            LastName = user.LastName,
                            MiddleName = user.MiddleName,
                            Password = "",
                            Position = user.Position,
                            Username = user.Username,
                            IsActive = user.isActive
                        };
                        txtUsername.Text = "Username";
                        txtPassword.Text = "Password";
                        txtPassword.UseSystemPasswordChar = false;
                        metroSetControlBox1.Focus();

                        var newLog = new tblHistoryLog
                        {
                            Action = $"{DatabaseHelper.user.LastName}({DatabaseHelper.user.ID}) " +
                        $"logged in",
                            Type = LogType.LOGBOOK.ToString(),
                            Date = new DateTimeOffset(DateTime.Now).ToUnixTimeMilliseconds(),
                            EditBy = $"{DatabaseHelper.user.FirstName} {DatabaseHelper.user.LastName}"
                        };

                        DatabaseHelper.db.tblHistoryLogs.InsertOnSubmit(newLog);
                        DatabaseHelper.db.SubmitChanges();
                        new frmMain().Show();
                        Hide();
                    }
                    else
                    {
                        MessageBox.Show("Invalid username or password.", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Invalid username or password.", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void txtUsername_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                loginUser();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void cbShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if(cbShowPassword.Checked)
            {
                txtPassword.UseSystemPasswordChar = false;
            } else
            {
                txtPassword.UseSystemPasswordChar = true;
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}
