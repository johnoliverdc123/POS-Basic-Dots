using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSWinforms.Models
{
    public class ProductionAndTransaction
    {
        public long ID { get; set; }
        public string Status { get; set; }
        public DateTime timeStamp { get; set; }
        public decimal TransactionsGrandTotal { get; set; }
        public int TransactionsPerDate { get; set; }
    }
}
