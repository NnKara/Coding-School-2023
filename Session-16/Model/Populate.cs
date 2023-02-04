using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Populate
    {
        private List<Customer> _customerList=new List<Customer>();
        private List<Employee> _employeeList=new List<Employee>();
        private List<Pet> _petList=new List<Pet>();
        private List<PetFood> _petFoodList = new List<PetFood>();
        private List<Transaction> _transactionList=new List<Transaction>();  
        
        public List<Customer> PopulateCustomers()
        {
            Customer customer1 = new Customer()
            {
                CustomerName="Nikos",
                CustomerSurname="karamitos",
                Phone="693186632",
                TIN="182739102"
            }; 
            
            Customer customer2 = new Customer()
            {
                CustomerName="Giannis",
                CustomerSurname="katsaros",
                Phone="6931321332",
                TIN="182419102"
            };
            
            Customer customer3 = new Customer()
            {
                CustomerName="Petros",
                CustomerSurname="Pateras",
                Phone="6931221412",
                TIN="182352102"
            };
            _customerList.Add(customer1);
            _customerList.Add(customer2);
            _customerList.Add(customer3);
            return _customerList;
        }

        public List<Employee> PopulateEmployees() {

            Employee employee1 = new Employee() {
                EmployeeName = "Lionel",
                EmployeeSurname = "Messi",
                EmployeeType = Employee.EmployeeWorkType.MANAGER,
                SallaryPerMonth = 800
            };

            Employee employee2 = new Employee() {
                EmployeeName = "Christiano",
                EmployeeSurname = "Ronaldo",
                EmployeeType = Employee.EmployeeWorkType.STAFF,
                SallaryPerMonth = 600
            };

            Employee employee3 = new Employee() {
                EmployeeName = "Djibril",
                EmployeeSurname = "Cisse",
                EmployeeType = Employee.EmployeeWorkType.STAFF,
                SallaryPerMonth = 600
            };
            _employeeList.Add(employee1);
            _employeeList.Add(employee2);
            _employeeList.Add(employee3);
            return _employeeList;
        }

        public List<Pet> PopulatePets() {


            Pet pet1 = new Pet() {
                AnimalType =AnimalType.Dog,
                Breed="French Bulldog",
                Cost=200,
                Price=900,
                PetStatus=PetStatus.OK
            };
            
            Pet pet2 = new Pet() {
                AnimalType =AnimalType.Dog,
                Breed="Chihuaua",
                Cost=500,
                Price=800,
                PetStatus=PetStatus.OK
            };
            
            Pet pet3 = new Pet() {
                AnimalType=AnimalType.Dog,
                Breed="Akita",
                Cost=700,
                Price=1000,
                PetStatus=PetStatus.RECOVERING
            };
            Pet pet4 = new Pet() {
                AnimalType = AnimalType.Dog,
                Breed = "American",
                Price=1000,
                Cost = 500,
                PetStatus = PetStatus.UNHEALTHY
            };
            Pet pet5 = new Pet() {
                AnimalType = AnimalType.Cat,
                Breed = "Abyssinian Cat",
                Cost = 1000,
                Price = 800,
                PetStatus = PetStatus.OK
            };
            Pet pet6 = new Pet() {
                AnimalType = AnimalType.Cat,
                Breed = "American  Cat",
                Price=800,
                Cost= 500,
                PetStatus = PetStatus.UNHEALTHY
            };
            Pet pet7 = new Pet() {
                AnimalType = AnimalType.Cat,
                Breed = "Bengal Cat",
                Cost = 700,
                Price = 800,
                PetStatus = PetStatus.RECOVERING
            };
            Pet pet8 = new Pet() {
                AnimalType = AnimalType.Bird,
                Breed = "Canaries",
                Price=150,
                Cost= 80,
                PetStatus = PetStatus.OK
            };
            Pet pet9 = new Pet() {
                AnimalType = AnimalType.Bird,
                Breed = "African Parrot",
                Cost = 700,
                Price = 500,
                PetStatus = PetStatus.RECOVERING
            };
            
            Pet pet10 = new Pet() {
                AnimalType = AnimalType.Bird,
                Breed = "Pionus Parrot",
                Price= 500,
                Cost = 300,
                PetStatus = PetStatus.UNHEALTHY
            };

            _petList.Add(pet1); 
            _petList.Add(pet2);
            _petList.Add(pet3);
            _petList.Add(pet4);
            _petList.Add(pet5);
            _petList.Add(pet6);
            _petList.Add(pet7);
            _petList.Add(pet8);
            _petList.Add(pet9);
            _petList.Add(pet10);
            return _petList;
        }


        public List<PetFood> PopulatePetFood() {

            PetFood petFood1 = new PetFood() {
            AnimalType = AnimalType.Bird,
            Price=50,
            Cost=25
            };
            
            PetFood petFood2 = new PetFood() {
            AnimalType = AnimalType.Dog,
            Price=90,
            Cost=60
            };
            
            PetFood petFood3 = new PetFood() {
            AnimalType = AnimalType.Cat,
            Price=70,
            Cost=40
            };

            _petFoodList.Add(petFood1);
            _petFoodList.Add(petFood2);
            _petFoodList.Add(petFood3);
            return _petFoodList;
        }





        public List<Transaction> PopulateTransactions() {


            Transaction tranasaction = new Transaction() {
                CustomerID = _customerList[0].CustomerID,
                EmployeeID = _employeeList[0].EmployeeID,
                PetID = _petList[0].PetID,
                PetFoodPrice = _petFoodList[0].Price,
                PetFoodQty = 3,
                PetPrice = _petFoodList[0].Price
            };
            _transactionList.Add(tranasaction);
            return _transactionList;

        }



    }
}
