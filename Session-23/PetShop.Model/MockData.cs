using PetShop.Model.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShop.Model {
    public class MockData {


        private List<Customer> _customerList = new List<Customer>();
        private List<Employee> _employeeList = new List<Employee>();
        private List<Pet> _petList = new List<Pet>();
        private List<PetFood> _petFoodList = new List<PetFood>();

        public List<Customer> PopulateCustomers() {
            Customer customer1 = new Customer() {
                CustomerName = "Nikos",
                CustomerSurname = "karamitos",
                Phone = "6931866321",
                TIN = "182739102"
            };

            Customer customer2 = new Customer() {
                CustomerName = "Giannis",
                CustomerSurname = "katsaros",
                Phone = "691321123",
                TIN = "182419102"
            };

            Customer customer3 = new Customer() {
                CustomerName = "Petros",
                CustomerSurname = "Pateras",
                Phone = "693121412",
                TIN = "182352102"
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
                EmployeeType = EmployeeType.Manager,
                SalaryPerMonth = 800
            };

            Employee employee2 = new Employee() {
                EmployeeName = "Christiano",
                EmployeeSurname = "Ronaldo",
                EmployeeType = EmployeeType.Staff ,
                SalaryPerMonth = 600
            };

            Employee employee3 = new Employee() {
                EmployeeName = "Djibril",
                EmployeeSurname = "Cisse",
                EmployeeType = EmployeeType.Staff ,
               SalaryPerMonth = 600
            };
            _employeeList.Add(employee1);
            _employeeList.Add(employee2);
            _employeeList.Add(employee3);
            return _employeeList;
        }

        public List<Pet> PopulatePets() {


            Pet pet1 = new Pet() {
                AnimalType = AnimalType.Reptile,
                Breed = "Bearded Dragon",
                Cost = 200,
                Price = 900,
                PetStatus = PetStatus.Ok
            };

            Pet pet2 = new Pet() {
                AnimalType = AnimalType.Reptile,
                Breed = "Iguana",
                Cost = 500,
                Price = 800,
                PetStatus = PetStatus.Recovering
            };

            Pet pet3 = new Pet() {
                AnimalType = AnimalType.Reptile,
                Breed = "Tortoise",
                Cost = 700,
                Price = 1000,
                PetStatus = PetStatus.Unhealthy
            };
            Pet pet4 = new Pet() {
                AnimalType = AnimalType.Mammal,
                Breed = "Pocket Gophers",
                Price = 1000,
                Cost = 500,
                PetStatus = PetStatus.Unhealthy
            };
            Pet pet5 = new Pet() {
                AnimalType = AnimalType.Mammal,
                Breed = "Red Squirrels",
                Cost = 1000,
                Price = 800,
                PetStatus = PetStatus.Ok
            };
            Pet pet6 = new Pet() {
                AnimalType = AnimalType.Mammal,
                Breed = "American  Cat",
                Price = 800,
                Cost = 500,
                PetStatus = PetStatus.Recovering
            };
            Pet pet7 = new Pet() {
                AnimalType = AnimalType.Bird,
                Breed = "Amazon Parrot",
                Cost = 700,
                Price = 800,
                PetStatus = PetStatus.Ok
            };
            Pet pet8 = new Pet() {
                AnimalType = AnimalType.Bird,
                Breed = "Canaries",
                Price = 150,
                Cost = 80,
                PetStatus = PetStatus.Ok
            };
            Pet pet9 = new Pet() {
                AnimalType = AnimalType.Bird,
                Breed = "African Parrot",
                Cost = 700,
                Price = 500,
                PetStatus = PetStatus.Recovering
            };

            Pet pet10 = new Pet() {
                AnimalType = AnimalType.Fish,
                Breed = "Tuna",
                Price = 300,
                Cost = 100,
                PetStatus = PetStatus.Ok
            };
            Pet pet11 = new Pet() {
                AnimalType = AnimalType.Fish,
                Breed = "Tilapia",
                Price = 200,
                Cost = 100,
                PetStatus = PetStatus.Unhealthy
            };
            Pet pet12 = new Pet() {
                AnimalType = AnimalType.Fish,
                Breed = "Salmon",
                Price = 200,
                Cost = 100,
                PetStatus = PetStatus.Recovering
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
            _petList.Add(pet11);
            _petList.Add(pet12);
            return _petList;
        }


        public List<PetFood> PopulatePetFood() {

            PetFood petFood1 = new PetFood() {
                AnimalType = AnimalType.Bird,
                Price = 50,
                Cost = 25
            };

            PetFood petFood2 = new PetFood() {
                AnimalType = AnimalType.Mammal,
                Price = 90,
                Cost = 60
            };

            PetFood petFood3 = new PetFood() {
                AnimalType = AnimalType.Fish,
                Price = 70,
                Cost = 40
            }; 
            
            PetFood petFood4 = new PetFood() {
                AnimalType = AnimalType.Reptile,
                Price = 100,
                Cost = 40
            };

            _petFoodList.Add(petFood1);
            _petFoodList.Add(petFood2);
            _petFoodList.Add(petFood3);
            _petFoodList.Add(petFood4);
            return _petFoodList;
        }

       

      
    }
}
