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
            this.grdViewStudents = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.grdViewStudents)).BeginInit();
            this.SuspendLayout();
            // 
            // grdViewStudents
            // 
            this.grdViewStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdViewStudents.Location = new System.Drawing.Point(40, 34);
            this.grdViewStudents.Name = "grdViewStudents";
            this.grdViewStudents.RowHeadersWidth = 51;
            this.grdViewStudents.RowTemplate.Height = 29;
            this.grdViewStudents.Size = new System.Drawing.Size(671, 188);
            this.grdViewStudents.TabIndex = 0;
            this.grdViewStudents.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdViewStudents_CellContentClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grdViewStudents);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdViewStudents)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView grdViewStudents;
    }
}