using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegenCommerce.Model
{
    public class Customer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public decimal Balance { get; set; }
        public int TransactionsCount { get; set; }
        public bool IsActive { get; set; }
    }
}