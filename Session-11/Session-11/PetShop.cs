using DevExpress.Office.Utils;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_11
{
    public class PetShop
    {
        public List<Pet> Pets { get; set; }
        public List<Customer> Customers { get; set; }
        public List<Employee> Employees { get; set; }
        public List<PetFood> PetFoods { get; set; }
        public List<Transaction> Transactions { get; set; }
         public Stock stock { get; set; }


        public PetShop()
        {
            Pets = new List<Pet>();
            Customers = new List<Customer>();
            Employees = new List<Employee>();
            PetFoods= new List<PetFood>();
            Transactions = new List<Transaction>();
            stock=new Stock();
        }
    }
}
