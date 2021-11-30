using MetroSet_UI.Forms;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace POSWinforms
{
    public partial class frmOrderDetail : Form
    {

        public frmOrderDetail()
        {
            InitializeComponent();
        }

        public void setOrderDetail(List<tblOrderDetail> orderDetails)
        {
            lbOrderId.Text = orderDetails.Select(s => s.OrderID).FirstOrDefault().ToString();
            dgvOrderDetails.Rows.Clear();
            foreach (var order in orderDetails)
            {
                dgvOrderDetails.Rows.Add(
                        order.ID,
                        order.ItemCode,
                        order.ItemNumber,
                        order.ItemDescription,
                        order.Quantity,
                        order.Price.ToString("C2"),
                        order.Discount,
                        order.Total.ToString("C2")
                    );
            }
            dgvOrderDetails.ClearSelection();
        }
    }
}
