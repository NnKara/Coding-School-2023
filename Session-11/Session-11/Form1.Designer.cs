namespace Session_11
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.colCustomerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSurname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPetType = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.colPetFoodQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTotalPrise = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnOrder = new System.Windows.Forms.Button();
            this.btnCancerl = new System.Windows.Forms.Button();
            this.bsPetType = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.petBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.breedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.animalTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsPetType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.petBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCustomerName,
            this.colSurname,
            this.colPetType,
            this.colPetFoodQty,
            this.colTotalPrise});
            this.dataGridView1.Location = new System.Drawing.Point(273, 104);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(1023, 296);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // colCustomerName
            // 
            this.colCustomerName.DataPropertyName = "Name";
            this.colCustomerName.HeaderText = "Customer Name";
            this.colCustomerName.MinimumWidth = 6;
            this.colCustomerName.Name = "colCustomerName";
            // 
            // colSurname
            // 
            this.colSurname.HeaderText = "Surname";
            this.colSurname.MinimumWidth = 6;
            this.colSurname.Name = "colSurname";
            // 
            // colPetType
            // 
            this.colPetType.HeaderText = "Pet Type";
            this.colPetType.MinimumWidth = 6;
            this.colPetType.Name = "colPetType";
            // 
            // colPetFoodQty
            // 
            this.colPetFoodQty.HeaderText = "Pet Food Quantity";
            this.colPetFoodQty.MinimumWidth = 6;
            this.colPetFoodQty.Name = "colPetFoodQty";
            // 
            // colTotalPrise
            // 
            this.colTotalPrise.HeaderText = "Total Price";
            this.colTotalPrise.MinimumWidth = 6;
            this.colTotalPrise.Name = "colTotalPrise";
            this.colTotalPrise.ReadOnly = true;
            // 
            // btnOrder
            // 
            this.btnOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOrder.Location = new System.Drawing.Point(978, 321);
            this.btnOrder.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(141, 44);
            this.btnOrder.TabIndex = 1;
            this.btnOrder.Text = "Order";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // btnCancerl
            // 
            this.btnCancerl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancerl.Location = new System.Drawing.Point(1128, 321);
            this.btnCancerl.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancerl.Name = "btnCancerl";
            this.btnCancerl.Size = new System.Drawing.Size(141, 44);
            this.btnCancerl.TabIndex = 2;
            this.btnCancerl.Text = "Cancel";
            this.btnCancerl.UseVisualStyleBackColor = true;
            this.btnCancerl.Click += new System.EventHandler(this.btnCancerl_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.breedDataGridViewTextBoxColumn,
            this.animalTypeDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.costDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.petBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(208, 870);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 72;
            this.dataGridView2.RowTemplate.Height = 37;
            this.dataGridView2.Size = new System.Drawing.Size(1135, 341);
            this.dataGridView2.TabIndex = 3;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // petBindingSource
            // 
            this.petBindingSource.DataSource = typeof(Session_11.Pet);
            // 
            // breedDataGridViewTextBoxColumn
            // 
            this.breedDataGridViewTextBoxColumn.DataPropertyName = "Breed";
            this.breedDataGridViewTextBoxColumn.HeaderText = "Breed";
            this.breedDataGridViewTextBoxColumn.MinimumWidth = 9;
            this.breedDataGridViewTextBoxColumn.Name = "breedDataGridViewTextBoxColumn";
            this.breedDataGridViewTextBoxColumn.Width = 175;
            // 
            // animalTypeDataGridViewTextBoxColumn
            // 
            this.animalTypeDataGridViewTextBoxColumn.DataPropertyName = "AnimalType";
            this.animalTypeDataGridViewTextBoxColumn.HeaderText = "AnimalType";
            this.animalTypeDataGridViewTextBoxColumn.MinimumWidth = 9;
            this.animalTypeDataGridViewTextBoxColumn.Name = "animalTypeDataGridViewTextBoxColumn";
            this.animalTypeDataGridViewTextBoxColumn.Width = 175;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.MinimumWidth = 9;
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.Width = 175;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.MinimumWidth = 9;
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.Width = 175;
            // 
            // costDataGridViewTextBoxColumn
            // 
            this.costDataGridViewTextBoxColumn.DataPropertyName = "Cost";
            this.costDataGridViewTextBoxColumn.HeaderText = "Cost";
            this.costDataGridViewTextBoxColumn.MinimumWidth = 9;
            this.costDataGridViewTextBoxColumn.Name = "costDataGridViewTextBoxColumn";
            this.costDataGridViewTextBoxColumn.Width = 175;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1990, 1412);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.btnCancerl);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsPetType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.petBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dataGridView1;
        private Button btnOrder;
        private Button btnCancerl;
        private BindingSource bsPetType;
        private DataGridViewTextBoxColumn colCustomerName;
        private DataGridViewTextBoxColumn colSurname;
        private DataGridViewComboBoxColumn colPetType;
        private DataGridViewTextBoxColumn colPetFoodQty;
        private DataGridViewTextBoxColumn colTotalPrise;

       
        private DataGridView dataGridView2;
        private DataGridViewTextBoxColumn breedDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn animalTypeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn costDataGridViewTextBoxColumn;
        private BindingSource petBindingSource;
    }
}