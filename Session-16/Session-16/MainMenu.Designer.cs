namespace Session_16
{
    partial class MainMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCustomers = new System.Windows.Forms.Button();
            this.btnEmployees = new System.Windows.Forms.Button();
            this.btnPet = new System.Windows.Forms.Button();
            this.btnPetFood = new System.Windows.Forms.Button();
            this.btTransactions = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCustomers
            // 
            this.btnCustomers.Location = new System.Drawing.Point(12, 76);
            this.btnCustomers.Name = "btnCustomers";
            this.btnCustomers.Size = new System.Drawing.Size(94, 29);
            this.btnCustomers.TabIndex = 0;
            this.btnCustomers.Text = "Customers";
            this.btnCustomers.UseVisualStyleBackColor = true;
            this.btnCustomers.Click += new System.EventHandler(this.btnCustomers_Click);
            // 
            // btnEmployees
            // 
            this.btnEmployees.Location = new System.Drawing.Point(12, 145);
            this.btnEmployees.Name = "btnEmployees";
            this.btnEmployees.Size = new System.Drawing.Size(94, 29);
            this.btnEmployees.TabIndex = 1;
            this.btnEmployees.Text = "Employees";
            this.btnEmployees.UseVisualStyleBackColor = true;
            this.btnEmployees.Click += new System.EventHandler(this.btnEmployees_Click);
            // 
            // btnPet
            // 
            this.btnPet.Location = new System.Drawing.Point(12, 219);
            this.btnPet.Name = "btnPet";
            this.btnPet.Size = new System.Drawing.Size(94, 29);
            this.btnPet.TabIndex = 2;
            this.btnPet.Text = "Pets";
            this.btnPet.UseVisualStyleBackColor = true;
            this.btnPet.Click += new System.EventHandler(this.btnPet_Click);
            // 
            // btnPetFood
            // 
            this.btnPetFood.Location = new System.Drawing.Point(12, 301);
            this.btnPetFood.Name = "btnPetFood";
            this.btnPetFood.Size = new System.Drawing.Size(94, 29);
            this.btnPetFood.TabIndex = 3;
            this.btnPetFood.Text = "PetFoods";
            this.btnPetFood.UseVisualStyleBackColor = true;
            this.btnPetFood.Click += new System.EventHandler(this.btnPetFood_Click);
            // 
            // btTransactions
            // 
            this.btTransactions.Location = new System.Drawing.Point(276, 176);
            this.btTransactions.Name = "btTransactions";
            this.btTransactions.Size = new System.Drawing.Size(94, 29);
            this.btTransactions.TabIndex = 4;
            this.btTransactions.Text = "Transactions";
            this.btTransactions.UseVisualStyleBackColor = true;
            this.btTransactions.Click += new System.EventHandler(this.btTransactions_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btTransactions);
            this.Controls.Add(this.btnPetFood);
            this.Controls.Add(this.btnPet);
            this.Controls.Add(this.btnEmployees);
            this.Controls.Add(this.btnCustomers);
            this.Name = "MainMenu";
            this.Text = "MainMenu";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnCustomers;
        private Button btnEmployees;
        private Button btnPet;
        private Button btnPetFood;
        private Button btTransactions;
    }
}