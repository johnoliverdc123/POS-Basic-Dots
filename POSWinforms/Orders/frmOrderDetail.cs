using MetroSet_UI.Forms;
using POSWinforms.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace POSWinforms
{
    public partial class frmOrderDetail : Form
    {

        private tblOrder orderObj = new tblOrder();

        public frmOrderDetail()
        {
            InitializeComponent();
        }

        public void setOrderDetail(List<tblOrderDetail> orderDetails)
        {
            var orderId = orderDetails.Select(s => s.OrderID).FirstOrDefault();
            orderObj = (from s in DatabaseHelper.db.tblOrders
                            where s.ID == orderId
                            select s).FirstOrDefault();

            dgvOrderDetails.Rows.Clear();
            foreach (var order in orderDetails)
            {
                dgvOrderDetails.Rows.Add(
                    orderObj.CustomerID,
                        order.ID,
                        order.ItemCode,
                        order.ItemDescription,
                        order.Size,
                        order.Quantity,
                        order.Price.ToString("C2"),
                        order.Discount,
                        order.Total.ToString("C2")
                    );
            }
            dgvOrderDetails.ClearSelection();
        }

        private void btnPrint_Click(object sender, System.EventArgs e)
        {
            if (dgvOrderDetails.Rows.Count > 0)
            {
                DGVPrinter printer = new DGVPrinter();
                printer.Title = $"Order Details - {orderObj.CustomerID}";
                printer.SubTitle = string.Format("Date: {0}", DateTime.Now.ToString("MM/dd/yyyy hh:mm:ss tt"));
                printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
                printer.PageNumbers = true;
                printer.PageNumberInHeader = false;
                printer.PorportionalColumns = true;
                printer.HeaderCellAlignment = StringAlignment.Near;
                printer.PrintDataGridView(dgvOrderDetails);
            }
        }
    }
}
