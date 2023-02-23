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
            this.btnSave = new System.Windows.Forms.Button();
            this.bsTransactions = new System.Windows.Forms.BindingSource(this.components);
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.bsItems = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.bsTransLines = new System.Windows.Forms.BindingSource(this.components);
            this.btnNewTrans = new System.Windows.Forms.Button();
            this.bsEmployees = new System.Windows.Forms.BindingSource(this.components);
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnNewLine = new System.Windows.Forms.Button();
            this.colTransID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDiscValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDisPercentage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNetValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colItemPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colItem = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.colTransLineID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grdTransLines = new System.Windows.Forms.DataGridView();
            this.colEmployee = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.colTotalValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPaymentMethod = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.colDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTransactionID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grdTransactions = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.bsTransactions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTransLines)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsEmployees)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdTransLines)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdTransactions)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(1013, 76);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(94, 29);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(1013, 122);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(94, 29);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(1013, 625);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(94, 29);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Info;
            this.label2.Location = new System.Drawing.Point(329, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "CDetails";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnNewTrans
            // 
            this.btnNewTrans.Location = new System.Drawing.Point(65, 286);
            this.btnNewTrans.Name = "btnNewTrans";
            this.btnNewTrans.Size = new System.Drawing.Size(94, 29);
            this.btnNewTrans.TabIndex = 10;
            this.btnNewTrans.Text = "New Line";
            this.btnNewTrans.UseVisualStyleBackColor = true;
            this.btnNewTrans.Click += new System.EventHandler(this.btnNewTrans_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(1013, 286);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(94, 29);
            this.btnRefresh.TabIndex = 6;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnNewLine
            // 
            this.btnNewLine.Location = new System.Drawing.Point(65, 616);
            this.btnNewLine.Name = "btnNewLine";
            this.btnNewLine.Size = new System.Drawing.Size(94, 29);
            this.btnNewLine.TabIndex = 3;
            this.btnNewLine.Text = "New Line";
            this.btnNewLine.UseVisualStyleBackColor = true;
            this.btnNewLine.Click += new System.EventHandler(this.btnNewLine_Click);
            // 
            // colTransID
            // 
            this.colTransID.DataPropertyName = "TransactionID";
            this.colTransID.HeaderText = "TransID";
            this.colTransID.MinimumWidth = 6;
            this.colTransID.Name = "colTransID";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "TotalValue";
            this.dataGridViewTextBoxColumn1.HeaderText = "Total";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // colDiscValue
            // 
            this.colDiscValue.DataPropertyName = "DiscountValue";
            this.colDiscValue.HeaderText = "DiscValue";
            this.colDiscValue.MinimumWidth = 6;
            this.colDiscValue.Name = "colDiscValue";
            // 
            // colDisPercentage
            // 
            this.colDisPercentage.DataPropertyName = "DiscountPercent";
            this.colDisPercentage.HeaderText = "DiscPercentage";
            this.colDisPercentage.MinimumWidth = 6;
            this.colDisPercentage.Name = "colDisPercentage";
            // 
            // colNetValue
            // 
            this.colNetValue.DataPropertyName = "NetValue";
            this.colNetValue.HeaderText = "NetValue";
            this.colNetValue.MinimumWidth = 6;
            this.colNetValue.Name = "colNetValue";
            // 
            // colQuantity
            // 
            this.colQuantity.DataPropertyName = "Quantity";
            this.colQuantity.HeaderText = "Quantity";
            this.colQuantity.MinimumWidth = 6;
            this.colQuantity.Name = "colQuantity";
            // 
            // colItemPrice
            // 
            this.colItemPrice.DataPropertyName = "ItemPrice";
            this.colItemPrice.HeaderText = "Price";
            this.colItemPrice.MinimumWidth = 6;
            this.colItemPrice.Name = "colItemPrice";
            // 
            // colItem
            // 
            this.colItem.DataPropertyName = "ItemID";
            this.colItem.HeaderText = "Item";
            this.colItem.MinimumWidth = 6;
            this.colItem.Name = "colItem";
            this.colItem.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colItem.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // colTransLineID
            // 
            this.colTransLineID.DataPropertyName = "TransactionLineID";
            this.colTransLineID.HeaderText = "TransLineID";
            this.colTransLineID.MinimumWidth = 6;
            this.colTransLineID.Name = "colTransLineID";
            // 
            // grdTransLines
            // 
            this.grdTransLines.AllowUserToAddRows = false;
            this.grdTransLines.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.grdTransLines.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdTransLines.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.grdTransLines.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdTransLines.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colTransLineID,
            this.colItem,
            this.colItemPrice,
            this.colQuantity,
            this.colNetValue,
            this.colDisPercentage,
            this.colDiscValue,
            this.dataGridViewTextBoxColumn1,
            this.colTransID});
            this.grdTransLines.Location = new System.Drawing.Point(65, 374);
            this.grdTransLines.Name = "grdTransLines";
            this.grdTransLines.RowHeadersWidth = 51;
            this.grdTransLines.RowTemplate.Height = 29;
            this.grdTransLines.Size = new System.Drawing.Size(1048, 227);
            this.grdTransLines.TabIndex = 5;
            this.grdTransLines.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdTransLines_CellContentClick);
            this.grdTransLines.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdTransLines_CellValueChangedAsync);
            // 
            // colEmployee
            // 
            this.colEmployee.DataPropertyName = "Employee";
            this.colEmployee.HeaderText = "Employee";
            this.colEmployee.MinimumWidth = 6;
            this.colEmployee.Name = "colEmployee";
            // 
            // colTotalValue
            // 
            this.colTotalValue.DataPropertyName = "TotalValue";
            this.colTotalValue.HeaderText = "Total";
            this.colTotalValue.MinimumWidth = 6;
            this.colTotalValue.Name = "colTotalValue";
            // 
            // colPaymentMethod
            // 
            this.colPaymentMethod.HeaderText = "PaymentMethod";
            this.colPaymentMethod.MinimumWidth = 6;
            this.colPaymentMethod.Name = "colPaymentMethod";
            this.colPaymentMethod.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // colDate
            // 
            this.colDate.DataPropertyName = "Date";
            this.colDate.HeaderText = "Date";
            this.colDate.MinimumWidth = 6;
            this.colDate.Name = "colDate";
            // 
            // colTransactionID
            // 
            this.colTransactionID.DataPropertyName = "TransactionID";
            this.colTransactionID.HeaderText = "TransactionID";
            this.colTransactionID.MinimumWidth = 6;
            this.colTransactionID.Name = "colTransactionID";
            // 
            // grdTransactions
            // 
            this.grdTransactions.AllowUserToAddRows = false;
            this.grdTransactions.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.grdTransactions.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdTransactions.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.grdTransactions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdTransactions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colTransactionID,
            this.colDate,
            this.colPaymentMethod,
            this.colTotalValue,
            this.colEmployee});
            this.grdTransactions.Location = new System.Drawing.Point(180, 76);
            this.grdTransactions.Name = "grdTransactions";
            this.grdTransactions.RowHeadersWidth = 51;
            this.grdTransactions.RowTemplate.Height = 29;
            this.grdTransactions.Size = new System.Drawing.Size(781, 239);
            this.grdTransactions.TabIndex = 4;
            this.grdTransactions.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdTransactions_CellContentClick);
            this.grdTransactions.SelectionChanged += new System.EventHandler(this.grdTransactions_SelectionChanged);
            // 
            // TransactionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1185, 683);
            this.Controls.Add(this.btnNewTrans);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.grdTransLines);
            this.Controls.Add(this.grdTransactions);
            this.Controls.Add(this.btnNewLine);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSave);
            this.Name = "TransactionForm";
            this.Text = "TransactionForm";
            this.Load += new System.EventHandler(this.TransactionForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsTransactions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTransLines)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsEmployees)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdTransLines)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdTransactions)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnSave;
        private BindingSource bsTransactions;
        private Button btnDelete;
        private Button btnClose;
        private DataGridView dataGridView1;
        private DataGridView dataGridView2;
        private BindingSource bindingSource1;
        private Label label2;
        private BindingSource bsTransLines;
        private Button btnNewTrans;
        private BindingSource bsItems;
        private BindingSource bsEmployees;
        private Button btnRefresh;
        private Button btnNewLine;
        private DataGridViewTextBoxColumn colTransID;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn colDiscValue;
        private DataGridViewTextBoxColumn colDisPercentage;
        private DataGridViewTextBoxColumn colNetValue;
        private DataGridViewTextBoxColumn colQuantity;
        private DataGridViewTextBoxColumn colItemPrice;
        private DataGridViewComboBoxColumn colItem;
        private DataGridViewTextBoxColumn colTransLineID;
        private DataGridView grdTransLines;
        private DataGridViewComboBoxColumn colEmployee;
        private DataGridViewTextBoxColumn colTotalValue;
        private DataGridViewComboBoxColumn colPaymentMethod;
        private DataGridViewTextBoxColumn colDate;
        private DataGridViewTextBoxColumn colTransactionID;
        private DataGridView grdTransactions;
    }
}