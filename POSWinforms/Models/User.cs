using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSWinforms.Models
{
    public class User
    {
        public long ID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public string Position { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string ContactNo { get; set; }
        public int IsActive { get; set; }

    }
}
