using DevExpress.XtraEditors;
using FuelStation.EF.Repositorys;
using FuelStation.Model;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace FuelStation.WinForm {
    public partial class FuelStation : Form {

        private EmployeeType _role;
        
        public FuelStation() {
            InitializeComponent();
            txtPassword.PasswordChar = '*';
        }


        private void btnLogout_Click(object sender, EventArgs e) {
            this.Close();
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Hide();
            if (txtUsername.Text == "manager" && txtPassword.Text == "manager")
            {
                _role = EmployeeType.Manager;
                MainMenu mainMenu = new (_role);
                mainMenu.ShowDialog();
                this.Hide();
            }
            else if (txtUsername.Text == "cashier" && txtPassword.Text == "cashier")
            {
                _role = EmployeeType.Cashier;
                MainMenu mainMenu = new MainMenu(_role);
                mainMenu.ShowDialog();
                this.Hide();
            }
            else if (txtUsername.Text == "staff" && txtPassword.Text == "staff")
            {
                _role = EmployeeType.Staff;
                MainMenu mainMenu = new MainMenu(_role);
                mainMenu.ShowDialog();
            }
            else
            {
                XtraMessageBox.Show("Invalid Username or Password!");
                txtUsername.Clear();
                txtPassword.Clear();
            }
            Show();
            
        }
    }
}