namespace Session_16
{
    partial class PetShop
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
            this.btnExit = new System.Windows.Forms.Button();
            this.btnMonthlyLedger = new System.Windows.Forms.Button();
            this.btnPetReport = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCustomers
            // 
            this.btnCustomers.BackColor = System.Drawing.Color.Lime;
            this.btnCustomers.Location = new System.Drawing.Point(615, 224);
            this.btnCustomers.Name = "btnCustomers";
            this.btnCustomers.Size = new System.Drawing.Size(173, 71);
            this.btnCustomers.TabIndex = 0;
            this.btnCustomers.Text = "Customers";
            this.btnCustomers.UseVisualStyleBackColor = false;
            this.btnCustomers.Click += new System.EventHandler(this.btnCustomers_Click);
            // 
            // btnEmployees
            // 
            this.btnEmployees.BackColor = System.Drawing.Color.Lime;
            this.btnEmployees.Location = new System.Drawing.Point(416, 221);
            this.btnEmployees.Name = "btnEmployees";
            this.btnEmployees.Size = new System.Drawing.Size(177, 71);
            this.btnEmployees.TabIndex = 1;
            this.btnEmployees.Text = "Employees";
            this.btnEmployees.UseVisualStyleBackColor = false;
            this.btnEmployees.Click += new System.EventHandler(this.btnEmployees_Click);
            // 
            // btnPet
            // 
            this.btnPet.BackColor = System.Drawing.Color.Lime;
            this.btnPet.Location = new System.Drawing.Point(210, 221);
            this.btnPet.Name = "btnPet";
            this.btnPet.Size = new System.Drawing.Size(177, 71);
            this.btnPet.TabIndex = 2;
            this.btnPet.Text = "Pets";
            this.btnPet.UseVisualStyleBackColor = false;
            this.btnPet.Click += new System.EventHandler(this.btnPet_Click);
            // 
            // btnPetFood
            // 
            this.btnPetFood.BackColor = System.Drawing.Color.Lime;
            this.btnPetFood.Location = new System.Drawing.Point(12, 221);
            this.btnPetFood.Name = "btnPetFood";
            this.btnPetFood.Size = new System.Drawing.Size(166, 71);
            this.btnPetFood.TabIndex = 3;
            this.btnPetFood.Text = "PetFoods";
            this.btnPetFood.UseVisualStyleBackColor = false;
            this.btnPetFood.Click += new System.EventHandler(this.btnPetFood_Click);
            // 
            // btTransactions
            // 
            this.btTransactions.BackColor = System.Drawing.Color.Lime;
            this.btTransactions.Location = new System.Drawing.Point(210, 32);
            this.btTransactions.Name = "btTransactions";
            this.btTransactions.Size = new System.Drawing.Size(383, 65);
            this.btTransactions.TabIndex = 4;
            this.btTransactions.Text = "Transactions";
            this.btTransactions.UseVisualStyleBackColor = false;
            this.btTransactions.Click += new System.EventHandler(this.btTransactions_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Red;
            this.btnExit.Location = new System.Drawing.Point(680, 397);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(108, 41);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnMonthlyLedger
            // 
            this.btnMonthlyLedger.BackColor = System.Drawing.Color.Lime;
            this.btnMonthlyLedger.Location = new System.Drawing.Point(12, 345);
            this.btnMonthlyLedger.Name = "btnMonthlyLedger";
            this.btnMonthlyLedger.Size = new System.Drawing.Size(166, 40);
            this.btnMonthlyLedger.TabIndex = 6;
            this.btnMonthlyLedger.Text = "Monthly Ledger";
            this.btnMonthlyLedger.UseVisualStyleBackColor = false;
            this.btnMonthlyLedger.Click += new System.EventHandler(this.btnMonthlyLedger_Click);
            // 
            // btnPetReport
            // 
            this.btnPetReport.BackColor = System.Drawing.Color.Lime;
            this.btnPetReport.Location = new System.Drawing.Point(12, 398);
            this.btnPetReport.Name = "btnPetReport";
            this.btnPetReport.Size = new System.Drawing.Size(166, 40);
            this.btnPetReport.TabIndex = 7;
            this.btnPetReport.Text = "Pet Report";
            this.btnPetReport.UseVisualStyleBackColor = false;
            this.btnPetReport.Click += new System.EventHandler(this.btnPetReport_Click);
            // 
            // PetShop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnPetReport);
            this.Controls.Add(this.btnMonthlyLedger);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btTransactions);
            this.Controls.Add(this.btnPetFood);
            this.Controls.Add(this.btnPet);
            this.Controls.Add(this.btnEmployees);
            this.Controls.Add(this.btnCustomers);
            this.Name = "PetShop";
            this.Text = "West Side Pet-Shop";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnCustomers;
        private Button btnEmployees;
        private Button btnPet;
        private Button btnPetFood;
        private Button btTransactions;
        private Button btnExit;
        private Button btnMonthlyLedger;
        private Button btnPetReport;
    }
}