namespace FuelStation.WinForm {
    partial class TransactionLogin {
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
            this.btnOpenOrder = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOpenOrder
            // 
            this.btnOpenOrder.Location = new System.Drawing.Point(302, 168);
            this.btnOpenOrder.Name = "btnOpenOrder";
            this.btnOpenOrder.Size = new System.Drawing.Size(109, 37);
            this.btnOpenOrder.TabIndex = 0;
            this.btnOpenOrder.Text = "Open Order";
            this.btnOpenOrder.UseVisualStyleBackColor = true;
            this.btnOpenOrder.Click += new System.EventHandler(this.btnOpenOrder_ClickAsync);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(282, 100);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(156, 34);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(677, 392);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(94, 29);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // TransactionLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnOpenOrder);
            this.Name = "TransactionLogin";
            this.Text = "TransactionLogin";
            this.Load += new System.EventHandler(this.TransactionLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnOpenOrder;
        private TextBox textBox1;
        private Button btnClose;
    }
}