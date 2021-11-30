using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSWinforms.Models
{
    public class OrderDetail
    {
        public long ID { get; set; }
        public string ItemCode { get; set; }
        public long ItemNumber { get; set; }
        public string ItemDescription { get; set; }
        public int Quantity { get; set; }

        public decimal Price { get; set; }
        public int Discount { get; set; }
        public decimal Total { get; set; }
        public long OrderID { get; set; }
    }
}
