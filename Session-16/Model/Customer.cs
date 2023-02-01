using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Customer
    {
        public Guid CustomerID { get; set; }
        public string CustomerName { get; set; } = null!;
        public string CustomerSurname { get; set; } = null!;
        public string Phone { get; set; } = null!;
        public string TIN { get; set; } = null!;

        //relations
        public List<Transaction> Transactions { get; set; }
 

        public Customer()
        {
            CustomerID = Guid.NewGuid();
            Transactions=new List<Transaction>();
        }

    }

}
