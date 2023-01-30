//namespace Session_11
//{
//    partial class Form1
//    {
//        /// <summary>
//        ///  Required designer variable.
//        /// </summary>
//        private System.ComponentModel.IContainer components = null;

//        /// <summary>
//        ///  Clean up any resources being used.
//        /// </summary>
//        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
//        protected override void Dispose(bool disposing)
//        {
//            if (disposing && (components != null))
//            {
//                components.Dispose();
//            }
//            base.Dispose(disposing);
//        }

//        #region Windows Form Designer generated code

//        /// <summary>
//        ///  Required method for Designer support - do not modify
//        ///  the contents of this method with the code editor.
//        /// </summary>
//        private void InitializeComponent()
//        {
//            this.components = new System.ComponentModel.Container();
//            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
//            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
//            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
//            this.bsTransaction = new System.Windows.Forms.BindingSource(this.components);
//            this.grvPetFood = new System.Windows.Forms.DataGridView();
//            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
//            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
//            this.petFoodPriceDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
//            this.petFoodCostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
//            this.bsPetFood = new System.Windows.Forms.BindingSource(this.components);
//            this.label1 = new System.Windows.Forms.Label();
//            this.bsPet = new System.Windows.Forms.BindingSource(this.components);
//            this.bsCustomer = new System.Windows.Forms.BindingSource(this.components);
//            this.label4 = new System.Windows.Forms.Label();
//            this.bsEmployee = new System.Windows.Forms.BindingSource(this.components);
//            this.monthlyLedgerBindingSource = new System.Windows.Forms.BindingSource(this.components);
//            this.button2 = new System.Windows.Forms.Button();
//            this.button3 = new System.Windows.Forms.Button();
//            this.label7 = new System.Windows.Forms.Label();
//            this.Year = new System.Windows.Forms.DataGridViewTextBoxColumn();
//            this.Month = new System.Windows.Forms.DataGridViewTextBoxColumn();
//            this.AnimalType = new System.Windows.Forms.DataGridViewTextBoxColumn();
//            this.tabsform = new DevExpress.XtraTab.XtraTabControl();
//            this.tabCustomer = new DevExpress.XtraTab.XtraTabPage();
//            this.grcCustomers = new DevExpress.XtraGrid.GridControl();
//            this.grvCustomers = new DevExpress.XtraGrid.Views.Grid.GridView();
//            this.colCustName = new DevExpress.XtraGrid.Columns.GridColumn();
//            this.colCustSurname = new DevExpress.XtraGrid.Columns.GridColumn();
//            this.colPhone = new DevExpress.XtraGrid.Columns.GridColumn();
//            this.colTin = new DevExpress.XtraGrid.Columns.GridColumn();
//            this.tabEmployee = new DevExpress.XtraTab.XtraTabPage();
//            this.grcEmployees = new DevExpress.XtraGrid.GridControl();
//            this.grvEmployees = new DevExpress.XtraGrid.Views.Grid.GridView();
//            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
//            this.repositoryItemTextEdit5 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
//            this.colSurname = new DevExpress.XtraGrid.Columns.GridColumn();
//            this.colType = new DevExpress.XtraGrid.Columns.GridColumn();
//            this.repositoryItemComboBox1 = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
//            this.colSalary = new DevExpress.XtraGrid.Columns.GridColumn();
//            this.tabPets = new DevExpress.XtraTab.XtraTabPage();
//            this.grcPets = new DevExpress.XtraGrid.GridControl();
//            this.grvPets = new DevExpress.XtraGrid.Views.Grid.GridView();
//            this.colAnimalType = new DevExpress.XtraGrid.Columns.GridColumn();
//            this.repositoryItemComboBox2 = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
//            this.colBreed = new DevExpress.XtraGrid.Columns.GridColumn();
//            this.repositoryItemTextEdit3 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
//            this.colStatus = new DevExpress.XtraGrid.Columns.GridColumn();
//            this.colPrice = new DevExpress.XtraGrid.Columns.GridColumn();
//            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
//            this.Cost = new DevExpress.XtraGrid.Columns.GridColumn();
//            this.repositoryItemTextEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
//            this.repositoryItemTextEdit4 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
//            this.tabPetFoods = new DevExpress.XtraTab.XtraTabPage();
//            this.grcPetFoods = new DevExpress.XtraGrid.GridControl();
//            this.grvPetFoods = new DevExpress.XtraGrid.Views.Grid.GridView();
//            this.colAnimalTypeFood = new DevExpress.XtraGrid.Columns.GridColumn();
//            this.repositoryItemComboBox3 = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
//            this.colFoodPrice = new DevExpress.XtraGrid.Columns.GridColumn();
//            this.repositoryItemTextEdit7 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
//            this.colFoodCost = new DevExpress.XtraGrid.Columns.GridColumn();
//            this.repositoryItemTextEdit8 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
//            this.repositoryItemTextEdit6 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
//            this.repositoryItemTextEdit9 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
//            this.tabTransactions = new DevExpress.XtraTab.XtraTabPage();
//            this.grcTransactions = new DevExpress.XtraGrid.GridControl();
//            this.grvTransactions = new DevExpress.XtraGrid.Views.Grid.GridView();
//            this.colTransactionDate = new DevExpress.XtraGrid.Columns.GridColumn();
//            this.repositoryItemComboBox4 = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
//            this.CustomerName = new DevExpress.XtraGrid.Columns.GridColumn();
//            this.colEmployeeName = new DevExpress.XtraGrid.Columns.GridColumn();
//            this.colPetID = new DevExpress.XtraGrid.Columns.GridColumn();
//            this.repositoryItemTextEdit11 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
//            this.colPetPrice = new DevExpress.XtraGrid.Columns.GridColumn();
//            this.colFoodID = new DevExpress.XtraGrid.Columns.GridColumn();
//            this.repositoryItemTextEdit22 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
//            this.colPetFoodQty = new DevExpress.XtraGrid.Columns.GridColumn();
//            this.repositoryItemTextEdit23 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
//            this.colPetFoodPrice = new DevExpress.XtraGrid.Columns.GridColumn();
//            this.repositoryItemTextEdit24 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
//            this.colTotal = new DevExpress.XtraGrid.Columns.GridColumn();
//            this.repositoryItemTextEdit25 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
//            this.repositoryItemTextEdit12 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
//            this.repositoryItemTextEdit10 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
//            this.repositoryItemTextEdit13 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
//            this.tabMonthlyLedger = new DevExpress.XtraTab.XtraTabPage();
//            this.gridControl6 = new DevExpress.XtraGrid.GridControl();
//            this.gridView6 = new DevExpress.XtraGrid.Views.Grid.GridView();
//            this.repositoryItemTextEdit15 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
//            this.repositoryItemTextEdit16 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
//            this.repositoryItemTextEdit14 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
//            this.repositoryItemTextEdit17 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
//            this.repositoryItemComboBox5 = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
//            this.tabPetReport = new DevExpress.XtraTab.XtraTabPage();
//            this.gridControl7 = new DevExpress.XtraGrid.GridControl();
//            this.gridView7 = new DevExpress.XtraGrid.Views.Grid.GridView();
//            this.repositoryItemTextEdit19 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
//            this.repositoryItemTextEdit20 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
//            this.repositoryItemTextEdit18 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
//            this.repositoryItemTextEdit21 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
//            this.repositoryItemComboBox6 = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
//            ((System.ComponentModel.ISupportInitialize)(this.bsTransaction)).BeginInit();
//            this.gridControl4 = new DevExpress.XtraGrid.GridControl();
//            this.gridView4 = new DevExpress.XtraGrid.Views.Grid.GridView();
//            this.gridControl5 = new DevExpress.XtraGrid.GridControl();
//            this.gridView5 = new DevExpress.XtraGrid.Views.Grid.GridView();
//            this.buttonEdit1 = new DevExpress.XtraEditors.ButtonEdit();
//            this.buttonEdit2 = new DevExpress.XtraEditors.ButtonEdit();
//            this.buttonEdit3 = new DevExpress.XtraEditors.ButtonEdit();
//            this.buttonEdit4 = new DevExpress.XtraEditors.ButtonEdit();
//            this.gridControl6 = new DevExpress.XtraGrid.GridControl();
//            this.gridView6 = new DevExpress.XtraGrid.Views.Grid.GridView();
//            this.gridControl7 = new DevExpress.XtraGrid.GridControl();
//            this.gridView7 = new DevExpress.XtraGrid.Views.Grid.GridView();
//            this.gridControl8 = new DevExpress.XtraGrid.GridControl();
//            this.gridView8 = new DevExpress.XtraGrid.Views.Grid.GridView();
//            this.buttonEdit5 = new DevExpress.XtraEditors.ButtonEdit();
//            this.buttonEdit6 = new DevExpress.XtraEditors.ButtonEdit();
//            this.An = new DevExpress.XtraGrid.Columns.GridColumn();
//            this.pets = new DevExpress.XtraEditors.LabelControl();
//            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
//            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
//            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
//            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
//            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
//            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
//            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
//            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
//            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
//            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
//            this.gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
//            ((System.ComponentModel.ISupportInitialize)(this.transactionBindingSource)).BeginInit();
//            ((System.ComponentModel.ISupportInitialize)(this.grvPetFood)).BeginInit();
//            ((System.ComponentModel.ISupportInitialize)(this.bsPetFood)).BeginInit();
//            ((System.ComponentModel.ISupportInitialize)(this.bsPet)).BeginInit();
//            ((System.ComponentModel.ISupportInitialize)(this.bsCustomer)).BeginInit();
//            ((System.ComponentModel.ISupportInitialize)(this.bsEmployee)).BeginInit();
//            ((System.ComponentModel.ISupportInitialize)(this.monthlyLedgerBindingSource)).BeginInit();
//            ((System.ComponentModel.ISupportInitialize)(this.tabsform)).BeginInit();
//            this.tabsform.SuspendLayout();
//            this.tabCustomer.SuspendLayout();
//            ((System.ComponentModel.ISupportInitialize)(this.grcCustomers)).BeginInit();
//            ((System.ComponentModel.ISupportInitialize)(this.grvCustomers)).BeginInit();
//            this.tabEmployee.SuspendLayout();
//            ((System.ComponentModel.ISupportInitialize)(this.grcEmployees)).BeginInit();
//            ((System.ComponentModel.ISupportInitialize)(this.grvEmployees)).BeginInit();
//            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit5)).BeginInit();
//            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).BeginInit();
//            this.tabPets.SuspendLayout();
//            ((System.ComponentModel.ISupportInitialize)(this.grcPets)).BeginInit();
//            ((System.ComponentModel.ISupportInitialize)(this.grvPets)).BeginInit();
//            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox2)).BeginInit();
//            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit3)).BeginInit();
//            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
//            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit2)).BeginInit();
//            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit4)).BeginInit();
//            this.tabPetFoods.SuspendLayout();
//            ((System.ComponentModel.ISupportInitialize)(this.grcPetFoods)).BeginInit();
//            ((System.ComponentModel.ISupportInitialize)(this.grvPetFoods)).BeginInit();
//            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox3)).BeginInit();
//            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit7)).BeginInit();
//            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit8)).BeginInit();
//            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit6)).BeginInit();
//            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit9)).BeginInit();
//            this.tabTransactions.SuspendLayout();
//            ((System.ComponentModel.ISupportInitialize)(this.grcTransactions)).BeginInit();
//            ((System.ComponentModel.ISupportInitialize)(this.grvTransactions)).BeginInit();
//            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox4)).BeginInit();
//            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit11)).BeginInit();
//            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit22)).BeginInit();
//            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit23)).BeginInit();
//            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit24)).BeginInit();
//            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit25)).BeginInit();
//            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit12)).BeginInit();
//            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit10)).BeginInit();
//            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit13)).BeginInit();
//            this.tabMonthlyLedger.SuspendLayout();
//            ((System.ComponentModel.ISupportInitialize)(this.gridControl6)).BeginInit();
//            ((System.ComponentModel.ISupportInitialize)(this.gridView6)).BeginInit();
//            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit15)).BeginInit();
//            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit16)).BeginInit();
//            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit14)).BeginInit();
//            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit17)).BeginInit();
//            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox5)).BeginInit();
//            this.tabPetReport.SuspendLayout();
//            ((System.ComponentModel.ISupportInitialize)(this.gridControl7)).BeginInit();
//            ((System.ComponentModel.ISupportInitialize)(this.gridView7)).BeginInit();
//            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit19)).BeginInit();
//            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit20)).BeginInit();
//            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit18)).BeginInit();
//            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit21)).BeginInit();
//            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox6)).BeginInit();
//            ((System.ComponentModel.ISupportInitialize)(this.gridControl4)).BeginInit();
//            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).BeginInit();
//            ((System.ComponentModel.ISupportInitialize)(this.gridControl5)).BeginInit();
//            ((System.ComponentModel.ISupportInitialize)(this.gridView5)).BeginInit();
//            ((System.ComponentModel.ISupportInitialize)(this.buttonEdit1.Properties)).BeginInit();
//            ((System.ComponentModel.ISupportInitialize)(this.buttonEdit2.Properties)).BeginInit();
//            ((System.ComponentModel.ISupportInitialize)(this.buttonEdit3.Properties)).BeginInit();
//            ((System.ComponentModel.ISupportInitialize)(this.buttonEdit4.Properties)).BeginInit();
//            ((System.ComponentModel.ISupportInitialize)(this.gridControl6)).BeginInit();
//            ((System.ComponentModel.ISupportInitialize)(this.gridView6)).BeginInit();
//            ((System.ComponentModel.ISupportInitialize)(this.gridControl7)).BeginInit();
//            ((System.ComponentModel.ISupportInitialize)(this.gridView7)).BeginInit();
//            ((System.ComponentModel.ISupportInitialize)(this.gridControl8)).BeginInit();
//            ((System.ComponentModel.ISupportInitialize)(this.gridView8)).BeginInit();
//            ((System.ComponentModel.ISupportInitialize)(this.buttonEdit5.Properties)).BeginInit();
//            ((System.ComponentModel.ISupportInitialize)(this.buttonEdit6.Properties)).BeginInit();
//            this.SuspendLayout();
//            // 
//            // bsTransaction
//            // 
//            this.bsTransaction.DataSource = typeof(Session_11.Transaction);
//            // 
//            // grvPetFood
//            // 
//            this.grvPetFood.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
//            this.grvPetFood.AutoGenerateColumns = false;
//            this.grvPetFood.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
//            this.grvPetFood.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
//            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
//            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
//            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
//            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
//            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
//            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
//            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
//            this.grvPetFood.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
//            this.grvPetFood.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
//            this.grvPetFood.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
//            this.dataGridViewTextBoxColumn2,
//            this.Status,
//            this.petFoodPriceDataGridViewTextBoxColumn1,
//            this.petFoodCostDataGridViewTextBoxColumn});
//            this.grvPetFood.DataSource = this.bsPetFood;
//            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
//            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
//            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
//            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
//            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
//            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
//            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
//            this.grvPetFood.DefaultCellStyle = dataGridViewCellStyle5;
//            this.grvPetFood.Location = new System.Drawing.Point(734, 498);
//            this.grvPetFood.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
//            this.grvPetFood.Name = "grvPetFood";
//            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
//            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
//            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
//            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
//            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
//            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
//            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
//            this.grvPetFood.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
//            this.grvPetFood.RowHeadersWidth = 51;
//            this.grvPetFood.RowTemplate.Height = 29;
//            this.grvPetFood.Size = new System.Drawing.Size(693, 344);
//            this.grvPetFood.TabIndex = 0;
//            // 
//            // dataGridViewTextBoxColumn2
//            // 
//            this.dataGridViewTextBoxColumn2.DataPropertyName = "AnimalType";
//            this.dataGridViewTextBoxColumn2.HeaderText = "AnimalType";
//            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
//            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
//            // 
//            // Status
//            // 
//            this.Status.DataPropertyName = "Status";
//            this.Status.HeaderText = "Status";
//            this.Status.MinimumWidth = 6;
//            this.Status.Name = "Status";
//            // 
//            // petFoodPriceDataGridViewTextBoxColumn1
//            // 
//            this.petFoodPriceDataGridViewTextBoxColumn1.DataPropertyName = "PetFoodPrice";
//            this.petFoodPriceDataGridViewTextBoxColumn1.HeaderText = "PetFoodPrice";
//            this.petFoodPriceDataGridViewTextBoxColumn1.MinimumWidth = 6;
//            this.petFoodPriceDataGridViewTextBoxColumn1.Name = "petFoodPriceDataGridViewTextBoxColumn1";
//            // 
//            // petFoodCostDataGridViewTextBoxColumn
//            // 
//            this.petFoodCostDataGridViewTextBoxColumn.DataPropertyName = "PetFoodCost";
//            this.petFoodCostDataGridViewTextBoxColumn.HeaderText = "PetFoodCost";
//            this.petFoodCostDataGridViewTextBoxColumn.MinimumWidth = 6;
//            this.petFoodCostDataGridViewTextBoxColumn.Name = "petFoodCostDataGridViewTextBoxColumn";
//            // 
//            // bsPetFood
//            // 
//            this.bsPetFood.DataSource = typeof(Session_11.PetFood);
//            // 
//            // label1
//            // 
//            this.label1.AutoSize = true;
//            this.label1.Location = new System.Drawing.Point(734, 460);
//            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
//            this.label1.Name = "label1";
//            this.label1.Size = new System.Drawing.Size(154, 30);
//            this.label1.TabIndex = 1;
//            this.label1.Text = "Pet Food Menu";
//            // 
//            // bsPet
//            // 
//            this.bsPet.DataSource = typeof(Session_11.Pet);
//            // 
//            // bsCustomer
//            // 
//            this.bsCustomer.DataSource = typeof(Session_11.Customer);
//            this.bsCustomer.CurrentChanged += new System.EventHandler(this.customerBindingSource1_CurrentChanged);
//            // 
//            // label4
//            // 
//            this.label4.AutoSize = true;
//            this.label4.Location = new System.Drawing.Point(684, 908);
//            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
//            this.label4.Name = "label4";
//            this.label4.Size = new System.Drawing.Size(111, 30);
//            this.label4.TabIndex = 7;
//            this.label4.Text = "Customers";
//            // 
//            // bsEmployee
//            // 
//            this.bsEmployee.DataSource = typeof(Session_11.Employee);
//            // 
//            // monthlyLedgerBindingSource
//            // 
//            this.monthlyLedgerBindingSource.DataSource = typeof(Session_11.MonthlyLedger);
//            // 
//            // button2
//            // 
//            this.button2.Location = new System.Drawing.Point(1102, 850);
//            this.button2.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
//            this.button2.Name = "button2";
//            this.button2.Size = new System.Drawing.Size(141, 44);
//            this.button2.TabIndex = 23;
//            this.button2.Text = "Add";
//            this.button2.UseVisualStyleBackColor = true;
//            this.button2.Click += new System.EventHandler(this.button2_Click);
//            // 
//            // button3
//            // 
//            this.button3.Location = new System.Drawing.Point(1253, 850);
//            this.button3.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
//            this.button3.Name = "button3";
//            this.button3.Size = new System.Drawing.Size(141, 44);
//            this.button3.TabIndex = 24;
//            this.button3.Text = "Remove";
//            this.button3.UseVisualStyleBackColor = true;
//            this.button3.Click += new System.EventHandler(this.button3_Click);
//            // 
//            // label7
//            // 
//            this.label7.AutoSize = true;
//            this.label7.Location = new System.Drawing.Point(1497, 460);
//            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
//            this.label7.Name = "label7";
//            this.label7.Size = new System.Drawing.Size(109, 30);
//            this.label7.TabIndex = 27;
//            this.label7.Text = "Pet Report";
//            // 
//            // Year
//            // 
//            this.Year.HeaderText = "colYearReport";
//            this.Year.MinimumWidth = 6;
//            this.Year.Name = "Year";
//            this.Year.ReadOnly = true;
//            this.Year.Width = 125;
//            // 
//            // Month
//            // 
//            this.Month.HeaderText = "colMonthReport";
//            this.Month.MinimumWidth = 6;
//            this.Month.Name = "Month";
//            this.Month.ReadOnly = true;
//            this.Month.Width = 125;
//            // 
//            // AnimalType
//            // 
//            this.AnimalType.HeaderText = "colAnimalTypeReport";
//            this.AnimalType.MinimumWidth = 6;
//            this.AnimalType.Name = "AnimalType";
//            this.AnimalType.ReadOnly = true;
//            this.AnimalType.Width = 125;
//            // 
//            // tabsform
//            // 
//            this.tabsform.Location = new System.Drawing.Point(14, 15);
//            this.tabsform.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
//            this.tabsform.Name = "tabsform";
//            this.tabsform.SelectedTabPage = this.tabCustomer;
//            this.tabsform.Size = new System.Drawing.Size(2174, 981);
//            this.tabsform.TabIndex = 32;
//            this.tabsform.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
//            this.tabCustomer,
//            this.tabEmployee,
//            this.tabPets,
//            this.tabPetFoods,
//            this.tabTransactions,
//            this.tabMonthlyLedger,
//            this.tabPetReport});
//            // 
//            // tabCustomer
//            // 
//            this.tabCustomer.Controls.Add(this.grcCustomers);
//            this.tabCustomer.Controls.Add(this.labelControl3);
//            this.tabCustomer.Controls.Add(this.labelControl2);
//            this.tabCustomer.Controls.Add(this.pets);
//            this.tabCustomer.Controls.Add(this.buttonEdit2);
//            this.tabCustomer.Controls.Add(this.buttonEdit1);
//            this.tabCustomer.Controls.Add(this.gridControl5);
//            this.tabCustomer.Controls.Add(this.gridControl4);
//            this.tabCustomer.Controls.Add(this.gridControl3);
//            this.tabCustomer.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
//            this.tabCustomer.Name = "tabCustomer";
//            this.tabCustomer.Size = new System.Drawing.Size(2170, 936);
//            this.tabCustomer.Text = "Customers";
//            // 
//            // grcCustomers
//            // 
//            this.grcCustomers.DataSource = this.bsCustomer;
//            this.grcCustomers.Location = new System.Drawing.Point(3, 13);
//            this.grcCustomers.MainView = this.grvCustomers;
//            this.grcCustomers.Name = "grcCustomers";
//            this.grcCustomers.Size = new System.Drawing.Size(704, 361);
//            this.grcCustomers.TabIndex = 2;
//            this.grcCustomers.UseEmbeddedNavigator = true;
//            this.grcCustomers.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
//            this.grvCustomers});
//            this.grcCustomers.Click += new System.EventHandler(this.gridControl3_Click);
//            this.gridControl3.DataSource = this.bsCustomer;
//            this.gridControl3.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
//            this.gridControl3.Location = new System.Drawing.Point(53, 511);
//            this.gridControl3.MainView = this.gridView3;
//            this.gridControl3.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
//            this.gridControl3.Name = "gridControl3";
//            this.gridControl3.Size = new System.Drawing.Size(1716, 425);
//            this.gridControl3.TabIndex = 2;
//            this.gridControl3.UseEmbeddedNavigator = true;
//            this.gridControl3.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
//            this.gridView3});
//            this.gridControl3.Click += new System.EventHandler(this.gridControl3_Click);
//            // 
//            // grvCustomers
//            // 
//            this.grvCustomers.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
//            this.colCustName,
//            this.colCustSurname,
//            this.colPhone,
//            this.colTin});
//            this.grvCustomers.GridControl = this.grcCustomers;
//            this.grvCustomers.Name = "grvCustomers";
//            this.grvCustomers.OptionsView.ShowGroupPanel = false;
//            this.gridView3.DetailHeight = 700;
//            this.gridView3.GridControl = this.gridControl3;
//            this.gridView3.Name = "gridView3";
//            // 
//            // colCustName
//            // 
//            this.colCustName.Caption = "Name";
//            this.colCustName.FieldName = "Name";
//            this.colCustName.MinWidth = 34;
//            this.colCustName.Name = "colCustName";
//            this.colCustName.Visible = true;
//            this.colCustName.VisibleIndex = 0;
//            this.colCustName.Width = 129;
//            // 
//            // colCustSurname
//            // 
//            this.colCustSurname.Caption = "Surname";
//            this.colCustSurname.FieldName = "Surname";
//            this.colCustSurname.MinWidth = 34;
//            this.colCustSurname.Name = "colCustSurname";
//            this.colCustSurname.Visible = true;
//            this.colCustSurname.VisibleIndex = 1;
//            this.colCustSurname.Width = 129;
//            // 
//            // colPhone
//            // 
//            this.colPhone.Caption = "Phone";
//            this.colPhone.FieldName = "Phone";
//            this.colPhone.MinWidth = 34;
//            this.colPhone.Name = "colPhone";
//            this.colPhone.Visible = true;
//            this.colPhone.VisibleIndex = 2;
//            this.colPhone.Width = 129;
//            // 
//            // colTin
//            // 
//            this.colTin.Caption = "TIN";
//            this.colTin.FieldName = "TIN";
//            this.colTin.MinWidth = 34;
//            this.colTin.Name = "colTin";
//            this.colTin.Visible = true;
//            this.colTin.VisibleIndex = 3;
//            this.colTin.Width = 129;
//            // 
//            // tabEmployee
//            // 
//            this.tabEmployee.Controls.Add(this.grcEmployees);
//            this.tabEmployee.Controls.Add(this.labelControl5);
//            this.tabEmployee.Controls.Add(this.labelControl4);
//            this.tabEmployee.Controls.Add(this.labelControl1);
//            this.tabEmployee.Controls.Add(this.gridControl7);
//            this.tabEmployee.Controls.Add(this.gridControl6);
//            this.tabEmployee.Controls.Add(this.buttonEdit4);
//            this.tabEmployee.Controls.Add(this.buttonEdit3);
//            this.tabEmployee.Controls.Add(this.gridControl1);
//            this.tabEmployee.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
//            this.tabEmployee.Name = "tabEmployee";
//            this.tabEmployee.Size = new System.Drawing.Size(2170, 936);
//            this.tabEmployee.Text = "Employees";
//            // 
//            // grcEmployees
//            // 
//            this.grcEmployees.DataSource = this.bsEmployee;
//            this.grcEmployees.Location = new System.Drawing.Point(3, 12);
//            this.grcEmployees.MainView = this.grvEmployees;
//            this.grcEmployees.Name = "grcEmployees";
//            this.grcEmployees.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
//            this.gridControl1.DataSource = this.bsEmployee;
//            this.gridControl1.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
//            this.gridControl1.Location = new System.Drawing.Point(25, 44);
//            this.gridControl1.MainView = this.gridView1;
//            this.gridControl1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
//            this.gridControl1.Name = "gridControl1";
//            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
//            this.repositoryItemComboBox1,
//            this.repositoryItemTextEdit5});
//            this.grcEmployees.Size = new System.Drawing.Size(704, 366);
//            this.grcEmployees.TabIndex = 1;
//            this.grcEmployees.UseEmbeddedNavigator = true;
//            this.grcEmployees.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
//            this.grvEmployees});
//            this.gridControl1.Size = new System.Drawing.Size(1782, 424);
//            this.gridControl1.TabIndex = 1;
//            this.gridControl1.UseEmbeddedNavigator = true;
//            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
//            this.gridView1});
//            // 
//            // grvEmployees
//            // 
//            this.grvEmployees.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
//            this.colName,
//            this.colSurname,
//            this.colType,
//            this.colSalary});
//            this.grvEmployees.GridControl = this.grcEmployees;
//            this.grvEmployees.Name = "grvEmployees";
//            this.grvEmployees.OptionsView.ShowGroupPanel = false;
//            this.gridView1.DetailHeight = 700;
//            this.gridView1.GridControl = this.gridControl1;
//            this.gridView1.Name = "gridView1";
//            // 
//            // colName
//            // 
//            this.colName.Caption = "Name";
//            this.colName.ColumnEdit = this.repositoryItemTextEdit5;
//            this.colName.FieldName = "Name";
//            this.colName.MinWidth = 34;
//            this.colName.Name = "colName";
//            this.colName.Visible = true;
//            this.colName.VisibleIndex = 0;
//            this.colName.Width = 129;
//            // 
//            // repositoryItemTextEdit5
//            // 
//            this.repositoryItemTextEdit5.AutoHeight = false;
//            this.repositoryItemTextEdit5.Name = "repositoryItemTextEdit5";
//            // 
//            // colSurname
//            // 
//            this.colSurname.Caption = "Surname";
//            this.colSurname.ColumnEdit = this.repositoryItemTextEdit5;
//            this.colSurname.FieldName = "Surname";
//            this.colSurname.MinWidth = 34;
//            this.colSurname.Name = "colSurname";
//            this.colSurname.Visible = true;
//            this.colSurname.VisibleIndex = 1;
//            this.colSurname.Width = 129;
//            // 
//            // colType
//            // 
//            this.colType.Caption = "Employee Type";
//            this.colType.ColumnEdit = this.repositoryItemComboBox1;
//            this.colType.FieldName = "EmployeeType";
//            this.colType.MinWidth = 34;
//            this.colType.Name = "colType";
//            this.colType.Visible = true;
//            this.colType.VisibleIndex = 2;
//            this.colType.Width = 129;
//            // 
//            // repositoryItemComboBox1
//            // 
//            this.repositoryItemComboBox1.AutoHeight = false;
//            this.repositoryItemComboBox1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
//            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
//            this.repositoryItemComboBox1.Name = "repositoryItemComboBox1";
//            // 
//            // colSalary
//            // 
//            this.colSalary.Caption = "Salary";
//            this.colSalary.ColumnEdit = this.repositoryItemTextEdit5;
//            this.colSalary.FieldName = "SalaryPerMonth";
//            this.colSalary.MinWidth = 34;
//            this.colSalary.Name = "colSalary";
//            this.colSalary.Visible = true;
//            this.colSalary.VisibleIndex = 3;
//            this.colSalary.Width = 129;
//            // 
//            // tabPets
//            // 
//            this.tabPets.Controls.Add(this.grcPets);
//            this.tabPets.Controls.Add(this.labelControl7);
//            this.tabPets.Controls.Add(this.labelControl6);
//            this.tabPets.Controls.Add(this.buttonEdit6);
//            this.tabPets.Controls.Add(this.buttonEdit5);
//            this.tabPets.Controls.Add(this.gridControl8);
//            this.tabPets.Controls.Add(this.gridControl2);
//            this.tabPets.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
//            this.tabPets.Name = "tabPets";
//            this.tabPets.Size = new System.Drawing.Size(2170, 936);
//            this.tabPets.Text = "Pets";
//            // 
//            // grcPets
//            // 
//            this.grcPets.DataSource = this.bsPet;
//            this.grcPets.Location = new System.Drawing.Point(3, 17);
//            this.grcPets.MainView = this.grvPets;
//            this.grcPets.Name = "grcPets";
//            this.grcPets.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
//            this.gridControl2.DataSource = this.bsPet;
//            this.gridControl2.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
//            this.gridControl2.Location = new System.Drawing.Point(5, 74);
//            this.gridControl2.MainView = this.gridView2;
//            this.gridControl2.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
//            this.gridControl2.Name = "gridControl2";
//            this.gridControl2.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
//            this.repositoryItemTextEdit1,
//            this.repositoryItemTextEdit2,
//            this.repositoryItemTextEdit3,
//            this.repositoryItemTextEdit4,
//            this.repositoryItemComboBox2});
//            this.grcPets.Size = new System.Drawing.Size(704, 357);
//            this.grcPets.TabIndex = 2;
//            this.grcPets.UseEmbeddedNavigator = true;
//            this.grcPets.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
//            this.grvPets});
//            this.grcPets.Click += new System.EventHandler(this.gridControl2_Click);
//            this.repositoryItemTextEdit4});
//            this.gridControl2.Size = new System.Drawing.Size(1659, 435);
//            this.gridControl2.TabIndex = 2;
//            this.gridControl2.UseEmbeddedNavigator = true;
//            this.gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
//            this.gridView2});
//            this.gridControl2.Click += new System.EventHandler(this.gridControl2_Click);
//            // 
//            // grvPets
//            // 
//            this.grvPets.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
//            this.colAnimalType,
//            this.colBreed,
//            this.colStatus,
//            this.colPrice,
//            this.Cost});
//            this.grvPets.GridControl = this.grcPets;
//            this.grvPets.Name = "grvPets";
//            this.grvPets.OptionsView.ShowGroupPanel = false;
//            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
//            this.gridColumn5,
//            this.gridColumn6,
//            this.gridColumn7,
//            this.gridColumn8});
//            this.gridView2.DetailHeight = 700;
//            this.gridView2.GridControl = this.gridControl2;
//            this.gridView2.Name = "gridView2";
//            // 
//            // colAnimalType
//            // 
//            this.colAnimalType.Caption = "AnimalType";
//            this.colAnimalType.ColumnEdit = this.repositoryItemComboBox2;
//            this.colAnimalType.FieldName = "AnimalType";
//            this.colAnimalType.Name = "colAnimalType";
//            this.colAnimalType.Visible = true;
//            this.colAnimalType.VisibleIndex = 0;
//            this.gridColumn5.Caption = "Name";
//            this.gridColumn5.ColumnEdit = this.repositoryItemTextEdit4;
//            this.gridColumn5.FieldName = "Name";
//            this.gridColumn5.MinWidth = 34;
//            this.gridColumn5.Name = "gridColumn5";
//            this.gridColumn5.Visible = true;
//            this.gridColumn5.VisibleIndex = 0;
//            this.gridColumn5.Width = 129;
//            // 
//            // repositoryItemComboBox2
//            // 
//            this.repositoryItemComboBox2.AutoHeight = false;
//            this.repositoryItemComboBox2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
//            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
//            this.repositoryItemComboBox2.Name = "repositoryItemComboBox2";
//            // 
//            // colBreed
//            // 
//            this.colBreed.Caption = "Breed";
//            this.colBreed.ColumnEdit = this.repositoryItemTextEdit3;
//            this.colBreed.FieldName = "Breed";
//            this.colBreed.Name = "colBreed";
//            this.colBreed.Visible = true;
//            this.colBreed.VisibleIndex = 1;
//            this.gridColumn6.Caption = "Surname";
//            this.gridColumn6.ColumnEdit = this.repositoryItemTextEdit3;
//            this.gridColumn6.FieldName = "Surname";
//            this.gridColumn6.MinWidth = 34;
//            this.gridColumn6.Name = "gridColumn6";
//            this.gridColumn6.Visible = true;
//            this.gridColumn6.VisibleIndex = 1;
//            this.gridColumn6.Width = 129;
//            // 
//            // repositoryItemTextEdit3
//            // 
//            this.repositoryItemTextEdit3.AutoHeight = false;
//            this.repositoryItemTextEdit3.Name = "repositoryItemTextEdit3";
//            // 
//            // colStatus
//            // 
//            this.colStatus.Caption = "Status";
//            this.colStatus.ColumnEdit = this.repositoryItemComboBox2;
//            this.colStatus.FieldName = "Status";
//            this.colStatus.Name = "colStatus";
//            this.colStatus.Visible = true;
//            this.colStatus.VisibleIndex = 2;
//            // 
//            // colPrice
//            // 
//            this.colPrice.Caption = "Price";
//            this.colPrice.ColumnEdit = this.repositoryItemTextEdit1;
//            this.colPrice.FieldName = "Price";
//            this.colPrice.Name = "colPrice";
//            this.colPrice.Visible = true;
//            this.colPrice.VisibleIndex = 3;
//            // 
//            // repositoryItemTextEdit1
//            // 
//            this.repositoryItemTextEdit1.AutoHeight = false;
//            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
//            // 
//            // Cost
//            // 
//            this.Cost.Caption = "Cost";
//            this.Cost.ColumnEdit = this.repositoryItemTextEdit1;
//            this.Cost.FieldName = "Cost";
//            this.Cost.Name = "Cost";
//            this.Cost.Visible = true;
//            this.Cost.VisibleIndex = 4;
//            this.gridColumn7.Caption = "Phone";
//            this.gridColumn7.ColumnEdit = this.repositoryItemTextEdit2;
//            this.gridColumn7.FieldName = "Phone";
//            this.gridColumn7.MinWidth = 34;
//            this.gridColumn7.Name = "gridColumn7";
//            this.gridColumn7.Visible = true;
//            this.gridColumn7.VisibleIndex = 2;
//            this.gridColumn7.Width = 129;
//            // 
//            // repositoryItemTextEdit2
//            // 
//            this.repositoryItemTextEdit2.AutoHeight = false;
//            this.repositoryItemTextEdit2.Name = "repositoryItemTextEdit2";
//            // 
//            // repositoryItemTextEdit4
//            // 
//            this.repositoryItemTextEdit4.AutoHeight = false;
//            this.repositoryItemTextEdit4.Name = "repositoryItemTextEdit4";
//            // 
//            // tabPetFoods
//            // 
//            this.tabPetFoods.Controls.Add(this.grcPetFoods);
//            this.tabPetFoods.Name = "tabPetFoods";
//            this.tabPetFoods.Size = new System.Drawing.Size(710, 381);
//            this.tabPetFoods.Text = "PetFoods";
//            // 
//            // grcPetFoods
//            // 
//            this.grcPetFoods.DataSource = this.bsPetFood;
//            this.grcPetFoods.Location = new System.Drawing.Point(3, 12);
//            this.grcPetFoods.MainView = this.grvPetFoods;
//            this.grcPetFoods.Name = "grcPetFoods";
//            this.grcPetFoods.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
//            this.repositoryItemTextEdit7,
//            this.repositoryItemTextEdit8,
//            this.repositoryItemTextEdit6,
//            this.repositoryItemTextEdit9,
//            this.repositoryItemComboBox3});
//            this.grcPetFoods.Size = new System.Drawing.Size(704, 357);
//            this.grcPetFoods.TabIndex = 3;
//            this.grcPetFoods.UseEmbeddedNavigator = true;
//            this.grcPetFoods.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
//            this.grvPetFoods});
//            // 
//            // grvPetFoods
//            // 
//            this.grvPetFoods.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
//            this.colAnimalTypeFood,
//            this.colFoodPrice,
//            this.colFoodCost});
//            this.grvPetFoods.GridControl = this.grcPetFoods;
//            this.grvPetFoods.Name = "grvPetFoods";
//            this.grvPetFoods.OptionsView.ShowGroupPanel = false;
//            // 
//            // colAnimalTypeFood
//            // 
//            this.colAnimalTypeFood.Caption = "AnimalType";
//            this.colAnimalTypeFood.ColumnEdit = this.repositoryItemComboBox3;
//            this.colAnimalTypeFood.FieldName = "AnimalType";
//            this.colAnimalTypeFood.Name = "colAnimalTypeFood";
//            this.colAnimalTypeFood.Visible = true;
//            this.colAnimalTypeFood.VisibleIndex = 0;
//            // 
//            // repositoryItemComboBox3
//            // 
//            this.repositoryItemComboBox3.AutoHeight = false;
//            this.repositoryItemComboBox3.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
//            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
//            this.repositoryItemComboBox3.Name = "repositoryItemComboBox3";
//            // 
//            // colFoodPrice
//            // 
//            this.colFoodPrice.Caption = "Price";
//            this.colFoodPrice.ColumnEdit = this.repositoryItemTextEdit7;
//            this.colFoodPrice.FieldName = "Price";
//            this.colFoodPrice.Name = "colFoodPrice";
//            this.colFoodPrice.Visible = true;
//            this.colFoodPrice.VisibleIndex = 1;
//            // 
//            // repositoryItemTextEdit7
//            // 
//            this.repositoryItemTextEdit7.AutoHeight = false;
//            this.repositoryItemTextEdit7.Name = "repositoryItemTextEdit7";
//            // 
//            // colFoodCost
//            // 
//            this.colFoodCost.Caption = "Cost";
//            this.colFoodCost.ColumnEdit = this.repositoryItemTextEdit7;
//            this.colFoodCost.FieldName = "Cost";
//            this.colFoodCost.Name = "colFoodCost";
//            this.colFoodCost.Visible = true;
//            this.colFoodCost.VisibleIndex = 2;
//            // 
//            // repositoryItemTextEdit8
//            // 
//            this.repositoryItemTextEdit8.AutoHeight = false;
//            this.repositoryItemTextEdit8.Name = "repositoryItemTextEdit8";
//            // 
//            // repositoryItemTextEdit6
//            // 
//            this.repositoryItemTextEdit6.AutoHeight = false;
//            this.repositoryItemTextEdit6.Name = "repositoryItemTextEdit6";
//            // 
//            // repositoryItemTextEdit9
//            // 
//            this.repositoryItemTextEdit9.AutoHeight = false;
//            this.repositoryItemTextEdit9.Name = "repositoryItemTextEdit9";
//            // 
//            // tabTransactions
//            // 
//            this.tabTransactions.Controls.Add(this.grcTransactions);
//            this.tabTransactions.Name = "tabTransactions";
//            this.tabTransactions.Size = new System.Drawing.Size(710, 381);
//            this.tabTransactions.Text = "Transactions";
//            // 
//            // grcTransactions
//            // 
//            this.grcTransactions.DataSource = this.bsTransaction;
//            this.grcTransactions.Location = new System.Drawing.Point(3, 12);
//            this.grcTransactions.MainView = this.grvTransactions;
//            this.grcTransactions.Name = "grcTransactions";
//            this.grcTransactions.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
//            this.repositoryItemTextEdit11,
//            this.repositoryItemTextEdit12,
//            this.repositoryItemTextEdit10,
//            this.repositoryItemTextEdit13,
//            this.repositoryItemComboBox4,
//            this.repositoryItemTextEdit22,
//            this.repositoryItemTextEdit23,
//            this.repositoryItemTextEdit24,
//            this.repositoryItemTextEdit25});
//            this.grcTransactions.Size = new System.Drawing.Size(704, 357);
//            this.grcTransactions.TabIndex = 3;
//            this.grcTransactions.UseEmbeddedNavigator = true;
//            this.grcTransactions.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
//            this.grvTransactions});
//            // 
//            // grvTransactions
//            // 
//            this.grvTransactions.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
//            this.colTransactionDate,
//            this.CustomerName,
//            this.colEmployeeName,
//            this.colPetID,
//            this.colPetPrice,
//            this.colFoodID,
//            this.colPetFoodQty,
//            this.colPetFoodPrice,
//            this.colTotal});
//            this.grvTransactions.GridControl = this.grcTransactions;
//            this.grvTransactions.Name = "grvTransactions";
//            this.grvTransactions.OptionsView.ShowGroupPanel = false;
//            // 
//            // colTransactionDate
//            // 
//            this.colTransactionDate.Caption = "DateTime";
//            this.colTransactionDate.ColumnEdit = this.repositoryItemComboBox4;
//            this.colTransactionDate.FieldName = "TransactionDate";
//            this.colTransactionDate.Name = "colTransactionDate";
//            this.colTransactionDate.Visible = true;
//            this.colTransactionDate.VisibleIndex = 0;
//            // 
//            // repositoryItemComboBox4
//            // 
//            this.repositoryItemComboBox4.AutoHeight = false;
//            this.repositoryItemComboBox4.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
//            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
//            this.repositoryItemComboBox4.Name = "repositoryItemComboBox4";
//            // 
//            // CustomerName
//            // 
//            this.CustomerName.Caption = "CustomerName";
//            this.CustomerName.ColumnEdit = this.repositoryItemComboBox4;
//            this.CustomerName.FieldName = "CustomerID";
//            this.CustomerName.Name = "CustomerName";
//            this.CustomerName.Visible = true;
//            this.CustomerName.VisibleIndex = 1;
//            // 
//            // colEmployeeName
//            // 
//            this.colEmployeeName.Caption = "EmployeeName";
//            this.colEmployeeName.ColumnEdit = this.repositoryItemComboBox4;
//            this.colEmployeeName.FieldName = "EmployeeID";
//            this.colEmployeeName.Name = "colEmployeeName";
//            this.colEmployeeName.Visible = true;
//            this.colEmployeeName.VisibleIndex = 2;
//            // 
//            // colPetID
//            // 
//            this.colPetID.Caption = "Pet";
//            this.colPetID.ColumnEdit = this.repositoryItemTextEdit11;
//            this.colPetID.FieldName = "PetID";
//            this.colPetID.Name = "colPetID";
//            this.colPetID.Visible = true;
//            this.colPetID.VisibleIndex = 3;
//            // 
//            // repositoryItemTextEdit11
//            // 
//            this.repositoryItemTextEdit11.AutoHeight = false;
//            this.repositoryItemTextEdit11.Name = "repositoryItemTextEdit11";
//            // 
//            // colPetPrice
//            // 
//            this.colPetPrice.Caption = "PetPrice";
//            this.colPetPrice.ColumnEdit = this.repositoryItemTextEdit11;
//            this.colPetPrice.FieldName = "PetPrice";
//            this.colPetPrice.Name = "colPetPrice";
//            this.colPetPrice.Visible = true;
//            this.colPetPrice.VisibleIndex = 5;
//            // 
//            // colFoodID
//            // 
//            this.colFoodID.Caption = "PetFood";
//            this.colFoodID.ColumnEdit = this.repositoryItemTextEdit22;
//            this.colFoodID.FieldName = "PetFoodID";
//            this.colFoodID.Name = "colFoodID";
//            this.colFoodID.Visible = true;
//            this.colFoodID.VisibleIndex = 4;
//            // 
//            // repositoryItemTextEdit22
//            // 
//            this.repositoryItemTextEdit22.AutoHeight = false;
//            this.repositoryItemTextEdit22.Name = "repositoryItemTextEdit22";
//            // 
//            // colPetFoodQty
//            // 
//            this.colPetFoodQty.Caption = "PetFoodQty";
//            this.colPetFoodQty.ColumnEdit = this.repositoryItemTextEdit23;
//            this.colPetFoodQty.FieldName = "PetFoodQty";
//            this.colPetFoodQty.Name = "colPetFoodQty";
//            this.colPetFoodQty.Visible = true;
//            this.colPetFoodQty.VisibleIndex = 8;
//            // 
//            // repositoryItemTextEdit23
//            // 
//            this.repositoryItemTextEdit23.AutoHeight = false;
//            this.repositoryItemTextEdit23.Name = "repositoryItemTextEdit23";
//            // 
//            // colPetFoodPrice
//            // 
//            this.colPetFoodPrice.Caption = "PetFoodPrice";
//            this.colPetFoodPrice.ColumnEdit = this.repositoryItemTextEdit24;
//            this.colPetFoodPrice.FieldName = "PetFoodPrice";
//            this.colPetFoodPrice.Name = "colPetFoodPrice";
//            this.colPetFoodPrice.Visible = true;
//            this.colPetFoodPrice.VisibleIndex = 6;
//            // 
//            // repositoryItemTextEdit24
//            // 
//            this.repositoryItemTextEdit24.AutoHeight = false;
//            this.repositoryItemTextEdit24.Name = "repositoryItemTextEdit24";
//            // 
//            // colTotal
//            // 
//            this.colTotal.Caption = "TotalPrice";
//            this.colTotal.ColumnEdit = this.repositoryItemTextEdit25;
//            this.colTotal.FieldName = "TotalPrice";
//            this.colTotal.Name = "colTotal";
//            this.colTotal.Visible = true;
//            this.colTotal.VisibleIndex = 7;
//            // 
//            // repositoryItemTextEdit25
//            // 
//            this.repositoryItemTextEdit25.AutoHeight = false;
//            this.repositoryItemTextEdit25.Name = "repositoryItemTextEdit25";
//            // 
//            // repositoryItemTextEdit12
//            // 
//            this.repositoryItemTextEdit12.AutoHeight = false;
//            this.repositoryItemTextEdit12.Name = "repositoryItemTextEdit12";
//            // 
//            // repositoryItemTextEdit10
//            // 
//            this.repositoryItemTextEdit10.AutoHeight = false;
//            this.repositoryItemTextEdit10.Name = "repositoryItemTextEdit10";
//            // 
//            // repositoryItemTextEdit13
//            // 
//            this.repositoryItemTextEdit13.AutoHeight = false;
//            this.repositoryItemTextEdit13.Name = "repositoryItemTextEdit13";
//            // 
//            // tabMonthlyLedger
//            // 
//            this.tabMonthlyLedger.Controls.Add(this.gridControl6);
//            this.tabMonthlyLedger.Name = "tabMonthlyLedger";
//            this.tabMonthlyLedger.Size = new System.Drawing.Size(710, 381);
//            this.tabMonthlyLedger.Text = "MonthlyLedger";
//            // 
//            // gridControl6
//            // 
//            this.gridControl6.DataSource = this.bsPet;
//            this.gridControl6.Location = new System.Drawing.Point(3, 12);
//            this.gridControl6.MainView = this.gridView6;
//            this.gridControl6.Name = "gridControl6";
//            this.gridControl6.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
//            this.repositoryItemTextEdit15,
//            this.repositoryItemTextEdit16,
//            this.repositoryItemTextEdit14,
//            this.repositoryItemTextEdit17,
//            this.repositoryItemComboBox5});
//            this.gridControl6.Size = new System.Drawing.Size(704, 357);
//            this.gridControl6.TabIndex = 3;
//            this.gridControl6.UseEmbeddedNavigator = true;
//            this.gridControl6.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
//            this.gridView6});
//            // 
//            // gridView6
//            // 
//            this.gridView6.GridControl = this.gridControl6;
//            this.gridView6.Name = "gridView6";
//            this.gridView6.OptionsView.ShowGroupPanel = false;
//            // 
//            // repositoryItemTextEdit15
//            // 
//            this.repositoryItemTextEdit15.AutoHeight = false;
//            this.repositoryItemTextEdit15.Name = "repositoryItemTextEdit15";
//            // 
//            // repositoryItemTextEdit16
//            // 
//            this.repositoryItemTextEdit16.AutoHeight = false;
//            this.repositoryItemTextEdit16.Name = "repositoryItemTextEdit16";
//            // 
//            // repositoryItemTextEdit14
//            // 
//            this.repositoryItemTextEdit14.AutoHeight = false;
//            this.repositoryItemTextEdit14.Name = "repositoryItemTextEdit14";
//            // 
//            // repositoryItemTextEdit17
//            // 
//            this.repositoryItemTextEdit17.AutoHeight = false;
//            this.repositoryItemTextEdit17.Name = "repositoryItemTextEdit17";
//            // 
//            // repositoryItemComboBox5
//            // 
//            this.repositoryItemComboBox5.AutoHeight = false;
//            this.repositoryItemComboBox5.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
//            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
//            this.repositoryItemComboBox5.Name = "repositoryItemComboBox5";
//            // 
//            // tabPetReport
//            // 
//            this.tabPetReport.Controls.Add(this.gridControl7);
//            this.tabPetReport.Name = "tabPetReport";
//            this.tabPetReport.Size = new System.Drawing.Size(710, 381);
//            this.tabPetReport.Text = "PetReport";
//            // 
//            // gridControl7
//            // 
//            this.gridControl7.DataSource = this.bsPet;
//            this.gridControl7.Location = new System.Drawing.Point(3, 12);
//            this.gridControl7.MainView = this.gridView7;
//            this.gridControl7.Name = "gridControl7";
//            this.gridControl7.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
//            this.repositoryItemTextEdit19,
//            this.repositoryItemTextEdit20,
//            this.repositoryItemTextEdit18,
//            this.repositoryItemTextEdit21,
//            this.repositoryItemComboBox6});
//            this.gridControl7.Size = new System.Drawing.Size(704, 357);
//            this.gridControl7.TabIndex = 3;
//            this.gridControl7.UseEmbeddedNavigator = true;
//            this.gridControl7.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
//            this.gridView7});
//            // 
//            // gridView7
//            // 
//            this.gridView7.GridControl = this.gridControl7;
//            this.gridView7.Name = "gridView7";
//            this.gridView7.OptionsView.ShowGroupPanel = false;
//            // 
//            // repositoryItemTextEdit19
//            // 
//            this.repositoryItemTextEdit19.AutoHeight = false;
//            this.repositoryItemTextEdit19.Name = "repositoryItemTextEdit19";
//            // 
//            // repositoryItemTextEdit20
//            // 
//            this.repositoryItemTextEdit20.AutoHeight = false;
//            this.repositoryItemTextEdit20.Name = "repositoryItemTextEdit20";
//            // 
//            // repositoryItemTextEdit18
//            // 
//            this.repositoryItemTextEdit18.AutoHeight = false;
//            this.repositoryItemTextEdit18.Name = "repositoryItemTextEdit18";
//            // 
//            // repositoryItemTextEdit21
//            // 
//            this.repositoryItemTextEdit21.AutoHeight = false;
//            this.repositoryItemTextEdit21.Name = "repositoryItemTextEdit21";
//            this.gridColumn8.Caption = "TIN";
//            this.gridColumn8.ColumnEdit = this.repositoryItemTextEdit1;
//            this.gridColumn8.FieldName = "TIN";
//            this.gridColumn8.MinWidth = 34;
//            this.gridColumn8.Name = "gridColumn8";
//            this.gridColumn8.Visible = true;
//            this.gridColumn8.VisibleIndex = 3;
//            this.gridColumn8.Width = 129;
//            // 
//            // repositoryItemComboBox6
//            // 
//            this.repositoryItemComboBox6.AutoHeight = false;
//            this.repositoryItemComboBox6.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
//            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
//            this.repositoryItemComboBox6.Name = "repositoryItemComboBox6";
//            // 
//            // gridControl4
//            // 
//            this.gridControl4.Location = new System.Drawing.Point(53, 50);
//            this.gridControl4.MainView = this.gridView4;
//            this.gridControl4.Name = "gridControl4";
//            this.gridControl4.Size = new System.Drawing.Size(774, 432);
//            this.gridControl4.TabIndex = 3;
//            this.gridControl4.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
//            this.gridView4});
//            this.gridControl4.Click += new System.EventHandler(this.gridControl4_Click);
//            // 
//            // gridView4
//            // 
//            this.gridView4.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
//            this.An,
//            this.gridColumn2,
//            this.gridColumn3,
//            this.gridColumn4,
//            this.gridColumn9});
//            this.gridView4.GridControl = this.gridControl4;
//            this.gridView4.Name = "gridView4";
//            // 
//            // gridControl5
//            // 
//            this.gridControl5.Location = new System.Drawing.Point(953, 50);
//            this.gridControl5.MainView = this.gridView5;
//            this.gridControl5.Name = "gridControl5";
//            this.gridControl5.Size = new System.Drawing.Size(816, 424);
//            this.gridControl5.TabIndex = 4;
//            this.gridControl5.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
//            this.gridView5});
//            // 
//            // gridView5
//            // 
//            this.gridView5.GridControl = this.gridControl5;
//            this.gridView5.Name = "gridView5";
//            // 
//            // buttonEdit1
//            // 
//            this.buttonEdit1.EditValue = "Save";
//            this.buttonEdit1.Location = new System.Drawing.Point(1896, 44);
//            this.buttonEdit1.Name = "buttonEdit1";
//            this.buttonEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
//            new DevExpress.XtraEditors.Controls.EditorButton()});
//            this.buttonEdit1.Size = new System.Drawing.Size(213, 38);
//            this.buttonEdit1.TabIndex = 5;
//            // 
//            // buttonEdit2
//            // 
//            this.buttonEdit2.EditValue = "Load";
//            this.buttonEdit2.Location = new System.Drawing.Point(1896, 130);
//            this.buttonEdit2.Name = "buttonEdit2";
//            this.buttonEdit2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
//            new DevExpress.XtraEditors.Controls.EditorButton()});
//            this.buttonEdit2.Size = new System.Drawing.Size(213, 38);
//            this.buttonEdit2.TabIndex = 6;
//            // 
//            // buttonEdit3
//            // 
//            this.buttonEdit3.EditValue = "Save";
//            this.buttonEdit3.Location = new System.Drawing.Point(1825, 57);
//            this.buttonEdit3.Name = "buttonEdit3";
//            this.buttonEdit3.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
//            new DevExpress.XtraEditors.Controls.EditorButton()});
//            this.buttonEdit3.Size = new System.Drawing.Size(306, 38);
//            this.buttonEdit3.TabIndex = 2;
//            // 
//            // buttonEdit4
//            // 
//            this.buttonEdit4.EditValue = "Load";
//            this.buttonEdit4.Location = new System.Drawing.Point(1825, 143);
//            this.buttonEdit4.Name = "buttonEdit4";
//            this.buttonEdit4.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
//            new DevExpress.XtraEditors.Controls.EditorButton()});
//            this.buttonEdit4.Size = new System.Drawing.Size(306, 38);
//            this.buttonEdit4.TabIndex = 3;
//            // 
//            // gridControl6
//            // 
//            this.gridControl6.Location = new System.Drawing.Point(25, 530);
//            this.gridControl6.MainView = this.gridView6;
//            this.gridControl6.Name = "gridControl6";
//            this.gridControl6.Size = new System.Drawing.Size(700, 350);
//            this.gridControl6.TabIndex = 4;
//            this.gridControl6.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
//            this.gridView6});
//            this.gridControl6.Click += new System.EventHandler(this.gridControl6_Click);
//            // 
//            // gridView6
//            // 
//            this.gridView6.GridControl = this.gridControl6;
//            this.gridView6.Name = "gridView6";
//            // 
//            // gridControl7
//            // 
//            this.gridControl7.Location = new System.Drawing.Point(1107, 530);
//            this.gridControl7.MainView = this.gridView7;
//            this.gridControl7.Name = "gridControl7";
//            this.gridControl7.Size = new System.Drawing.Size(700, 350);
//            this.gridControl7.TabIndex = 5;
//            this.gridControl7.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
//            this.gridView7});
//            // 
//            // gridView7
//            // 
//            this.gridView7.GridControl = this.gridControl7;
//            this.gridView7.Name = "gridView7";
//            // 
//            // gridControl8
//            // 
//            this.gridControl8.Location = new System.Drawing.Point(5, 583);
//            this.gridControl8.MainView = this.gridView8;
//            this.gridControl8.Name = "gridControl8";
//            this.gridControl8.Size = new System.Drawing.Size(1659, 350);
//            this.gridControl8.TabIndex = 3;
//            this.gridControl8.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
//            this.gridView8});
//            // 
//            // gridView8
//            // 
//            this.gridView8.GridControl = this.gridControl8;
//            this.gridView8.Name = "gridView8";
//            // 
//            // buttonEdit5
//            // 
//            this.buttonEdit5.EditValue = "Save";
//            this.buttonEdit5.Location = new System.Drawing.Point(1793, 110);
//            this.buttonEdit5.Name = "buttonEdit5";
//            this.buttonEdit5.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
//            new DevExpress.XtraEditors.Controls.EditorButton()});
//            this.buttonEdit5.Size = new System.Drawing.Size(306, 38);
//            this.buttonEdit5.TabIndex = 4;
//            // 
//            // buttonEdit6
//            // 
//            this.buttonEdit6.EditValue = "Load";
//            this.buttonEdit6.Location = new System.Drawing.Point(1793, 218);
//            this.buttonEdit6.Name = "buttonEdit6";
//            this.buttonEdit6.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
//            new DevExpress.XtraEditors.Controls.EditorButton()});
//            this.buttonEdit6.Size = new System.Drawing.Size(306, 38);
//            this.buttonEdit6.TabIndex = 5;
//            // 
//            // An
//            // 
//            this.An.Caption = "gridColumn1";
//            this.An.MinWidth = 35;
//            this.An.Name = "An";
//            this.An.Visible = true;
//            this.An.VisibleIndex = 4;
//            this.An.Width = 131;
//            // 
//            // pets
//            // 
//            this.pets.Location = new System.Drawing.Point(53, 21);
//            this.pets.Name = "pets";
//            this.pets.Size = new System.Drawing.Size(34, 23);
//            this.pets.TabIndex = 7;
//            this.pets.Text = "Pets";
//            this.pets.Click += new System.EventHandler(this.pets_Click);
//            // 
//            // labelControl2
//            // 
//            this.labelControl2.Location = new System.Drawing.Point(955, 21);
//            this.labelControl2.Name = "labelControl2";
//            this.labelControl2.Size = new System.Drawing.Size(81, 23);
//            this.labelControl2.TabIndex = 8;
//            this.labelControl2.Text = "Pet Foods";
//            // 
//            // labelControl3
//            // 
//            this.labelControl3.Location = new System.Drawing.Point(56, 488);
//            this.labelControl3.Name = "labelControl3";
//            this.labelControl3.Size = new System.Drawing.Size(46, 23);
//            this.labelControl3.TabIndex = 9;
//            this.labelControl3.Text = "Stock";
//            // 
//            // labelControl1
//            // 
//            this.labelControl1.Location = new System.Drawing.Point(25, 12);
//            this.labelControl1.Name = "labelControl1";
//            this.labelControl1.Size = new System.Drawing.Size(105, 23);
//            this.labelControl1.TabIndex = 6;
//            this.labelControl1.Text = "Transactions";
//            this.labelControl1.Click += new System.EventHandler(this.labelControl1_Click);
//            // 
//            // labelControl4
//            // 
//            this.labelControl4.Location = new System.Drawing.Point(25, 501);
//            this.labelControl4.Name = "labelControl4";
//            this.labelControl4.Size = new System.Drawing.Size(87, 23);
//            this.labelControl4.TabIndex = 7;
//            this.labelControl4.Text = "Customers";
//            // 
//            // labelControl5
//            // 
//            this.labelControl5.Location = new System.Drawing.Point(1107, 501);
//            this.labelControl5.Name = "labelControl5";
//            this.labelControl5.Size = new System.Drawing.Size(46, 23);
//            this.labelControl5.TabIndex = 8;
//            this.labelControl5.Text = "Stock";
//            // 
//            // labelControl6
//            // 
//            this.labelControl6.Location = new System.Drawing.Point(5, 23);
//            this.labelControl6.Name = "labelControl6";
//            this.labelControl6.Size = new System.Drawing.Size(89, 23);
//            this.labelControl6.TabIndex = 6;
//            this.labelControl6.Text = "Employees";
//            this.labelControl6.Click += new System.EventHandler(this.labelControl6_Click);
//            // 
//            // labelControl7
//            // 
//            this.labelControl7.Location = new System.Drawing.Point(5, 554);
//            this.labelControl7.Name = "labelControl7";
//            this.labelControl7.Size = new System.Drawing.Size(130, 23);
//            this.labelControl7.TabIndex = 7;
//            this.labelControl7.Text = "Monthly Ledger";
//            // 
//            // gridColumn2
//            // 
//            this.gridColumn2.MinWidth = 35;
//            this.gridColumn2.Name = "gridColumn2";
//            this.gridColumn2.Visible = true;
//            this.gridColumn2.VisibleIndex = 3;
//            this.gridColumn2.Width = 131;
//            // 
//            // gridColumn3
//            // 
//            this.gridColumn3.MinWidth = 35;
//            this.gridColumn3.Name = "gridColumn3";
//            this.gridColumn3.Visible = true;
//            this.gridColumn3.VisibleIndex = 2;
//            this.gridColumn3.Width = 131;
//            // 
//            // gridColumn4
//            // 
//            this.gridColumn4.MinWidth = 35;
//            this.gridColumn4.Name = "gridColumn4";
//            this.gridColumn4.Visible = true;
//            this.gridColumn4.VisibleIndex = 1;
//            this.gridColumn4.Width = 131;
//            // 
//            // gridColumn9
//            // 
//            this.gridColumn9.MinWidth = 35;
//            this.gridColumn9.Name = "gridColumn9";
//            this.gridColumn9.Visible = true;
//            this.gridColumn9.VisibleIndex = 0;
//            this.gridColumn9.Width = 131;
//            // 
//            // Form1
//            // 
//            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
//            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
//            this.ClientSize = new System.Drawing.Size(2297, 1370);
//            this.Controls.Add(this.tabsform);
//            this.Controls.Add(this.label7);
//            this.Controls.Add(this.button3);
//            this.Controls.Add(this.button2);
//            this.Controls.Add(this.label4);
//            this.Controls.Add(this.label1);
//            this.Controls.Add(this.grvPetFood);
//            this.IsMdiContainer = true;
//            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
//            this.Name = "Form1";
//            this.Text = "Form1";
//            this.Load += new System.EventHandler(this.Form1_Load);
//            ((System.ComponentModel.ISupportInitialize)(this.bsTransaction)).EndInit();
//            ((System.ComponentModel.ISupportInitialize)(this.grvPetFood)).EndInit();
//            ((System.ComponentModel.ISupportInitialize)(this.bsPetFood)).EndInit();
//            ((System.ComponentModel.ISupportInitialize)(this.bsPet)).EndInit();
//            ((System.ComponentModel.ISupportInitialize)(this.bsCustomer)).EndInit();
//            ((System.ComponentModel.ISupportInitialize)(this.bsEmployee)).EndInit();
//            ((System.ComponentModel.ISupportInitialize)(this.monthlyLedgerBindingSource)).EndInit();
//            ((System.ComponentModel.ISupportInitialize)(this.tabsform)).EndInit();
//            this.tabsform.ResumeLayout(false);
//            this.tabCustomer.ResumeLayout(false);
//            ((System.ComponentModel.ISupportInitialize)(this.grcCustomers)).EndInit();
//            ((System.ComponentModel.ISupportInitialize)(this.grvCustomers)).EndInit();
//            this.tabCustomer.PerformLayout();
//            ((System.ComponentModel.ISupportInitialize)(this.gridControl3)).EndInit();
//            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
//            this.tabEmployee.ResumeLayout(false);
//            ((System.ComponentModel.ISupportInitialize)(this.grcEmployees)).EndInit();
//            ((System.ComponentModel.ISupportInitialize)(this.grvEmployees)).EndInit();
//            this.tabEmployee.PerformLayout();
//            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
//            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
//            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit5)).EndInit();
//            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).EndInit();
//            this.tabPets.ResumeLayout(false);
//            ((System.ComponentModel.ISupportInitialize)(this.grcPets)).EndInit();
//            ((System.ComponentModel.ISupportInitialize)(this.grvPets)).EndInit();
//            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox2)).EndInit();
//            this.tabPets.PerformLayout();
//            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
//            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
//            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit4)).EndInit();
//            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit3)).EndInit();
//            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
//            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit2)).EndInit();
//            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit4)).EndInit();
//            this.tabPetFoods.ResumeLayout(false);
//            ((System.ComponentModel.ISupportInitialize)(this.grcPetFoods)).EndInit();
//            ((System.ComponentModel.ISupportInitialize)(this.grvPetFoods)).EndInit();
//            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox3)).EndInit();
//            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit7)).EndInit();
//            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit8)).EndInit();
//            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit6)).EndInit();
//            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit9)).EndInit();
//            this.tabTransactions.ResumeLayout(false);
//            ((System.ComponentModel.ISupportInitialize)(this.grcTransactions)).EndInit();
//            ((System.ComponentModel.ISupportInitialize)(this.grvTransactions)).EndInit();
//            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox4)).EndInit();
//            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit11)).EndInit();
//            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit22)).EndInit();
//            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit23)).EndInit();
//            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit24)).EndInit();
//            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit25)).EndInit();
//            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit12)).EndInit();
//            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit10)).EndInit();
//            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit13)).EndInit();
//            this.tabMonthlyLedger.ResumeLayout(false);
//            ((System.ComponentModel.ISupportInitialize)(this.gridControl6)).EndInit();
//            ((System.ComponentModel.ISupportInitialize)(this.gridView6)).EndInit();
//            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit15)).EndInit();
//            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit16)).EndInit();
//            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit14)).EndInit();
//            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit17)).EndInit();
//            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox5)).EndInit();
//            this.tabPetReport.ResumeLayout(false);
//            ((System.ComponentModel.ISupportInitialize)(this.gridControl7)).EndInit();
//            ((System.ComponentModel.ISupportInitialize)(this.gridView7)).EndInit();
//            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit19)).EndInit();
//            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit20)).EndInit();
//            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit18)).EndInit();
//            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit21)).EndInit();
//            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox6)).EndInit();
//            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
//            ((System.ComponentModel.ISupportInitialize)(this.gridControl4)).EndInit();
//            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).EndInit();
//            ((System.ComponentModel.ISupportInitialize)(this.gridControl5)).EndInit();
//            ((System.ComponentModel.ISupportInitialize)(this.gridView5)).EndInit();
//            ((System.ComponentModel.ISupportInitialize)(this.buttonEdit1.Properties)).EndInit();
//            ((System.ComponentModel.ISupportInitialize)(this.buttonEdit2.Properties)).EndInit();
//            ((System.ComponentModel.ISupportInitialize)(this.buttonEdit3.Properties)).EndInit();
//            ((System.ComponentModel.ISupportInitialize)(this.buttonEdit4.Properties)).EndInit();
//            ((System.ComponentModel.ISupportInitialize)(this.gridControl6)).EndInit();
//            ((System.ComponentModel.ISupportInitialize)(this.gridView6)).EndInit();
//            ((System.ComponentModel.ISupportInitialize)(this.gridControl7)).EndInit();
//            ((System.ComponentModel.ISupportInitialize)(this.gridView7)).EndInit();
//            ((System.ComponentModel.ISupportInitialize)(this.gridControl8)).EndInit();
//            ((System.ComponentModel.ISupportInitialize)(this.gridView8)).EndInit();
//            ((System.ComponentModel.ISupportInitialize)(this.buttonEdit5.Properties)).EndInit();
//            ((System.ComponentModel.ISupportInitialize)(this.buttonEdit6.Properties)).EndInit();
//            this.ResumeLayout(false);
//            this.PerformLayout();

