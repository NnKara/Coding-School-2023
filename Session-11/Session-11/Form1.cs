using System.Formats.Asn1;

namespace Session_11 {
    public partial class Form1 : Form {
        public Transaction transaction;
        public Form1() {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) {

            Buy();


            //Customer newCustm = new Customer() {

            //    Name = "Nikos",
            //    Surname = "Karamitos",
            //    Phone = "6978319622",
            //    TIN = "12390812903"
            //};
            //dataGridView1.AutoGenerateColumns = false;
            ////Transaction
        }

        private void btnOrder_Click(object sender, EventArgs e) {

        }

        private void btnCancerl_Click(object sender, EventArgs e) {

        }
        public void Buy() {

            transaction = GetTransaction();

            //Student student1 = new Student() {
            //    Name = "Dimitris",
            //    Age = 40,
            //    RegistrationNumber = 1
            //};
            //university.Students.Add(student1);
            //bsStudents.DataSource = university.Students;
        }


        public Transaction GetTransaction() {
            Transaction tran = new Transaction {
                TransactionID = new Guid(),
                TransactionDate = DateTime.Now,
                CustomerID = new Guid(),
                EmployeeID = new Guid(),
                PetID = new Guid()

            };


        }


    }
}