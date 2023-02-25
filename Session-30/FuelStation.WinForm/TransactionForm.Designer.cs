namespace FuelStation.WinForm {
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
            this.bsTransactions = new System.Windows.Forms.BindingSource(this.components);
            this.btnClose = new System.Windows.Forms.Button();
            this.bsItems = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.bsTransLines = new System.Windows.Forms.BindingSource(this.components);
            this.bsEmployees = new System.Windows.Forms.BindingSource(this.components);
            this.grdTransactionLines = new DevExpress.XtraGrid.GridControl();
            this.grdTransLines = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colItemID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repoItem = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQuantity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repQuantity = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.colNetValue = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDiscountPercent = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDiscValue = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TotalValue = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTransactionLineID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grdTransactions = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colTransactionID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmployee = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repoEmployee = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colPaymentMethod = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalValue = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repoPaymentMethod = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.btnAddTransLine = new System.Windows.Forms.Button();
            this.btnDeleteLine = new System.Windows.Forms.Button();
            this.btnOpenTransaction = new System.Windows.Forms.Button();
            this.BtnSaveUpdateTransaction = new System.Windows.Forms.Button();
            this.btnDeleteTrans = new System.Windows.Forms.Button();
            this.stackPanel1 = new DevExpress.Utils.Layout.StackPanel();
            this.btnRemoveCurrentRow = new System.Windows.Forms.Button();
            this.btnRemoveCurrentTransaction = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bsTransactions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTransLines)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsEmployees)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdTransactionLines)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdTransLines)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repoItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdTransactions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repoEmployee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repoPaymentMethod)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stackPanel1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.Gainsboro;
            this.btnClose.Location = new System.Drawing.Point(1226, 848);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(111, 57);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Info;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(371, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 31);
            this.label2.TabIndex = 9;
            this.label2.Text = "CDetails";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // grdTransactionLines
            // 
            this.grdTransactionLines.Location = new System.Drawing.Point(185, 572);
            this.grdTransactionLines.MainView = this.grdTransLines;
            this.grdTransactionLines.Name = "grdTransactionLines";
            this.grdTransactionLines.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repoItem,
            this.repQuantity});
            this.grdTransactionLines.Size = new System.Drawing.Size(1013, 250);
            this.grdTransactionLines.TabIndex = 11;
            this.grdTransactionLines.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdTransLines});
            this.grdTransactionLines.Click += new System.EventHandler(this.grdTransactionLines_Click);
            // 
            // grdTransLines
            // 
            this.grdTransLines.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colItemID,
            this.colPrice,
            this.colQuantity,
            this.colNetValue,
            this.colDiscountPercent,
            this.colDiscValue,
            this.TotalValue,
            this.colTransactionLineID,
            this.col});
            this.grdTransLines.GridControl = this.grdTransactionLines;
            this.grdTransLines.Name = "grdTransLines";
            this.grdTransLines.OptionsView.ShowGroupPanel = false;
            this.grdTransLines.OptionsView.ShowIndicator = false;
            this.grdTransLines.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.grdTransLines_CellValueChanged);
            this.grdTransLines.RowUpdated += new DevExpress.XtraGrid.Views.Base.RowObjectEventHandler(this.grdTransLines_RowUpdated);
            // 
            // colItemID
            // 
            this.colItemID.Caption = "Item";
            this.colItemID.ColumnEdit = this.repoItem;
            this.colItemID.FieldName = "ItemID";
            this.colItemID.MinWidth = 25;
            this.colItemID.Name = "colItemID";
            this.colItemID.Visible = true;
            this.colItemID.VisibleIndex = 0;
            this.colItemID.Width = 94;
            // 
            // repoItem
            // 
            this.repoItem.AutoHeight = false;
            this.repoItem.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repoItem.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Code", "Code"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Description", "Description"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ItemType", "Type")});
            this.repoItem.Name = "repoItem";
            // 
            // colPrice
            // 
            this.colPrice.Caption = "Price";
            this.colPrice.FieldName = "ItemPrice";
            this.colPrice.MinWidth = 25;
            this.colPrice.Name = "colPrice";
            this.colPrice.OptionsColumn.AllowEdit = false;
            this.colPrice.Visible = true;
            this.colPrice.VisibleIndex = 1;
            this.colPrice.Width = 94;
            // 
            // colQuantity
            // 
            this.colQuantity.Caption = "Quantity";
            this.colQuantity.ColumnEdit = this.repQuantity;
            this.colQuantity.FieldName = "Quantity";
            this.colQuantity.MinWidth = 25;
            this.colQuantity.Name = "colQuantity";
            this.colQuantity.Visible = true;
            this.colQuantity.VisibleIndex = 2;
            this.colQuantity.Width = 94;
            // 
            // repQuantity
            // 
            this.repQuantity.AutoHeight = false;
            this.repQuantity.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repQuantity.Name = "repQuantity";
            // 
            // colNetValue
            // 
            this.colNetValue.Caption = "NetValue";
            this.colNetValue.FieldName = "NetValue";
            this.colNetValue.MinWidth = 25;
            this.colNetValue.Name = "colNetValue";
            this.colNetValue.OptionsColumn.AllowEdit = false;
            this.colNetValue.Visible = true;
            this.colNetValue.VisibleIndex = 3;
            this.colNetValue.Width = 94;
            // 
            // colDiscountPercent
            // 
            this.colDiscountPercent.Caption = "DiscountPercent";
            this.colDiscountPercent.FieldName = "DiscountPercent";
            this.colDiscountPercent.MinWidth = 25;
            this.colDiscountPercent.Name = "colDiscountPercent";
            this.colDiscountPercent.OptionsColumn.AllowEdit = false;
            this.colDiscountPercent.Visible = true;
            this.colDiscountPercent.VisibleIndex = 4;
            this.colDiscountPercent.Width = 94;
            // 
            // colDiscValue
            // 
            this.colDiscValue.Caption = "DiscountValue";
            this.colDiscValue.FieldName = "DiscountValue";
            this.colDiscValue.MinWidth = 25;
            this.colDiscValue.Name = "colDiscValue";
            this.colDiscValue.OptionsColumn.AllowEdit = false;
            this.colDiscValue.Visible = true;
            this.colDiscValue.VisibleIndex = 5;
            this.colDiscValue.Width = 94;
            // 
            // TotalValue
            // 
            this.TotalValue.Caption = "TotalValue";
            this.TotalValue.FieldName = "TotalValue";
            this.TotalValue.MinWidth = 25;
            this.TotalValue.Name = "TotalValue";
            this.TotalValue.OptionsColumn.AllowEdit = false;
            this.TotalValue.Visible = true;
            this.TotalValue.VisibleIndex = 6;
            this.TotalValue.Width = 94;
            // 
            // colTransactionLineID
            // 
            this.colTransactionLineID.Caption = "TransactionLineID";
            this.colTransactionLineID.FieldName = "TransactionLineID";
            this.colTransactionLineID.MinWidth = 25;
            this.colTransactionLineID.Name = "colTransactionLineID";
            this.colTransactionLineID.OptionsColumn.AllowEdit = false;
            this.colTransactionLineID.Width = 94;
            // 
            // col
            // 
            this.col.Caption = "TransactionID";
            this.col.FieldName = "TransactionID";
            this.col.MinWidth = 25;
            this.col.Name = "col";
            this.col.OptionsColumn.AllowEdit = false;
            this.col.Width = 94;
            // 
            // grdTransactions
            // 
            this.grdTransactions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdTransactions.Location = new System.Drawing.Point(196, 90);
            this.grdTransactions.MainView = this.gridView1;
            this.grdTransactions.Name = "grdTransactions";
            this.grdTransactions.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repoPaymentMethod,
            this.repoEmployee});
            this.grdTransactions.Size = new System.Drawing.Size(1002, 286);
            this.grdTransactions.TabIndex = 12;
            this.grdTransactions.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.grdTransactions.Click += new System.EventHandler(this.grdTransactions_Click);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colTransactionID,
            this.colDate,
            this.colEmployee,
            this.colPaymentMethod,
            this.colTotalValue});
            this.gridView1.GridControl = this.grdTransactions;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.OptionsView.ShowIndicator = false;
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            this.gridView1.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridTransactions_CellValueChanged);
            this.gridView1.RowDeleting += new DevExpress.Data.RowDeletingEventHandler(this.grdTransactionsDelete);
            this.gridView1.RowUpdated += new DevExpress.XtraGrid.Views.Base.RowObjectEventHandler(this.gridView1_RowUpdated);
            // 
            // colTransactionID
            // 
            this.colTransactionID.Caption = "TransactionID";
            this.colTransactionID.FieldName = "TransactionID";
            this.colTransactionID.MinWidth = 25;
            this.colTransactionID.Name = "colTransactionID";
            this.colTransactionID.OptionsColumn.AllowEdit = false;
            this.colTransactionID.Width = 94;
            // 
            // colDate
            // 
            this.colDate.Caption = "Date";
            this.colDate.FieldName = "Date";
            this.colDate.MinWidth = 25;
            this.colDate.Name = "colDate";
            this.colDate.Visible = true;
            this.colDate.VisibleIndex = 0;
            this.colDate.Width = 94;
            // 
            // colEmployee
            // 
            this.colEmployee.Caption = "Employee";
            this.colEmployee.ColumnEdit = this.repoEmployee;
            this.colEmployee.FieldName = "EmployeeID";
            this.colEmployee.MinWidth = 25;
            this.colEmployee.Name = "colEmployee";
            this.colEmployee.Visible = true;
            this.colEmployee.VisibleIndex = 1;
            this.colEmployee.Width = 94;
            // 
            // repoEmployee
            // 
            this.repoEmployee.AutoHeight = false;
            this.repoEmployee.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repoEmployee.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("EmployeeName", "Name"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("EmployeeSurname", "Surname")});
            this.repoEmployee.Name = "repoEmployee";
            // 
            // colPaymentMethod
            // 
            this.colPaymentMethod.Caption = "PaymentMethod";
            this.colPaymentMethod.FieldName = "PaymentMethod";
            this.colPaymentMethod.MinWidth = 25;
            this.colPaymentMethod.Name = "colPaymentMethod";
            this.colPaymentMethod.Visible = true;
            this.colPaymentMethod.VisibleIndex = 2;
            this.colPaymentMethod.Width = 94;
            // 
            // colTotalValue
            // 
            this.colTotalValue.Caption = "TotalValue";
            this.colTotalValue.FieldName = "TotalValue";
            this.colTotalValue.MinWidth = 25;
            this.colTotalValue.Name = "colTotalValue";
            this.colTotalValue.OptionsColumn.AllowEdit = false;
            this.colTotalValue.Visible = true;
            this.colTotalValue.VisibleIndex = 3;
            this.colTotalValue.Width = 94;
            // 
            // repoPaymentMethod
            // 
            this.repoPaymentMethod.AutoHeight = false;
            this.repoPaymentMethod.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repoPaymentMethod.Name = "repoPaymentMethod";
            // 
            // btnAddTransLine
            // 
            this.btnAddTransLine.BackColor = System.Drawing.Color.Khaki;
            this.btnAddTransLine.Location = new System.Drawing.Point(12, 572);
            this.btnAddTransLine.Name = "btnAddTransLine";
            this.btnAddTransLine.Size = new System.Drawing.Size(111, 51);
            this.btnAddTransLine.TabIndex = 13;
            this.btnAddTransLine.Text = "New Line";
            this.btnAddTransLine.UseVisualStyleBackColor = false;
            this.btnAddTransLine.Click += new System.EventHandler(this.btnAddTransLine_Click);
            // 
            // btnDeleteLine
            // 
            this.btnDeleteLine.BackColor = System.Drawing.Color.Red;
            this.btnDeleteLine.Location = new System.Drawing.Point(12, 776);
            this.btnDeleteLine.Name = "btnDeleteLine";
            this.btnDeleteLine.Size = new System.Drawing.Size(111, 46);
            this.btnDeleteLine.TabIndex = 14;
            this.btnDeleteLine.Text = "Delete";
            this.btnDeleteLine.UseVisualStyleBackColor = false;
            this.btnDeleteLine.Click += new System.EventHandler(this.btnDeleteLine_Click);
            // 
            // btnOpenTransaction
            // 
            this.btnOpenTransaction.BackColor = System.Drawing.Color.Khaki;
            this.btnOpenTransaction.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnOpenTransaction.Location = new System.Drawing.Point(12, 90);
            this.btnOpenTransaction.Name = "btnOpenTransaction";
            this.btnOpenTransaction.Size = new System.Drawing.Size(111, 54);
            this.btnOpenTransaction.TabIndex = 16;
            this.btnOpenTransaction.Text = "Open Transaction";
            this.btnOpenTransaction.UseVisualStyleBackColor = false;
            this.btnOpenTransaction.Click += new System.EventHandler(this.btnOpenTransaction_Click);
            // 
            // BtnSaveUpdateTransaction
            // 
            this.BtnSaveUpdateTransaction.BackColor = System.Drawing.Color.SpringGreen;
            this.BtnSaveUpdateTransaction.Location = new System.Drawing.Point(611, 425);
            this.BtnSaveUpdateTransaction.Name = "BtnSaveUpdateTransaction";
            this.BtnSaveUpdateTransaction.Size = new System.Drawing.Size(116, 64);
            this.BtnSaveUpdateTransaction.TabIndex = 17;
            this.BtnSaveUpdateTransaction.Text = "Save/Update";
            this.BtnSaveUpdateTransaction.UseVisualStyleBackColor = false;
            this.BtnSaveUpdateTransaction.Click += new System.EventHandler(this.BtnSaveUpdateTransaction_Click);
            // 
            // btnDeleteTrans
            // 
            this.btnDeleteTrans.BackColor = System.Drawing.Color.Red;
            this.btnDeleteTrans.Location = new System.Drawing.Point(12, 322);
            this.btnDeleteTrans.Name = "btnDeleteTrans";
            this.btnDeleteTrans.Size = new System.Drawing.Size(111, 54);
            this.btnDeleteTrans.TabIndex = 18;
            this.btnDeleteTrans.Text = "Delete";
            this.btnDeleteTrans.UseVisualStyleBackColor = false;
            this.btnDeleteTrans.Click += new System.EventHandler(this.btnDeleteTrans_Click);
            // 
            // stackPanel1
            // 
            this.stackPanel1.Location = new System.Drawing.Point(597, 439);
            this.stackPanel1.Name = "stackPanel1";
            this.stackPanel1.Size = new System.Drawing.Size(8, 8);
            this.stackPanel1.TabIndex = 19;
            this.stackPanel1.UseSkinIndents = true;
            // 
            // btnRemoveCurrentRow
            // 
            this.btnRemoveCurrentRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnRemoveCurrentRow.Location = new System.Drawing.Point(12, 667);
            this.btnRemoveCurrentRow.Name = "btnRemoveCurrentRow";
            this.btnRemoveCurrentRow.Size = new System.Drawing.Size(111, 51);
            this.btnRemoveCurrentRow.TabIndex = 20;
            this.btnRemoveCurrentRow.Text = "Remove Current ";
            this.btnRemoveCurrentRow.UseVisualStyleBackColor = false;
            this.btnRemoveCurrentRow.Click += new System.EventHandler(this.btnRemoveCurrentRow_Click);
            // 
            // btnRemoveCurrentTransaction
            // 
            this.btnRemoveCurrentTransaction.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnRemoveCurrentTransaction.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnRemoveCurrentTransaction.Location = new System.Drawing.Point(12, 200);
            this.btnRemoveCurrentTransaction.Name = "btnRemoveCurrentTransaction";
            this.btnRemoveCurrentTransaction.Size = new System.Drawing.Size(111, 54);
            this.btnRemoveCurrentTransaction.TabIndex = 21;
            this.btnRemoveCurrentTransaction.Text = "Remove Current";
            this.btnRemoveCurrentTransaction.UseVisualStyleBackColor = false;
            this.btnRemoveCurrentTransaction.Click += new System.EventHandler(this.btnRemoveCurrentTransaction_Click);
            // 
            // TransactionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(1383, 935);
            this.Controls.Add(this.btnRemoveCurrentTransaction);
            this.Controls.Add(this.btnRemoveCurrentRow);
            this.Controls.Add(this.stackPanel1);
            this.Controls.Add(this.btnDeleteTrans);
            this.Controls.Add(this.BtnSaveUpdateTransaction);
            this.Controls.Add(this.btnOpenTransaction);
            this.Controls.Add(this.btnDeleteLine);
            this.Controls.Add(this.btnAddTransLine);
            this.Controls.Add(this.grdTransactions);
            this.Controls.Add(this.grdTransactionLines);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnClose);
            this.Name = "TransactionForm";
            this.Text = "TransactionForm";
            this.Load += new System.EventHandler(this.TransactionForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsTransactions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTransLines)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsEmployees)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdTransactionLines)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdTransLines)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repoItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdTransactions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repoEmployee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repoPaymentMethod)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stackPanel1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private BindingSource bsTransactions;
        private Button btnClose;
        private DataGridView dataGridView1;
        private DataGridView dataGridView2;
        private BindingSource bindingSource1;
        private Label label2;
        private BindingSource bsTransLines;
        private BindingSource bsItems;
        private BindingSource bsEmployees;
        private DevExpress.XtraGrid.GridControl grdTransactionLines;
        private DevExpress.XtraGrid.Views.Grid.GridView grdTransLines;
        //private DevExpress.XtraGrid.Columns.GridColumn colTransactionLineID;
        private DevExpress.XtraGrid.Columns.GridColumn colItemID;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repoItem;
        private DevExpress.XtraGrid.Columns.GridColumn colPrice;
        private DevExpress.XtraGrid.Columns.GridColumn colQuantity;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit repQuantity;
        private DevExpress.XtraGrid.Columns.GridColumn colNetValue;
        private DevExpress.XtraGrid.Columns.GridColumn colDiscountPercent;
        private DevExpress.XtraGrid.Columns.GridColumn colDiscValue;
        private DevExpress.XtraGrid.Columns.GridColumn TotalValue;
        private DevExpress.XtraGrid.Columns.GridColumn colTransaction;
        private DevExpress.XtraGrid.GridControl grdTransactions;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repoPaymentMethod;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repoEmployee;
        private Button btnAddTransLine;
        private Button btnDeleteLine;
        private Button btnOpenTransaction;
        private Button BtnSaveUpdateTransaction;
        private Button btnDeleteTrans;
        private DevExpress.XtraGrid.Columns.GridColumn colTransactionLineID;
        private DevExpress.XtraGrid.Columns.GridColumn col;
        private DevExpress.Utils.Layout.StackPanel stackPanel1;
        private Button btnRemoveCurrentRow;
        private DevExpress.XtraGrid.Columns.GridColumn colTransactionID;
        private DevExpress.XtraGrid.Columns.GridColumn colDate;
        private DevExpress.XtraGrid.Columns.GridColumn colEmployee;
        private DevExpress.XtraGrid.Columns.GridColumn colPaymentMethod;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalValue;
        private Button btnRemoveCurrentTransaction;
    }
}