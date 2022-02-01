using MetroSet_UI.Forms;
using POSWinforms.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POSWinforms.Maintenance
{
    public partial class frmAddEditItem : Form
    {

        private string itemCode = "";
        private string sizeType = "";
        private string category = "";
        private decimal unitPrice = 0;
        private int quantity = 0;
        private int restockLevel = 0;
        private long newItemNo = 1;
        private tblItem item;
        private List<tblCategory> categories = new List<tblCategory>();
        public frmAddEditItem()
        {
            InitializeComponent();

            categories = (from s in DatabaseHelper.db.tblCategories
                          where s.isActive == 1
                          select s).ToList();
            foreach (var category in categories)
            {
                cmbCategory.Items.Add(category.ItemDescription);
            }
        }

        public void updateItem(tblItem item)
        {
            this.item = item;
            lbTitle.Text = "Update Item";
            btnSave.Text = "Update";
            cmbCategory.Enabled = false;
            txtCode.Enabled = false;

            string[] descriptionFromCode = item.ItemCode.Split('-');
            string description = categories.Where(x => x.ItemCode.Equals(descriptionFromCode[0])).Select(x => x.ItemDescription).FirstOrDefault();
            cmbCategory.SelectedIndex = cmbCategory.Items.IndexOf(description);

            unitPrice = item.Price;
            quantity = item.Stocks;
            restockLevel = item.ReStockLevel;

            txtCode.Text = item.ItemCode;
            txtDescription.Text = item.ItemDescription;
            txtSize.Text = item.Size;
            txtUnitPrice.Text = unitPrice.ToString();
            txtQuantity.Text = quantity.ToString();
            txtReProduceLevel.Text = restockLevel.ToString();
            txtSupplierInformation.Text = item.supplierInformation;
        }

        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCategory.SelectedIndex >= 0)
            {
                var selectedCategory = categories[cmbCategory.SelectedIndex];
                category = selectedCategory.ItemDescription;

                string letterCode = selectedCategory.ItemCode;
                var itemNo = (from s in DatabaseHelper.db.tblItems
                              where SqlMethods.Like(s.ItemCode, "%" + letterCode + "%")
                              orderby s.ItemCode descending
                              select s.ItemNumber).FirstOrDefault();
                if (itemNo > 0)
                {
                    newItemNo = itemNo + 1;
                }
                else
                {
                    newItemNo = 1;
                }
                txtCode.Text = letterCode + "-" + newItemNo.ToString("000");
                itemCode = letterCode + "-" + newItemNo.ToString("000");

                txtDescription.Text = selectedCategory.ItemDescription;

                sizeType = "";
                txtSize.Text = "";
                cmbSize.Items.Clear();

                cmbSize.Text = "";
                cmbCategory.Text = "";
                txtUnitPrice.Text = "";

                if (selectedCategory.SizeType.Equals("PANTS"))
                {
                    txtSize.Enabled = false;
                    cmbSize.Enabled = true;

                    sizeType = selectedCategory.SizeType;

                    foreach (var size in DatabaseHelper.pantSizes)
                    {
                        cmbSize.Items.Add(size.Size);
                    }
                    cmbSize.SelectedIndex = 0;
                }
                else if (selectedCategory.SizeType.Equals("SHIRT"))
                {
                    txtSize.Enabled = false;
                    cmbSize.Enabled = true;

                    sizeType = selectedCategory.SizeType;

                    foreach (var size in DatabaseHelper.shirtSizes)
                    {
                        cmbSize.Items.Add(size.Size);
                    }
                    cmbSize.SelectedIndex = 0;
                }
                else if (selectedCategory.SizeType.Equals("MUGS"))
                {
                    txtSize.Enabled = false;
                    cmbSize.Enabled = true;

                    sizeType = selectedCategory.SizeType;

                    foreach (var size in DatabaseHelper.mugTypes)
                    {
                        cmbSize.Items.Add(size.Size);
                    }
                    cmbSize.SelectedIndex = 0;
                }
                else
                {
                    txtSize.Enabled = true;
                    cmbSize.Enabled = false;
                }
            }
        }

        private void txtDescription_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDescription.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtDescription, "Please enter item description!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtDescription, null);
            }
        }

        private void txtSize_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSize.Text) && txtSize.Enabled)
            {
                e.Cancel = true;
                errorProvider1.SetError(txtSize, "Please enter item size!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtSize, null);
            }
        }

        private void txtQuantity_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtQuantity.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtQuantity, "Please enter item quantity!");
            }
            else if (!int.TryParse(txtQuantity.Text, out int j))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtQuantity, "Quantity should be number!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtQuantity, null);
            }
        }

        private void txtUnitPrice_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUnitPrice.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtUnitPrice, "Please enter item price!");
            }
            else if (!double.TryParse(txtUnitPrice.Text, out double j))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtUnitPrice, "Unit Price should be number ex. 12.50!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtUnitPrice, null);
            }
        }

        private void txtReProduceLevel_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtReProduceLevel.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtReProduceLevel, "Please enter item re-produce level!");
            }
            else if (!int.TryParse(txtReProduceLevel.Text, out int j))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtReProduceLevel, "Reproduce Level should be number ex. 10!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtReProduceLevel, null);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            saveItem();
        }

        private void saveItem()
        {
            if (cmbCategory.SelectedIndex < 0)
            {
                MessageBox.Show("Please choose a category!", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                if (btnSave.Text.Equals("Save"))
                {

                    var sizeStr = "";

                    if (!string.IsNullOrEmpty(txtSize.Text))
                    {
                        sizeStr = txtSize.Text;
                    }
                    else if(!string.IsNullOrEmpty(cmbSize.SelectedItem.ToString()))
                    {
                        sizeStr = cmbSize.SelectedItem.ToString();
                    } 
                    else
                    {
                        MessageBox.Show("You cannot add an item without size.", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    var isSizeExisting = (from s in DatabaseHelper.db.tblItems
                                          where sizeStr.Equals(s.Size) && s.ItemCategory.ToLower().Equals(category.ToLower())
                                          select s).FirstOrDefault();

                    if (isSizeExisting != null)
                    {
                        MessageBox.Show("You cannot add an item with the same size and category.", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    else
                    {

                        var newItem = new tblItem
                        {
                            ItemNumber = newItemNo,
                            ItemCode = itemCode,
                            ItemCategory = category,
                            ItemDescription = txtDescription.Text,
                            Size = sizeStr,
                            Price = unitPrice,
                            Stocks = quantity,
                            Sold = 0,
                            ReStockLevel = restockLevel,
                            isActive = 1,
                            supplierInformation = txtSupplierInformation.Text
                        };

                        var newLog = new tblHistoryLog
                        {
                            Action = $"{DatabaseHelper.user.LastName}({DatabaseHelper.user.ID}) " +
                            $"new item({newItem.ItemCode}) {newItem.ItemDescription}",
                            Type = LogType.PRODUCT.ToString(),
                            Date = DateTime.Now,
                            EditBy = $"{DatabaseHelper.user.FirstName} {DatabaseHelper.user.LastName}",
                            SupplierInformation = txtSupplierInformation.Text
                        };

                        DatabaseHelper.db.tblHistoryLogs.InsertOnSubmit(newLog);
                        DatabaseHelper.db.tblItems.InsertOnSubmit(newItem);
                        DatabaseHelper.db.SubmitChanges();
                        MessageBox.Show("Item added successfully!", "INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Close();
                    }

                }
                else if (btnSave.Text.Equals("Update"))
                {
                    var sizeStr = "";

                    if (!string.IsNullOrEmpty(txtSize.Text))
                    {
                        sizeStr = txtSize.Text;
                    }
                    else if (!string.IsNullOrEmpty(cmbSize.SelectedItem.ToString()))
                    {
                        sizeStr = cmbSize.SelectedItem.ToString();
                    }
                    else
                    {
                        MessageBox.Show("You cannot add an item without size.", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    item.ItemDescription = txtDescription.Text;
                    item.Size = sizeStr;
                    item.ReStockLevel = restockLevel;
                    item.Stocks = quantity;
                    item.Price = unitPrice;
                    item.supplierInformation = txtSupplierInformation.Text;

                    var newLog = new tblHistoryLog
                    {
                        Action = $"{DatabaseHelper.user.LastName}({DatabaseHelper.user.ID}) " +
                        $"updated item({item.ItemNumber})",
                        Type = LogType.PRODUCT.ToString(),
                        Date = DateTime.Now,
                        EditBy = $"{DatabaseHelper.user.FirstName} {DatabaseHelper.user.LastName}",
                        SupplierInformation = txtSupplierInformation.Text
                    };

                    DatabaseHelper.db.tblHistoryLogs.InsertOnSubmit(newLog);
                    DatabaseHelper.db.SubmitChanges();
                    MessageBox.Show("Item updated successfully!", "INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
            }
        }

        private void cmbCategory_Validating(object sender, CancelEventArgs e)
        {
            if (cmbCategory.SelectedIndex < 0)
            {
                e.Cancel = true;
                errorProvider1.SetError(cmbCategory, "Please choose a category!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(cmbCategory, null);
            }
        }

        private void txtUnitPrice_TextChanged(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtUnitPrice.Text, out decimal price))
            {
                this.unitPrice = price;
            }
            else
            {
                txtUnitPrice.Text = "";
            }
        }

        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(txtQuantity.Text, out int qty))
            {
                this.quantity = qty;
            }
            else
            {
                txtQuantity.Text = "";
            }
        }

        private void txtReProduceLevel_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(txtReProduceLevel.Text, out int level))
            {
                this.restockLevel = level;
            }
            else
            {
                txtReProduceLevel.Text = "";
            }
        }

        private void txtReProduceLevel_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                saveItem();
            }
        }

        private void cmbSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (sizeType.Equals("PANTS"))
            {
                txtUnitPrice.Text = DatabaseHelper.pantSizes[cmbSize.SelectedIndex].Price.ToString();
            }
            else if (sizeType.Equals("SHIRT"))
            {
                txtUnitPrice.Text = DatabaseHelper.shirtSizes[cmbSize.SelectedIndex].Price.ToString();
            }
            else if (sizeType.Equals("MUGS"))
            {
                txtUnitPrice.Text = DatabaseHelper.mugTypes[cmbSize.SelectedIndex].Price.ToString();
            }
        }
    }
}
