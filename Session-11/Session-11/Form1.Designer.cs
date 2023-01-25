namespace Session_11
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.transactionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.grvPetFood = new System.Windows.Forms.DataGridView();
            this.animalTypeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.petFoodPriceDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.petFoodCostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.petFoodBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.grvPets = new System.Windows.Forms.DataGridView();
            this.breedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.animalTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.petBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.grvTransactions = new System.Windows.Forms.DataGridView();
            this.colCustomer = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.colEmployee = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.colAnimalType = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.colPetPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.petFoodQtyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.petFoodPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.grvCustomers = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tINDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.grvEmployee = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surnameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salaryPerMonthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.btnRemoveCustomer = new System.Windows.Forms.Button();
            this.btnAddCustomer = new System.Windows.Forms.Button();
            this.btnRemoveTrans = new System.Windows.Forms.Button();
            this.btnOrder = new System.Windows.Forms.Button();
            this.btnAddEmployee = new System.Windows.Forms.Button();
            this.btnRemoveEmployee = new System.Windows.Forms.Button();
            this.grvMonthlyLedger = new System.Windows.Forms.DataGridView();
            this.yearDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.monthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.incomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expensesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.monthlyLedgerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnLoad = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAddTrans = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnAddPet = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.transactionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvPetFood)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.petFoodBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvPets)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.petBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvTransactions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvCustomers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvEmployee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvMonthlyLedger)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.monthlyLedgerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // transactionBindingSource
            // 
            this.transactionBindingSource.DataSource = typeof(Session_11.Transaction);
            // 
            // grvPetFood
            // 
            this.grvPetFood.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.grvPetFood.AutoGenerateColumns = false;
            this.grvPetFood.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grvPetFood.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.grvPetFood.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvPetFood.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.animalTypeDataGridViewTextBoxColumn1,
            this.Status,
            this.petFoodPriceDataGridViewTextBoxColumn1,
            this.petFoodCostDataGridViewTextBoxColumn});
            this.grvPetFood.DataSource = this.petFoodBindingSource1;
            this.grvPetFood.Location = new System.Drawing.Point(50, 614);
            this.grvPetFood.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grvPetFood.Name = "grvPetFood";
            this.grvPetFood.RowHeadersWidth = 51;
            this.grvPetFood.RowTemplate.Height = 29;
            this.grvPetFood.Size = new System.Drawing.Size(645, 141);
            this.grvPetFood.TabIndex = 0;
            // 
            // animalTypeDataGridViewTextBoxColumn1
            // 
            this.animalTypeDataGridViewTextBoxColumn1.DataPropertyName = "AnimalType";
            this.animalTypeDataGridViewTextBoxColumn1.HeaderText = "AnimalType";
            this.animalTypeDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.animalTypeDataGridViewTextBoxColumn1.Name = "animalTypeDataGridViewTextBoxColumn1";
            // 
            // Status
            // 
            this.Status.DataPropertyName = "Status";
            this.Status.HeaderText = "Status";
            this.Status.MinimumWidth = 6;
            this.Status.Name = "Status";
            // 
            // petFoodPriceDataGridViewTextBoxColumn1
            // 
            this.petFoodPriceDataGridViewTextBoxColumn1.DataPropertyName = "PetFoodPrice";
            this.petFoodPriceDataGridViewTextBoxColumn1.HeaderText = "PetFoodPrice";
            this.petFoodPriceDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.petFoodPriceDataGridViewTextBoxColumn1.Name = "petFoodPriceDataGridViewTextBoxColumn1";
            // 
            // petFoodCostDataGridViewTextBoxColumn
            // 
            this.petFoodCostDataGridViewTextBoxColumn.DataPropertyName = "PetFoodCost";
            this.petFoodCostDataGridViewTextBoxColumn.HeaderText = "PetFoodCost";
            this.petFoodCostDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.petFoodCostDataGridViewTextBoxColumn.Name = "petFoodCostDataGridViewTextBoxColumn";
            // 
            // petFoodBindingSource1
            // 
            this.petFoodBindingSource1.DataSource = typeof(Session_11.PetFood);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 570);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Pet Food Menu";
            // 
            // grvPets
            // 
            this.grvPets.AllowUserToDeleteRows = false;
            this.grvPets.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.grvPets.AutoGenerateColumns = false;
            this.grvPets.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grvPets.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.grvPets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvPets.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.breedDataGridViewTextBoxColumn,
            this.animalTypeDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.costDataGridViewTextBoxColumn});
            this.grvPets.DataSource = this.petBindingSource;
            this.grvPets.Location = new System.Drawing.Point(50, 335);
            this.grvPets.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grvPets.Name = "grvPets";
            this.grvPets.RowHeadersWidth = 51;
            this.grvPets.RowTemplate.Height = 29;
            this.grvPets.Size = new System.Drawing.Size(440, 196);
            this.grvPets.TabIndex = 2;
            this.grvPets.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewAnimalMenu_CellContentClick);
            // 
            // breedDataGridViewTextBoxColumn
            // 
            this.breedDataGridViewTextBoxColumn.DataPropertyName = "Breed";
            this.breedDataGridViewTextBoxColumn.HeaderText = "Breed";
            this.breedDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.breedDataGridViewTextBoxColumn.Name = "breedDataGridViewTextBoxColumn";
            // 
            // animalTypeDataGridViewTextBoxColumn
            // 
            this.animalTypeDataGridViewTextBoxColumn.DataPropertyName = "AnimalType";
            this.animalTypeDataGridViewTextBoxColumn.HeaderText = "AnimalType";
            this.animalTypeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.animalTypeDataGridViewTextBoxColumn.Name = "animalTypeDataGridViewTextBoxColumn";
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            // 
            // costDataGridViewTextBoxColumn
            // 
            this.costDataGridViewTextBoxColumn.DataPropertyName = "Cost";
            this.costDataGridViewTextBoxColumn.HeaderText = "Cost";
            this.costDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.costDataGridViewTextBoxColumn.Name = "costDataGridViewTextBoxColumn";
            // 
            // petBindingSource
            // 
            this.petBindingSource.DataSource = typeof(Session_11.Pet);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 302);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Pet Menu";
            // 
            // grvTransactions
            // 
            this.grvTransactions.AllowUserToAddRows = false;
            this.grvTransactions.AutoGenerateColumns = false;
            this.grvTransactions.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grvTransactions.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.grvTransactions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvTransactions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCustomer,
            this.colEmployee,
            this.colAnimalType,
            this.colPetPrice,
            this.petFoodQtyDataGridViewTextBoxColumn,
            this.petFoodPriceDataGridViewTextBoxColumn,
            this.totalPriceDataGridViewTextBoxColumn});
            this.grvTransactions.DataSource = this.transactionBindingSource;
            this.grvTransactions.Location = new System.Drawing.Point(74, 27);
            this.grvTransactions.Name = "grvTransactions";
            this.grvTransactions.RowHeadersWidth = 51;
            this.grvTransactions.RowTemplate.Height = 29;
            this.grvTransactions.Size = new System.Drawing.Size(814, 188);
            this.grvTransactions.TabIndex = 4;
            // 
            // colCustomer
            // 
            this.colCustomer.HeaderText = "Customer";
            this.colCustomer.MinimumWidth = 6;
            this.colCustomer.Name = "colCustomer";
            // 
            // colEmployee
            // 
            this.colEmployee.HeaderText = "Employee";
            this.colEmployee.MinimumWidth = 6;
            this.colEmployee.Name = "colEmployee";
            // 
            // colAnimalType
            // 
            this.colAnimalType.HeaderText = "AnimalType";
            this.colAnimalType.MinimumWidth = 6;
            this.colAnimalType.Name = "colAnimalType";
            // 
            // colPetPrice
            // 
            this.colPetPrice.HeaderText = "PetPrice";
            this.colPetPrice.MinimumWidth = 6;
            this.colPetPrice.Name = "colPetPrice";
            // 
            // petFoodQtyDataGridViewTextBoxColumn
            // 
            this.petFoodQtyDataGridViewTextBoxColumn.DataPropertyName = "PetFoodQty";
            this.petFoodQtyDataGridViewTextBoxColumn.HeaderText = "PetFoodQty";
            this.petFoodQtyDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.petFoodQtyDataGridViewTextBoxColumn.Name = "petFoodQtyDataGridViewTextBoxColumn";
            // 
            // petFoodPriceDataGridViewTextBoxColumn
            // 
            this.petFoodPriceDataGridViewTextBoxColumn.DataPropertyName = "PetFoodPrice";
            this.petFoodPriceDataGridViewTextBoxColumn.HeaderText = "PetFoodPrice";
            this.petFoodPriceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.petFoodPriceDataGridViewTextBoxColumn.Name = "petFoodPriceDataGridViewTextBoxColumn";
            // 
            // totalPriceDataGridViewTextBoxColumn
            // 
            this.totalPriceDataGridViewTextBoxColumn.DataPropertyName = "TotalPrice";
            this.totalPriceDataGridViewTextBoxColumn.HeaderText = "TotalPrice";
            this.totalPriceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.totalPriceDataGridViewTextBoxColumn.Name = "totalPriceDataGridViewTextBoxColumn";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(74, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Transaction";
            // 
            // grvCustomers
            // 
            this.grvCustomers.AllowUserToAddRows = false;
            this.grvCustomers.AutoGenerateColumns = false;
            this.grvCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvCustomers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.surnameDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn,
            this.tINDataGridViewTextBoxColumn});
            this.grvCustomers.DataSource = this.customerBindingSource1;
            this.grvCustomers.Location = new System.Drawing.Point(934, 65);
            this.grvCustomers.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grvCustomers.Name = "grvCustomers";
            this.grvCustomers.RowHeadersWidth = 51;
            this.grvCustomers.RowTemplate.Height = 29;
            this.grvCustomers.Size = new System.Drawing.Size(454, 141);
            this.grvCustomers.TabIndex = 6;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 125;
            // 
            // surnameDataGridViewTextBoxColumn
            // 
            this.surnameDataGridViewTextBoxColumn.DataPropertyName = "Surname";
            this.surnameDataGridViewTextBoxColumn.HeaderText = "Surname";
            this.surnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.surnameDataGridViewTextBoxColumn.Name = "surnameDataGridViewTextBoxColumn";
            this.surnameDataGridViewTextBoxColumn.Width = 125;
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "Phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "Phone";
            this.phoneDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            this.phoneDataGridViewTextBoxColumn.Width = 125;
            // 
            // tINDataGridViewTextBoxColumn
            // 
            this.tINDataGridViewTextBoxColumn.DataPropertyName = "TIN";
            this.tINDataGridViewTextBoxColumn.HeaderText = "TIN";
            this.tINDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tINDataGridViewTextBoxColumn.Name = "tINDataGridViewTextBoxColumn";
            this.tINDataGridViewTextBoxColumn.Width = 125;
            // 
            // customerBindingSource1
            // 
            this.customerBindingSource1.DataSource = typeof(Session_11.Customer);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(919, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Customers";
            // 
            // grvEmployee
            // 
            this.grvEmployee.AutoGenerateColumns = false;
            this.grvEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvEmployee.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn1,
            this.surnameDataGridViewTextBoxColumn1,
            this.employeeTypeDataGridViewTextBoxColumn,
            this.salaryPerMonthDataGridViewTextBoxColumn});
            this.grvEmployee.DataSource = this.employeeBindingSource;
            this.grvEmployee.Location = new System.Drawing.Point(894, 314);
            this.grvEmployee.Name = "grvEmployee";
            this.grvEmployee.RowHeadersWidth = 51;
            this.grvEmployee.RowTemplate.Height = 29;
            this.grvEmployee.Size = new System.Drawing.Size(449, 188);
            this.grvEmployee.TabIndex = 8;
            // 
            // nameDataGridViewTextBoxColumn1
            // 
            this.nameDataGridViewTextBoxColumn1.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn1.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn1.Name = "nameDataGridViewTextBoxColumn1";
            this.nameDataGridViewTextBoxColumn1.Width = 80;
            // 
            // surnameDataGridViewTextBoxColumn1
            // 
            this.surnameDataGridViewTextBoxColumn1.DataPropertyName = "Surname";
            this.surnameDataGridViewTextBoxColumn1.HeaderText = "Surname";
            this.surnameDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.surnameDataGridViewTextBoxColumn1.Name = "surnameDataGridViewTextBoxColumn1";
            this.surnameDataGridViewTextBoxColumn1.Width = 80;
            // 
            // employeeTypeDataGridViewTextBoxColumn
            // 
            this.employeeTypeDataGridViewTextBoxColumn.DataPropertyName = "EmployeeType";
            this.employeeTypeDataGridViewTextBoxColumn.HeaderText = "EmployeeType";
            this.employeeTypeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.employeeTypeDataGridViewTextBoxColumn.Name = "employeeTypeDataGridViewTextBoxColumn";
            this.employeeTypeDataGridViewTextBoxColumn.Width = 90;
            // 
            // salaryPerMonthDataGridViewTextBoxColumn
            // 
            this.salaryPerMonthDataGridViewTextBoxColumn.DataPropertyName = "SalaryPerMonth";
            this.salaryPerMonthDataGridViewTextBoxColumn.HeaderText = "SalaryPerMonth";
            this.salaryPerMonthDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.salaryPerMonthDataGridViewTextBoxColumn.Name = "salaryPerMonthDataGridViewTextBoxColumn";
            this.salaryPerMonthDataGridViewTextBoxColumn.Width = 90;
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataSource = typeof(Session_11.Employee);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(903, 285);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Employees";
            // 
            // btnRemoveCustomer
            // 
            this.btnRemoveCustomer.Location = new System.Drawing.Point(1265, 220);
            this.btnRemoveCustomer.Name = "btnRemoveCustomer";
            this.btnRemoveCustomer.Size = new System.Drawing.Size(94, 29);
            this.btnRemoveCustomer.TabIndex = 10;
            this.btnRemoveCustomer.Text = "Remove";
            this.btnRemoveCustomer.UseVisualStyleBackColor = true;
            this.btnRemoveCustomer.Click += new System.EventHandler(this.btnRemoveCustomer_Click);
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.Location = new System.Drawing.Point(1150, 220);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Size = new System.Drawing.Size(94, 29);
            this.btnAddCustomer.TabIndex = 11;
            this.btnAddCustomer.Text = "Add";
            this.btnAddCustomer.UseVisualStyleBackColor = true;
            this.btnAddCustomer.Click += new System.EventHandler(this.btnAddCustomer_Click);
            // 
            // btnRemoveTrans
            // 
            this.btnRemoveTrans.Location = new System.Drawing.Point(146, 220);
            this.btnRemoveTrans.Name = "btnRemoveTrans";
            this.btnRemoveTrans.Size = new System.Drawing.Size(85, 31);
            this.btnRemoveTrans.TabIndex = 12;
            this.btnRemoveTrans.Text = "Remove";
            this.btnRemoveTrans.UseVisualStyleBackColor = true;
            this.btnRemoveTrans.Click += new System.EventHandler(this.btnRemoveTrans_Click);
            // 
            // btnOrder
            // 
            this.btnOrder.Location = new System.Drawing.Point(794, 222);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(94, 29);
            this.btnOrder.TabIndex = 13;
            this.btnOrder.Text = "Order";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click_1);
            // 
            // btnAddEmployee
            // 
            this.btnAddEmployee.Location = new System.Drawing.Point(1165, 511);
            this.btnAddEmployee.Name = "btnAddEmployee";
            this.btnAddEmployee.Size = new System.Drawing.Size(79, 29);
            this.btnAddEmployee.TabIndex = 14;
            this.btnAddEmployee.Text = "Add ";
            this.btnAddEmployee.UseVisualStyleBackColor = true;
            this.btnAddEmployee.Click += new System.EventHandler(this.btnAddEmployee_Click);
            // 
            // btnRemoveEmployee
            // 
            this.btnRemoveEmployee.Location = new System.Drawing.Point(1250, 511);
            this.btnRemoveEmployee.Name = "btnRemoveEmployee";
            this.btnRemoveEmployee.Size = new System.Drawing.Size(71, 29);
            this.btnRemoveEmployee.TabIndex = 15;
            this.btnRemoveEmployee.Text = "Remove";
            this.btnRemoveEmployee.UseVisualStyleBackColor = true;
            this.btnRemoveEmployee.Click += new System.EventHandler(this.btnRemoveEmployee_Click);
            // 
            // grvMonthlyLedger
            // 
            this.grvMonthlyLedger.AutoGenerateColumns = false;
            this.grvMonthlyLedger.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvMonthlyLedger.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.yearDataGridViewTextBoxColumn,
            this.monthDataGridViewTextBoxColumn,
            this.incomeDataGridViewTextBoxColumn,
            this.expensesDataGridViewTextBoxColumn,
            this.totalDataGridViewTextBoxColumn});
            this.grvMonthlyLedger.DataSource = this.monthlyLedgerBindingSource;
            this.grvMonthlyLedger.Location = new System.Drawing.Point(883, 590);
            this.grvMonthlyLedger.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grvMonthlyLedger.Name = "grvMonthlyLedger";
            this.grvMonthlyLedger.RowHeadersWidth = 51;
            this.grvMonthlyLedger.RowTemplate.Height = 29;
            this.grvMonthlyLedger.Size = new System.Drawing.Size(485, 141);
            this.grvMonthlyLedger.TabIndex = 16;
            // 
            // yearDataGridViewTextBoxColumn
            // 
            this.yearDataGridViewTextBoxColumn.DataPropertyName = "Year";
            this.yearDataGridViewTextBoxColumn.HeaderText = "Year";
            this.yearDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.yearDataGridViewTextBoxColumn.Name = "yearDataGridViewTextBoxColumn";
            this.yearDataGridViewTextBoxColumn.Width = 125;
            // 
            // monthDataGridViewTextBoxColumn
            // 
            this.monthDataGridViewTextBoxColumn.DataPropertyName = "Month";
            this.monthDataGridViewTextBoxColumn.HeaderText = "Month";
            this.monthDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.monthDataGridViewTextBoxColumn.Name = "monthDataGridViewTextBoxColumn";
            this.monthDataGridViewTextBoxColumn.Width = 125;
            // 
            // incomeDataGridViewTextBoxColumn
            // 
            this.incomeDataGridViewTextBoxColumn.DataPropertyName = "Income";
            this.incomeDataGridViewTextBoxColumn.HeaderText = "Income";
            this.incomeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.incomeDataGridViewTextBoxColumn.Name = "incomeDataGridViewTextBoxColumn";
            this.incomeDataGridViewTextBoxColumn.Width = 125;
            // 
            // expensesDataGridViewTextBoxColumn
            // 
            this.expensesDataGridViewTextBoxColumn.DataPropertyName = "Expenses";
            this.expensesDataGridViewTextBoxColumn.HeaderText = "Expenses";
            this.expensesDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.expensesDataGridViewTextBoxColumn.Name = "expensesDataGridViewTextBoxColumn";
            this.expensesDataGridViewTextBoxColumn.Width = 125;
            // 
            // totalDataGridViewTextBoxColumn
            // 
            this.totalDataGridViewTextBoxColumn.DataPropertyName = "Total";
            this.totalDataGridViewTextBoxColumn.HeaderText = "Total";
            this.totalDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.totalDataGridViewTextBoxColumn.Name = "totalDataGridViewTextBoxColumn";
            this.totalDataGridViewTextBoxColumn.Width = 125;
            // 
            // monthlyLedgerBindingSource
            // 
            this.monthlyLedgerBindingSource.DataSource = typeof(Session_11.MonthlyLedger);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(1136, 749);
            this.btnLoad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(94, 29);
            this.btnLoad.TabIndex = 17;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(894, 552);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 20);
            this.label6.TabIndex = 18;
            this.label6.Text = "Monthly Ledger";
            // 
            // btnAddTrans
            // 
            this.btnAddTrans.Location = new System.Drawing.Point(74, 221);
            this.btnAddTrans.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAddTrans.Name = "btnAddTrans";
            this.btnAddTrans.Size = new System.Drawing.Size(66, 31);
            this.btnAddTrans.TabIndex = 19;
            this.btnAddTrans.Text = "Add";
            this.btnAddTrans.UseVisualStyleBackColor = true;
            this.btnAddTrans.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(1250, 749);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(94, 29);
            this.btnSave.TabIndex = 20;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnAddPet
            // 
            this.btnAddPet.Location = new System.Drawing.Point(284, 536);
            this.btnAddPet.Name = "btnAddPet";
            this.btnAddPet.Size = new System.Drawing.Size(94, 29);
            this.btnAddPet.TabIndex = 21;
            this.btnAddPet.Text = "Add";
            this.btnAddPet.UseVisualStyleBackColor = true;
            this.btnAddPet.Click += new System.EventHandler(this.btnAddPet_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(396, 536);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 22;
            this.button1.Text = "Remove";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(479, 763);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 29);
            this.button2.TabIndex = 23;
            this.button2.Text = "Add";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(589, 763);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(94, 29);
            this.button3.TabIndex = 24;
            this.button3.Text = "Remove";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1400, 796);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnAddPet);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnAddTrans);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.grvMonthlyLedger);
            this.Controls.Add(this.btnRemoveEmployee);
            this.Controls.Add(this.btnAddEmployee);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.btnRemoveTrans);
            this.Controls.Add(this.btnAddCustomer);
            this.Controls.Add(this.btnRemoveCustomer);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.grvEmployee);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.grvCustomers);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.grvTransactions);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.grvPets);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grvPetFood);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.transactionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvPetFood)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.petFoodBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvPets)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.petBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvTransactions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvCustomers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvEmployee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvMonthlyLedger)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.monthlyLedgerBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private BindingSource transactionBindingSource;
        private DataGridView grvPetFood;
        private Label label1;
        private DataGridView grvPets;
        private Label label2;
        private DataGridView grvTransactions;
        private Label label3;
        private DataGridView grvCustomers;
        private Label label4;
        private DataGridView grvEmployee;
        private Label label5;
        private Button btnRemoveCustomer;
        private Button btnAddCustomer;
        private Button btnRemoveTrans;
        private Button btnOrder;
        private Button btnAddEmployee;
        private Button btnRemoveEmployee;
        private DataGridView grvMonthlyLedger;
        private Button btnLoad;
        private Label label6;
        private BindingSource petBindingSource;
        private DataGridViewTextBoxColumn breedDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn animalTypeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn costDataGridViewTextBoxColumn;
        private BindingSource petFoodBindingSource1;
        private BindingSource customerBindingSource1;
        private BindingSource employeeBindingSource;
        private DataGridViewTextBoxColumn yearDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn monthDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn incomeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn expensesDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn totalDataGridViewTextBoxColumn;
        private BindingSource monthlyLedgerBindingSource;
        private DataGridViewTextBoxColumn animalTypeDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn Status;
        private DataGridViewTextBoxColumn petFoodPriceDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn petFoodCostDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn customerIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn employeeIDDataGridViewTextBoxColumn;
        private Button btnAddTrans;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn surnameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn tINDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn surnameDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn employeeTypeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn salaryPerMonthDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn petPriceDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn transactionDateDataGridViewTextBoxColumn;
        private DataGridViewComboBoxColumn colCustomer;
        private DataGridViewComboBoxColumn colEmployee;
        private DataGridViewComboBoxColumn colAnimalType;
        private DataGridViewTextBoxColumn petFoodQtyDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn petFoodPriceDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn totalPriceDataGridViewTextBoxColumn;
        private Button btnSave;
        private DataGridViewTextBoxColumn colPetPrice;
        private Button btnAddPet;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}