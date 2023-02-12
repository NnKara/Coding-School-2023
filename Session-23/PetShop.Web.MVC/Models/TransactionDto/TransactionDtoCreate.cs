using Microsoft.AspNetCore.Mvc.Rendering;
using PetShop.Model;
using System.ComponentModel;

namespace PetShop.Web.MVC.Models.TransactionDto {
    public class TransactionDtoCreate {
        public int TransactionID { get; set; }
        public DateTime Date { get; set; }
        [DisplayName("Pet Price")]
        public decimal PetPrice { get; set; }

        [DisplayName("PetFood Quantity")]
        public int PetFoodQty { get; set; }

        [DisplayName("PetFood Price")]
        public decimal PetFoodPrice { get; set; }

        [DisplayName("Total Price")]
        public decimal TotalPrice { get; set; }

        //Relations
        [DisplayName("Customer")]
        public int CustomerID { get; set; }

        [DisplayName("Employee")]
        public int EmployeeID { get; set; }
        [DisplayName("Pet")]
        public int PetID { get; set; }
        [DisplayName("Pet Food")]
        public int PetFoodID { get; set; }
        public List<SelectListItem> Customers { get; } = new List<SelectListItem>();
        public List<SelectListItem> Employees { get; } = new List<SelectListItem>();
        public List<SelectListItem> Pets { get; } = new List<SelectListItem>();
        public List<SelectListItem>PetFoods { get; } = new List<SelectListItem>();
    }
}
