namespace Session_16 {
    partial class MonthlyLedgerForm {
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
            this.grdMonthlyLedger = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMonthlyLedgerID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMonth = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colYear = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colExpenses = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIncome = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.bsMonthlyLedger = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.grdMonthlyLedger)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMonthlyLedger)).BeginInit();
            this.SuspendLayout();
            // 
            // grdMonthlyLedger
            // 
            this.grdMonthlyLedger.Location = new System.Drawing.Point(234, 40);
            this.grdMonthlyLedger.MainView = this.gridView1;
            this.grdMonthlyLedger.Name = "grdMonthlyLedger";
            this.grdMonthlyLedger.Size = new System.Drawing.Size(724, 445);
            this.grdMonthlyLedger.TabIndex = 0;
            this.grdMonthlyLedger.UseEmbeddedNavigator = true;
            this.grdMonthlyLedger.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMonthlyLedgerID,
            this.colMonth,
            this.colYear,
            this.colExpenses,
            this.colIncome,
            this.colTotal});
            this.gridView1.GridControl = this.grdMonthlyLedger;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colMonthlyLedgerID
            // 
            this.colMonthlyLedgerID.Caption = "MonthlyLedger";
            this.colMonthlyLedgerID.FieldName = "MonthlyLedgerID";
            this.colMonthlyLedgerID.MinWidth = 25;
            this.colMonthlyLedgerID.Name = "colMonthlyLedgerID";
            this.colMonthlyLedgerID.Visible = true;
            this.colMonthlyLedgerID.VisibleIndex = 0;
            this.colMonthlyLedgerID.Width = 94;
            // 
            // colMonth
            // 
            this.colMonth.Caption = "Month";
            this.colMonth.FieldName = "Month";
            this.colMonth.MinWidth = 25;
            this.colMonth.Name = "colMonth";
            this.colMonth.Visible = true;
            this.colMonth.VisibleIndex = 1;
            this.colMonth.Width = 94;
            // 
            // colYear
            // 
            this.colYear.Caption = "Year";
            this.colYear.FieldName = "Year";
            this.colYear.MinWidth = 25;
            this.colYear.Name = "colYear";
            this.colYear.Visible = true;
            this.colYear.VisibleIndex = 2;
            this.colYear.Width = 94;
            // 
            // colExpenses
            // 
            this.colExpenses.Caption = "Expenses";
            this.colExpenses.FieldName = "Expenses";
            this.colExpenses.MinWidth = 25;
            this.colExpenses.Name = "colExpenses";
            this.colExpenses.Visible = true;
            this.colExpenses.VisibleIndex = 3;
            this.colExpenses.Width = 94;
            // 
            // colIncome
            // 
            this.colIncome.Caption = "Income";
            this.colIncome.FieldName = "Income";
            this.colIncome.MinWidth = 25;
            this.colIncome.Name = "colIncome";
            this.colIncome.Visible = true;
            this.colIncome.VisibleIndex = 4;
            this.colIncome.Width = 94;
            // 
            // colTotal
            // 
            this.colTotal.Caption = "Total";
            this.colTotal.FieldName = "Total";
            this.colTotal.MinWidth = 25;
            this.colTotal.Name = "colTotal";
            this.colTotal.Visible = true;
            this.colTotal.VisibleIndex = 5;
            this.colTotal.Width = 94;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(33, 491);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(215, 27);
            this.button1.TabIndex = 1;
            this.button1.Text = "Populate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MonthlyLedgerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1053, 539);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.grdMonthlyLedger);
            this.Name = "MonthlyLedgerForm";
            this.Text = "MonthlyLedgerForm";
            this.Load += new System.EventHandler(this.MonthlyLedgerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdMonthlyLedger)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMonthlyLedger)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl grdMonthlyLedger;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMonthlyLedgerID;
        private DevExpress.XtraGrid.Columns.GridColumn colMonth;
        private DevExpress.XtraGrid.Columns.GridColumn colYear;
        private DevExpress.XtraGrid.Columns.GridColumn colExpenses;
        private DevExpress.XtraGrid.Columns.GridColumn colIncome;
        private DevExpress.XtraGrid.Columns.GridColumn colTotal;
        private Button button1;
        private BindingSource bsMonthlyLedger;
    }
}