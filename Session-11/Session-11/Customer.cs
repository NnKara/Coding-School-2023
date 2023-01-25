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

        public string FullName {
            get {
                return Name + " " + Surname;
            }
        }


        public Customer(Guid customerID, String name,String surname, string phone, string tIN) : base(name,surname)
        {
            CustomerID = customerID;
            Phone = phone;
            TIN = tIN;
        }

        public Customer()
        {
            CustomerID = Guid.NewGuid();
        }


       
        
    }
}
