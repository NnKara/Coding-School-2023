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
            PopulatePetFoods();
            dataGridViewCustomers.DataSource = petShop.Customers;
            PopulatePets();
            
            dataGridViewCustomers.DataSource = customerBindingSource1;
            dataGridViewAnimalMenu.DataSource = petShop.Pets;
            dataGridViewPetFoodMenu.DataSource = petShop.PetFoods;
            employeeBindingSource.DataSource = petShop.Employees;            
            grvEmployee.DataSource = employeeBindingSource;
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


        public List<PetFood> PopulatePetFoods()
        {
            //var petsFood = new List<PetFood>
            //{
            //    new PetFood {AnimalType = Pet.AnimalTypeEnum.Dog,Status=Pet.PetStatusEnum.OK ,PetFoodPrice = 70, PetFoodCost = 50},
            //    new PetFood {AnimalType = Pet.AnimalTypeEnum.Dog,Status=Pet.PetStatusEnum.Recovering ,PetFoodPrice =60,PetFoodCost = 50},
            //    new PetFood {AnimalType = Pet.AnimalTypeEnum.Cat,Status=Pet.PetStatusEnum.OK,PetFoodPrice = 50, PetFoodCost = 30},
            //    new PetFood {AnimalType = Pet.AnimalTypeEnum.Cat,Status=Pet.PetStatusEnum.Recovering, PetFoodPrice = 40, PetFoodCost = 30},
            //    new PetFood {AnimalType = Pet.AnimalTypeEnum.Bird,Status=Pet.PetStatusEnum.OK, PetFoodPrice = 80, PetFoodCost = 30},
            //    new PetFood {AnimalType = Pet.AnimalTypeEnum.Bird,Status=Pet.PetStatusEnum.Recovering, PetFoodPrice = 80, PetFoodCost = 30},    
            //};
            //petShop.PetFoods.AddRange(petsFood);
            petFoodBindingSource1.DataSource = petShop.PetFoods; 
            return petShop.PetFoods;
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
                Phone = "6973132822",
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
                    //     newTras = SelectCat(pet, newTras);
                        break;

                    case Pet.AnimalTypeEnum.Dog:
                     //     newTras = SelectDog(pet, newTras);
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

        //public Transaction SelectCat(Pet pet, Transaction trans) {
        //    Stock stock = new Stock();
        //    PetFood petFood = new PetFood();
        //    if (stock.GetPetsNumberStock() > 0) {
        //        if (pet.Status.ToString() == "Unhealthy") {
        //            return null;
        //        }
        //        else {
        //            trans.PetPrice = pet.Price;
        //            trans.PetFoodPrice = petFood.PetFoodPrice;
        //            trans.TransactionDate = DateTime.Now;
        //            trans.PetFoodQty = stock.GetPetFoodStock() - trans.PetFoodQty;
        //            trans.TransactionID = pet.PetID;

        //        }
        //    }
        //    else {

        //        MessageBox.Show("Cat is Out of Stock!");

        //    }
        //    return trans;
        //}


        //public Transaction SelectDog(Pet pet, Transaction trans) {
       
        //    Stock stock = new Stock();
        //    PetFood petFood = new PetFood();
        //    if (stock.GetPetsNumberStock() > 0) {
        //        if (pet.Status.ToString() == "Unhealthy") {
        //            return null;
        //        }
        //        else {
        //            trans.PetPrice = pet.Price;
        //            trans.PetFoodPrice = petFood.PetFoodPrice;
        //            trans.TransactionDate = DateTime.Now;
        //            trans.PetFoodQty = stock.GetPetFoodStock() - trans.PetFoodQty;
        //            trans.TransactionID = pet.PetID;
        //        }

        //    }
        //    else {
        //        MessageBox.Show("Dog is Out of Stock!");
        //    }
        //    return trans;
        //}


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

        private List<Pet> PopulatePets()
        {

            var pets = new List<Pet>
            {
                new Pet {AnimalType = Pet.AnimalTypeEnum.Dog,Status=Pet.PetStatusEnum.OK ,Price = 100, Cost = 70,Breed="French Bulldog"},
                new Pet {AnimalType = Pet.AnimalTypeEnum.Dog,Status=Pet.PetStatusEnum.Recovering ,Price =80, Cost = 30,Breed="Akita"},
                new Pet {AnimalType = Pet.AnimalTypeEnum.Dog,Status=Pet.PetStatusEnum.Unhealthy ,Price =0, Cost = 20,Breed="Beagle"},
                new Pet {AnimalType = Pet.AnimalTypeEnum.Cat,Status=Pet.PetStatusEnum.OK, Price = 100, Cost = 80,Breed="Persian"},
                new Pet {AnimalType = Pet.AnimalTypeEnum.Cat,Status=Pet.PetStatusEnum.Recovering, Price = 80, Cost = 60,Breed="Maine Coon"},
                new Pet {AnimalType = Pet.AnimalTypeEnum.Cat,Status=Pet.PetStatusEnum.Unhealthy, Price = 0, Cost = 20,Breed="Ragdoll"},
                new Pet {AnimalType = Pet.AnimalTypeEnum.Bird,Status=Pet.PetStatusEnum.OK, Price = 80, Cost = 50,Breed="Canary"},
                new Pet {AnimalType = Pet.AnimalTypeEnum.Bird,Status=Pet.PetStatusEnum.Recovering, Price = 60, Cost = 40,Breed="Amazon Parrot"},
                new Pet {AnimalType = Pet.AnimalTypeEnum.Bird,Status=Pet.PetStatusEnum.Unhealthy, Price = 30, Cost = 15,Breed="African Grey Parrot"}
            };
            petShop.Pets.AddRange(pets);
            petBindingSource.DataSource = petShop.Pets; 
            return petShop.Pets;

        }

        public void SetControls() {
            //DataGridViewComboBoxColumn colTransactionDate = grvTransactions.Columns["colTransactionDate"] as DataGridViewComboBoxColumn;
            //colTransactionDate.DataSource = DateTime.Now;
            DataGridViewComboBoxColumn colCustomer = grvTransactions.Columns["colCustomer"] as DataGridViewComboBoxColumn;
            colCustomer.DataSource = petShop.Customers;
            colCustomer.DisplayMember = "FullName";
            colCustomer.ValueMember = "CustomerID";
            DataGridViewComboBoxColumn colEmployee = grvTransactions.Columns["colEmployee"] as DataGridViewComboBoxColumn;
            colEmployee.DataSource = petShop.Employees;
            colEmployee.DisplayMember = "FullName";
            colEmployee.ValueMember = "EmployeeID";
            DataGridViewComboBoxColumn colAnimalType = grvTransactions.Columns["colAnimalType"] as DataGridViewComboBoxColumn;
            colAnimalType.DataSource = petShop.Pets;
            colAnimalType.DisplayMember = "AnimalBreed";
            //DataGridViewComboBoxColumn colPetPrice = grvTransactions.Columns["colPetPrice"] as DataGridViewComboBoxColumn;
            //colPetPrice.DataSource = petShop.Pets;
            //colPetPrice.DisplayMember = "Price";

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

        private void btnRemoveTrans_Click(object sender, EventArgs e) {
            transactionBindingSource.RemoveCurrent();
        }

        private void btnAddEmployee_Click(object sender, EventArgs e) {
            employeeBindingSource.AddNew();
        }

        private void btnRemoveEmployee_Click(object sender, EventArgs e) {
            employeeBindingSource.RemoveCurrent();
        }
    }
}
