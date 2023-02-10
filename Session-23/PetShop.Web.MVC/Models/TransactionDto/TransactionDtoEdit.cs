using Microsoft.AspNetCore.Mvc.Rendering;
using PetShop.Model;

namespace PetShop.Web.MVC.Models.TransactionDto {
    public class TransactionDtoEdit {
        public int TransactionID { get; set; }
        public DateTime Date { get; set; }
        public decimal PetPrice { get; set; }
        public int PetFoodQty { get; set; }
        public decimal PetFoodPrice { get; set; }
        public decimal TotalPrice { get; set; }

        // Relations
        public int CustomerID { get; set; }
        public Customer Customer { get; set; } = null!;

        public int EmployeeID { get; set; }
        public Employee Employee { get; set; } = null!;

        public int PetID { get; set; }
        public Pet Pet { get; set; } = null!;

        public int PetFoodID { get; set; }
        public PetFood PetFood { get; set; } = null!;

        public List<SelectListItem> Customers { get; } = new List<SelectListItem>();
        public List<SelectListItem> Employees { get; } = new List<SelectListItem>();
        public List<SelectListItem> Pets { get; } = new List<SelectListItem>();
        public List<SelectListItem> PetFoods { get; } = new List<SelectListItem>();
    }
}
