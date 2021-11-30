using System;
using POSWinforms.Models;
using System.Collections.Generic;

namespace POSWinforms.Transaction
{
    public partial class InvoiceCustomer : DevExpress.XtraReports.UI.XtraReport
    {
        public InvoiceCustomer()
        {
            InitializeComponent();
        }

        public void initData(
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
            pInvoiceNo.Value = invoiceNo;
            pCustomerName.Value = fullName;
            pDate.Value = date;
            pTotalAmt.Value = subTotal;
            pServiceFee.Value = serviceFee;
            pCash.Value = cash;
            pChange.Value = change;

            foreach (var item in cartList)
            {
                string[] firstWord = item.ItemDescription.Split(' ');
                item.ItemDescription = item.ItemCode + " " + firstWord[0];
            }

            objectDataSource1.DataSource = cartList;
        }

    }
}
