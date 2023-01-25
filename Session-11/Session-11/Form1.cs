namespace Session_11 {
    public partial class Form1 : Form {

        public Transaction transaction;
        public PetShop petShop;


        public Form1() {
            InitializeComponent();
            //SetControlProperties();
            //var pets = this.list;
            //dataGridView2.DataSource = pets;
            Pet pet = new Pet();
            Transaction newTras = new Transaction();

            Employee newEmployee = addNewEmployee();//koumpi add gia employee
            Customer newCustomer = addNewCustomer();//koumpi add gia customer
            PopulateCustomers();
            PopulatePets();
            PopulateEmployee();
            Buy(newCustomer, pet); 
            dataGridViewAnimalMenu.DataSource = petShop.Pets;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) {
         
        }



        private void btnOrder_Click(object sender, EventArgs e) {

        }

        private void btnCancerl_Click(object sender, EventArgs e) {

        }

        //Koumpi add gia customer
        public Customer addNewCustomer() {
            Customer newCust = new Customer();
            petShop.Customers.Add(newCust);
            return newCust;
        }

        //Koumpi add gia employee
        public Employee addNewEmployee() {
            Employee newEmployee = new Employee();
            petShop.Employees.Add(newEmployee);
            return newEmployee;
        }





        public Transaction Buy(Customer customer, Pet pet) {


            Transaction newTras = new Transaction();
            try {
                switch (pet.AnimalType) {
                    case Pet.AnimalTypeEnum.Bird:
                        newTras = SelectBird(pet, newTras);
                        break;

                    case Pet.AnimalTypeEnum.Cat:
                         newTras = SelectCat(pet, newTras);
                        break;

                    case Pet.AnimalTypeEnum.Dog:
                          newTras = SelectDog(pet, newTras);
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

        public Transaction SelectBird(Pet pet, Transaction trans) {

            if (pet.Status.ToString() == "Unhealthy") {
                return null;
            }
            else {

                trans.PetFoodPrice = 5;
                trans.PetFoodQty = 3;
                trans.PetPrice = pet.Price;
                trans.PetID = pet.PetID;
                trans.TransactionDate = DateTime.Now;
                trans.TotalPrice = pet.Price + (trans.PetFoodPrice * (trans.PetFoodQty - 1));


            }
            return trans;
        }

        public Transaction SelectCat(Pet pet, Transaction trans) {
            Stock stock = new Stock();
            PetFood petFood = new PetFood();
            if (stock.GetPetsNumberStock() > 0) {
                if (pet.Status.ToString() == "Unhealthy") {
                    return null;
                }
                else {
                    trans.PetPrice = pet.Price;
                    trans.PetFoodPrice = petFood.PetFoodPrice;
                    trans.TransactionDate = DateTime.Now;
                    trans.PetFoodQty = stock.GetPetFoodStock() - trans.PetFoodQty;
                    trans.TransactionID = pet.PetID;

                }
            }
            else {

                MessageBox.Show("Cat is Out of Stock!");

            }
            return trans;
        }


        public Transaction SelectDog(Pet pet, Transaction trans) {
       
            Stock stock = new Stock();
            PetFood petFood = new PetFood();
            if (stock.GetPetsNumberStock() > 0) {
                if (pet.Status.ToString() == "Unhealthy") {
                    return null;
                }
                else {
                    trans.PetPrice = pet.Price;
                    trans.PetFoodPrice = petFood.PetFoodPrice;
                    trans.TransactionDate = DateTime.Now;
                    trans.PetFoodQty = stock.GetPetFoodStock() - trans.PetFoodQty;
                    trans.TransactionID = pet.PetID;
                }

            }
            else {
                MessageBox.Show("Dog is Out of Stock!");
            }
            return trans;
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
        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e) {
            //pet pricing
        }
        private void PopulateEmployee() {

            Employee employee1 = new Employee() {
                Name = "Fotis",
                Surname = "Chrysoulas",
                EmployeeType = Employee.EmployeeTypeEnum.Manager,
                SalaryPerMonth = 1000

            };

            Employee employee2 = new Employee() {
                Name = "Alex",
                Surname = "Gad",
                EmployeeType = Employee.EmployeeTypeEnum.Staff,
                SalaryPerMonth = 1000

            };

            petShop.Employees.Add(employee1);
            petShop.Employees.Add(employee2);
            //employeeBindingSource.DataSource = petShop.Employees;

        }

        private void PopulatePets() {

            Pet pet1 = new Pet() {
                PetID = Guid.NewGuid(),
                Breed = "Haski",
                AnimalType = Pet.AnimalTypeEnum.Dog,
                Status = Pet.PetStatusEnum.OK,
                Price = 100

            };
            petShop.Pets.Add(pet1);
            Pet pet2 = new Pet() {
                PetID = Guid.NewGuid(),
                Breed = "Pigeon",
                AnimalType = Pet.AnimalTypeEnum.Bird,
                Status = Pet.PetStatusEnum.Unhealthy,
                Price = 30

            };
            petShop.Pets.Add(pet2);
            Pet pet3 = new Pet() {
                PetID = Guid.NewGuid(),
                Breed = "Black",
                AnimalType = Pet.AnimalTypeEnum.Cat,
                Status = Pet.PetStatusEnum.Recovering,
                Price = 20

            };
            petShop.Pets.Add(pet3);
            petBindingSource1.DataSource = petShop.Pets;
        }

        public void PopulateCustomers() {
            Customer cust1 = new Customer() {
                CustomerID = Guid.NewGuid(),
                Name = "Nikos",
                Surname = "Karamitos",
                Phone = "6978453324",
                TIN = "4567332"
            };
            customerBindingSource.DataSource = petShop.Customers;
        }




        public void CheckStock(Stock stock, double petFoodQty) {

        }

        //private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e) {
        //    //pet pricing
        //}

        private void gridControl1_Click(object sender, EventArgs e) {

        }
        //private void SetControlProperties() {
        //    grdCustomers.DataSource = grdCustomers;
        //    grdEmployees.DataSource = grdEmployees;
        //    grdPets.DataSource = grdPets;
        //    grdPetFoods.DataSource = grdPetFoods;
        //    grdTransactions.DataSource = grdTransactions;
        //}

        private void employeeBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void dataGridViewAnimalMenu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
