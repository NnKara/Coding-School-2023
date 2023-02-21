namespace FuelStation.WinForm {
    partial class FuelStation {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.btnLoginManager = new System.Windows.Forms.Button();
            this.btnLoginCashier = new System.Windows.Forms.Button();
            this.btnLoginStaff = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLoginManager
            // 
            this.btnLoginManager.Location = new System.Drawing.Point(80, 230);
            this.btnLoginManager.Name = "btnLoginManager";
            this.btnLoginManager.Size = new System.Drawing.Size(193, 92);
            this.btnLoginManager.TabIndex = 0;
            this.btnLoginManager.Text = "Manager";
            this.btnLoginManager.UseVisualStyleBackColor = true;
            this.btnLoginManager.Click += new System.EventHandler(this.btnLoginManager_Click);
            // 
            // btnLoginCashier
            // 
            this.btnLoginCashier.Location = new System.Drawing.Point(360, 230);
            this.btnLoginCashier.Name = "btnLoginCashier";
            this.btnLoginCashier.Size = new System.Drawing.Size(193, 92);
            this.btnLoginCashier.TabIndex = 1;
            this.btnLoginCashier.Text = "Cashier";
            this.btnLoginCashier.UseVisualStyleBackColor = true;
            this.btnLoginCashier.Click += new System.EventHandler(this.btnLoginCashier_Click);
            // 
            // btnLoginStaff
            // 
            this.btnLoginStaff.Location = new System.Drawing.Point(649, 230);
            this.btnLoginStaff.Name = "btnLoginStaff";
            this.btnLoginStaff.Size = new System.Drawing.Size(193, 92);
            this.btnLoginStaff.TabIndex = 2;
            this.btnLoginStaff.Text = "Staff";
            this.btnLoginStaff.UseVisualStyleBackColor = true;
            this.btnLoginStaff.Click += new System.EventHandler(this.btnLoginStaff_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(838, 512);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(94, 29);
            this.btnLogout.TabIndex = 3;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // FuelStation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(976, 553);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnLoginStaff);
            this.Controls.Add(this.btnLoginCashier);
            this.Controls.Add(this.btnLoginManager);
            this.Name = "FuelStation";
            this.Text = "FuelStation";
            this.Load += new System.EventHandler(this.FuelStation_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnLoginManager;
        private Button btnLoginCashier;
        private Button btnLoginStaff;
        private Button btnLogout;
    }
}