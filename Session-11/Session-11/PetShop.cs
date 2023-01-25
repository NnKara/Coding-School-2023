using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Session_11
{
    public class PetShop
    {
        public List<Pet>? Pets { get; set; }
        public List<Customer>? Customers { get; set; }
        public List<Employee>? Employees { get; set; }
        public List<PetFood>? PetFoods { get; set; }
        public List<Transaction>? Transactions { get; set; }

        public List<MonthlyLedger>? MonthlyLedgers { get; set; }    
        public Stock stock { get; set; }



        private void Initialize() {
            Stock stock = new Stock();
            Employee staffEmployee = CreateEmployee();
            Customer customer = CreateCustomer();
            Pet pet = CreatePet("Poodle");
            double petFoodQty = 12.5;
            double petFoodCost = 9.2;
            double petFoodPrice = petFoodQty * petFoodCost;
          //  PetFood petFood = CreatePetFood(pet.AnimalType, petFoodPrice, petFoodCost);

            ////Employees = new List<Emloyee>;
            ////Employees.Add(employeeStaff);

        }

        //private PetFood CreatePetFood(Pet.AnimalTypeEnum animalType, double petFoodPrice, double petFoodCost) {
        //    PetFood petFood = new PetFood() {
        //        PetFoodID = Guid.NewGuid(),
        //        PetFoodPrice = petFoodPrice,
        //        PetFoodCost = petFoodCost,
        //        };
        //    return petFood; 
        //}

        private Pet CreatePet(string breed) {

            Pet pet = new Pet() {
                PetID = Guid.NewGuid(),
                Breed = breed,
                AnimalType = Pet.AnimalTypeEnum.Dog,
                Status = Pet.PetStatusEnum.OK,
                Price = 200,
                Cost = 100
            };
            return pet;
        }

        private Customer CreateCustomer() {
            Customer customer = new Customer() {
                CustomerID = Guid.NewGuid(),
                Name = "John",
                Surname = "Doe",
                Phone = "1234567890",
                TIN = "987654321"
            };
            return customer;
        }

        private Employee CreateEmployee() {
            Employee employee = new Employee() {
                EmployeeID = Guid.NewGuid(),
                Name = "Jane",
                Surname = "Dewey",
                SalaryPerMonth = 619,
                EmployeeType = Employee.EmployeeTypeEnum.Staff
            };
            return employee;
        }

        private void AddTransaction(Employee employee, Customer customer, Pet pet, PetFood petFood, double petFoodQty, double profit) {
            List<Transaction> transactions = new List<Transaction>();
            Transaction transaction = CreateTransaction(employee, customer, pet, petFood, petFoodQty, profit);
            transactions.Add(transaction);
        }

        public Transaction CreateTransaction(Employee employee, Customer customer, Pet pet, PetFood petFood, double petFoodQty, double profit) {

            double petFoodPrice = (petFood.Cost * petFoodQty) + profit;

            Transaction transaction = new Transaction() { //customerID, employeeID, petID,  petPrice, petFoodID,  petFoodQty,  petFoodPrice,  totalPrice
                CustomerID = customer.CustomerID,
                EmployeeID = employee.EmployeeID,
                PetID = pet.PetID,
                PetPrice = pet.Price,
                PetFoodID = petFood.PetFoodID,
                PetFoodQty = petFoodQty,
                PetFoodPrice = petFoodPrice
            };
            return transaction;
        }
        
      


        public PetShop()
        {
            Pets = new List<Pet>();
            Customers = new List<Customer>();
            Employees = new List<Employee>();
            PetFoods= new List<PetFood>();
            Transactions = new List<Transaction>();
            MonthlyLedgers = new List<MonthlyLedger>();
            stock=new Stock();
        }
    }

    

    //Transaction CreateTransaction(object employee, object customer, object pet, object petFood, object petFoodQty, object profit) {
    //    throw new NotImplementedException();
    //}

}
