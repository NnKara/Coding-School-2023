namespace FuelStation.WinForm {
    partial class ItemForm {
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
            this.bsItems = new System.Windows.Forms.BindingSource(this.components);
            this.btnNewLine = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colItemID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colItemType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCost = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bsItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNewLine
            // 
            this.btnNewLine.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnNewLine.BackColor = System.Drawing.Color.Khaki;
            this.btnNewLine.Location = new System.Drawing.Point(210, 502);
            this.btnNewLine.Name = "btnNewLine";
            this.btnNewLine.Size = new System.Drawing.Size(790, 41);
            this.btnNewLine.TabIndex = 1;
            this.btnNewLine.Text = "New Line";
            this.btnNewLine.UseVisualStyleBackColor = false;
            this.btnNewLine.Click += new System.EventHandler(this.btnNewLine_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.BackColor = System.Drawing.Color.ForestGreen;
            this.btnSave.Location = new System.Drawing.Point(210, 563);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(217, 49);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.BackColor = System.Drawing.Color.Red;
            this.btnDelete.Location = new System.Drawing.Point(778, 563);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(211, 48);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefresh.BackColor = System.Drawing.Color.Khaki;
            this.btnRefresh.Location = new System.Drawing.Point(500, 562);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(216, 49);
            this.btnRefresh.TabIndex = 4;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.Gainsboro;
            this.btnClose.Location = new System.Drawing.Point(513, 666);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(188, 51);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(210, 90);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(790, 406);
            this.gridControl1.TabIndex = 6;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colItemID,
            this.colCode,
            this.colDescription,
            this.colItemType,
            this.colCost,
            this.colPrice});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // colItemID
            // 
            this.colItemID.Caption = "ItemID";
            this.colItemID.FieldName = "ItemID";
            this.colItemID.MinWidth = 25;
            this.colItemID.Name = "colItemID";
            this.colItemID.OptionsColumn.AllowEdit = false;
            this.colItemID.Width = 94;
            // 
            // colCode
            // 
            this.colCode.Caption = "Code";
            this.colCode.FieldName = "Code";
            this.colCode.MinWidth = 25;
            this.colCode.Name = "colCode";
            this.colCode.Visible = true;
            this.colCode.VisibleIndex = 0;
            this.colCode.Width = 94;
            // 
            // colDescription
            // 
            this.colDescription.Caption = "Description";
            this.colDescription.FieldName = "Description";
            this.colDescription.MinWidth = 25;
            this.colDescription.Name = "colDescription";
            this.colDescription.Visible = true;
            this.colDescription.VisibleIndex = 1;
            this.colDescription.Width = 94;
            // 
            // colItemType
            // 
            this.colItemType.Caption = "Type";
            this.colItemType.FieldName = "ItemType";
            this.colItemType.MinWidth = 25;
            this.colItemType.Name = "colItemType";
            this.colItemType.Visible = true;
            this.colItemType.VisibleIndex = 2;
            this.colItemType.Width = 94;
            // 
            // colCost
            // 
            this.colCost.Caption = "Cost";
            this.colCost.FieldName = "Cost";
            this.colCost.MinWidth = 25;
            this.colCost.Name = "colCost";
            this.colCost.Visible = true;
            this.colCost.VisibleIndex = 3;
            this.colCost.Width = 94;
            // 
            // colPrice
            // 
            this.colPrice.Caption = "Price";
            this.colPrice.FieldName = "Price";
            this.colPrice.MinWidth = 25;
            this.colPrice.Name = "colPrice";
            this.colPrice.Visible = true;
            this.colPrice.VisibleIndex = 4;
            this.colPrice.Width = 94;
            // 
            // ItemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(1237, 729);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnNewLine);
            this.Name = "ItemForm";
            this.Text = "ItemForm";
            this.Load += new System.EventHandler(this.ItemForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private BindingSource bsItems;
        private Button btnNewLine;
        private Button btnSave;
        private Button btnDelete;
        private Button btnRefresh;
        private Button btnClose;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colItemID;
        private DevExpress.XtraGrid.Columns.GridColumn colCode;
        private DevExpress.XtraGrid.Columns.GridColumn colDescription;
        private DevExpress.XtraGrid.Columns.GridColumn colItemType;
        private DevExpress.XtraGrid.Columns.GridColumn colCost;
        private DevExpress.XtraGrid.Columns.GridColumn colPrice;
    }
}