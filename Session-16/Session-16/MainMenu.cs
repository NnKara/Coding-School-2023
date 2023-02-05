using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Session_16
{
    public partial class PetShop : Form
    {
        public PetShop()
        {
            InitializeComponent();
        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            PetShopForm petShopForm=new PetShopForm();
            petShopForm.ShowDialog();
        }

        private void btnEmployees_Click(object sender, EventArgs e) {
            FormEmployees employeeForm = new FormEmployees();
            employeeForm.ShowDialog();
        }

        private void btnPet_Click(object sender, EventArgs e) {
            PetForm petForm = new PetForm();
            petForm.ShowDialog();
        }

        private void btnPetFood_Click(object sender, EventArgs e) {
            PetFoodForm petFoodForm = new PetFoodForm();
            petFoodForm.ShowDialog();
        }

        private void btTransactions_Click(object sender, EventArgs e) {
            TransactionForm newTras = new TransactionForm();
            newTras.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void btnPetReport_Click(object sender, EventArgs e) {
          
            PetReportForm petReport = new PetReportForm();
            petReport.ShowDialog();

        }

        private void btnMonthlyLedger_Click(object sender, EventArgs e) {
            MonthlyLedgerForm montlyLedger = new MonthlyLedgerForm();
            montlyLedger.ShowDialog();
        }
    }
}
