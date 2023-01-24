using System.Formats.Asn1;
using System.Security.Cryptography.X509Certificates;

namespace Session_11 {
    public partial class Form1 : Form {
        public Transaction transaction;
        public Form1() {
            InitializeComponent();
        }


        // private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) {

        //    Buy();


        //Customer newCustm = new Customer() {

        //    Name = "Nikos",
        //    Surname = "Karamitos",
        //    Phone = "6978319622",
        //    TIN = "12390812903"
        //};
        //dataGridView1.AutoGenerateColumns = false;
        ////Transaction
        // }

        private void btnOrder_Click(object sender, EventArgs e) {

        }

        private void btnCancerl_Click(object sender, EventArgs e) {

        }
        // public void Buy() {

        //transaction = GetTransaction();

        //Student student1 = new Student() {
        //    Name = "Dimitris",
        //    Age = 40,
        //    RegistrationNumber = 1
        //};
        //university.Students.Add(student1);
        //bsStudents.DataSource = university.Students;
        // }



        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) {
            Pet pet = new Pet();
            Transaction newTras = new Transaction();
            Customer newCustomer = new Customer() {

                Name = "Nikos",
                Surname = "Karamitos",
                Phone = "6978319622",
                TIN = "12390812903"
            };

            Buy(newCustomer, pet);


        }



        public Transaction Buy(Customer custmer, Pet pet) {

            Transaction newTras = new Transaction();

            switch (pet.AnimalType) {
                case Pet.AnimalTypeEnum.Bird:
                    newTras = SelectBird(pet);
                    break;

                case Pet.AnimalTypeEnum.Cat:
                    break;

                case Pet.AnimalTypeEnum.Dog:
                    break;


                default:

                    break;

            }


            // return tras;

            return newTras;



        }

        public Transaction SelectBird(Pet pet) {
            Transaction tras = new Transaction();
            if (pet.Status.ToString() == "Unhealthy") {
                return null;
            }
            else {
                tras.PetFoodPrice = 5;
                tras.PetFoodQty = 3;
                tras.PetPrice = pet.Price;
                tras.PetID = pet.PetID;
                tras.TransactionDate = DateTime.Now;

            }
            return tras;
        }



    }
}



