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
            pInvoiceNo.Value = invoiceNo;
            pCustomerName.Value = customerName;
            pCustomerID.Value = customerId;
            pDate.Value = date.ToString("MM/dd/yyyy hh:mm:ss tt");

            pSubTotal.Value = (subTotal - serviceFee).ToString("0.00");
            pTotalAmt.Value = subTotal.ToString("0.00");
            pServiceFee.Value = serviceFee.ToString("0.00");
            pServiceType.Value = serviceType;
            pCash.Value = cash.ToString("0.00");
            pChange.Value = change.ToString("0.00");

            foreach (var item in cartList)
            {
                string[] firstWord = item.ItemDescription.Split(' ');
                item.ItemDescription = item.ItemCode + " " + firstWord[0];
            }

            objectDataSource1.DataSource = cartList;
        }

    }
}
