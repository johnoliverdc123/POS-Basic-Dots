using POSWinforms.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Linq.SqlClient;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace POSWinforms.Maintenance
{
    public partial class frmItem : Form
    {

        private List<tblItem> itemList = new List<tblItem>();
        private string itemCode = "";

        private bool isTransactionMode = false;

        public frmItem()
        {
            InitializeComponent();

            cmbSearchFilter.SelectedIndex = 0;
            loadAllItems(null);
        }

        public frmItem(bool normalMode)
        {
            InitializeComponent();
            
            btnAdd.Visible = normalMode;
            btnUpdate.Visible = normalMode;
            btnStockIn.Visible = normalMode;
            dgvItems.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(dgvItems_CellDoubleClick);

            cmbSearchFilter.Enabled = false;
            isTransactionMode = true;
            loadAllItems(null);
        }

        private void loadAllItems(string searchItem)
        {
            itemList.Clear();
            dgvItems.Rows.Clear();

            var searchFilter = 0;
            if (cmbSearchFilter.SelectedIndex == 0)
                searchFilter = 1;

            // Search dito yung mga active or not active items para yon lang yung lumabas sa datagrid.
            if (isTransactionMode)
            {
                if (searchItem != null)
                {
                    itemList = (from s in DatabaseHelper.db.tblItems
                                where s.isActive == 1 &&
                                s.ItemCode == txtSearch.Text ||
                                SqlMethods.Like(s.ItemDescription, "%" + txtSearch.Text + "%")
                                select s).ToList();

                }
                else
                {
                    itemList = (from s in DatabaseHelper.db.tblItems
                                where s.isActive == 1
                                select s).ToList();
                }
            }
            else
            {
                if (searchItem != null)
                {
                    itemList = (from s in DatabaseHelper.db.tblItems
                                where s.isActive == searchFilter &&
                                s.ItemCode == txtSearch.Text ||
                                SqlMethods.Like(s.ItemDescription, "%" + txtSearch.Text + "%")
                                select s).ToList();

                }
                else
                {
                    itemList = (from s in DatabaseHelper.db.tblItems
                                where s.isActive == searchFilter
                                select s).ToList();
                }
            }

            // Sort all items by fast track to slow track.
            // Lahat ng items na 0 na yung stocks nasa ilalim na.
            itemList = itemList.OrderByDescending(i => i.Sold).ThenByDescending(i => i.Stocks).ToList();

            foreach (var item in itemList)
            {
                dgvItems.Rows.Add(
                        item.ItemNumber,
                        item.ItemCode,
                        item.ItemDescription,
                        item.Size,
                        item.Price.ToString("0.00"),
                        item.Stocks,
                        item.isActive,
                        item.supplierInformation,
                        item.Sold,
                        item.ReStockLevel
                    );
            }

            foreach (DataGridViewRow row in dgvItems.Rows)
            {
                row.DefaultCellStyle.ForeColor = Color.White;
                if (int.Parse(row.Cells["colStocks"].Value.ToString()) <= int.Parse(row.Cells["colRestockLvl"].Value.ToString()))
                {
                    row.DefaultCellStyle.BackColor = Color.OrangeRed;
                }
                else
                {
                    row.DefaultCellStyle.BackColor = Color.LightGreen;
                }
            }


            btnUpdate.Enabled = false;
            btnStockIn.Enabled = false;

            dgvItems.ClearSelection();
        }

        private void dgvItems_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                itemCode = dgvItems.Rows[e.RowIndex].Cells[1].Value.ToString();

                btnUpdate.Enabled = true;
                btnStockIn.Enabled = true;
                btnActivateDeactivate.Enabled = true;
            } 
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if(txtSearch.Text.Length == 0)
            {
                loadAllItems(null);
            }
            else
            {
                loadAllItems(txtSearch.Text);
            }
        }

        private void dgvItems_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                itemCode = dgvItems.Rows[e.RowIndex].Cells[1].Value.ToString();
                if (Convert.ToInt32(dgvItems.Rows[e.RowIndex].Cells["colStocks"].Value) > 0)
                {
                    DatabaseHelper.item = itemList.Where(x => x.ItemCode.Equals(itemCode)).FirstOrDefault();
                    Close();
                }
                else
                {
                    MessageBox.Show($"Item '{itemCode}' is not available anymore. Please select another item.", "WARNING",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var frm = new frmAddEditItem();
            frm.ShowDialog();
            loadAllItems(null);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            tblItem item = itemList.Where(x => x.ItemCode.Equals(itemCode)).FirstOrDefault();
            if (item != null)
            {
                var frm = new frmAddEditItem();
                frm.updateItem(item);
                frm.ShowDialog();
                loadAllItems(null);
            }
        }

        private void btnStockIn_Click(object sender, EventArgs e)
        {
            if (itemCode.Length > 0)
            {
                var frm = new frmItemStockEdit();
                frm.setItemCode(itemCode);
                frm.ShowDialog();
                loadAllItems(null);
            }
        }

        private void cmbSearchFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSearchFilter.SelectedIndex == 1)
                btnActivateDeactivate.Text = "Activate";
            else
                btnActivateDeactivate.Text = "Deactivate";

            itemCode = "";
            loadAllItems(null);
        }

        private void btnActivateDeactivate_Click(object sender, EventArgs e)
        {
            tblItem selectedItem = itemList.Find(i => i.ItemCode.Equals(itemCode));

            if (btnActivateDeactivate.Text.Equals("Activate"))
            {
                // Activate inactive items that is for sale again.
                if (selectedItem != null)
                {
                    if (selectedItem.isActive == 0)
                    {
                        selectedItem.isActive = 1;
                        DatabaseHelper.db.SubmitChanges();

                        MessageBox.Show("Item activated successfully!", "INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Item failed to activate!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Item cannot be empty.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (btnActivateDeactivate.Text.Equals("Deactivate"))
            {
                // Deactivate items that are not for sale anymore.
                if (selectedItem != null)
                {
                    if (selectedItem.isActive == 1)
                    {
                        selectedItem.isActive = 0;
                        DatabaseHelper.db.SubmitChanges();

                        MessageBox.Show("Item deactivated successfully!", "INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Item failed to deactivate!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Item cannot be empty.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            itemCode = "";
            loadAllItems(null);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
