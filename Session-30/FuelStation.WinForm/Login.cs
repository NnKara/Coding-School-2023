using FuelStation.EF.Repositorys;
using FuelStation.Model;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace FuelStation.WinForm {
    public partial class FuelStation : Form {

        private EmployeeType _role;
        
        public FuelStation() {
            InitializeComponent();
            
        }

        private void FuelStation_Load(object sender, EventArgs e) {
          
        }

        private void btnLoginManager_Click(object sender, EventArgs e) {
            _role = EmployeeType.Manager;
            MainMenu menu = new MainMenu(_role);
            menu.Show();

            //TODO
            this.Hide();
        }

        private void btnLoginCashier_Click(object sender, EventArgs e) {
            _role = EmployeeType.Cashier;
            MainMenu menu = new MainMenu(_role);
            menu.Show();
            this.Hide();
        }

        private void btnLoginStaff_Click(object sender, EventArgs e) {
            _role = EmployeeType.Staff;
            MainMenu menu = new MainMenu(_role);
            menu.Show();
            this.Hide();
        }

        private void btnLogout_Click(object sender, EventArgs e) {
            this.Close();
            Application.Exit();
        }

       
    }
}