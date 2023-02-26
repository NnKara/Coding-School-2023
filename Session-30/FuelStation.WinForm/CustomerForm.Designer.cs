namespace FuelStation.WinForm {
    partial class CustomerForm {
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
            this.bsCustomers = new System.Windows.Forms.BindingSource(this.components);
            this.btnClose = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.gridCustomers = new DevExpress.XtraGrid.GridControl();
            this.grdCustomers = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCustomerID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCustomerName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSurname = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCardNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bsCustomers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridCustomers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdCustomers)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnClose.BackColor = System.Drawing.Color.Gainsboro;
            this.btnClose.Location = new System.Drawing.Point(454, 637);
            this.btnClose.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(160, 49);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.BackColor = System.Drawing.Color.Khaki;
            this.btnAdd.Location = new System.Drawing.Point(119, 424);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(817, 51);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "New Line";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.BackColor = System.Drawing.Color.Red;
            this.btnDelete.Location = new System.Drawing.Point(691, 494);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(245, 50);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.ForestGreen;
            this.btnSave.Location = new System.Drawing.Point(119, 492);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(250, 52);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefresh.BackColor = System.Drawing.Color.Khaki;
            this.btnRefresh.Location = new System.Drawing.Point(454, 492);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(160, 51);
            this.btnRefresh.TabIndex = 5;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // gridCustomers
            // 
            this.gridCustomers.Location = new System.Drawing.Point(119, 79);
            this.gridCustomers.MainView = this.grdCustomers;
            this.gridCustomers.Name = "gridCustomers";
            this.gridCustomers.Size = new System.Drawing.Size(817, 317);
            this.gridCustomers.TabIndex = 6;
            this.gridCustomers.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdCustomers});
            // 
            // grdCustomers
            // 
            this.grdCustomers.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCustomerID,
            this.colCustomerName,
            this.colSurname,
            this.colCardNumber});
            this.grdCustomers.GridControl = this.gridCustomers;
            this.grdCustomers.Name = "grdCustomers";
            // 
            // colCustomerID
            // 
            this.colCustomerID.Caption = "CustomerID";
            this.colCustomerID.FieldName = "CustomerID";
            this.colCustomerID.MinWidth = 25;
            this.colCustomerID.Name = "colCustomerID";
            this.colCustomerID.Width = 94;
            // 
            // colCustomerName
            // 
            this.colCustomerName.Caption = "Name";
            this.colCustomerName.FieldName = "CustomerName";
            this.colCustomerName.MinWidth = 25;
            this.colCustomerName.Name = "colCustomerName";
            this.colCustomerName.Visible = true;
            this.colCustomerName.VisibleIndex = 1;
            this.colCustomerName.Width = 94;
            // 
            // colSurname
            // 
            this.colSurname.Caption = "Surname";
            this.colSurname.FieldName = "CustomerSurname";
            this.colSurname.MinWidth = 25;
            this.colSurname.Name = "colSurname";
            this.colSurname.Visible = true;
            this.colSurname.VisibleIndex = 2;
            this.colSurname.Width = 94;
            // 
            // colCardNumber
            // 
            this.colCardNumber.Caption = "CardNumber";
            this.colCardNumber.FieldName = "CardNumber";
            this.colCardNumber.MinWidth = 25;
            this.colCardNumber.Name = "colCardNumber";
            this.colCardNumber.OptionsColumn.AllowEdit = false;
            this.colCardNumber.Visible = true;
            this.colCardNumber.VisibleIndex = 2;
            this.colCardNumber.Width = 94;
            // 
            // CustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(1128, 690);
            this.Controls.Add(this.gridCustomers);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "CustomerForm";
            this.Text = "CustomerForm";
            this.Load += new System.EventHandler(this.CustomerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsCustomers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridCustomers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdCustomers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private BindingSource bsCustomers;
        private Button btnClose;
        private Button btnAdd;
        private Button btnDelete;
        private Button btnSave;
        private Button btnRefresh;
        private DevExpress.XtraGrid.GridControl gridCustomers;
        private DevExpress.XtraGrid.Views.Grid.GridView grdCustomers;
        private DevExpress.XtraGrid.Columns.GridColumn colCustomerID;
        private DevExpress.XtraGrid.Columns.GridColumn colCustomerName;
        private DevExpress.XtraGrid.Columns.GridColumn colSurname;
        private DevExpress.XtraGrid.Columns.GridColumn colCardNumber;
    }
}