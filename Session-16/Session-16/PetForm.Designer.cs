namespace Session_16 {
    partial class PetForm {
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
            this.gridViewPet = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colPetID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldBreed = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPetStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPetPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPetCost = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPetType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnPopulatePets = new System.Windows.Forms.Button();
            this.bsPet = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsPet)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(126, 74);
            this.gridControl1.MainView = this.gridViewPet;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(833, 346);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.UseEmbeddedNavigator = true;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewPet});
            this.gridControl1.Click += new System.EventHandler(this.gridControl1_Click);
            // 
            // gridViewPet
            // 
            this.gridViewPet.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colPetType,
            this.colPetID,
            this.coldBreed,
            this.colPetStatus,
            this.colPetPrice,
            this.colPetCost});
            this.gridViewPet.GridControl = this.gridControl1;
            this.gridViewPet.Name = "gridViewPet";
            this.gridViewPet.RowDeleting += new DevExpress.Data.RowDeletingEventHandler(this.gridViewPet_RowDeleting);
            this.gridViewPet.ValidateRow += new DevExpress.XtraGrid.Views.Base.ValidateRowEventHandler(this.gridViewPet_ValidateRow);
            // 
            // colPetID
            // 
            this.colPetID.Caption = "PetID";
            this.colPetID.FieldName = "PetID";
            this.colPetID.MinWidth = 25;
            this.colPetID.Name = "colPetID";
            this.colPetID.Width = 94;
            // 
            // coldBreed
            // 
            this.coldBreed.Caption = "Breed";
            this.coldBreed.FieldName = "Breed";
            this.coldBreed.MinWidth = 25;
            this.coldBreed.Name = "coldBreed";
            this.coldBreed.Visible = true;
            this.coldBreed.VisibleIndex = 1;
            this.coldBreed.Width = 94;
            // 
            // colPetStatus
            // 
            this.colPetStatus.Caption = "Status";
            this.colPetStatus.FieldName = "PetStatus";
            this.colPetStatus.MinWidth = 25;
            this.colPetStatus.Name = "colPetStatus";
            this.colPetStatus.Visible = true;
            this.colPetStatus.VisibleIndex = 2;
            this.colPetStatus.Width = 94;
            // 
            // colPetPrice
            // 
            this.colPetPrice.Caption = "Price";
            this.colPetPrice.FieldName = "Price";
            this.colPetPrice.MinWidth = 25;
            this.colPetPrice.Name = "colPetPrice";
            this.colPetPrice.Visible = true;
            this.colPetPrice.VisibleIndex = 3;
            this.colPetPrice.Width = 94;
            // 
            // colPetCost
            // 
            this.colPetCost.Caption = "Cost";
            this.colPetCost.FieldName = "Cost";
            this.colPetCost.MinWidth = 25;
            this.colPetCost.Name = "colPetCost";
            this.colPetCost.Visible = true;
            this.colPetCost.VisibleIndex = 4;
            this.colPetCost.Width = 94;
            // 
            // colPetType
            // 
            this.colPetType.Caption = "Pet";
            this.colPetType.FieldName = "PetType";
            this.colPetType.MinWidth = 25;
            this.colPetType.Name = "colPetType";
            this.colPetType.Visible = true;
            this.colPetType.VisibleIndex = 0;
            this.colPetType.Width = 94;
            // 
            // btnPopulatePets
            // 
            this.btnPopulatePets.Location = new System.Drawing.Point(126, 441);
            this.btnPopulatePets.Name = "btnPopulatePets";
            this.btnPopulatePets.Size = new System.Drawing.Size(94, 29);
            this.btnPopulatePets.TabIndex = 1;
            this.btnPopulatePets.Text = "Populate";
            this.btnPopulatePets.UseVisualStyleBackColor = true;
            this.btnPopulatePets.Click += new System.EventHandler(this.btnPopulatePets_Click);
            // 
            // PetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1154, 689);
            this.Controls.Add(this.btnPopulatePets);
            this.Controls.Add(this.gridControl1);
            this.Name = "PetForm";
            this.Text = "PetForm";
            this.Load += new System.EventHandler(this.PetForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsPet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewPet;
        private DevExpress.XtraGrid.Columns.GridColumn colPetID;
        private DevExpress.XtraGrid.Columns.GridColumn coldBreed;
        private DevExpress.XtraGrid.Columns.GridColumn colPetStatus;
        private DevExpress.XtraGrid.Columns.GridColumn colPetPrice;
        private DevExpress.XtraGrid.Columns.GridColumn colPetCost;
        private DevExpress.XtraGrid.Columns.GridColumn colPetType;
        private Button btnPopulatePets;
        private BindingSource bsPet;
    }
}