using System.Formats.Asn1;
using System.Security.Cryptography.X509Certificates;

namespace Session_11
{
    public partial class Form1 : Form
    {
        public Transaction transaction;
        public PetShop petShop;

        public Form1()
        {
            InitializeComponent();
            //var pets = this.list;
            //dataGridView2.DataSource = pets;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) {
            Pet pet = new Pet();
            Transaction newTras = new Transaction();

            Employee newEmployee = addNewEmployee();//koumpi add gia employee
            Customer newCustomer = addNewCustomer();//koumpi add gia customer
            populateCustomers();
            PopulatePets();
            PopulateEmployee();
           
            Buy(newCustomer, pet);



        }

        

        private void btnOrder_Click(object sender, EventArgs e) {

        }

        private void btnCancerl_Click(object sender, EventArgs e) {

        }

        //Koumpi add gia customer
        public Customer addNewCustomer()
        {
            Customer newCust = new Customer();        
            petShop.Customers.Add(newCust);
            return newCust;
        }

        //Koumpi add gia employee
        public Employee addNewEmployee()
        {
            Employee newEmployee = new Employee();
            petShop.Employees.Add(newEmployee);
            return newEmployee;
        }

        //gia controll view show every single customer
        public List<Customer> populateCustomers()
        {
            return petShop.Customers;
        }



        public Transaction Buy(Customer customer, Pet pet) {


            Transaction newTras = new Transaction();
            try {
                switch (pet.AnimalType) {
                    case Pet.AnimalTypeEnum.Bird:
                        newTras = SelectBird(pet);
                        break;

                    case Pet.AnimalTypeEnum.Cat:
                        newTras = SelectCat(pet);
                        break;

                    case Pet.AnimalTypeEnum.Dog:
                        newTras = SelectDog(pet);
                        break;


                    default:
                        //ola ta values set se null.
                        
                        MessageBox.Show("Order Cancelled");
                        break;
                }
            }
            catch (Exception ex) {

                MessageBox.Show("Something Went Wrong");

            }

            return newTras;


        }

        public Transaction SelectBird(Pet pet)
        {
            Transaction tras = new Transaction();
            if (pet.Status.ToString() == "Unhealthy")
            {
                return null;
            }
            else
            {

                tras.PetFoodPrice = 5;
                tras.PetFoodQty = 3;
                tras.PetPrice = pet.Price;
                tras.PetID = pet.PetID;
                tras.TransactionDate = DateTime.Now;
                tras.TotalPrice = pet.Price + (tras.PetFoodPrice * (tras.PetFoodQty - 1));
  

            }
            return tras;
        }

        public Transaction SelectCat(Pet pet)
        {
            Stock stock = new Stock();
            PetFood petFood = new PetFood();
            Transaction tras = new Transaction();
            if (stock.GetPetsNumberStock() > 0)
            {
                if (pet.Status.ToString() == "Unhealthy")
                {
                    return null;
                }
                else
                {
                    tras.PetPrice = pet.Price;
                    tras.PetFoodPrice = petFood.PetFoodPrice;
                    tras.TransactionDate = DateTime.Now;
                    tras.PetFoodQty = stock.GetPetFoodStock() - tras.PetFoodQty;
                    tras.TransactionID = pet.PetID;
                        
                }
            }
            else
            {
               
                MessageBox.Show("Cat is Out of Stock!");

            }
            return tras;
        }


        public Transaction SelectDog(Pet pet)
        {
            Transaction tras=new Transaction();
            Stock stock=new Stock();
            PetFood petFood=new PetFood();
            if (stock.GetPetsNumberStock() > 0)
            {
                if (pet.Status.ToString() == "Unhealthy")
                {
                    return null;
                }
                else
                {
                    tras.PetPrice = pet.Price;
                    tras.PetFoodPrice = petFood.PetFoodPrice;
                    tras.TransactionDate = DateTime.Now;
                    tras.PetFoodQty = stock.GetPetFoodStock() - tras.PetFoodQty;
                    tras.TransactionID = pet.PetID;
                }

            }
            else
            {
                MessageBox.Show("Dog is Out of Stock!");
            }
            return tras;
        }



        // Pet petcat = new Pet()
        //{
        //    AnimalType = Pet.AnimalTypeEnum.Cat,
        //    Status = Pet.PetStatusEnum.OK,
        //    Breed = "black"
        //};
        // Pet petDog = new Pet()
        //{
        //    AnimalType = Pet.AnimalTypeEnum.Dog,
        //    Status = Pet.PetStatusEnum.OK,
        //    Breed = "black"
        //};
        
        //Pet petBird = new Pet()
        //{
        //    AnimalType = Pet.AnimalTypeEnum.Bird,
        //    Status = Pet.PetStatusEnum.OK,
        //    Breed = "black"
        //};

        //List<Pet> list = new List<Pet>() { petcat, petDog, petBird };


        //PetShop petShop = new PetShop()
        //{

        //    Pets = new List<Pet>() {
        //        petcat, petDog,petBird
        //    }

        //};
        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //pet pricing
        }
        private void PopulateEmployee()
        {

            Employee employee1 = new Employee()
            {
                Name = "Fotis",
                Surname = "Chrysoulas",
                EmployeeType = Employee.EmployeeTypeEnum.Manager,
                SalaryPerMonth = 1000

            };

            Employee employee2 = new Employee()
            {
                Name = "Alex",
                Surname = "Gad",
                EmployeeType = Employee.EmployeeTypeEnum.Staff,
                SalaryPerMonth = 1000

            };

            petShop.Employees.Add(employee1);
            petShop.Employees.Add(employee2);

        }

        private void PopulatePets()
        {

            Pet pet1 = new Pet()
            {
                PetID = Guid.NewGuid(),
                Breed = "Haski",
                AnimalType = Pet.AnimalTypeEnum.Dog,
                Price = 100

            };
            petShop.Pets.Add(pet1);
            Pet pet2 = new Pet()
            {
                PetID = Guid.NewGuid(),
                Breed = "Pigeon",
                AnimalType = Pet.AnimalTypeEnum.Bird,
                Price = 30

            };
            petShop.Pets.Add(pet2);
            Pet pet3 = new Pet()
            {
                PetID = Guid.NewGuid(),
                Breed = "Black",
                AnimalType = Pet.AnimalTypeEnum.Cat,
                Price = 20

            };
            petShop.Pets.Add(pet3);
        }
    }
}
