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
            this.btnRef = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
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
            // 
            // grdTransactionLines
            // 
            this.grdTransactionLines.Location = new System.Drawing.Point(196, 572);
            this.grdTransactionLines.MainView = this.grdTransLines;
            this.grdTransactionLines.Name = "grdTransactionLines";
            this.grdTransactionLines.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repoItem,
            this.repQuantity});
            this.grdTransactionLines.Size = new System.Drawing.Size(890, 250);
            this.grdTransactionLines.TabIndex = 11;
            this.grdTransactionLines.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdTransLines});
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
            this.grdTransLines.OptionsDetail.EnableMasterViewMode = false;
            this.grdTransLines.OptionsDetail.ShowDetailTabs = false;
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
            this.repQuantity.MaxValue = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.repQuantity.MinValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
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
            this.grdTransactions.Size = new System.Drawing.Size(870, 286);
            this.grdTransactions.TabIndex = 12;
            this.grdTransactions.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.ActiveFilterEnabled = false;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colTransactionID,
            this.colDate,
            this.colEmployee,
            this.colPaymentMethod,
            this.colTotalValue});
            this.gridView1.GridControl = this.grdTransactions;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsDetail.EnableMasterViewMode = false;
            this.gridView1.OptionsDetail.ShowDetailTabs = false;
            this.gridView1.OptionsView.ShowGroupExpandCollapseButtons = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.OptionsView.ShowIndicator = false;
            this.gridView1.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridTransactions_CellValueChanged);
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
            this.btnAddTransLine.Location = new System.Drawing.Point(37, 3);
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
            this.btnDeleteLine.Location = new System.Drawing.Point(37, 204);
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
            this.btnOpenTransaction.Location = new System.Drawing.Point(49, 100);
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
            this.BtnSaveUpdateTransaction.Location = new System.Drawing.Point(371, 425);
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
            this.btnDeleteTrans.Location = new System.Drawing.Point(49, 322);
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
            this.btnRemoveCurrentRow.Location = new System.Drawing.Point(37, 104);
            this.btnRemoveCurrentRow.Name = "btnRemoveCurrentRow";
            this.btnRemoveCurrentRow.Size = new System.Drawing.Size(111, 50);
            this.btnRemoveCurrentRow.TabIndex = 20;
            this.btnRemoveCurrentRow.Text = "Remove Current ";
            this.btnRemoveCurrentRow.UseVisualStyleBackColor = false;
            this.btnRemoveCurrentRow.Click += new System.EventHandler(this.btnRemoveCurrentRow_Click);
            // 
            // btnRemoveCurrentTransaction
            // 
            this.btnRemoveCurrentTransaction.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnRemoveCurrentTransaction.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnRemoveCurrentTransaction.Location = new System.Drawing.Point(49, 196);
            this.btnRemoveCurrentTransaction.Name = "btnRemoveCurrentTransaction";
            this.btnRemoveCurrentTransaction.Size = new System.Drawing.Size(111, 54);
            this.btnRemoveCurrentTransaction.TabIndex = 21;
            this.btnRemoveCurrentTransaction.Text = "Remove Current";
            this.btnRemoveCurrentTransaction.UseVisualStyleBackColor = false;
            this.btnRemoveCurrentTransaction.Click += new System.EventHandler(this.btnRemoveCurrentTransaction_Click);
            // 
            // btnRef
            // 
            this.btnRef.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnRef.Location = new System.Drawing.Point(725, 425);
            this.btnRef.Name = "btnRef";
            this.btnRef.Size = new System.Drawing.Size(116, 64);
            this.btnRef.TabIndex = 22;
            this.btnRef.Text = "Refresh";
            this.btnRef.UseVisualStyleBackColor = false;
            this.btnRef.Click += new System.EventHandler(this.btnRef_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FloralWhite;
            this.label1.Location = new System.Drawing.Point(371, 874);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 31);
            this.label1.TabIndex = 23;
            this.label1.Text = "KARA\'S FUEL STATION";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::FuelStation.WinForm.Properties.Resources._198257_200;
            this.pictureBox2.Location = new System.Drawing.Point(661, 861);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(193, 62);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 24;
            this.pictureBox2.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(1087, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 31);
            this.label3.TabIndex = 25;
            this.label3.Text = "Information:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(1072, 157);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(285, 23);
            this.label8.TabIndex = 26;
            this.label8.Text = "• You have to fill every cell before ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(1087, 180);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(132, 23);
            this.label9.TabIndex = 27;
            this.label9.Text = "saving an Item.";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnAddTransLine);
            this.panel1.Controls.Add(this.btnRemoveCurrentRow);
            this.panel1.Controls.Add(this.btnDeleteLine);
            this.panel1.Location = new System.Drawing.Point(12, 572);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(180, 259);
            this.panel1.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(1072, 227);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(261, 23);
            this.label4.TabIndex = 29;
            this.label4.Text = "•Above 50 euros , customer has";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(1076, 250);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 23);
            this.label5.TabIndex = 30;
            this.label5.Text = " to pay by cash.";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(1072, 302);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(284, 23);
            this.label6.TabIndex = 31;
            this.label6.Text = "•In order to save a tranasction you";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(1076, 325);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(270, 23);
            this.label7.TabIndex = 32;
            this.label7.Text = "you have to fill transaction lines.";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(1092, 575);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(270, 23);
            this.label10.TabIndex = 33;
            this.label10.Text = "•A transaction can have only one";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(1102, 598);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(178, 23);
            this.label11.TabIndex = 34;
            this.label11.Text = "product of type fuel.";
            // 
            // TransactionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(1383, 935);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRef);
            this.Controls.Add(this.btnRemoveCurrentTransaction);
            this.Controls.Add(this.stackPanel1);
            this.Controls.Add(this.btnDeleteTrans);
            this.Controls.Add(this.BtnSaveUpdateTransaction);
            this.Controls.Add(this.btnOpenTransaction);
            this.Controls.Add(this.grdTransactions);
            this.Controls.Add(this.grdTransactionLines);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
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
        private Button btnRefresh;
        private Button btnRef;
        private Label label1;
        private PictureBox pictureBox2;
        private Label label3;
        private Label label8;
        private Label label9;
        private Panel panel1;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label10;
        private Label label11;
    }
}