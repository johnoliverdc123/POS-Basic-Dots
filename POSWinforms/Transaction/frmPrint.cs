using POSWinforms.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace POSWinforms.Transaction
{
    public partial class frmPrint : DevExpress.XtraEditors.XtraForm
    {
        public frmPrint()
        {
            InitializeComponent();
        }

        public void printInvoice(
            long invoiceNo,
            string customerId,
            DateTime date,
            decimal subTotal,
            decimal serviceFee,
            string serviceType,
            decimal cash,
            decimal change,
            List<OrderDetail> cartList,
            string customerName
            )
        {
            InvoiceCustomer report = new InvoiceCustomer();
            foreach (DevExpress.XtraReports.Parameters.Parameter p in report.Parameters)
                p.Visible = false;
            report.initData(invoiceNo, customerId, date, subTotal, serviceFee, serviceType, cash, change, cartList, customerName);
            documentViewer1.DocumentSource = report;
            report.CreateDocument();
        }

        private void frmPrint_FormClosing(object sender, FormClosingEventArgs e)
        {
            DatabaseHelper.cartList.Clear();
        }
    }
}