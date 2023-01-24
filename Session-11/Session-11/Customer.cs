using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_11 {
    public class Customer : Person {
        public Guid CustomerID { get; set; }
        public string Phone { get; set; }
        public string TIN { get; set; }


        public Customer(Guid id, String name,String surname, string phone, string tIN) : base(id,name,surname)
        {
            
            Phone = phone;
            TIN = tIN;
        }

        public Customer()
        {
        }

        public Customer(Guid id) : base(id) {
            CustomerID = id;
        }

    }
}
