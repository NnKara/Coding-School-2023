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
            this.colRegistartioNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUniversity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Age = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grdViewGrades = new System.Windows.Forms.DataGridView();
            this.colGrade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grdViewSchedules = new System.Windows.Forms.DataGridView();
            this.colDateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grdVCourses = new System.Windows.Forms.DataGridView();
            this.colSubject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdViewStudents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdViewGrades)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdViewSchedules)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdVCourses)).BeginInit();
            this.SuspendLayout();
            // 
            // grdViewStudents
            // 
            this.grdViewStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdViewStudents.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colRegistartioNumber,
            this.colUniversity,
            this.Age,
            this.colName});
            this.grdViewStudents.Location = new System.Drawing.Point(40, 25);
            this.grdViewStudents.Name = "grdViewStudents";
            this.grdViewStudents.RowHeadersWidth = 51;
            this.grdViewStudents.RowTemplate.Height = 29;
            this.grdViewStudents.Size = new System.Drawing.Size(669, 85);
            this.grdViewStudents.TabIndex = 0;
            this.grdViewStudents.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdViewStudents_CellContentClick);
            // 
            // colRegistartioNumber
            // 
            this.colRegistartioNumber.DataPropertyName = "RegistrationNumber";
            this.colRegistartioNumber.HeaderText = "RegistrationNumber";
            this.colRegistartioNumber.MinimumWidth = 6;
            this.colRegistartioNumber.Name = "colRegistartioNumber";
            this.colRegistartioNumber.Width = 125;
            // 
            // colUniversity
            // 
            this.colUniversity.DataPropertyName = "University";
            this.colUniversity.HeaderText = "University";
            this.colUniversity.MinimumWidth = 6;
            this.colUniversity.Name = "colUniversity";
            this.colUniversity.Width = 125;
            // 
            // Age
            // 
            this.Age.DataPropertyName = "Age";
            this.Age.HeaderText = "Age";
            this.Age.MinimumWidth = 6;
            this.Age.Name = "Age";
            this.Age.Width = 125;
            // 
            // colName
            // 
            this.colName.DataPropertyName = "Name";
            this.colName.HeaderText = "Name";
            this.colName.MinimumWidth = 6;
            this.colName.Name = "colName";
            this.colName.Width = 125;
            // 
            // grdViewGrades
            // 
            this.grdViewGrades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdViewGrades.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colGrade,
            this.dataGridViewTextBoxColumn2});
            this.grdViewGrades.Location = new System.Drawing.Point(40, 216);
            this.grdViewGrades.Name = "grdViewGrades";
            this.grdViewGrades.RowHeadersWidth = 51;
            this.grdViewGrades.RowTemplate.Height = 29;
            this.grdViewGrades.Size = new System.Drawing.Size(669, 95);
            this.grdViewGrades.TabIndex = 2;
            this.grdViewGrades.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdViewGrades_CellContentClick);
            // 
            // colGrade
            // 
            this.colGrade.DataPropertyName = "GradeValue";
            this.colGrade.HeaderText = "Grade";
            this.colGrade.MinimumWidth = 6;
            this.colGrade.Name = "colGrade";
            this.colGrade.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "University";
            this.dataGridViewTextBoxColumn2.HeaderText = "University";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // grdViewSchedules
            // 
            this.grdViewSchedules.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdViewSchedules.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colDateTime,
            this.dataGridViewTextBoxColumn3});
            this.grdViewSchedules.Location = new System.Drawing.Point(40, 317);
            this.grdViewSchedules.Name = "grdViewSchedules";
            this.grdViewSchedules.RowHeadersWidth = 51;
            this.grdViewSchedules.RowTemplate.Height = 29;
            this.grdViewSchedules.Size = new System.Drawing.Size(669, 89);
            this.grdViewSchedules.TabIndex = 3;
            this.grdViewSchedules.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdViewSchedules_CellContentClick);
            // 
            // colDateTime
            // 
            this.colDateTime.DataPropertyName = "Callendar";
            this.colDateTime.HeaderText = "DateTime";
            this.colDateTime.MinimumWidth = 6;
            this.colDateTime.Name = "colDateTime";
            this.colDateTime.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "University";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // grdVCourses
            // 
            this.grdVCourses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdVCourses.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSubject,
            this.dataGridViewTextBoxColumn1,
            this.colCode});
            this.grdVCourses.Location = new System.Drawing.Point(40, 125);
            this.grdVCourses.Name = "grdVCourses";
            this.grdVCourses.RowHeadersWidth = 51;
            this.grdVCourses.RowTemplate.Height = 29;
            this.grdVCourses.Size = new System.Drawing.Size(669, 85);
            this.grdVCourses.TabIndex = 4;
            this.grdVCourses.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdVCourses_CellContentClick);
            // 
            // colSubject
            // 
            this.colSubject.DataPropertyName = "Subject";
            this.colSubject.HeaderText = "Subject";
            this.colSubject.MinimumWidth = 6;
            this.colSubject.Name = "colSubject";
            this.colSubject.Width = 125;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "University";
            this.dataGridViewTextBoxColumn1.HeaderText = "University";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // colCode
            // 
            this.colCode.DataPropertyName = "Code";
            this.colCode.HeaderText = "Code";
            this.colCode.MinimumWidth = 6;
            this.colCode.Name = "colCode";
            this.colCode.Width = 125;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(626, 412);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 5;
            this.button1.Text = "Load";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(509, 412);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 29);
            this.button2.TabIndex = 6;
            this.button2.Text = "Save";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.grdVCourses);
            this.Controls.Add(this.grdViewSchedules);
            this.Controls.Add(this.grdViewGrades);
            this.Controls.Add(this.grdViewStudents);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdViewStudents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdViewGrades)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdViewSchedules)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdVCourses)).EndInit();
            this.ResumeLayout(false);

        }

        private void grdViewCourses_CellContentClick(object sender, DataGridViewCellEventArgs e) => throw new NotImplementedException();


        #endregion

        private DataGridView grdViewStudents;
        private DataGridView grdViewGrades;
        private DataGridView grdViewSchedules;
        private DataGridView grdVCourses;
        private DataGridViewTextBoxColumn colRegistartioNumber;
        private DataGridViewTextBoxColumn colUniversity;
        private DataGridViewTextBoxColumn Age;
        private DataGridViewTextBoxColumn colName;
        private DataGridViewTextBoxColumn colSubject;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn colCode;
        private DataGridViewTextBoxColumn colGrade;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn colDateTime;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private Button button1;
        private Button button2;
    }
}