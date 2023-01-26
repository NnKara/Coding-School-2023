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
            this.bsTransaction = new System.Windows.Forms.BindingSource(this.components);
            this.bsPetFood = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.bsPet = new System.Windows.Forms.BindingSource(this.components);
            this.bsCustomer = new System.Windows.Forms.BindingSource(this.components);
            this.bsEmployee = new System.Windows.Forms.BindingSource(this.components);
            this.monthlyLedgerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Year = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Month = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AnimalType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabsform = new DevExpress.XtraTab.XtraTabControl();
            this.tabCustomer = new DevExpress.XtraTab.XtraTabPage();
            this.grcCustomers = new DevExpress.XtraGrid.GridControl();
            this.grvCustomers = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCustName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCustSurname = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPhone = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTin = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tabEmployee = new DevExpress.XtraTab.XtraTabPage();
            this.grcEmployees = new DevExpress.XtraGrid.GridControl();
            this.grvEmployees = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemTextEdit5 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.colSurname = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemComboBox1 = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.colSalary = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tabPets = new DevExpress.XtraTab.XtraTabPage();
            this.grcPets = new DevExpress.XtraGrid.GridControl();
            this.grvPets = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colAnimalType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemTextEdit26 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.colBreed = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemTextEdit3 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.colStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemComboBox2 = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.colPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.Cost = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemTextEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.repositoryItemTextEdit4 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.tabPetFoods = new DevExpress.XtraTab.XtraTabPage();
            this.grcPetFoods = new DevExpress.XtraGrid.GridControl();
            this.grvPetFoods = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colAnimalTypeFood = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemTextEdit9 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.colPetFoodStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemTextEdit27 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.colFoodPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemTextEdit7 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.colFoodCost = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemTextEdit8 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.repositoryItemTextEdit6 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.repositoryItemComboBox3 = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.tabTransactions = new DevExpress.XtraTab.XtraTabPage();
            this.grcTransactions = new DevExpress.XtraGrid.GridControl();
            this.grvTransactions = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCustomerID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTransactionDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemComboBox4 = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.colCustomerName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmployeeName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPetID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemTextEdit11 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.colPetPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFoodID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemTextEdit22 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.colPetFoodQty = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemTextEdit23 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.colPetFoodPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemTextEdit24 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.colTotal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemTextEdit25 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.repositoryItemTextEdit12 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.repositoryItemTextEdit10 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.repositoryItemTextEdit13 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.tabMonthlyLedger = new DevExpress.XtraTab.XtraTabPage();
            this.gridControl6 = new DevExpress.XtraGrid.GridControl();
            this.gridView6 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.repositoryItemTextEdit15 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.repositoryItemTextEdit16 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.repositoryItemTextEdit14 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.repositoryItemTextEdit17 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.repositoryItemComboBox5 = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.tabPetReport = new DevExpress.XtraTab.XtraTabPage();
            this.gridControl7 = new DevExpress.XtraGrid.GridControl();
            this.gridView7 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.repositoryItemTextEdit19 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.repositoryItemTextEdit20 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.repositoryItemTextEdit18 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.repositoryItemTextEdit21 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.repositoryItemComboBox6 = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bsTransaction)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsPetFood)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsPet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsEmployee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.monthlyLedgerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabsform)).BeginInit();
            this.tabsform.SuspendLayout();
            this.tabCustomer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grcCustomers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvCustomers)).BeginInit();
            this.tabEmployee.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grcEmployees)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvEmployees)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).BeginInit();
            this.tabPets.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grcPets)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvPets)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit26)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit4)).BeginInit();
            this.tabPetFoods.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grcPetFoods)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvPetFoods)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit27)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox3)).BeginInit();
            this.tabTransactions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grcTransactions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvTransactions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit22)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit23)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit24)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit25)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit13)).BeginInit();
            this.tabMonthlyLedger.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit17)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox5)).BeginInit();
            this.tabPetReport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit19)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit20)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit18)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox6)).BeginInit();
            this.SuspendLayout();
            // 
            // bsTransaction
            // 
            this.bsTransaction.DataSource = typeof(Session_11.Transaction);
            // 
            // bsPetFood
            // 
            this.bsPetFood.DataSource = typeof(Session_11.PetFood);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(428, 230);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Pet Food Menu";
            // 
            // bsPet
            // 
            this.bsPet.DataSource = typeof(Session_11.Pet);
            // 
            // bsCustomer
            // 
            this.bsCustomer.DataSource = typeof(Session_11.Customer);
            this.bsCustomer.CurrentChanged += new System.EventHandler(this.customerBindingSource1_CurrentChanged);
            // 
            // bsEmployee
            // 
            this.bsEmployee.DataSource = typeof(Session_11.Employee);
            // 
            // monthlyLedgerBindingSource
            // 
            this.monthlyLedgerBindingSource.DataSource = typeof(Session_11.MonthlyLedger);
            // 
            // Year
            // 
            this.Year.HeaderText = "colYearReport";
            this.Year.MinimumWidth = 6;
            this.Year.Name = "Year";
            this.Year.ReadOnly = true;
            this.Year.Width = 125;
            // 
            // Month
            // 
            this.Month.HeaderText = "colMonthReport";
            this.Month.MinimumWidth = 6;
            this.Month.Name = "Month";
            this.Month.ReadOnly = true;
            this.Month.Width = 125;
            // 
            // AnimalType
            // 
            this.AnimalType.HeaderText = "colAnimalTypeReport";
            this.AnimalType.MinimumWidth = 6;
            this.AnimalType.Name = "AnimalType";
            this.AnimalType.ReadOnly = true;
            this.AnimalType.Width = 125;
            // 
            // tabsform
            // 
            this.tabsform.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabsform.Location = new System.Drawing.Point(13, 14);
            this.tabsform.Name = "tabsform";
            this.tabsform.SelectedTabPage = this.tabCustomer;
            this.tabsform.Size = new System.Drawing.Size(712, 406);
            this.tabsform.TabIndex = 32;
            this.tabsform.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.tabCustomer,
            this.tabEmployee,
            this.tabPets,
            this.tabPetFoods,
            this.tabTransactions,
            this.tabMonthlyLedger,
            this.tabPetReport});
            // 
            // tabCustomer
            // 
            this.tabCustomer.Controls.Add(this.grcCustomers);
            this.tabCustomer.Name = "tabCustomer";
            this.tabCustomer.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.tabCustomer.Size = new System.Drawing.Size(710, 381);
            this.tabCustomer.Text = "Customers";
            // 
            // grcCustomers
            // 
            this.grcCustomers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grcCustomers.DataSource = this.bsCustomer;
            this.grcCustomers.Location = new System.Drawing.Point(8, 13);
            this.grcCustomers.MainView = this.grvCustomers;
            this.grcCustomers.Name = "grcCustomers";
            this.grcCustomers.Size = new System.Drawing.Size(699, 361);
            this.grcCustomers.TabIndex = 2;
            this.grcCustomers.UseEmbeddedNavigator = true;
            this.grcCustomers.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvCustomers});
            this.grcCustomers.Click += new System.EventHandler(this.gridControl3_Click);
            // 
            // grvCustomers
            // 
            this.grvCustomers.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCustName,
            this.colCustSurname,
            this.colPhone,
            this.colTin});
            this.grvCustomers.GridControl = this.grcCustomers;
            this.grvCustomers.Name = "grvCustomers";
            this.grvCustomers.OptionsView.ShowGroupPanel = false;
            // 
            // colCustName
            // 
            this.colCustName.Caption = "Name";
            this.colCustName.FieldName = "Name";
            this.colCustName.Name = "colCustName";
            this.colCustName.Visible = true;
            this.colCustName.VisibleIndex = 0;
            // 
            // colCustSurname
            // 
            this.colCustSurname.Caption = "Surname";
            this.colCustSurname.FieldName = "Surname";
            this.colCustSurname.Name = "colCustSurname";
            this.colCustSurname.Visible = true;
            this.colCustSurname.VisibleIndex = 1;
            // 
            // colPhone
            // 
            this.colPhone.Caption = "Phone";
            this.colPhone.FieldName = "Phone";
            this.colPhone.Name = "colPhone";
            this.colPhone.Visible = true;
            this.colPhone.VisibleIndex = 2;
            // 
            // colTin
            // 
            this.colTin.Caption = "TIN";
            this.colTin.FieldName = "TIN";
            this.colTin.Name = "colTin";
            this.colTin.Visible = true;
            this.colTin.VisibleIndex = 3;
            // 
            // tabEmployee
            // 
            this.tabEmployee.Controls.Add(this.grcEmployees);
            this.tabEmployee.Name = "tabEmployee";
            this.tabEmployee.Size = new System.Drawing.Size(710, 381);
            this.tabEmployee.Text = "Employees";
            // 
            // grcEmployees
            // 
            this.grcEmployees.DataSource = this.bsEmployee;
            this.grcEmployees.Location = new System.Drawing.Point(3, 12);
            this.grcEmployees.MainView = this.grvEmployees;
            this.grcEmployees.Name = "grcEmployees";
            this.grcEmployees.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemComboBox1,
            this.repositoryItemTextEdit5});
            this.grcEmployees.Size = new System.Drawing.Size(704, 366);
            this.grcEmployees.TabIndex = 1;
            this.grcEmployees.UseEmbeddedNavigator = true;
            this.grcEmployees.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvEmployees});
            // 
            // grvEmployees
            // 
            this.grvEmployees.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colName,
            this.colSurname,
            this.colType,
            this.colSalary});
            this.grvEmployees.GridControl = this.grcEmployees;
            this.grvEmployees.Name = "grvEmployees";
            this.grvEmployees.OptionsView.ShowGroupPanel = false;
            // 
            // colName
            // 
            this.colName.Caption = "Name";
            this.colName.ColumnEdit = this.repositoryItemTextEdit5;
            this.colName.FieldName = "Name";
            this.colName.Name = "colName";
            this.colName.Visible = true;
            this.colName.VisibleIndex = 0;
            // 
            // repositoryItemTextEdit5
            // 
            this.repositoryItemTextEdit5.AutoHeight = false;
            this.repositoryItemTextEdit5.Name = "repositoryItemTextEdit5";
            // 
            // colSurname
            // 
            this.colSurname.Caption = "Surname";
            this.colSurname.ColumnEdit = this.repositoryItemTextEdit5;
            this.colSurname.FieldName = "Surname";
            this.colSurname.Name = "colSurname";
            this.colSurname.Visible = true;
            this.colSurname.VisibleIndex = 1;
            // 
            // colType
            // 
            this.colType.Caption = "Employee Type";
            this.colType.ColumnEdit = this.repositoryItemComboBox1;
            this.colType.FieldName = "EmployeeType";
            this.colType.Name = "colType";
            this.colType.Visible = true;
            this.colType.VisibleIndex = 2;
            // 
            // repositoryItemComboBox1
            // 
            this.repositoryItemComboBox1.AutoHeight = false;
            this.repositoryItemComboBox1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemComboBox1.Name = "repositoryItemComboBox1";
            // 
            // colSalary
            // 
            this.colSalary.Caption = "Salary";
            this.colSalary.ColumnEdit = this.repositoryItemTextEdit5;
            this.colSalary.FieldName = "SalaryPerMonth";
            this.colSalary.Name = "colSalary";
            this.colSalary.Visible = true;
            this.colSalary.VisibleIndex = 3;
            // 
            // tabPets
            // 
            this.tabPets.Controls.Add(this.grcPets);
            this.tabPets.Margin = new System.Windows.Forms.Padding(5, 3, 3, 3);
            this.tabPets.Name = "tabPets";
            this.tabPets.Size = new System.Drawing.Size(710, 381);
            this.tabPets.TabPageWidth = 30;
            this.tabPets.Text = "Pets";
            // 
            // grcPets
            // 
            this.grcPets.DataSource = this.bsPet;
            this.grcPets.Location = new System.Drawing.Point(3, 17);
            this.grcPets.MainView = this.grvPets;
            this.grcPets.Name = "grcPets";
            this.grcPets.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemTextEdit1,
            this.repositoryItemTextEdit2,
            this.repositoryItemTextEdit3,
            this.repositoryItemTextEdit4,
            this.repositoryItemComboBox2,
            this.repositoryItemTextEdit26});
            this.grcPets.Size = new System.Drawing.Size(704, 357);
            this.grcPets.TabIndex = 2;
            this.grcPets.UseEmbeddedNavigator = true;
            this.grcPets.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvPets});
            this.grcPets.Click += new System.EventHandler(this.gridControl2_Click);
            // 
            // grvPets
            // 
            this.grvPets.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colAnimalType,
            this.colBreed,
            this.colStatus,
            this.colPrice,
            this.Cost});
            this.grvPets.GridControl = this.grcPets;
            this.grvPets.Name = "grvPets";
            this.grvPets.OptionsView.ShowGroupPanel = false;
            // 
            // colAnimalType
            // 
            this.colAnimalType.Caption = "AnimalType";
            this.colAnimalType.ColumnEdit = this.repositoryItemTextEdit26;
            this.colAnimalType.FieldName = "AnimalType";
            this.colAnimalType.Name = "colAnimalType";
            this.colAnimalType.Visible = true;
            this.colAnimalType.VisibleIndex = 0;
            // 
            // repositoryItemTextEdit26
            // 
            this.repositoryItemTextEdit26.AutoHeight = false;
            this.repositoryItemTextEdit26.Name = "repositoryItemTextEdit26";
            // 
            // colBreed
            // 
            this.colBreed.Caption = "Breed";
            this.colBreed.ColumnEdit = this.repositoryItemTextEdit3;
            this.colBreed.FieldName = "Breed";
            this.colBreed.Name = "colBreed";
            this.colBreed.Visible = true;
            this.colBreed.VisibleIndex = 1;
            // 
            // repositoryItemTextEdit3
            // 
            this.repositoryItemTextEdit3.AutoHeight = false;
            this.repositoryItemTextEdit3.Name = "repositoryItemTextEdit3";
            // 
            // colStatus
            // 
            this.colStatus.Caption = "Status";
            this.colStatus.ColumnEdit = this.repositoryItemComboBox2;
            this.colStatus.FieldName = "Status";
            this.colStatus.Name = "colStatus";
            this.colStatus.Visible = true;
            this.colStatus.VisibleIndex = 2;
            // 
            // repositoryItemComboBox2
            // 
            this.repositoryItemComboBox2.AutoHeight = false;
            this.repositoryItemComboBox2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemComboBox2.Name = "repositoryItemComboBox2";
            // 
            // colPrice
            // 
            this.colPrice.Caption = "Price";
            this.colPrice.ColumnEdit = this.repositoryItemTextEdit1;
            this.colPrice.FieldName = "Price";
            this.colPrice.Name = "colPrice";
            this.colPrice.Visible = true;
            this.colPrice.VisibleIndex = 3;
            // 
            // repositoryItemTextEdit1
            // 
            this.repositoryItemTextEdit1.AutoHeight = false;
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            // 
            // Cost
            // 
            this.Cost.Caption = "Cost";
            this.Cost.ColumnEdit = this.repositoryItemTextEdit1;
            this.Cost.FieldName = "Cost";
            this.Cost.Name = "Cost";
            this.Cost.Visible = true;
            this.Cost.VisibleIndex = 4;
            // 
            // repositoryItemTextEdit2
            // 
            this.repositoryItemTextEdit2.AutoHeight = false;
            this.repositoryItemTextEdit2.Name = "repositoryItemTextEdit2";
            // 
            // repositoryItemTextEdit4
            // 
            this.repositoryItemTextEdit4.AutoHeight = false;
            this.repositoryItemTextEdit4.Name = "repositoryItemTextEdit4";
            // 
            // tabPetFoods
            // 
            this.tabPetFoods.Controls.Add(this.grcPetFoods);
            this.tabPetFoods.Name = "tabPetFoods";
            this.tabPetFoods.Size = new System.Drawing.Size(710, 381);
            this.tabPetFoods.Text = "PetFoods";
            // 
            // grcPetFoods
            // 
            this.grcPetFoods.DataSource = this.bsPetFood;
            this.grcPetFoods.Location = new System.Drawing.Point(3, 12);
            this.grcPetFoods.MainView = this.grvPetFoods;
            this.grcPetFoods.Name = "grcPetFoods";
            this.grcPetFoods.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemTextEdit7,
            this.repositoryItemTextEdit8,
            this.repositoryItemTextEdit6,
            this.repositoryItemTextEdit9,
            this.repositoryItemComboBox3,
            this.repositoryItemTextEdit27});
            this.grcPetFoods.Size = new System.Drawing.Size(704, 357);
            this.grcPetFoods.TabIndex = 3;
            this.grcPetFoods.UseEmbeddedNavigator = true;
            this.grcPetFoods.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvPetFoods});
            // 
            // grvPetFoods
            // 
            this.grvPetFoods.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colAnimalTypeFood,
            this.colPetFoodStatus,
            this.colFoodPrice,
            this.colFoodCost});
            this.grvPetFoods.GridControl = this.grcPetFoods;
            this.grvPetFoods.Name = "grvPetFoods";
            this.grvPetFoods.OptionsView.ShowGroupPanel = false;
            // 
            // colAnimalTypeFood
            // 
            this.colAnimalTypeFood.Caption = "AnimalType";
            this.colAnimalTypeFood.ColumnEdit = this.repositoryItemTextEdit9;
            this.colAnimalTypeFood.FieldName = "AnimalType";
            this.colAnimalTypeFood.Name = "colAnimalTypeFood";
            this.colAnimalTypeFood.Visible = true;
            this.colAnimalTypeFood.VisibleIndex = 0;
            // 
            // repositoryItemTextEdit9
            // 
            this.repositoryItemTextEdit9.AutoHeight = false;
            this.repositoryItemTextEdit9.Name = "repositoryItemTextEdit9";
            // 
            // colPetFoodStatus
            // 
            this.colPetFoodStatus.Caption = "AnimalStatus";
            this.colPetFoodStatus.ColumnEdit = this.repositoryItemTextEdit27;
            this.colPetFoodStatus.FieldName = "Status";
            this.colPetFoodStatus.Name = "colPetFoodStatus";
            this.colPetFoodStatus.Visible = true;
            this.colPetFoodStatus.VisibleIndex = 1;
            // 
            // repositoryItemTextEdit27
            // 
            this.repositoryItemTextEdit27.AutoHeight = false;
            this.repositoryItemTextEdit27.Name = "repositoryItemTextEdit27";
            // 
            // colFoodPrice
            // 
            this.colFoodPrice.Caption = "Price";
            this.colFoodPrice.ColumnEdit = this.repositoryItemTextEdit7;
            this.colFoodPrice.FieldName = "PetFoodPrice";
            this.colFoodPrice.Name = "colFoodPrice";
            this.colFoodPrice.Visible = true;
            this.colFoodPrice.VisibleIndex = 2;
            // 
            // repositoryItemTextEdit7
            // 
            this.repositoryItemTextEdit7.AutoHeight = false;
            this.repositoryItemTextEdit7.Name = "repositoryItemTextEdit7";
            // 
            // colFoodCost
            // 
            this.colFoodCost.Caption = "Cost";
            this.colFoodCost.ColumnEdit = this.repositoryItemTextEdit7;
            this.colFoodCost.FieldName = "PetFoodCost";
            this.colFoodCost.Name = "colFoodCost";
            this.colFoodCost.Visible = true;
            this.colFoodCost.VisibleIndex = 3;
            // 
            // repositoryItemTextEdit8
            // 
            this.repositoryItemTextEdit8.AutoHeight = false;
            this.repositoryItemTextEdit8.Name = "repositoryItemTextEdit8";
            // 
            // repositoryItemTextEdit6
            // 
            this.repositoryItemTextEdit6.AutoHeight = false;
            this.repositoryItemTextEdit6.Name = "repositoryItemTextEdit6";
            // 
            // repositoryItemComboBox3
            // 
            this.repositoryItemComboBox3.AutoHeight = false;
            this.repositoryItemComboBox3.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemComboBox3.Name = "repositoryItemComboBox3";
            // 
            // tabTransactions
            // 
            this.tabTransactions.Controls.Add(this.grcTransactions);
            this.tabTransactions.Name = "tabTransactions";
            this.tabTransactions.Size = new System.Drawing.Size(710, 381);
            this.tabTransactions.Text = "Transactions";
            // 
            // grcTransactions
            // 
            this.grcTransactions.DataSource = this.bsTransaction;
            this.grcTransactions.Location = new System.Drawing.Point(3, 12);
            this.grcTransactions.MainView = this.grvTransactions;
            this.grcTransactions.Name = "grcTransactions";
            this.grcTransactions.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemTextEdit11,
            this.repositoryItemTextEdit12,
            this.repositoryItemTextEdit10,
            this.repositoryItemTextEdit13,
            this.repositoryItemComboBox4,
            this.repositoryItemTextEdit22,
            this.repositoryItemTextEdit23,
            this.repositoryItemTextEdit24,
            this.repositoryItemTextEdit25});
            this.grcTransactions.Size = new System.Drawing.Size(704, 357);
            this.grcTransactions.TabIndex = 3;
            this.grcTransactions.UseEmbeddedNavigator = true;
            this.grcTransactions.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvTransactions});
            // 
            // grvTransactions
            // 
            this.grvTransactions.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCustomerID,
            this.colTransactionDate,
            this.colCustomerName,
            this.colEmployeeName,
            this.colPetID,
            this.colPetPrice,
            this.colFoodID,
            this.colPetFoodQty,
            this.colPetFoodPrice,
            this.colTotal});
            this.grvTransactions.GridControl = this.grcTransactions;
            this.grvTransactions.Name = "grvTransactions";
            this.grvTransactions.OptionsView.ShowGroupPanel = false;
            // 
            // colCustomerID
            // 
            this.colCustomerID.Caption = "CustomerID";
            this.colCustomerID.FieldName = "CustomerID";
            this.colCustomerID.Name = "colCustomerID";
            // 
            // colTransactionDate
            // 
            this.colTransactionDate.Caption = "DateTime";
            this.colTransactionDate.ColumnEdit = this.repositoryItemComboBox4;
            this.colTransactionDate.FieldName = "TransactionDate";
            this.colTransactionDate.Name = "colTransactionDate";
            this.colTransactionDate.Visible = true;
            this.colTransactionDate.VisibleIndex = 0;
            // 
            // repositoryItemComboBox4
            // 
            this.repositoryItemComboBox4.AutoHeight = false;
            this.repositoryItemComboBox4.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemComboBox4.Name = "repositoryItemComboBox4";
            // 
            // colCustomerName
            // 
            this.colCustomerName.Caption = "CustomerName";
            this.colCustomerName.ColumnEdit = this.repositoryItemComboBox4;
            this.colCustomerName.FieldName = "CustomerID";
            this.colCustomerName.Name = "colCustomerName";
            this.colCustomerName.Visible = true;
            this.colCustomerName.VisibleIndex = 1;
            // 
            // colEmployeeName
            // 
            this.colEmployeeName.Caption = "EmployeeName";
            this.colEmployeeName.ColumnEdit = this.repositoryItemComboBox4;
            this.colEmployeeName.FieldName = "EmployeeID";
            this.colEmployeeName.Name = "colEmployeeName";
            this.colEmployeeName.Visible = true;
            this.colEmployeeName.VisibleIndex = 2;
            // 
            // colPetID
            // 
            this.colPetID.Caption = "Pet";
            this.colPetID.ColumnEdit = this.repositoryItemTextEdit11;
            this.colPetID.FieldName = "PetID";
            this.colPetID.Name = "colPetID";
            this.colPetID.Visible = true;
            this.colPetID.VisibleIndex = 3;
            // 
            // repositoryItemTextEdit11
            // 
            this.repositoryItemTextEdit11.AutoHeight = false;
            this.repositoryItemTextEdit11.Name = "repositoryItemTextEdit11";
            // 
            // colPetPrice
            // 
            this.colPetPrice.Caption = "PetPrice";
            this.colPetPrice.ColumnEdit = this.repositoryItemTextEdit11;
            this.colPetPrice.FieldName = "PetPrice";
            this.colPetPrice.Name = "colPetPrice";
            this.colPetPrice.Visible = true;
            this.colPetPrice.VisibleIndex = 5;
            // 
            // colFoodID
            // 
            this.colFoodID.Caption = "PetFood";
            this.colFoodID.ColumnEdit = this.repositoryItemTextEdit22;
            this.colFoodID.FieldName = "PetFoodID";
            this.colFoodID.Name = "colFoodID";
            this.colFoodID.Visible = true;
            this.colFoodID.VisibleIndex = 4;
            // 
            // repositoryItemTextEdit22
            // 
            this.repositoryItemTextEdit22.AutoHeight = false;
            this.repositoryItemTextEdit22.Name = "repositoryItemTextEdit22";
            // 
            // colPetFoodQty
            // 
            this.colPetFoodQty.Caption = "PetFoodQty";
            this.colPetFoodQty.ColumnEdit = this.repositoryItemTextEdit23;
            this.colPetFoodQty.FieldName = "PetFoodQty";
            this.colPetFoodQty.Name = "colPetFoodQty";
            this.colPetFoodQty.Visible = true;
            this.colPetFoodQty.VisibleIndex = 8;
            // 
            // repositoryItemTextEdit23
            // 
            this.repositoryItemTextEdit23.AutoHeight = false;
            this.repositoryItemTextEdit23.Name = "repositoryItemTextEdit23";
            // 
            // colPetFoodPrice
            // 
            this.colPetFoodPrice.Caption = "PetFoodPrice";
            this.colPetFoodPrice.ColumnEdit = this.repositoryItemTextEdit24;
            this.colPetFoodPrice.FieldName = "PetFoodPrice";
            this.colPetFoodPrice.Name = "colPetFoodPrice";
            this.colPetFoodPrice.Visible = true;
            this.colPetFoodPrice.VisibleIndex = 6;
            // 
            // repositoryItemTextEdit24
            // 
            this.repositoryItemTextEdit24.AutoHeight = false;
            this.repositoryItemTextEdit24.Name = "repositoryItemTextEdit24";
            // 
            // colTotal
            // 
            this.colTotal.Caption = "TotalPrice";
            this.colTotal.ColumnEdit = this.repositoryItemTextEdit25;
            this.colTotal.FieldName = "TotalPrice";
            this.colTotal.Name = "colTotal";
            this.colTotal.Visible = true;
            this.colTotal.VisibleIndex = 7;
            // 
            // repositoryItemTextEdit25
            // 
            this.repositoryItemTextEdit25.AutoHeight = false;
            this.repositoryItemTextEdit25.Name = "repositoryItemTextEdit25";
            // 
            // repositoryItemTextEdit12
            // 
            this.repositoryItemTextEdit12.AutoHeight = false;
            this.repositoryItemTextEdit12.Name = "repositoryItemTextEdit12";
            // 
            // repositoryItemTextEdit10
            // 
            this.repositoryItemTextEdit10.AutoHeight = false;
            this.repositoryItemTextEdit10.Name = "repositoryItemTextEdit10";
            // 
            // repositoryItemTextEdit13
            // 
            this.repositoryItemTextEdit13.AutoHeight = false;
            this.repositoryItemTextEdit13.Name = "repositoryItemTextEdit13";
            // 
            // tabMonthlyLedger
            // 
            this.tabMonthlyLedger.Controls.Add(this.gridControl6);
            this.tabMonthlyLedger.Name = "tabMonthlyLedger";
            this.tabMonthlyLedger.Size = new System.Drawing.Size(710, 381);
            this.tabMonthlyLedger.Text = "MonthlyLedger";
            // 
            // gridControl6
            // 
            this.gridControl6.Location = new System.Drawing.Point(3, 12);
            this.gridControl6.MainView = this.gridView6;
            this.gridControl6.Name = "gridControl6";
            this.gridControl6.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemTextEdit15,
            this.repositoryItemTextEdit16,
            this.repositoryItemTextEdit14,
            this.repositoryItemTextEdit17,
            this.repositoryItemComboBox5});
            this.gridControl6.Size = new System.Drawing.Size(704, 357);
            this.gridControl6.TabIndex = 3;
            this.gridControl6.UseEmbeddedNavigator = true;
            this.gridControl6.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView6});
            // 
            // gridView6
            // 
            this.gridView6.GridControl = this.gridControl6;
            this.gridView6.Name = "gridView6";
            this.gridView6.OptionsView.ShowGroupPanel = false;
            // 
            // repositoryItemTextEdit15
            // 
            this.repositoryItemTextEdit15.AutoHeight = false;
            this.repositoryItemTextEdit15.Name = "repositoryItemTextEdit15";
            // 
            // repositoryItemTextEdit16
            // 
            this.repositoryItemTextEdit16.AutoHeight = false;
            this.repositoryItemTextEdit16.Name = "repositoryItemTextEdit16";
            // 
            // repositoryItemTextEdit14
            // 
            this.repositoryItemTextEdit14.AutoHeight = false;
            this.repositoryItemTextEdit14.Name = "repositoryItemTextEdit14";
            // 
            // repositoryItemTextEdit17
            // 
            this.repositoryItemTextEdit17.AutoHeight = false;
            this.repositoryItemTextEdit17.Name = "repositoryItemTextEdit17";
            // 
            // repositoryItemComboBox5
            // 
            this.repositoryItemComboBox5.AutoHeight = false;
            this.repositoryItemComboBox5.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemComboBox5.Name = "repositoryItemComboBox5";
            // 
            // tabPetReport
            // 
            this.tabPetReport.Controls.Add(this.gridControl7);
            this.tabPetReport.Name = "tabPetReport";
            this.tabPetReport.Size = new System.Drawing.Size(710, 381);
            this.tabPetReport.Text = "PetReport";
            // 
            // gridControl7
            // 
            this.gridControl7.Location = new System.Drawing.Point(3, 12);
            this.gridControl7.MainView = this.gridView7;
            this.gridControl7.Name = "gridControl7";
            this.gridControl7.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemTextEdit19,
            this.repositoryItemTextEdit20,
            this.repositoryItemTextEdit18,
            this.repositoryItemTextEdit21,
            this.repositoryItemComboBox6});
            this.gridControl7.Size = new System.Drawing.Size(704, 357);
            this.gridControl7.TabIndex = 3;
            this.gridControl7.UseEmbeddedNavigator = true;
            this.gridControl7.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView7});
            // 
            // gridView7
            // 
            this.gridView7.GridControl = this.gridControl7;
            this.gridView7.Name = "gridView7";
            this.gridView7.OptionsView.ShowGroupPanel = false;
            // 
            // repositoryItemTextEdit19
            // 
            this.repositoryItemTextEdit19.AutoHeight = false;
            this.repositoryItemTextEdit19.Name = "repositoryItemTextEdit19";
            // 
            // repositoryItemTextEdit20
            // 
            this.repositoryItemTextEdit20.AutoHeight = false;
            this.repositoryItemTextEdit20.Name = "repositoryItemTextEdit20";
            // 
            // repositoryItemTextEdit18
            // 
            this.repositoryItemTextEdit18.AutoHeight = false;
            this.repositoryItemTextEdit18.Name = "repositoryItemTextEdit18";
            // 
            // repositoryItemTextEdit21
            // 
            this.repositoryItemTextEdit21.AutoHeight = false;
            this.repositoryItemTextEdit21.Name = "repositoryItemTextEdit21";
            // 
            // repositoryItemComboBox6
            // 
            this.repositoryItemComboBox6.AutoHeight = false;
            this.repositoryItemComboBox6.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemComboBox6.Name = "repositoryItemComboBox6";
            // 
            // btnLoad
            // 
            this.btnLoad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLoad.Location = new System.Drawing.Point(506, 431);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(104, 42);
            this.btnLoad.TabIndex = 34;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click_1);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(621, 431);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(104, 42);
            this.btnSave.TabIndex = 35;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 485);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.tabsform);
            this.Controls.Add(this.label1);
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "PetShop";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsTransaction)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsPetFood)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsPet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCustomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsEmployee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.monthlyLedgerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabsform)).EndInit();
            this.tabsform.ResumeLayout(false);
            this.tabCustomer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grcCustomers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvCustomers)).EndInit();
            this.tabEmployee.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grcEmployees)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvEmployees)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).EndInit();
            this.tabPets.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grcPets)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvPets)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit26)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit4)).EndInit();
            this.tabPetFoods.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grcPetFoods)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvPetFoods)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit27)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox3)).EndInit();
            this.tabTransactions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grcTransactions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvTransactions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit22)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit23)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit24)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit25)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit13)).EndInit();
            this.tabMonthlyLedger.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit17)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox5)).EndInit();
            this.tabPetReport.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit19)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit20)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit18)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private BindingSource bsTransaction;
        private Label label1;
        private BindingSource bsPet;
        private BindingSource bsPetFood;
        private BindingSource bsCustomer;
        private BindingSource bsEmployee;
        private BindingSource monthlyLedgerBindingSource;
        private DataGridViewTextBoxColumn customerIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn employeeIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn petPriceDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn transactionDateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn animalTypeDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn Year;
        private DataGridViewTextBoxColumn Month;
        private DataGridViewTextBoxColumn AnimalType;
        private DevExpress.XtraTab.XtraTabControl tabsform;
        private DevExpress.XtraTab.XtraTabPage tabCustomer;
        private DevExpress.XtraTab.XtraTabPage tabEmployee;
        private DevExpress.XtraTab.XtraTabPage tabPets;
        private DevExpress.XtraGrid.GridControl grcCustomers;
        private DevExpress.XtraGrid.Views.Grid.GridView grvCustomers;
        private DevExpress.XtraGrid.Columns.GridColumn colCustName;
        private DevExpress.XtraGrid.Columns.GridColumn colCustSurname;
        private DevExpress.XtraGrid.Columns.GridColumn colPhone;
        private DevExpress.XtraGrid.Columns.GridColumn colTin;
        private DevExpress.XtraGrid.GridControl grcEmployees;
        private DevExpress.XtraGrid.Views.Grid.GridView grvEmployees;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colSurname;
        private DevExpress.XtraGrid.Columns.GridColumn colType;
        private DevExpress.XtraGrid.Columns.GridColumn colSalary;
        private DevExpress.XtraGrid.GridControl grcPets;
        private DevExpress.XtraGrid.Views.Grid.GridView grvPets;
        private DevExpress.XtraGrid.Columns.GridColumn colAnimalType;
        private DevExpress.XtraGrid.Columns.GridColumn colBreed;
        private DevExpress.XtraGrid.Columns.GridColumn colStatus;
        private DevExpress.XtraGrid.Columns.GridColumn colPrice;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit4;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit3;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit2;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit5;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repositoryItemComboBox1;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repositoryItemComboBox2;
        private DevExpress.XtraGrid.Columns.GridColumn Cost;
        private DevExpress.XtraTab.XtraTabPage tabPetFoods;
        private DevExpress.XtraGrid.GridControl grcPetFoods;
        private DevExpress.XtraGrid.Views.Grid.GridView grvPetFoods;
        private DevExpress.XtraGrid.Columns.GridColumn colAnimalTypeFood;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repositoryItemComboBox3;
        private DevExpress.XtraGrid.Columns.GridColumn colFoodPrice;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit7;
        private DevExpress.XtraGrid.Columns.GridColumn colFoodCost;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit8;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit6;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit9;
        private DevExpress.XtraTab.XtraTabPage tabTransactions;
        private DevExpress.XtraGrid.GridControl grcTransactions;
        private DevExpress.XtraGrid.Views.Grid.GridView grvTransactions;
        private DevExpress.XtraGrid.Columns.GridColumn colTransactionDate;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repositoryItemComboBox4;
        private DevExpress.XtraGrid.Columns.GridColumn colCustomerName;
        private DevExpress.XtraGrid.Columns.GridColumn colEmployeeName;
        private DevExpress.XtraGrid.Columns.GridColumn colPetID;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit11;
        private DevExpress.XtraGrid.Columns.GridColumn colPetPrice;
        private DevExpress.XtraGrid.Columns.GridColumn colFoodID;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit22;
        private DevExpress.XtraGrid.Columns.GridColumn colPetFoodQty;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit23;
        private DevExpress.XtraGrid.Columns.GridColumn colPetFoodPrice;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit24;
        private DevExpress.XtraGrid.Columns.GridColumn colTotal;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit25;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit12;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit10;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit13;
        private DevExpress.XtraTab.XtraTabPage tabMonthlyLedger;
        private DevExpress.XtraGrid.GridControl gridControl6;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView6;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repositoryItemComboBox5;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit14;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit15;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit16;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit17;
        private DevExpress.XtraTab.XtraTabPage tabPetReport;
        private DevExpress.XtraGrid.GridControl gridControl7;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView7;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repositoryItemComboBox6;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit18;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit19;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit20;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit21;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit26;
        private DevExpress.XtraGrid.Columns.GridColumn colPetFoodStatus;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit27;
        private DevExpress.XtraGrid.Columns.GridColumn colCustomerID;
        private Button btnLoad;
        private Button btnSave;
    }
}