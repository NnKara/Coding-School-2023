using System.Formats.Asn1;
using System.Security.Cryptography.X509Certificates;

namespace Session_11 {
    public partial class Form1 : Form {

        public Transaction transaction;
        public PetShop petShop;


        public Form1() {
            InitializeComponent();
            SetControlProperties();
            //var pets = this.list;
            //dataGridView2.DataSource = pets;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) {
            Pet pet = new Pet();
            Customer newCustomer = new Customer();
            
            PopulateCustomer();
            PopulatePets();
            PopulateEmployee();
            Buy(newCustomer, pet);
        }



        private void btnOrder_Click(object sender, EventArgs e) {

        }

        private void btnCancerl_Click(object sender, EventArgs e) {

        }



        public Transaction Buy(Customer customer, Pet pet) {

            Transaction newTras = new Transaction();
            try {
                switch (pet.AnimalType) {
                    case Pet.AnimalTypeEnum.Bird:
                        newTras = SelectBird(pet, newTras);
                        break;

                    case Pet.AnimalTypeEnum.Cat:
                        // newTras = SelectCat(pet, newTras);
                        break;

                    case Pet.AnimalTypeEnum.Dog:
                        newTras = SelectDog(pet, newTras);
                        break;


                    default:
                        MessageBox.Show("Currently Out of Pets");
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

        //public Transaction SelectCat(Pet pet, Transaction trans) {
        //    Stock animalStock = new Stock();
        //    PetFood petFood = new PetFood();
        //    if (animalStock.PetsNumber > 0) {
        //        if (pet.Status.ToString() == "Unhealthy") {
        //            return null;
        //        }
        //        else {
        //            trans.PetPrice = pet.Price;
        //            trans.PetFoodPrice = petFood.PetFoodPrice;
        //            trans.TransactionDate = DateTime.Now;
        //            trans.PetFoodQty = animalStock.PetFoodQty - trans.PetFoodQty;
        //            trans.TransactionID = pet.PetID;

        //        }
        //    }
        //    else {
        //        MessageBox.Show("Currently Out of Stock");

        //    }
        //    return trans;
        //}
        public Transaction SelectDog(Pet pet, Transaction trans) {

            return trans;
        }


        private void PopulateCustomer() {
            Customer customer1 = new Customer() {
                Name = "Nikos",
                Surname = "Karamitos",
                Phone = "6978319622",
                TIN = "12390812903"
            };
            petShop.Customers.Add(customer1);
            customerBindingSource.DataSource = petShop.Customers;
        }

        private void PopulateEmployee() {

            Employee employee1 = new Employee() {
                Name = "Fotis",
                Surname = "Chrysoulas",
                EmployeeType = Employee.EmployeeTypeEnum.Manager

            };
            petShop.Employees.Add(employee1);
            Employee employee2 = new Employee() {
                Name = "Alex",
                Surname = "Gad",
                EmployeeType = Employee.EmployeeTypeEnum.Staff,
                SalaryPerMonth = 1000

            };
            petShop.Employees.Add(employee2);
            employeeBindingSource.DataSource = petShop.Employees;

        }

        private void PopulatePets() {

            Pet pet1 = new Pet() {
                PetID = Guid.NewGuid(),
                Breed = "Haski",
                AnimalType = Pet.AnimalTypeEnum.Dog,
                Price = 100

            };
            petShop.Pets.Add(pet1);
            Pet pet2 = new Pet() {
                PetID = Guid.NewGuid(),
                Breed = "Pigeon",
                AnimalType = Pet.AnimalTypeEnum.Bird,
                Price = 30

            };
            petShop.Pets.Add(pet2);
            Pet pet3 = new Pet() {
                PetID = Guid.NewGuid(),
                Breed = "Black",
                AnimalType = Pet.AnimalTypeEnum.Cat,
                Price = 20

            };
            petShop.Pets.Add(pet3);
            petBindingSource1.DataSource = petShop.Pets;
        }




        public void CheckStock(Stock stock, double petFoodQty) {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e) {
            //pet pricing
        }

        private void gridControl1_Click(object sender, EventArgs e) {

        }
        private void SetControlProperties() { 
        grdCustomers.DataSource = grdCustomers;
        grdEmployees.DataSource = grdEmployees;
        grdPets.DataSource= grdPets;
        grdPetFoods.DataSource = grdPetFoods;
        grdTransactions.DataSource = grdTransactions;   
        }

        }
}
