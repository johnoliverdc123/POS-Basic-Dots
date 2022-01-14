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

        private tblPosition selectedPosition = null;

        public frmPosition()
        {
            InitializeComponent();

            LoadActivePositions();
            btnClose.Focus();
        }

        private void LoadActivePositions()
        {
            positionList.Clear();
            positionList = (from s in DatabaseHelper.db.tblPositions
                            where s.isActive == 1
                               select s).ToList();

            dgvPositions.Rows.Clear();
            foreach(var pos in positionList)
            {
                dgvPositions.Rows.Add(
                        pos.ID,
                        pos.PosDescription,
                        pos.isActive
                    );
            }
            dgvPositions.ClearSelection();
        }

        private void LoadDeactivatedPositions()
        {
            positionList.Clear();
            positionList = (from s in DatabaseHelper.db.tblPositions
                            where s.isActive == 0
                            select s).ToList();

            dgvPositions.Rows.Clear();
            foreach (var pos in positionList)
            {
                dgvPositions.Rows.Add(
                        pos.ID,
                        pos.PosDescription,
                        pos.isActive
                    );
            }
            dgvPositions.ClearSelection();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Save new position here.
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                if(string.IsNullOrWhiteSpace(txtDescription.Text))
                {
                    MessageBox.Show("Please fill the form.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var isPositionExisting = (from s in DatabaseHelper.db.tblPositions
                                          where s.PosDescription.ToLower().Equals(txtDescription.Text.ToLower())
                                          select s).FirstOrDefault();

                if(isPositionExisting != null)
                {
                    MessageBox.Show(this, "Position is already existing in database", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!string.IsNullOrWhiteSpace(txtDescription.Text))
                {
                    var newPos = new tblPosition
                    {
                        PosDescription = txtDescription.Text,
                        isActive = 1
                    };

                    var newLog = new tblHistoryLog
                    {
                        Action = $"{DatabaseHelper.user.LastName}({DatabaseHelper.user.ID}) " +
                    $"added position({newPos.PosDescription})",
                        Type = LogType.POSITION.ToString(),
                        Date = DateTime.Now,
                        EditBy = $"{DatabaseHelper.user.FirstName} {DatabaseHelper.user.LastName}"
                    };

                    DatabaseHelper.db.tblHistoryLogs.InsertOnSubmit(newLog);
                    DatabaseHelper.db.tblPositions.InsertOnSubmit(newPos);
                    DatabaseHelper.db.SubmitChanges();

                    MessageBox.Show(this, "Position added successfully!", "INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnAdd.Text = "Add";
                    clearFields();
                    LoadActivePositions();
                }
                else
                {
                    MessageBox.Show(this, "Position description should not be empty!", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        public void clearFields()
        {
            txtID.Text = "";
            txtDescription.Text = "";
            btnClose.Text = "Close";
            btnClose.Focus();

            selectedPosition = null;
            btnActivateDeactivate.Text = "Deactivate";
            cbShowDeactivatedItems.Checked = false;
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
                    Date = DateTime.Now,
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
            LoadActivePositions();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            
            if(btnUpdate.Text.Equals("Update"))
            {
                btnUpdate.Text = "Save";
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

                selectedPosition = DatabaseHelper.db.tblPositions.FirstOrDefault(x => x.ID == ID);

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

        private void cbShowDeactivatedItems_CheckedChanged(object sender, EventArgs e)
        {
            if(cbShowDeactivatedItems.Checked)
            {
                btnActivateDeactivate.Text = "Activate";
                LoadDeactivatedPositions();
            } 
            else
            {
                btnActivateDeactivate.Text = "Deactivate";
                LoadActivePositions();
            }
        }

        private void btnActivateDeactivate_Click(object sender, EventArgs e)
        {
            if(selectedPosition != null)
            { 
                var activeStr = selectedPosition.isActive == 1 ? "Deactivate" : "Activate";

                var dialogResult = MessageBox.Show(this, $"Would you like to {activeStr} this position?",
                             "QUESTION", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    if (selectedPosition.isActive == 1)
                    {
                        selectedPosition.isActive = 0;
                    }
                    else
                    {
                        selectedPosition.isActive = 1;
                    }

                    var newLog = new tblHistoryLog
                    {
                        Action = $"{DatabaseHelper.user.LastName}({DatabaseHelper.user.ID}) " +
                        $"${activeStr}d position({selectedPosition.PosDescription})",
                        Type = LogType.POSITION.ToString(),
                        Date = DateTime.Now,
                        EditBy = $"{DatabaseHelper.user.FirstName} {DatabaseHelper.user.LastName}"
                    };

                    DatabaseHelper.db.tblHistoryLogs.InsertOnSubmit(newLog);
                    DatabaseHelper.db.SubmitChanges();
                    MessageBox.Show(this, $"Position {activeStr}d successfully!", "INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clearFields();
                    LoadActivePositions();
                }
            }
        }
    }
}
