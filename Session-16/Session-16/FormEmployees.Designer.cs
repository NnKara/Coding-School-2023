namespace Session_16 {
    partial class FormEmployees {
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
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.grdEmployees = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colEmployeeID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmployeeName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmployeeSurname = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmployeeType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmployeeSalary = new DevExpress.XtraGrid.Columns.GridColumn();
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnPopulateEmployees = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdEmployees)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(64, 38);
            this.gridControl1.MainView = this.grdEmployees;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(771, 420);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.UseEmbeddedNavigator = true;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdEmployees});
            this.gridControl1.Click += new System.EventHandler(this.gridControl1_Click);
            // 
            // grdEmployees
            // 
            this.grdEmployees.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colEmployeeID,
            this.colEmployeeName,
            this.colEmployeeSurname,
            this.colEmployeeType,
            this.colEmployeeSalary});
            this.grdEmployees.GridControl = this.gridControl1;
            this.grdEmployees.Name = "grdEmployees";
            this.grdEmployees.ValidateRow += new DevExpress.XtraGrid.Views.Base.ValidateRowEventHandler(this.grdEmployees_ValidateRow);
            // 
            // colEmployeeID
            // 
            this.colEmployeeID.Caption = "EmployeeID";
            this.colEmployeeID.FieldName = "EmployeeID";
            this.colEmployeeID.MinWidth = 25;
            this.colEmployeeID.Name = "colEmployeeID";
            this.colEmployeeID.Width = 94;
            // 
            // colEmployeeName
            // 
            this.colEmployeeName.Caption = "Name";
            this.colEmployeeName.FieldName = "EmployeeName";
            this.colEmployeeName.MinWidth = 25;
            this.colEmployeeName.Name = "colEmployeeName";
            this.colEmployeeName.Visible = true;
            this.colEmployeeName.VisibleIndex = 0;
            this.colEmployeeName.Width = 94;
            // 
            // colEmployeeSurname
            // 
            this.colEmployeeSurname.Caption = "Surname";
            this.colEmployeeSurname.FieldName = "EmployeeSurname";
            this.colEmployeeSurname.MinWidth = 25;
            this.colEmployeeSurname.Name = "colEmployeeSurname";
            this.colEmployeeSurname.Visible = true;
            this.colEmployeeSurname.VisibleIndex = 1;
            this.colEmployeeSurname.Width = 94;
            // 
            // colEmployeeType
            // 
            this.colEmployeeType.Caption = "Type";
            this.colEmployeeType.FieldName = "EmployeeType";
            this.colEmployeeType.MinWidth = 25;
            this.colEmployeeType.Name = "colEmployeeType";
            this.colEmployeeType.Visible = true;
            this.colEmployeeType.VisibleIndex = 2;
            this.colEmployeeType.Width = 94;
            // 
            // colEmployeeSalary
            // 
            this.colEmployeeSalary.Caption = "Sallary";
            this.colEmployeeSalary.FieldName = "SallaryPerMonth";
            this.colEmployeeSalary.MinWidth = 25;
            this.colEmployeeSalary.Name = "colEmployeeSalary";
            this.colEmployeeSalary.Visible = true;
            this.colEmployeeSalary.VisibleIndex = 3;
            this.colEmployeeSalary.Width = 94;
            // 
            // btnPopulateEmployees
            // 
            this.btnPopulateEmployees.Location = new System.Drawing.Point(64, 483);
            this.btnPopulateEmployees.Name = "btnPopulateEmployees";
            this.btnPopulateEmployees.Size = new System.Drawing.Size(94, 29);
            this.btnPopulateEmployees.TabIndex = 1;
            this.btnPopulateEmployees.Text = "Populate";
            this.btnPopulateEmployees.UseVisualStyleBackColor = true;
            this.btnPopulateEmployees.Click += new System.EventHandler(this.btnPopulateEmployees_Click);
            // 
            // FormEmployees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 628);
            this.Controls.Add(this.btnPopulateEmployees);
            this.Controls.Add(this.gridControl1);
            this.Name = "FormEmployees";
            this.Text = "FormEmployees";
            this.Load += new System.EventHandler(this.FormEmployees_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdEmployees)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView grdEmployees;
        private DevExpress.XtraGrid.Columns.GridColumn colEmployeeID;
        private DevExpress.XtraGrid.Columns.GridColumn colEmployeeName;
        private DevExpress.XtraGrid.Columns.GridColumn colEmployeeSurname;
        private DevExpress.XtraGrid.Columns.GridColumn colEmployeeType;
        private DevExpress.XtraGrid.Columns.GridColumn colEmployeeSalary;
        private BindingSource employeeBindingSource;
        private Button btnPopulateEmployees;
    }
}