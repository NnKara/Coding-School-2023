namespace Session_16 {
    partial class PetFoodForm {
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
            this.grdPetFood = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colPetFoodID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPetFoodType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPetFoodPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPetFoodCost = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnPopulatePetFood = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdPetFood)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // grdPetFood
            // 
            this.grdPetFood.Location = new System.Drawing.Point(143, 31);
            this.grdPetFood.MainView = this.gridView1;
            this.grdPetFood.Name = "grdPetFood";
            this.grdPetFood.Size = new System.Drawing.Size(827, 547);
            this.grdPetFood.TabIndex = 0;
            this.grdPetFood.UseEmbeddedNavigator = true;
            this.grdPetFood.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.grdPetFood.Click += new System.EventHandler(this.grdPetFood_Click);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colPetFoodID,
            this.colPetFoodType,
            this.colPetFoodPrice,
            this.colPetFoodCost});
            this.gridView1.GridControl = this.grdPetFood;
            this.gridView1.Name = "gridView1";
            this.gridView1.RowDeleting += new DevExpress.Data.RowDeletingEventHandler(this.gridView1_RowDeleting);
            this.gridView1.ValidateRow += new DevExpress.XtraGrid.Views.Base.ValidateRowEventHandler(this.gridView1_ValidateRow);
            // 
            // colPetFoodID
            // 
            this.colPetFoodID.Caption = "PetFoodID";
            this.colPetFoodID.FieldName = "PetFoodID";
            this.colPetFoodID.MinWidth = 25;
            this.colPetFoodID.Name = "colPetFoodID";
            this.colPetFoodID.Width = 94;
            // 
            // colPetFoodType
            // 
            this.colPetFoodType.Caption = "Type";
            this.colPetFoodType.FieldName = "AnimalType";
            this.colPetFoodType.MinWidth = 25;
            this.colPetFoodType.Name = "colPetFoodType";
            this.colPetFoodType.Visible = true;
            this.colPetFoodType.VisibleIndex = 0;
            this.colPetFoodType.Width = 94;
            // 
            // colPetFoodPrice
            // 
            this.colPetFoodPrice.Caption = "Price";
            this.colPetFoodPrice.FieldName = "Price";
            this.colPetFoodPrice.MinWidth = 25;
            this.colPetFoodPrice.Name = "colPetFoodPrice";
            this.colPetFoodPrice.Visible = true;
            this.colPetFoodPrice.VisibleIndex = 1;
            this.colPetFoodPrice.Width = 94;
            // 
            // colPetFoodCost
            // 
            this.colPetFoodCost.Caption = "Cost";
            this.colPetFoodCost.FieldName = "Cost";
            this.colPetFoodCost.MinWidth = 25;
            this.colPetFoodCost.Name = "colPetFoodCost";
            this.colPetFoodCost.Visible = true;
            this.colPetFoodCost.VisibleIndex = 2;
            this.colPetFoodCost.Width = 94;
            // 
            // btnPopulatePetFood
            // 
            this.btnPopulatePetFood.Location = new System.Drawing.Point(143, 594);
            this.btnPopulatePetFood.Name = "btnPopulatePetFood";
            this.btnPopulatePetFood.Size = new System.Drawing.Size(96, 33);
            this.btnPopulatePetFood.TabIndex = 1;
            this.btnPopulatePetFood.Text = "Populate";
            this.btnPopulatePetFood.UseVisualStyleBackColor = true;
            this.btnPopulatePetFood.Click += new System.EventHandler(this.btnPopulatePetFood_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(861, 594);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(94, 29);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // PetFoodForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1239, 808);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnPopulatePetFood);
            this.Controls.Add(this.grdPetFood);
            this.Name = "PetFoodForm";
            this.Text = "PetFoodForm";
            this.Load += new System.EventHandler(this.PetFoodForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdPetFood)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl grdPetFood;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colPetFoodID;
        private DevExpress.XtraGrid.Columns.GridColumn colPetFoodType;
        private DevExpress.XtraGrid.Columns.GridColumn colPetFoodPrice;
        private Button btnPopulatePetFood;
        private DevExpress.XtraGrid.Columns.GridColumn colPetFoodCost;
        private BindingSource bindingSource1;
        private Button btnClose;
    }
}