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
            string fullName,
            DateTime date,
            decimal subTotal,
            decimal serviceFee,
            decimal cash,
            decimal change,
            List<OrderDetail> cartList
            )
        {
            InvoiceCustomer report = new InvoiceCustomer();
            foreach (DevExpress.XtraReports.Parameters.Parameter p in report.Parameters)
                p.Visible = false;
            report.initData(invoiceNo, fullName, date, subTotal, serviceFee, cash, change, cartList);
            documentViewer1.DocumentSource = report;
            report.CreateDocument();
        }

        private void frmPrint_FormClosing(object sender, FormClosingEventArgs e)
        {
            DatabaseHelper.cartList.Clear();
        }
    }
}