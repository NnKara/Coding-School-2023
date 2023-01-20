namespace Session_10
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
            this.grdViewUniversity = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.grdViewUniversity)).BeginInit();
            this.SuspendLayout();
            // 
            // grdViewUniversity
            // 
            this.grdViewUniversity.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdViewUniversity.Location = new System.Drawing.Point(53, 48);
            this.grdViewUniversity.Name = "grdViewUniversity";
            this.grdViewUniversity.RowHeadersWidth = 51;
            this.grdViewUniversity.RowTemplate.Height = 29;
            this.grdViewUniversity.Size = new System.Drawing.Size(300, 188);
            this.grdViewUniversity.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grdViewUniversity);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdViewUniversity)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView grdViewUniversity;
    }
}