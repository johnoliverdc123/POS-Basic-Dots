using MetroSet_UI.Forms;
using POSWinforms.Models;
using POSWinforms.Transaction;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POSWinforms.Maintenance
{
    public partial class frmEditDiscount : Form
    {
        private int discount = 0;
        private OrderDetail editDiscount;

        public frmEditDiscount(OrderDetail selectedItem)
        {
            editDiscount = selectedItem;
            InitializeComponent();
            numericUpDown1.Value = editDiscount.Discount;
            discount = editDiscount.Discount;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                if (discount != editDiscount.Discount) {
                    editDiscount.Discount = discount;
                    editDiscount.Total = frmSelectItem.getGrandTotal(editDiscount.Price, editDiscount.Quantity, editDiscount.Discount);
                    Close();
                } else
                {
                    MessageBox.Show("Discount is still the same. Try changing it.", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            discount = int.Parse(numericUpDown1.Value.ToString());
        }

        private void frmEditDiscount_Load(object sender, EventArgs e)
        {
            numericUpDown1_ValueChanged(sender, e);
        }
    }
}
