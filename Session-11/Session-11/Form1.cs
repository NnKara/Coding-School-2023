namespace Session_11 {
    public partial class Form1 : Form {

        public Transaction transaction;
        public PetShop petShop;
        public Customer customer;

        public Form1() {


            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {

            petShop = new PetShop();

            PopulateEmployee();
            PopulateCustomers();
            PopulatePets();
            PopulatePetFoods();

            SetControllers();//bindings 
            SetControls(); //transaction datamembers
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) {

        }



        private void btnOrder_Click(object sender, EventArgs e) {

        }

        private void btnCancerl_Click(object sender, EventArgs e) {

        }


        public void PopulatePetFoods() {
            var petsFood = new List<PetFood>
            {
                new PetFood {PetFoodID= Guid.NewGuid(),AnimalType = Pet.AnimalTypeEnum.Dog,Status=Pet.PetStatusEnum.OK ,PetFoodPrice = 70, PetFoodCost = 50},
                new PetFood {PetFoodID= Guid.NewGuid(),AnimalType = Pet.AnimalTypeEnum.Dog,Status=Pet.PetStatusEnum.Recovering ,PetFoodPrice =60,PetFoodCost = 50},
                new PetFood {PetFoodID= Guid.NewGuid(),AnimalType = Pet.AnimalTypeEnum.Cat,Status=Pet.PetStatusEnum.OK,PetFoodPrice = 50, PetFoodCost = 30},
                new PetFood {PetFoodID= Guid.NewGuid(),AnimalType = Pet.AnimalTypeEnum.Cat,Status=Pet.PetStatusEnum.Recovering, PetFoodPrice = 40, PetFoodCost = 30},
                new PetFood {PetFoodID= Guid.NewGuid(),AnimalType = Pet.AnimalTypeEnum.Bird,Status=Pet.PetStatusEnum.OK, PetFoodPrice = 80, PetFoodCost = 30},
                new PetFood {PetFoodID= Guid.NewGuid(),AnimalType = Pet.AnimalTypeEnum.Bird,Status=Pet.PetStatusEnum.Recovering, PetFoodPrice = 80, PetFoodCost = 30},
            };
            petShop.PetFoods.AddRange(petsFood);
            petFoodBindingSource1.DataSource = petShop.PetFoods;
        }
        public void PopulateCustomers() {

            Customer Cust1 = new Customer() {
                CustomerID = Guid.NewGuid(),
                Name = "Nikos",
                Surname = "Karamitos",
                Phone = "6978319532",
                TIN = "37482910"
            };
            Customer cust2 = new Customer() {
                CustomerID = Guid.NewGuid(),
                Name = "Alex",
                Surname = "Gad",
                Phone = "6973132822",
                TIN = "38239102"
            };


            petShop.Customers.Add(Cust1);
            petShop.Customers.Add(cust2);
           
        }

        //Koumpi add gia employee
        //public Employee addNewEmployee() {
        //    Employee newEmployee = new Employee();
        //    petShop.Employees.Add(newEmployee);
        //    return newEmployee;
        //}

        //public Transaction SelectBird(Pet pet, Transaction trans) {

        //    if (pet.Status.ToString() == "Unhealthy") {
        //        return null;
        //    }
        //    else {

        //        trans.PetFoodPrice = 5;
        //        trans.PetFoodQty = 3;
        //        trans.PetPrice = pet.Price;
        //        trans.PetID = pet.PetID;
        //        trans.TransactionDate = DateTime.Now;
        //        trans.TotalPrice = pet.Price + (trans.PetFoodPrice * (trans.PetFoodQty - 1));


        //    }
        //    return trans;
        //}

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


     
        private void PopulateEmployee() {

            Employee employee1 = new Employee() {
                EmployeeID = Guid.NewGuid(),
                Name = "Fotis",
                Surname = "Chrysoulas",
                EmployeeType = Employee.EmployeeTypeEnum.Manager,
                SalaryPerMonth = 1000

            };

            Employee employee2 = new Employee() {
                EmployeeID = Guid.NewGuid(),
                Name = "Alex",
                Surname = "Gad",
                EmployeeType = Employee.EmployeeTypeEnum.Staff,
                SalaryPerMonth = 1000

            };
            petShop.Employees.Add(employee1);
            petShop.Employees.Add(employee2);
            employeeBindingSource.DataSource = petShop.Employees;

        }

        private void PopulatePets() {

            var pets = new List<Pet>
            {
                new Pet {PetID= Guid.NewGuid(),AnimalType = Pet.AnimalTypeEnum.Dog,Status=Pet.PetStatusEnum.OK ,Price = 100, Cost = 70,Breed="French Bulldog"},
                new Pet {PetID= Guid.NewGuid(),AnimalType = Pet.AnimalTypeEnum.Dog,Status=Pet.PetStatusEnum.Recovering ,Price =80, Cost = 30,Breed="Akita"},
                new Pet {PetID= Guid.NewGuid(),AnimalType = Pet.AnimalTypeEnum.Dog,Status=Pet.PetStatusEnum.Unhealthy ,Price =0, Cost = 20,Breed="Beagle"},
                new Pet {PetID= Guid.NewGuid(),AnimalType = Pet.AnimalTypeEnum.Cat,Status=Pet.PetStatusEnum.OK, Price = 100, Cost = 80,Breed="Persian"},
                new Pet {PetID= Guid.NewGuid(),AnimalType = Pet.AnimalTypeEnum.Cat,Status=Pet.PetStatusEnum.Recovering, Price = 80, Cost = 60,Breed="Maine Coon"},
                new Pet {PetID= Guid.NewGuid(),AnimalType = Pet.AnimalTypeEnum.Cat,Status=Pet.PetStatusEnum.Unhealthy, Price = 0, Cost = 20,Breed="Ragdoll"},
                new Pet {PetID= Guid.NewGuid(),AnimalType = Pet.AnimalTypeEnum.Bird,Status=Pet.PetStatusEnum.OK, Price = 80, Cost = 50,Breed="Canary"},
                new Pet {PetID= Guid.NewGuid(),AnimalType = Pet.AnimalTypeEnum.Bird,Status=Pet.PetStatusEnum.Recovering, Price = 60, Cost = 40,Breed="Amazon Parrot"},
                new Pet {PetID= Guid.NewGuid(),AnimalType = Pet.AnimalTypeEnum.Bird,Status=Pet.PetStatusEnum.Unhealthy, Price = 30, Cost = 15,Breed="African Grey Parrot"}
            };
            petShop.Pets.AddRange(pets);
            petBindingSource.DataSource = petShop.Pets;
          

        }

        public void SetControls() {
           
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
            

        }

        public void SetControllers() {
            customerBindingSource1.DataSource = petShop.Customers;
            grvCustomers.DataSource = customerBindingSource1;
            petBindingSource.DataSource = petShop.Pets;
            grvPets.DataSource = petBindingSource;
            petFoodBindingSource1.DataSource = petShop.PetFoods;
            grvPetFood.DataSource = petFoodBindingSource1;
            employeeBindingSource.DataSource = petShop.Employees;
            grvEmployee.DataSource = employeeBindingSource;
            transactionBindingSource.DataSource = petShop.Transactions;
            grvTransactions.DataSource = transactionBindingSource;
            customerBindingSource1.DataSource=petShop.Customers;
            grvCustomers.DataSource = customerBindingSource1;
            monthlyLedgerBindingSource.DataSource = petShop.MonthlyLedgers;
            grvMonthlyLedger.DataSource = monthlyLedgerBindingSource;
        }


        public void CheckStock(Stock stock, double petFoodQty) {

        }



        private void gridControl1_Click(object sender, EventArgs e) {

        }

        private void employeeBindingSource_CurrentChanged(object sender, EventArgs e) {

        }

        private void dataGridViewAnimalMenu_CellContentClick(object sender, DataGridViewCellEventArgs e) {

        }



        private void button1_Click(object sender, EventArgs e) {
            Transaction tras=new Transaction();
            transactionBindingSource.Add(tras);
        }

        private void btnRemoveTrans_Click(object sender, EventArgs e) {
            transactionBindingSource.RemoveCurrent();
        }

        private void btnAddEmployee_Click(object sender, EventArgs e) {
            Employee newEmployee= new Employee();
            employeeBindingSource.Add(newEmployee);
        }

        private void btnRemoveEmployee_Click(object sender, EventArgs e) {
            employeeBindingSource.RemoveCurrent();
        }

        private void btnSave_Click(object sender, EventArgs e) {
            Serializer serializer = new Serializer();
            serializer.SerializeToFile(petShop, "test.json");
        }

        private void btnLoad_Click(object sender, EventArgs e) {
            Serializer serializer = new Serializer();
            petShop = serializer.Deserialize<PetShop>("test.json");
        }

        private void btnAddPet_Click(object sender, EventArgs e)
        {
            Pet pet=new Pet();
            petBindingSource.Add(pet);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            petBindingSource.RemoveCurrent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PetFood petFood= new PetFood();          
            petFoodBindingSource1.Add(petFood);
          
        }

        private void button3_Click(object sender, EventArgs e)
        {
            petFoodBindingSource1.RemoveCurrent();
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            Customer newCust = new Customer();
            
            customerBindingSource1.Add(newCust);
        }

        private void btnRemoveCustomer_Click(object sender, EventArgs e)
        {
            customerBindingSource1.RemoveCurrent();
        }
    }
}
