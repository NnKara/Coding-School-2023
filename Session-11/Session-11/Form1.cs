namespace Session_11 {
    public partial class Form1 : Form {

        public Transaction transaction;
        public PetShop petShop;
        public Customer customer;

        public Form1() {


            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            petShop=new PetShop();
            
            PopulateEmployee();
            PopulateCustomers();
            PopulatePets();
            
            dataGridViewCustomers.DataSource = customerBindingSource1;
            dataGridViewAnimalMenu.DataSource = petShop.Pets;
            dataGridViewPetFoodMenu.DataSource = petShop.PetFoods;
            dataGridViewEmployess.DataSource = petShop.Employees;
            transactionBindingSource.DataSource = petShop.Transactions;
            grvTransactions.DataSource = transactionBindingSource;
            SetControls();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) {
         
        }



        private void btnOrder_Click(object sender, EventArgs e) {

        }

        private void btnCancerl_Click(object sender, EventArgs e) {

        }


        public void PopulateCustomers()
        {

            Customer Cust1 = new Customer()
            {
                Name = "Nikos",
                Surname = "Karamitos",
                Phone = "6978319532",
                TIN = "37482910"
            };
            Customer cust2 = new Customer()
            {
                Name = "Alex",
                Surname = "Gad",
                Phone = "693132822",
                TIN = "38239102"
            };


            petShop.Customers.Add(Cust1);
            petShop.Customers.Add(cust2);
            customerBindingSource1.DataSource = petShop.Customers;
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


        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e) {
            
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
            employeeBindingSource.DataSource = petShop.Employees;   

        }

        private List<Pet> PopulatePets() {


            var pets = new List<Pet>
            {
                new Pet {AnimalType = Pet.AnimalTypeEnum.Dog, Price = 100, Cost = 50},
                new Pet {AnimalType = Pet.AnimalTypeEnum.Cat, Price = 20, Cost = 10},
                new Pet {AnimalType = Pet.AnimalTypeEnum.Bird, Price = 30, Cost = 15}
            };

            petShop.Pets.AddRange(pets);
            petBindingSource.DataSource = petShop.Pets; 
            return petShop.Pets;

        }

        public void SetControls() {
            DataGridViewComboBoxColumn colCustomer = grvTransactions.Columns["colCustomer"] as DataGridViewComboBoxColumn;
            colCustomer.DataSource = petShop.Customers;
            colCustomer.DisplayMember = "Surname";
            colCustomer.ValueMember = "CustomerID";
            DataGridViewComboBoxColumn colEmployee = grvTransactions.Columns["colEmployee"] as DataGridViewComboBoxColumn;
            colEmployee.DataSource = petShop.Employees;
            colEmployee.DisplayMember = "FullName";
            colEmployee.ValueMember = "EmployeeID";
            DataGridViewComboBoxColumn colAnimalType = grvTransactions.Columns["colAnimalType"] as DataGridViewComboBoxColumn;
            colAnimalType.DataSource = petShop.Pets;
            colAnimalType.DisplayMember = "AnimalType";
         
        }



        public void CheckStock(Stock stock, double petFoodQty) {

        }



        private void gridControl1_Click(object sender, EventArgs e) {

        }

        private void employeeBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void dataGridViewAnimalMenu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        

        private void button1_Click(object sender, EventArgs e) {
            transactionBindingSource.AddNew();
           // grvTransactions.Focused
           
        }

   
    }
}
