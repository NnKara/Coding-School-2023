using System.Formats.Asn1;

namespace Session_11
{
    public partial class Form1 : Form
    {
        List<Transaction> lstTranscaction;
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


            Customer newCustm = new Customer()
            {
                
                Name = "Nikos",
                Surname = "Karamitos",
                Phone = "6978319622",
                TIN = "12390812903"
            };
            dataGridView1.AutoGenerateColumns = false;
            //Transaction
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {

        }

        private void btnCancerl_Click(object sender, EventArgs e)
        {

        }

        public void Buy()
        {
            Customer newCustm = new Customer()
            {
                Name = "Nikos",
                Surname = "Karamitos",
                Phone = "6978319622",
                TIN = "12390812903"
            };
        }
    }
}