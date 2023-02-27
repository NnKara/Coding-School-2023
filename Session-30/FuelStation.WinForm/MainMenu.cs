using DevExpress.CodeParser;
using FuelStation.EF.Repositorys;
using FuelStation.Model;
using Session_30.Server.Controllers;
using Session_30.Shared.Validator;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FuelStation.WinForm {
    public partial class MainMenu : Form {

        private EmployeeType _role;

        public MainMenu(EmployeeType role) {
            InitializeComponent();
            _role = role;
            RoleBasedView();
        }


        private void ManagerForm_Load(object sender, EventArgs e) {

        }

        private void btnCustomers_Click(object sender, EventArgs e) {
            this.Hide();
            CustomerForm custForm = new CustomerForm();
            custForm.FormClosed += (s, args) => this.Show();
            custForm.ShowDialog();
        }

        private void btnItems_Click(object sender, EventArgs e) {
            this.Hide();
            ItemForm itmForm = new ItemForm();
            itmForm.FormClosed += (s, args) => this.Show();
            itmForm.ShowDialog();
        }

        private void btnTransactions_Click(object sender, EventArgs e) {
            this.Hide();
            TransactionLogin trasLogin = new TransactionLogin();
            trasLogin.FormClosed += (s, args) => this.Show();
            trasLogin.ShowDialog();
        }

        private void btnClose_Click(object sender, EventArgs e) {
            FuelStation fuel=new FuelStation();
            fuel.Show();
            this.Hide();
        }

        private void RoleBasedView() {
            switch (_role) {
                case EmployeeType.Manager:

                    btnCustomers.Enabled = true;
                    btnTransactions.Enabled = true;
                    btnItems.Enabled = true;

                    break;
                case EmployeeType.Cashier:

                    btnCustomers.Enabled = false;
                    btnTransactions.Enabled = true;
                    btnItems.Enabled = true;

                    break;
                case EmployeeType.Staff:

                    btnCustomers.Enabled = false;
                    btnTransactions.Enabled = false;
                    btnItems.Enabled = true;

                    break;
                default:
                    break;
            }
        }
    }
}
