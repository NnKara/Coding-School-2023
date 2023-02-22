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
            var customersForm = new CustomerForm();
            customersForm.ShowDialog();
        }

        private void btnItems_Click(object sender, EventArgs e) {
            var itemFrom = new ItemForm();
            itemFrom.ShowDialog();
        }

        private void btnTransactions_Click(object sender, EventArgs e) {
            var trasForm = new TransactionLogin();
            trasForm.ShowDialog();
        }

        private void btnClose_Click(object sender, EventArgs e) {
            FuelStation fuel=new FuelStation();
            fuel.Show();
            this.Close();
        }

        private void RoleBasedView() {
            switch (_role) {
                case EmployeeType.Manager:

                    btnCustomers.Visible = true;
                    btnTransactions.Visible = true;
                    btnItems.Visible = true;

                    break;
                case EmployeeType.Cashier:

                    btnCustomers.Visible = false;
                    btnTransactions.Visible = true;
                    btnItems.Visible = true;

                    break;
                case EmployeeType.Staff:

                    btnCustomers.Visible = false;
                    btnTransactions.Visible = false;
                    btnItems.Visible = true;

                    break;
                default:
                    break;
            }
        }
    }
}
