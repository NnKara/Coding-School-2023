using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_11
{
    public class Customer : Person
    {
        public Guid CustomerID { get; set; }
        public string Phone { get; set; }
        public string TIN { get; set; }

        public Customer(Guid id):base (id) {
            CustomerID = id;


            
        }

    }
}
