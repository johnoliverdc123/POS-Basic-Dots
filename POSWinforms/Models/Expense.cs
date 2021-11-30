using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSWinforms.Models
{
    public class Expense
    {
        public long ID { get; set; }
        public string ExpenseType { get; set; }
        public decimal GrandTotal { get; set; }
        public DateTime TimeStamp { get; set; }
    }
}
