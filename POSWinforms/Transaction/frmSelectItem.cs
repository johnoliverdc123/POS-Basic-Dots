﻿using POSWinforms.Maintenance;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using POSWinforms.Models;

namespace POSWinforms.Transaction
{
    public partial class frmSelectItem : Form
    {
        private static decimal subTotal = 0;
        private static decimal discountedTotal = 0;
        private int quantity = 1;
        private int discount = 0;
        private long nextID = 1;
        private tblItem item;

        public frmSelectItem()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void btnSelectItem_Click(object sender, EventArgs e)
        {
            var frm = new frmItem(false);
            frm.ShowDialog();
            if(DatabaseHelper.item != null)
            {
                item = DatabaseHelper.item;
                txtItemCode.Text = item.ItemCode;
                txtItemDescription.Text = item.ItemDescription;
                txtUnitPrice.Text = item.Price.ToString("0.00");
                quantitySelector.Maximum = item.Stocks;
                lbAvailStock.Text = $"(Available Stocks - {item.Stocks})";
                lbAvailStock.Visible = true;
                btnAddToCart.Enabled = true;
            }
        }

        private void quantitySelector_ValueChanged(object sender, EventArgs e)
        {
            if(quantitySelector.Value > 0)
            {
                quantity = (int)quantitySelector.Value;
            }
        }

        private void discountSelector_ValueChanged(object sender, EventArgs e)
        {
            if(discountSelector.Value > 0)
            {
                discount = (int)discountSelector.Value;
            }
            else
            {
                discount = 0;
            }
        }

        public static decimal getGrandTotal(decimal price, int quantity, int discount)
        {
            subTotal = price * quantity;
            if (discount > 0)
            {
                discountedTotal = subTotal - (subTotal * discount / 100);
            } else
            {
                discountedTotal = 0;
            }
            return subTotal;
        }

        public decimal getGrandTotalWithDesignPrice(decimal unitPrice, decimal designPrice, int quantity, int discount)
        {
            subTotal = (unitPrice + designPrice) * quantity;
            if (discount > 0)
            {
                discountedTotal = subTotal - (subTotal * discount / 100);
                txtDiscountedTotal.Text = discountedTotal.ToString();
            }
            else
            {
                discountedTotal = 0;
                txtDiscountedTotal.Text = discountedTotal.ToString();
            }
            return subTotal;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (item != null)
            {
                if (string.IsNullOrEmpty(txtDesignPrice.Text))
                {
                    txtTotal.Text = getGrandTotal(item.Price, quantity, discount).ToString("0.00");
                    txtDiscountedTotal.Text = discountedTotal.ToString("0.00");
                } else
                {
                    if(decimal.TryParse(txtDesignPrice.Text, out decimal designPrice))
                    {
                        txtTotal.Text = getGrandTotalWithDesignPrice(item.Price, designPrice, quantity, discount).ToString("0.00");
                    }
                }
            }
            
        }

        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            addToCart();
        }

        private void addToCart()
        {
            if (item != null)
            {

                OrderDetail isItemExisting = DatabaseHelper.cartList.Where(x => x.ItemCode.Equals(item.ItemCode)).FirstOrDefault();
                if (isItemExisting != null)
                {
                    isItemExisting.Quantity += quantity;
                    isItemExisting.Discount = discount;
                    isItemExisting.Total = getGrandTotal(item.Price, isItemExisting.Quantity, isItemExisting.Discount);
                }
                else
                {
                    decimal total = 0;

                    if(discountedTotal > 0)
                    {
                        total = discountedTotal;
                    } 
                    else
                    {
                        total = subTotal;
                    }

                    DatabaseHelper.cartList.Add(new OrderDetail
                    {
                        ID = nextID,
                        ItemCode = item.ItemCode,
                        ItemDescription = item.ItemDescription,
                        Size = item.Size,
                        Discount = discount,
                        Quantity = quantity,
                        Price = item.Price,
                        Total = total,
                        OrderID = 0,
                    });

                }
                Close();
            }
            else
            {
                MessageBox.Show(this, "No item was selected!", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void frmAddItem_Load(object sender, EventArgs e)
        {
            if(DatabaseHelper.cartList.Count > 0)
            {
                nextID = DatabaseHelper.cartList.OrderByDescending(x => x.ID).Select(x => x.ID).FirstOrDefault();
                nextID += 1;
            }
        }

        private void quantitySelector_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.F)
            {
                addToCart();
            }
        }

        private void discountSelector_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F)
            {
                addToCart();
            }
        }
    }
}
