﻿using POSWinforms.Models;
using POSWinforms.Transaction;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace POSWinforms.Maintenance
{
    public partial class frmPayment : Form
    {

        private decimal total = 0;
        private decimal change = 1;
        private decimal serviceFee = 0;
        private decimal cash = 0;

        private DateTime dateNow;
        private string timeToday = "";

        private List<Item> itemList = new List<Item>();

        private bool hasService = false;

        public frmPayment()
        {
            InitializeComponent();

            cmbService.SelectedIndex = 1;
        }

        public void setTotal(decimal total, DateTime dateNow, string timeToday)
        {
            txtCash.Text = total.ToString();
            txtChange.Text = "0.00";

            this.total = total;
            this.dateNow = dateNow;
            this.timeToday = timeToday;
            txtTotal.Text = total.ToString("0.00");
            var allItems = from s in DatabaseHelper.db.tblItems
                           select s;
            foreach(var item in allItems)
            {
                itemList.Add(new Item
                {
                    ID = item.ID,
                    ItemNumber = item.ItemNumber,
                    ItemCode = item.ItemCode,
                    ItemDescription = item.ItemDescription,
                    Size = item.Size,
                    Price = item.Price,
                    Stocks = item.Stocks,
                    Committed = item.CommittedItem,
                    Sold = item.Sold,
                    Returned = item.Returned,
                    ReStockLevel = item.ReStockLevel,
                    IsActive = Convert.ToBoolean(item.isActive)
                });
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (change <= 0 && txtCash.Text.Length > 0)
            {
                DialogResult dr = MessageBox.Show("Do you really want to continue? You cannot undo this action", "QUESTION", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(dr == DialogResult.Yes)
                {
                    change = Math.Abs(change);

                    string dateString = dateNow.ToString("MM/dd/yyyy");

                    var newOrder = new tblOrder
                    {
                        CustomerID = frmTransaction.customerNo,
                        Status = PaymentStatus.PAID.ToString(),
                        Date = new DateTimeOffset(DateTime.Now).ToUnixTimeMilliseconds(),
                        Total = total,
                        HasService = Convert.ToInt32(hasService),
                        ServiceFee = Convert.ToDecimal(txtServiceFee.Text),
                        Cash = cash,
                        Change = change
                    };
                    DatabaseHelper.db.tblOrders.InsertOnSubmit(newOrder);
                    DatabaseHelper.db.SubmitChanges();

                    var st = (from tbl in itemList
                              join cart in DatabaseHelper.cartList on tbl.ItemCode equals cart.ItemCode
                              select new
                              {
                                  tbl.ItemCode,
                                  tbl.Stocks,
                                  tbl.Sold,
                                  cart.Quantity
                              }).ToList();

                    foreach (var item in st)
                    {
                        var reduceStock = (from s in DatabaseHelper.db.tblItems
                                           where s.ItemCode == item.ItemCode
                                           select s).First();

                        // Deduct stocks then add this to sold.
                        reduceStock.Stocks = (item.Stocks - item.Quantity);
                        reduceStock.Sold = (item.Sold + item.Quantity);

                    }

                    DatabaseHelper.db.SubmitChanges();


                    foreach (var item in DatabaseHelper.cartList)
                    {
                        var newOrderDetail = new tblOrderDetail
                        {
                            ItemCode = item.ItemCode,
                            ItemNumber = item.ItemNumber,
                            ItemDescription = item.ItemDescription,
                            Quantity = item.Quantity,
                            Price = item.Price,
                            Discount = item.Discount,
                            Total = item.Total,
                            OrderID = newOrder.ID
                        };
                        DatabaseHelper.db.tblOrderDetails.InsertOnSubmit(newOrderDetail);
                    }

                    var newLog = new tblHistoryLog
                    {
                        Action = $"{DatabaseHelper.user.LastName}({DatabaseHelper.user.ID}) " +
                        $"created new order({newOrder.ID})",
                        Type = LogType.ORDERS.ToString(),
                        Date = new DateTimeOffset(DateTime.Now).ToUnixTimeMilliseconds(),
                        EditBy = $"{DatabaseHelper.user.FirstName} {DatabaseHelper.user.LastName}"
                    };

                    DatabaseHelper.db.tblHistoryLogs.InsertOnSubmit(newLog);
                    DatabaseHelper.db.SubmitChanges();

                    decimal serviceFee = 0;
                    if(!string.IsNullOrWhiteSpace(txtServiceFee.Text))
                    {
                        serviceFee = Convert.ToDecimal(txtServiceFee.Text);
                    }

                    frmPrint frm = new frmPrint();
                    frm.printInvoice(
                           newOrder.ID,
                           frmTransaction.fullName,
                           dateNow,
                           total,
                           serviceFee,
                           cash,
                           change,
                           DatabaseHelper.cartList
                        );
                    MessageBox.Show("You can save this document", "INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frm.ShowDialog();
                    Close();
                }

            }
            else
            {
                MessageBox.Show("Please pay exact amount or more than the total amount", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtCash_TextChanged(object sender, EventArgs e)
        {
            if(decimal.TryParse(txtCash.Text, out decimal cash))
            {
                Decimal serviceFee = 0;

                if (!string.IsNullOrWhiteSpace(txtServiceFee.Text))
                {
                    serviceFee = Convert.ToDecimal(txtServiceFee.Text);
                }

                this.cash = cash;
                change = (total + serviceFee) - cash;
                txtChange.Text = change.ToString("0.00");
            }
            else
            {
                txtCash.Text = "";
            }
        }

        private void cmbService_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtServiceFee.Enabled = cmbService.SelectedIndex == 0;
            hasService = cmbService.SelectedIndex == 0;
        }

        private void txtServiceFee_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtServiceFee.Text))
            {
                e.Cancel = true;
                epMoney.SetError(txtServiceFee, "Please enter service fee!");
            }
            else if (!Regex.IsMatch(txtServiceFee.Text, @"^([0-9]{1,7})([.,][0-9]{1,2})?$"))
            {
                e.Cancel = true;
                epMoney.SetError(txtServiceFee, "Please input numbers only!");
            }
            else
            {
                e.Cancel = false;
                epMoney.SetError(txtServiceFee, null);
            }
        }

        private void txtCash_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCash.Text))
            {
                e.Cancel = true;
                epMoney.SetError(txtCash, "Please enter cost!");
            }
            else if (!Regex.IsMatch(txtCash.Text, @"^([0-9]{1,7})([.,][0-9]{1,2})?$"))
            {
                e.Cancel = true;
                epMoney.SetError(txtCash, "Please input numbers only!");
            }
            else
            {
                e.Cancel = false;
                epMoney.SetError(txtCash, null);
            }
        }

        private void txtServiceFee_TextChanged(object sender, EventArgs e)
        {
            serviceFee = 0;

            if (!string.IsNullOrWhiteSpace(txtServiceFee.Text))
            {
                try
                {
                    serviceFee = Convert.ToDecimal(txtServiceFee.Text);
                } catch(Exception ex)
                {
                    txtServiceFee.Text = "";
                }
            }

            var grandTotal = (total + serviceFee);

            cash = grandTotal;
            txtCash.Text = cash.ToString("0.00");

            change = grandTotal - cash;
            txtChange.Text = change.ToString("0.00");
        }
    }
}
