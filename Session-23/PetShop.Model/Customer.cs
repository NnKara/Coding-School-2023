using System.ComponentModel;

namespace PetShop.Model
{
    public class Customer
    {
        public Customer() {
            Transactions= new List<Transaction>();
        }

        public Customer(string name, string surname, string phone, string tin)
        {
            CustomerName = name;
            CustomerSurname = surname;
            Phone = phone;
            TIN = tin;
            Transactions = new List<Transaction>();
        }

        public int CustomerID { get; set; }

        [DisplayName("Name")]
        public string CustomerName { get; set; }

        [DisplayName("Surname")]
        public string CustomerSurname { get; set; }

        [DisplayName("Phone")]
        public string Phone { get; set; }
        public string TIN { get; set; }

        // Relations
        public List<Transaction> Transactions { get; set; }
    }
}
