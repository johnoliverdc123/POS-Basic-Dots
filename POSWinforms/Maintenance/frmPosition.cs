using POSWinforms.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace POSWinforms.Maintenance
{
    public partial class frmPosition : Form
    {

        private long ID;
        private List<tblPosition> positionList = new List<tblPosition>();

        public frmPosition()
        {
            InitializeComponent();

            LoadAllPositions();
            btnClose.Focus();
        }

        private void LoadAllPositions()
        {
            positionList.Clear();
            positionList = (from s in DatabaseHelper.db.tblPositions
                               select s).ToList();

            dgvPositions.Rows.Clear();
            foreach(var pos in positionList)
            {
                dgvPositions.Rows.Add(
                        pos.ID,
                        pos.PosDescription
                    );
            }
            dgvPositions.ClearSelection();
            dgvPositions.Enabled = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(btnAdd.Text.Equals("Add"))
            {
                btnAdd.Text = "Save";
                
                if(btnUpdate.Text.Equals("Save"))
                {
                    btnUpdate.Text = "Update";
                    txtDescription.Text = "";
                }

                txtDescription.Enabled = true;
                btnClose.Text = "Cancel";

                dgvPositions.ClearSelection();

                dgvPositions.Enabled = false;
                dgvPositions.CellClick -= new DataGridViewCellEventHandler(dgvPositions_CellClick);
                dgvPositions.ClearSelection();

                txtID.Enabled = false;
                var nextID = (from s in DatabaseHelper.db.tblPositions
                             orderby s.ID descending
                             select s.ID).FirstOrDefault();
                if(nextID > 0)
                {
                    long newID = nextID + 1;
                    txtID.Text = newID.ToString();
                }
                else
                {
                    txtID.Text = "1";
                }
            }
            else if(btnAdd.Text.Equals("Save"))
            {

                // Save new position here.
                if (ValidateChildren(ValidationConstraints.Enabled))
                {
                    if (!string.IsNullOrWhiteSpace(txtDescription.Text))
                    {
                        var newPos = new tblPosition
                        {
                            ID = long.Parse(txtID.Text),
                            PosDescription = txtDescription.Text
                        };

                        var newLog = new tblHistoryLog
                        {
                            Action = $"{DatabaseHelper.user.LastName}({DatabaseHelper.user.ID}) " +
                        $"added position({newPos.PosDescription})",
                            Type = LogType.POSITION.ToString(),
                            Date = new DateTimeOffset(DateTime.Now).ToUnixTimeMilliseconds(),
                            EditBy = $"{DatabaseHelper.user.FirstName} {DatabaseHelper.user.LastName}"
                        };

                        DatabaseHelper.db.tblHistoryLogs.InsertOnSubmit(newLog);
                        DatabaseHelper.db.tblPositions.InsertOnSubmit(newPos);
                        DatabaseHelper.db.SubmitChanges();

                        MessageBox.Show(this, "Position added successfully!", "INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnAdd.Text = "Add";
                        clearFields();
                        LoadAllPositions();
                    }
                    else
                    {
                        MessageBox.Show(this, "Position description should not be empty!", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
                 
        }

        public void clearFields()
        {
            txtID.Text = "";
            txtDescription.Text = "";
            btnClose.Text = "Close";
            txtDescription.Enabled = false;
            btnClose.Focus();
        }

        private void updatePosition()
        {
            btnUpdate.Text = "Update";
            var updatePosition = positionList.Where(x=> x.ID == ID).FirstOrDefault();

            if(updatePosition != null)
            {
                updatePosition.PosDescription = txtDescription.Text;

                var newLog = new tblHistoryLog
                {
                    Action = $"{DatabaseHelper.user.LastName}({DatabaseHelper.user.ID}) " +
                        $"updated position({updatePosition.ID}) to {updatePosition.PosDescription}",
                    Type = LogType.POSITION.ToString(),
                    Date = new DateTimeOffset(DateTime.Now).ToUnixTimeMilliseconds(),
                    EditBy = $"{DatabaseHelper.user.FirstName} {DatabaseHelper.user.LastName}"
                };

                DatabaseHelper.db.tblHistoryLogs.InsertOnSubmit(newLog);
                DatabaseHelper.db.SubmitChanges();
                MessageBox.Show(this, "Position with ID: " + txtID.Text + " was updated successfully!",
                    "UPDATE POSITION", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } 
            else
            {
                MessageBox.Show(this, "No ID is selected",
                    "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            clearFields();
            LoadAllPositions();
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
                txtDescription.Enabled = true;
                btnClose.Text = "Cancel";
                dgvPositions.Enabled = true;
                dgvPositions.CellClick += new DataGridViewCellEventHandler(dgvPositions_CellClick);
                dgvPositions.Rows[0].Selected = true;
                DataGridViewCellEventArgs f = new DataGridViewCellEventArgs(0, 0);
                dgvPositions_CellClick(sender, f);
            }
            else if(btnUpdate.Text.Equals("Save"))
            {
                DialogResult dialogResult = MessageBox.Show(this, "Would you like to update this position?",
                "QUESTION", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(dialogResult == DialogResult.Yes)
                {
                    if (ValidateChildren(ValidationConstraints.Enabled))
                    {
                        if(!string.IsNullOrWhiteSpace(txtDescription.Text))
                            updatePosition();
                        else
                            MessageBox.Show(this, "Position description should not be empty!", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }

        private void setPosition(DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                
                ID = long.Parse(dgvPositions.Rows[e.RowIndex].Cells[0].Value.ToString());

                txtID.Text = ID.ToString();
                txtDescription.Text = dgvPositions.Rows[e.RowIndex].Cells[1].Value.ToString();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult;
            if(btnAdd.Text.Equals("Save"))
            {
                 dialogResult = MessageBox.Show(this, "Would you like to cancel adding new position?",
                    "QUESTION", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(dialogResult == DialogResult.Yes)
                {
                    clearFields();
                    btnAdd.Text = "Add";
                    btnClose.Text = "Close";
                }
            }
            else if (btnUpdate.Text.Equals("Save"))
            {
                dialogResult = MessageBox.Show(this, "Would you like to cancel updating position?",
                    "QUESTION", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    clearFields();
                    btnUpdate.Text = "Update";
                    btnClose.Text = "Close";
                }
            }
            else if(btnClose.Text.Equals("Close"))
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

        private void txtDescription_Validating(object sender, CancelEventArgs e)
        {
            if (Regex.IsMatch(txtDescription.Text, @"^[0-9]+$"))
            {
                e.Cancel = true;
                txtDescription.Focus();
                errorProvider1.SetError(txtDescription, "Please input letters only!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtDescription, null);
            }
        }

        private void dgvPositions_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            setPosition(e);
        }
    }
}