//        }

//        #endregion
//        private BindingSource bsTransaction;
//        private DataGridView grvPetFood;
//        private Label label1;
//        private Label label4;
//        private BindingSource bsPet;
//        private BindingSource bsPetFood;
//        private BindingSource bsCustomer;
//        private BindingSource bsEmployee;
//        private BindingSource monthlyLedgerBindingSource;
//        private DataGridViewTextBoxColumn customerIDDataGridViewTextBoxColumn;
//        private DataGridViewTextBoxColumn employeeIDDataGridViewTextBoxColumn;
//        private DataGridViewTextBoxColumn petPriceDataGridViewTextBoxColumn;
//        private DataGridViewTextBoxColumn transactionDateDataGridViewTextBoxColumn;
//        private Button button2;
//        private Button button3;
//        private DataGridViewTextBoxColumn animalTypeDataGridViewTextBoxColumn1;
//        private Label label7;
//        private DataGridViewTextBoxColumn Year;
//        private DataGridViewTextBoxColumn Month;
//        private DataGridViewTextBoxColumn AnimalType;
//        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
//        private DataGridViewTextBoxColumn Status;
//        private DataGridViewTextBoxColumn petFoodPriceDataGridViewTextBoxColumn1;
//        private DataGridViewTextBoxColumn petFoodCostDataGridViewTextBoxColumn;
//        private DevExpress.XtraTab.XtraTabControl tabsform;
//        private DevExpress.XtraTab.XtraTabPage tabCustomer;
//        private DevExpress.XtraTab.XtraTabPage tabEmployee;
//        private DevExpress.XtraTab.XtraTabPage tabPets;
//        private DevExpress.XtraGrid.GridControl grcCustomers;
//        private DevExpress.XtraGrid.Views.Grid.GridView grvCustomers;
//        private DevExpress.XtraGrid.Columns.GridColumn colCustName;
//        private DevExpress.XtraGrid.Columns.GridColumn colCustSurname;
//        private DevExpress.XtraGrid.Columns.GridColumn colPhone;
//        private DevExpress.XtraGrid.Columns.GridColumn colTin;
//        private DevExpress.XtraGrid.GridControl grcEmployees;
//        private DevExpress.XtraGrid.Views.Grid.GridView grvEmployees;
//        private DevExpress.XtraGrid.Columns.GridColumn colName;
//        private DevExpress.XtraGrid.Columns.GridColumn colSurname;
//        private DevExpress.XtraGrid.Columns.GridColumn colType;
//        private DevExpress.XtraGrid.Columns.GridColumn colSalary;
//        private DevExpress.XtraGrid.GridControl grcPets;
//        private DevExpress.XtraGrid.Views.Grid.GridView grvPets;
//        private DevExpress.XtraGrid.Columns.GridColumn colAnimalType;
//        private DevExpress.XtraGrid.Columns.GridColumn colBreed;
//        private DevExpress.XtraGrid.Columns.GridColumn colStatus;
//        private DevExpress.XtraGrid.Columns.GridColumn colPrice;
//        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit4;
//        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit3;
//        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit2;
//        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
//        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit5;
//        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repositoryItemComboBox1;
//        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repositoryItemComboBox2;
//        private DevExpress.XtraGrid.Columns.GridColumn Cost;
//        private DevExpress.XtraTab.XtraTabPage tabPetFoods;
//        private DevExpress.XtraGrid.GridControl grcPetFoods;
//        private DevExpress.XtraGrid.Views.Grid.GridView grvPetFoods;
//        private DevExpress.XtraGrid.Columns.GridColumn colAnimalTypeFood;
//        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repositoryItemComboBox3;
//        private DevExpress.XtraGrid.Columns.GridColumn colFoodPrice;
//        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit7;
//        private DevExpress.XtraGrid.Columns.GridColumn colFoodCost;
//        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit8;
//        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit6;
//        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit9;
//        private DevExpress.XtraTab.XtraTabPage tabTransactions;
//        private DevExpress.XtraGrid.GridControl grcTransactions;
//        private DevExpress.XtraGrid.Views.Grid.GridView grvTransactions;
//        private DevExpress.XtraGrid.Columns.GridColumn colTransactionDate;
//        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repositoryItemComboBox4;
//        private DevExpress.XtraGrid.Columns.GridColumn CustomerName;
//        private DevExpress.XtraGrid.Columns.GridColumn colEmployeeName;
//        private DevExpress.XtraGrid.Columns.GridColumn colPetID;
//        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit11;
//        private DevExpress.XtraGrid.Columns.GridColumn colPetPrice;
//        private DevExpress.XtraGrid.Columns.GridColumn colFoodID;
//        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit22;
//        private DevExpress.XtraGrid.Columns.GridColumn colPetFoodQty;
//        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit23;
//        private DevExpress.XtraGrid.Columns.GridColumn colPetFoodPrice;
//        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit24;
//        private DevExpress.XtraGrid.Columns.GridColumn colTotal;
//        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit25;
//        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit12;
//        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit10;
//        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit13;
//        private DevExpress.XtraTab.XtraTabPage tabMonthlyLedger;
//        private DevExpress.XtraGrid.GridControl gridControl6;
//        private DevExpress.XtraGrid.Views.Grid.GridView gridView6;
//        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repositoryItemComboBox5;
//        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit14;
//        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit15;
//        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit16;
//        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit17;
//        private DevExpress.XtraTab.XtraTabPage tabPetReport;
//        private DevExpress.XtraGrid.GridControl gridControl7;
//        private DevExpress.XtraGrid.Views.Grid.GridView gridView7;
//        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repositoryItemComboBox6;
//        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit18;
//        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit19;
//        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit20;
//        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit21;
//        private DevExpress.XtraEditors.ButtonEdit buttonEdit2;
//        private DevExpress.XtraEditors.ButtonEdit buttonEdit1;
//        private DevExpress.XtraGrid.GridControl gridControl5;
//        private DevExpress.XtraGrid.Views.Grid.GridView gridView5;
//        private DevExpress.XtraGrid.GridControl gridControl4;
//        private DevExpress.XtraGrid.Views.Grid.GridView gridView4;
//        private DevExpress.XtraGrid.Columns.GridColumn An;
//        private DevExpress.XtraGrid.GridControl gridControl7;
//        private DevExpress.XtraGrid.Views.Grid.GridView gridView7;
//        private DevExpress.XtraGrid.GridControl gridControl6;
//        private DevExpress.XtraGrid.Views.Grid.GridView gridView6;
//        private DevExpress.XtraEditors.ButtonEdit buttonEdit4;
//        private DevExpress.XtraEditors.ButtonEdit buttonEdit3;
//        private DevExpress.XtraEditors.ButtonEdit buttonEdit6;
//        private DevExpress.XtraEditors.ButtonEdit buttonEdit5;
//        private DevExpress.XtraGrid.GridControl gridControl8;
//        private DevExpress.XtraGrid.Views.Grid.GridView gridView8;
//        private DevExpress.XtraEditors.LabelControl labelControl3;
//        private DevExpress.XtraEditors.LabelControl labelControl2;
//        private DevExpress.XtraEditors.LabelControl pets;
//        private DevExpress.XtraEditors.LabelControl labelControl1;
//        private DevExpress.XtraEditors.LabelControl labelControl5;
//        private DevExpress.XtraEditors.LabelControl labelControl4;
//        private DevExpress.XtraEditors.LabelControl labelControl6;
//        private DevExpress.XtraEditors.LabelControl labelControl7;
//        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
//        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
//        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
//        private DevExpress.XtraGrid.Columns.GridColumn gridColumn9;
//    }
//}