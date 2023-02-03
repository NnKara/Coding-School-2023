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
            this.grdTransaction = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.bsTransaction = new System.Windows.Forms.BindingSource(this.components);
            this.btnPopulateTransaction = new System.Windows.Forms.Button();
            this.colTransactionID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPetID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmployeeID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCustomerID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.PetPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPetFoodQty = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPetFoodPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTransactionDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grdTransaction)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTransaction)).BeginInit();
            this.SuspendLayout();
            // 
            // grdTransaction
            // 
            this.grdTransaction.Location = new System.Drawing.Point(154, 57);
            this.grdTransaction.MainView = this.gridView1;
            this.grdTransaction.Name = "grdTransaction";
            this.grdTransaction.Size = new System.Drawing.Size(1057, 482);
            this.grdTransaction.TabIndex = 0;
            this.grdTransaction.UseEmbeddedNavigator = true;
            this.grdTransaction.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.grdTransaction.Click += new System.EventHandler(this.grdTransaction_Click);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colTransactionID,
            this.colPetID,
            this.colEmployeeID,
            this.colCustomerID,
            this.PetPrice,
            this.colPetFoodQty,
            this.colPetFoodPrice,
            this.colTransactionDate,
            this.colTotalPrice});
            this.gridView1.GridControl = this.grdTransaction;
            this.gridView1.Name = "gridView1";
            this.gridView1.RowDeleting += new DevExpress.Data.RowDeletingEventHandler(this.gridView1_RowDeleting);
            this.gridView1.ValidateRow += new DevExpress.XtraGrid.Views.Base.ValidateRowEventHandler(this.gridView1_ValidateRow);
            // 
            // btnPopulateTransaction
            // 
            this.btnPopulateTransaction.Location = new System.Drawing.Point(154, 545);
            this.btnPopulateTransaction.Name = "btnPopulateTransaction";
            this.btnPopulateTransaction.Size = new System.Drawing.Size(94, 29);
            this.btnPopulateTransaction.TabIndex = 1;
            this.btnPopulateTransaction.Text = "Populate";
            this.btnPopulateTransaction.UseVisualStyleBackColor = true;
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
            this.colPetID.FieldName = "PetID";
            this.colPetID.MinWidth = 25;
            this.colPetID.Name = "colPetID";
            this.colPetID.Visible = true;
            this.colPetID.VisibleIndex = 1;
            this.colPetID.Width = 94;
            // 
            // colEmployeeID
            // 
            this.colEmployeeID.Caption = "EmployeeID";
            this.colEmployeeID.FieldName = "EmployeeID";
            this.colEmployeeID.MinWidth = 25;
            this.colEmployeeID.Name = "colEmployeeID";
            this.colEmployeeID.Visible = true;
            this.colEmployeeID.VisibleIndex = 2;
            this.colEmployeeID.Width = 94;
            // 
            // colCustomerID
            // 
            this.colCustomerID.Caption = "CustomerID";
            this.colCustomerID.FieldName = "CustomerID";
            this.colCustomerID.MinWidth = 25;
            this.colCustomerID.Name = "colCustomerID";
            this.colCustomerID.Visible = true;
            this.colCustomerID.VisibleIndex = 3;
            this.colCustomerID.Width = 94;
            // 
            // PetPrice
            // 
            this.PetPrice.Caption = "PetPrice";
            this.PetPrice.FieldName = "PetPrice";
            this.PetPrice.MinWidth = 25;
            this.PetPrice.Name = "PetPrice";
            this.PetPrice.Visible = true;
            this.PetPrice.VisibleIndex = 4;
            this.PetPrice.Width = 94;
            // 
            // colPetFoodQty
            // 
            this.colPetFoodQty.Caption = "PetFoodQty";
            this.colPetFoodQty.FieldName = "PetFoodQty";
            this.colPetFoodQty.MinWidth = 25;
            this.colPetFoodQty.Name = "colPetFoodQty";
            this.colPetFoodQty.Visible = true;
            this.colPetFoodQty.VisibleIndex = 5;
            this.colPetFoodQty.Width = 94;
            // 
            // colPetFoodPrice
            // 
            this.colPetFoodPrice.Caption = "PetFoodPrice";
            this.colPetFoodPrice.FieldName = "PetFoodPrice";
            this.colPetFoodPrice.MinWidth = 25;
            this.colPetFoodPrice.Name = "colPetFoodPrice";
            this.colPetFoodPrice.Visible = true;
            this.colPetFoodPrice.VisibleIndex = 6;
            this.colPetFoodPrice.Width = 94;
            // 
            // colTransactionDate
            // 
            this.colTransactionDate.Caption = "TransactionDate";
            this.colTransactionDate.FieldName = "TransactionDate";
            this.colTransactionDate.MinWidth = 25;
            this.colTransactionDate.Name = "colTransactionDate";
            this.colTransactionDate.Visible = true;
            this.colTransactionDate.VisibleIndex = 7;
            this.colTransactionDate.Width = 94;
            // 
            // colTotalPrice
            // 
            this.colTotalPrice.Caption = "TotalPrice";
            this.colTotalPrice.FieldName = "TotalPrice";
            this.colTotalPrice.MinWidth = 25;
            this.colTotalPrice.Name = "colTotalPrice";
            this.colTotalPrice.Visible = true;
            this.colTotalPrice.VisibleIndex = 8;
            this.colTotalPrice.Width = 94;
            // 
            // TransactionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1382, 715);
            this.Controls.Add(this.btnPopulateTransaction);
            this.Controls.Add(this.grdTransaction);
            this.Name = "TransactionForm";
            this.Text = "TransactionForm";
            this.Load += new System.EventHandler(this.TransactionForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdTransaction)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTransaction)).EndInit();
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
    }
}