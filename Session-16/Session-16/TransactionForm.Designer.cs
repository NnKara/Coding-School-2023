namespace Session_16 {
    partial class TransactionForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraGrid.Views.Grid.GridView gridView1;
            this.colTransactionID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPetID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repoPet = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colEmployeeID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repoEmployee = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colPetFoodID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repoPetFoodID = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colCustomerID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repoCustomerID = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.PetPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPetFoodQty = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repoFoodQty = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.colPetFoodPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repoPetFoodPrice = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colTransactionDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grdTransaction = new DevExpress.XtraGrid.GridControl();
            this.bsTransaction = new System.Windows.Forms.BindingSource(this.components);
            this.btnPopulateTransaction = new System.Windows.Forms.Button();
            this.btnOrder = new System.Windows.Forms.Button();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.btnClose = new System.Windows.Forms.Button();
            gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repoPet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repoEmployee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repoPetFoodID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repoCustomerID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repoFoodQty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repoPetFoodPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdTransaction)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTransaction)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // gridView1
            // 
            gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colTransactionID,
            this.colPetID,
            this.colEmployeeID,
            this.colPetFoodID,
            this.colCustomerID,
            this.PetPrice,
            this.colPetFoodQty,
            this.colPetFoodPrice,
            this.colTransactionDate,
            this.colTotalPrice});
            gridView1.GridControl = this.grdTransaction;
            gridView1.Name = "gridView1";
            gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            gridView1.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridView1_CellValueChanged);
            gridView1.RowDeleting += new DevExpress.Data.RowDeletingEventHandler(this.gridView1_RowDeleting);
            gridView1.ValidateRow += new DevExpress.XtraGrid.Views.Base.ValidateRowEventHandler(this.gridView1_ValidateRow);
            // 
            // colTransactionID
            // 
            this.colTransactionID.Caption = "TransactionID";
            this.colTransactionID.FieldName = "TransactionID";
            this.colTransactionID.MinWidth = 25;
            this.colTransactionID.Name = "colTransactionID";
            this.colTransactionID.Visible = true;
            this.colTransactionID.VisibleIndex = 0;
            this.colTransactionID.Width = 94;
            // 
            // colPetID
            // 
            this.colPetID.Caption = "PetID";
            this.colPetID.ColumnEdit = this.repoPet;
            this.colPetID.FieldName = "PetID";
            this.colPetID.MinWidth = 25;
            this.colPetID.Name = "colPetID";
            this.colPetID.Visible = true;
            this.colPetID.VisibleIndex = 1;
            this.colPetID.Width = 94;
            // 
            // repoPet
            // 
            this.repoPet.AutoHeight = false;
            this.repoPet.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repoPet.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Breed", "Breed")});
            this.repoPet.Name = "repoPet";
            // 
            // colEmployeeID
            // 
            this.colEmployeeID.Caption = "EmployeeID";
            this.colEmployeeID.ColumnEdit = this.repoEmployee;
            this.colEmployeeID.FieldName = "EmployeeID";
            this.colEmployeeID.MinWidth = 25;
            this.colEmployeeID.Name = "colEmployeeID";
            this.colEmployeeID.Visible = true;
            this.colEmployeeID.VisibleIndex = 2;
            this.colEmployeeID.Width = 94;
            // 
            // repoEmployee
            // 
            this.repoEmployee.AutoHeight = false;
            this.repoEmployee.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repoEmployee.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("EmployeeSurname", "Surname"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("EmployeeName", "Name")});
            this.repoEmployee.Name = "repoEmployee";
            // 
            // colPetFoodID
            // 
            this.colPetFoodID.Caption = "PetFoodID";
            this.colPetFoodID.ColumnEdit = this.repoPetFoodID;
            this.colPetFoodID.FieldName = "PetFoodID";
            this.colPetFoodID.MinWidth = 25;
            this.colPetFoodID.Name = "colPetFoodID";
            this.colPetFoodID.Visible = true;
            this.colPetFoodID.VisibleIndex = 3;
            this.colPetFoodID.Width = 94;
            // 
            // repoPetFoodID
            // 
            this.repoPetFoodID.AutoHeight = false;
            this.repoPetFoodID.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repoPetFoodID.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("AnimalType", "AnimalType")});
            this.repoPetFoodID.Name = "repoPetFoodID";
            // 
            // colCustomerID
            // 
            this.colCustomerID.Caption = "CustomerID";
            this.colCustomerID.ColumnEdit = this.repoCustomerID;
            this.colCustomerID.FieldName = "CustomerID";
            this.colCustomerID.MinWidth = 25;
            this.colCustomerID.Name = "colCustomerID";
            this.colCustomerID.Visible = true;
            this.colCustomerID.VisibleIndex = 4;
            this.colCustomerID.Width = 94;
            // 
            // repoCustomerID
            // 
            this.repoCustomerID.AutoHeight = false;
            this.repoCustomerID.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repoCustomerID.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CustomerSurname", "Surname"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CustomerName", "Name")});
            this.repoCustomerID.Name = "repoCustomerID";
            // 
            // PetPrice
            // 
            this.PetPrice.Caption = "PetPrice";
            this.PetPrice.FieldName = "PetPrice";
            this.PetPrice.MinWidth = 25;
            this.PetPrice.Name = "PetPrice";
            this.PetPrice.Visible = true;
            this.PetPrice.VisibleIndex = 5;
            this.PetPrice.Width = 94;
            // 
            // colPetFoodQty
            // 
            this.colPetFoodQty.Caption = "PetFoodQty";
            this.colPetFoodQty.ColumnEdit = this.repoFoodQty;
            this.colPetFoodQty.FieldName = "PetFoodQty";
            this.colPetFoodQty.MinWidth = 25;
            this.colPetFoodQty.Name = "colPetFoodQty";
            this.colPetFoodQty.Visible = true;
            this.colPetFoodQty.VisibleIndex = 6;
            this.colPetFoodQty.Width = 94;
            // 
            // repoFoodQty
            // 
            this.repoFoodQty.AutoHeight = false;
            this.repoFoodQty.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repoFoodQty.Name = "repoFoodQty";
            // 
            // colPetFoodPrice
            // 
            this.colPetFoodPrice.Caption = "PetFoodPrice";
            this.colPetFoodPrice.FieldName = "Price";
            this.colPetFoodPrice.MinWidth = 25;
            this.colPetFoodPrice.Name = "colPetFoodPrice";
            this.colPetFoodPrice.Visible = true;
            this.colPetFoodPrice.VisibleIndex = 7;
            this.colPetFoodPrice.Width = 94;
            // 
            // repoPetFoodPrice
            // 
            this.repoPetFoodPrice.AutoHeight = false;
            this.repoPetFoodPrice.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repoPetFoodPrice.Name = "repoPetFoodPrice";
            // 
            // colTransactionDate
            // 
            this.colTransactionDate.Caption = "TransactionDate";
            this.colTransactionDate.FieldName = "TransactionDate";
            this.colTransactionDate.MinWidth = 25;
            this.colTransactionDate.Name = "colTransactionDate";
            this.colTransactionDate.Visible = true;
            this.colTransactionDate.VisibleIndex = 8;
            this.colTransactionDate.Width = 94;
            // 
            // colTotalPrice
            // 
            this.colTotalPrice.Caption = "TotalPrice";
            this.colTotalPrice.FieldName = "TotalPrice";
            this.colTotalPrice.MinWidth = 25;
            this.colTotalPrice.Name = "colTotalPrice";
            this.colTotalPrice.Visible = true;
            this.colTotalPrice.VisibleIndex = 9;
            this.colTotalPrice.Width = 94;
            // 
            // grdTransaction
            // 
            this.grdTransaction.Location = new System.Drawing.Point(154, 57);
            this.grdTransaction.MainView = gridView1;
            this.grdTransaction.Name = "grdTransaction";
            this.grdTransaction.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repoCustomerID,
            this.repoFoodQty,
            this.repoEmployee,
            this.repoPet,
            this.repoPetFoodID,
            this.repoPetFoodPrice});
            this.grdTransaction.Size = new System.Drawing.Size(1063, 217);
            this.grdTransaction.TabIndex = 0;
            this.grdTransaction.UseEmbeddedNavigator = true;
            this.grdTransaction.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            gridView1});
            this.grdTransaction.Click += new System.EventHandler(this.grdTransaction_Click);
            // 
            // btnPopulateTransaction
            // 
            this.btnPopulateTransaction.Location = new System.Drawing.Point(12, 57);
            this.btnPopulateTransaction.Name = "btnPopulateTransaction";
            this.btnPopulateTransaction.Size = new System.Drawing.Size(94, 29);
            this.btnPopulateTransaction.TabIndex = 1;
            this.btnPopulateTransaction.Text = "Populate";
            this.btnPopulateTransaction.UseVisualStyleBackColor = true;
            this.btnPopulateTransaction.Click += new System.EventHandler(this.btnPopulateTransaction_Click);
            // 
            // btnOrder
            // 
            this.btnOrder.Location = new System.Drawing.Point(1246, 57);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(94, 29);
            this.btnOrder.TabIndex = 2;
            this.btnOrder.Text = "Order";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(154, 338);
            this.gridControl1.MainView = this.gridView2;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1063, 250);
            this.gridControl1.TabIndex = 3;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.gridControl1;
            this.gridView2.Name = "gridView2";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(534, 616);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(94, 29);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // TransactionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1382, 715);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.btnPopulateTransaction);
            this.Controls.Add(this.grdTransaction);
            this.Name = "TransactionForm";
            this.Text = "TransactionForm";
            this.Load += new System.EventHandler(this.TransactionForm_Load);
            ((System.ComponentModel.ISupportInitialize)(gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repoPet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repoEmployee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repoPetFoodID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repoCustomerID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repoFoodQty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repoPetFoodPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdTransaction)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTransaction)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl grdTransaction;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private BindingSource bsTransaction;
        private Button btnPopulateTransaction;
        private DevExpress.XtraGrid.Columns.GridColumn colTransactionID;
        private DevExpress.XtraGrid.Columns.GridColumn colPetID;
        private DevExpress.XtraGrid.Columns.GridColumn colEmployeeID;
        private DevExpress.XtraGrid.Columns.GridColumn colCustomerID;
        private DevExpress.XtraGrid.Columns.GridColumn PetPrice;
        private DevExpress.XtraGrid.Columns.GridColumn colPetFoodQty;
        private DevExpress.XtraGrid.Columns.GridColumn colPetFoodPrice;
        private DevExpress.XtraGrid.Columns.GridColumn colTransactionDate;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalPrice;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repoCustomerID;
        private Button btnOrder;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit repoFoodQty;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private Button btnClose;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repoEmployee;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repoPet;
        private DevExpress.XtraGrid.Columns.GridColumn colPetFoodID;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repoPetFoodID;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repoPetFoodPrice;
    }
}