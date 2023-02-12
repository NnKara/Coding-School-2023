using System.ComponentModel;

namespace PetShop.Model
{
    public class Transaction
    {
        
        public Transaction(decimal petPrice, int petFoodQty, decimal petFoodPrice, decimal totalPrice)
        {
            Date = DateTime.Now;
            PetPrice = petPrice;
            PetFoodPrice = petFoodPrice;
            PetFoodQty = petFoodQty;
            TotalPrice = totalPrice;
        }

        public int TransactionID { get; set; }
        public DateTime Date { get; set; }

        [DisplayName("Pet-Price")]
        public decimal PetPrice { get; set; }

        [DisplayName("Pet-Food Quantity")]
        public int PetFoodQty { get; set; }

        [DisplayName("Pet-Food Price")]
        public decimal PetFoodPrice { get; set; }

        [DisplayName("Total-Price")]
        public decimal TotalPrice { get; set; }

        // Relations
        public int CustomerID { get; set; }
        public Customer Customer { get; set; } = null!;

        public int EmployeeID { get; set; }
        public Employee Employee { get; set; } = null!;

        public int PetID { get; set; }
        public Pet Pet { get; set; } = null!;

        public int PetFoodID { get; set; }
        [DisplayName("Pet-Food")]
        public PetFood PetFood { get; set; } = null!;
    }
}
