using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Populate
    {
        private List<Customer> customerList=new List<Customer>();
        private List<Employee> employeeList=new List<Employee>();
        private List<Pet> petList=new List<Pet>();
        private List<PetFood> petFoodList = new List<PetFood>();
        
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
            customerList.Add(customer1);
            customerList.Add(customer2);
            customerList.Add(customer3);
            return customerList;
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
            employeeList.Add(employee1);
            employeeList.Add(employee2);
            employeeList.Add(employee3);
            return employeeList;
        }

        public List<Pet> PopulatePets() {


            Pet pet1 = new Pet() {
                PetType=Pet.AnimalType.Bird,
                Breed="Blue Parrot",
                Cost=200,
                Price=400,
                PetStatus=Pet.AnimalStatus.OK
            };
            
            Pet pet2 = new Pet() {
                PetType=Pet.AnimalType.Dog,
                Breed="Huski",
                Cost=500,
                Price=800,
                PetStatus=Pet.AnimalStatus.OK
            };
            
            Pet pet3 = new Pet() {
                PetType=Pet.AnimalType.Cat,
                Breed="Black Cat",
                Cost=300,
                Price=400,
                PetStatus=Pet.AnimalStatus.UNHEALTHY
            };

            petList.Add(pet1); 
            petList.Add(pet2);
            petList.Add(pet3);
            return petList;
        }


        public List<PetFood> PopulatePetFood() {
            PetFood petFood1 = new PetFood() {
            PetFoodType=Pet.AnimalType.Bird,
            Price=50,
            Cost=25
            };
            
            PetFood petFood2 = new PetFood() {
            PetFoodType=Pet.AnimalType.Dog,
            Price=90,
            Cost=60
            };
            
            PetFood petFood3 = new PetFood() {
            PetFoodType=Pet.AnimalType.Cat,
            Price=70,
            Cost=40
            };

            petFoodList.Add(petFood1);
            petFoodList.Add(petFood2);
            petFoodList.Add(petFood3);
            return petFoodList;
        }
        
        
    
    }
}
