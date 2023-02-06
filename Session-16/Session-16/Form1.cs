using Model;
using Orm.Repository;
using System.Data;
using System.Data.SqlClient;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;

namespace Session_16 {
    public partial class PetShopForm : Form {

        private CustomerRepo _customerRepo;
        private EmployeeRepo _employeeRepo;
        private PetRepo _petRepo;
        private PetFoodRepo _petFoodRepo;
        private MonthlyLedger _monthlyLedger;
        private PetReport _petReport;
        private TransactionRepo _transactionRepo;

        public PetShopForm() {
            InitializeComponent();
        }

        private void btnTestData_Click(object sender, EventArgs e) {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "data source=localhost; initial catalog=AdventureWorks2019; integrated security=SSPI;";
            conn.Open();

            DataSet ds = new DataSet();
            string selectQuery = Resource1.CustomerQuery;
            SqlDataAdapter adapter = new SqlDataAdapter(selectQuery, conn);
            adapter.Fill(ds);
            ds.WriteXml("nikos.xml");
        }

        private void Form1_Load(object sender, EventArgs e) {
            SetControllers();
        }

        private void SetControllers() {

            CustomerRepo customerRepo = new CustomerRepo();
            bsCustomer.DataSource = customerRepo.GetAll();
            grdCustomers.DataSource = bsCustomer;

        }

        private void gridControl1_Click(object sender, EventArgs e) {

        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e) {

        }

        private void btnPopulate_Click(object sender, EventArgs e) {
            CustomerRepo customerRepo = new CustomerRepo();
            Populate populateEntitys = new Populate();
            List<Customer> customers = populateEntitys.PopulateCustomers();
            foreach (Customer customer in customers) {
                customerRepo.Add(customer);
            }
        }

        private void gridView1_ValidateRow(object sender, ValidateRowEventArgs e) {

            GridView view = sender as GridView;
            CustomerRepo customerRepo = new CustomerRepo();
            Guid id = Guid.Parse(view.GetRowCellValue(view.FocusedRowHandle, colCustomerID).ToString());
            try {
                if (e.Valid) {
                    if (customerRepo.GetById(id) == null) {
                        customerRepo.Add((Customer)bsCustomer.Current);
                    } else {
                        customerRepo.Update(id, (Customer)bsCustomer.Current);
                    }
                }
            }catch(Exception ex) {
                MessageBox.Show("Fill every Cell!");
            }
        }

        private void gridView1_RowDeleting(object sender, DevExpress.Data.RowDeletingEventArgs e) {

            GridView view = sender as GridView;
            CustomerRepo customerRepo = new CustomerRepo();
            Guid id = Guid.Parse(view.GetRowCellValue(view.FocusedRowHandle, colCustomerID).ToString());
            customerRepo.Delete(id);
        }

        private void btnClose_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}