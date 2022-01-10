using POSWinforms.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Linq.SqlClient;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace POSWinforms
{
    public partial class frmOrders : Form
    {
        private List<tblOrder> orderList = new List<tblOrder>();

        private List<DateTime> datesToEvaluate = new List<DateTime>();

        private DateTime startDate = DateTime.Now;

        public frmOrders()
        {
            InitializeComponent();

            dtpToDate.MinDate = startDate.AddDays(1);
        }

        private void loadAllOrders(string searchedOrder)
        {
            orderList.Clear();
            dgvOrders.Rows.Clear();

            if (searchedOrder == null)
            {
                orderList = (from order in DatabaseHelper.db.tblOrders
                             where datesToEvaluate.Contains(order.Date.Date)
                             select order).ToList();

            }
            else
            {
                orderList = (from order in DatabaseHelper.db.tblOrders
                             where datesToEvaluate.Contains(order.Date.Date) &&
                             SqlMethods.Like(order.ID.ToString(), "%" + searchedOrder + "%") || SqlMethods.Like(order.CustomerID.ToString(), "%" + searchedOrder + "%")
                             select order).ToList();

            }

            orderList = orderList.OrderByDescending(o => o.Date).ToList();

            foreach (var order in orderList)
            {

                var hasService = "No";
                if (order.HasService == 1)
                {
                    hasService = "Yes";
                }

                dgvOrders.Rows.Add(
                        order.ID,
                        order.CustomerID,
                        order.Status,
                        order.Date,
                        order.Total.ToString("C2"),
                        hasService,
                        order.ServiceFee?.ToString("C2"),
                        order.Cash.ToString("C2"),
                        order.Change.ToString("C2")
                    );
            }
            dgvOrders.ClearSelection();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                long selectedID = Convert.ToInt64(dgvOrders.Rows[e.RowIndex].Cells[0].Value);

                List<tblOrderDetail> orderDetails = (from orderDetail in DatabaseHelper.db.tblOrderDetails
                                                     where selectedID == orderDetail.OrderID
                                                     select orderDetail).ToList();
                frmOrderDetail frm = new frmOrderDetail();
                frm.setOrderDetail(orderDetails);
                frm.ShowDialog();
            }
        }

        private void btnWithDateRange_Click(object sender, EventArgs e)
        {
            datesToEvaluate.Clear();
            for (var dt = dtpFromDate.Value.Date; dt <= dtpToDate.Value.Date; dt = dt.AddDays(1))
            {
                datesToEvaluate.Add(dt.Date);
            }

            if(txtSearch.Text.Length > 3)
            {
                loadAllOrders(txtSearch.Text);
            } else
            {
                loadAllOrders(null);
            }
        }

        private void dtpFromDate_ValueChanged(object sender, EventArgs e)
        {
            startDate = dtpFromDate.Value;
            dtpToDate.MinDate = startDate.AddDays(1);
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if(dgvOrders.Rows.Count > 0)
            {
                DGVPrinter printer = new DGVPrinter();
                printer.Title = "Orders Report";
                printer.SubTitle = string.Format("Date: {0}", DateTime.Now.ToString("MM/dd/yyyy hh:mm:ss tt"));
                printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
                printer.PageNumbers = true;
                printer.PageNumberInHeader = false;
                printer.PorportionalColumns = true;
                printer.HeaderCellAlignment = StringAlignment.Near;
                printer.PrintDataGridView(dgvOrders);
            }
        }
    }
}
