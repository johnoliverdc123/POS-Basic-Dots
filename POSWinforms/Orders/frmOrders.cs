using POSWinforms.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Linq.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace POSWinforms
{
    public partial class frmOrders : Form
    {
        private List<tblOrder> orderList = new List<tblOrder>();

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
                             select order).ToList();

            }
            else
            {
                orderList = (from order in DatabaseHelper.db.tblOrders
                             where SqlMethods.Like(order.ID.ToString(), "%" + searchedOrder + "%") ||
                             SqlMethods.Like(order.CustomerID.ToString(), "%" + searchedOrder + "%")
                             select order).ToList();

            }

            orderList = orderList.OrderByDescending(o => o.Date).ToList();

            foreach (var order in orderList)
            {
                var dateFromStamp = (new DateTime(1970, 1, 1)).AddMilliseconds(order.Date).ToLocalTime();

                var hasService = "No";
                if (order.HasService == 1)
                {
                    hasService = "Yes";
                }

                dgvOrders.Rows.Add(
                        order.ID,
                        order.CustomerID,
                        order.Status,
                        dateFromStamp,
                        order.Total.ToString("C2"),
                        hasService,
                        order.ServiceFee.ToString("C2"),
                        order.Cash.ToString("C2"),
                        order.Change.ToString("C2")
                    );
            }
            dgvOrders.ClearSelection();
        }

        private void loadAllOrdersWithDateRange()
        {
            orderList.Clear();
            dgvOrders.Rows.Clear();

            var startDateLong = new DateTimeOffset(dtpFromDate.Value).ToUnixTimeMilliseconds();
            var toDateLong = new DateTimeOffset(dtpToDate.Value).ToUnixTimeMilliseconds();

            orderList = (from order in DatabaseHelper.db.tblOrders
                         where ((new DateTime(1970, 1, 1, 0, 0, 0)).AddMilliseconds(order.Date).Date >=
                                    dtpFromDate.Value.Date &&
                                    (new DateTime(1970, 1, 1, 0, 0, 0)).AddMilliseconds(order.Date).Date <=
                                    dtpToDate.Value.Date)
                         select order).ToList();

            orderList = orderList.OrderByDescending(o => o.Date).ToList();

            foreach (var order in orderList)
            {
                var dateFromStamp = (new DateTime(1970, 1, 1, 0, 0, 0)).AddMilliseconds(order.Date).ToLocalTime();

                var hasService = "No";
                if (order.HasService == 1)
                {
                    hasService = "Yes";
                }

                dgvOrders.Rows.Add(
                        order.ID,
                        order.CustomerID,
                        order.Status,
                        dateFromStamp,
                        order.Total.ToString("C2"),
                        hasService,
                        order.ServiceFee.ToString("C2"),
                        order.Cash.ToString("C2"),
                        order.Change.ToString("C2")
                    );
            }
            dgvOrders.ClearSelection();
        }

        private void frmUser_Load(object sender, EventArgs e)
        {
            loadAllOrders(null);
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Text.Length == 0)
            {
                loadAllOrders(null);
            }
            else if (txtSearch.Text.Length > 0)
            {
                loadAllOrders(txtSearch.Text);
            }

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
            loadAllOrdersWithDateRange();
        }

        private void dtpFromDate_ValueChanged(object sender, EventArgs e)
        {
            startDate = dtpFromDate.Value;
            dtpToDate.MinDate = startDate.AddDays(1);
        }
    }
}
