using Model;
using Orm.Repository;
using System.Data;
using System.Data.SqlClient;

namespace Session_16
{
    public partial class Form1 : Form
    {

        private CustomerRepo _customerRepo;
        private EmployeeRepo _employeeRepo;
        private PetRepo _petRepo;
        private PetFoodRepo _petFoodRepo;
        private MonthlyLedger _monthlyLedger;
        private PetReport _petReport;
        private TransactionRepo _transactionRepo;
        public List<Customer> customers=new List<Customer>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTestData_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "data source=localhost; initial catalog=AdventureWorks2019; integrated security=SSPI;";
            conn.Open();

            DataSet ds = new DataSet();
            string selectQuery = Resource1.CustomerQuery;
            SqlDataAdapter adapter = new SqlDataAdapter(selectQuery, conn);
            adapter.Fill(ds);
            ds.WriteXml("nikos.xml");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var customerList=new List<Customer>();
            PopulateCustomers();
        }



        public List<Customer> PopulateCustomers()
        {
            
            Customer Cust1 = new Customer()
            {

                CustomerName = "Nikos",
                CustomerSurname = "Karamitos",
                Phone = "6978319532",
                TIN = "37482910",

            };
            Customer cust2 = new Customer()
            {

                CustomerName = "Alex",
                CustomerSurname = "Gad",
                Phone = "6973132822",
                TIN = "38239102"
            };

            customers.Add(Cust1);
            customers.Add(cust2);
            return customers;
            
        }


        private void PopulateEmployee()
        {

            Employee employee1 = new Employee()
            {
                EmployeeID = Guid.NewGuid(),
                EmployeeName = "Nikos",
                EmployeeSurname = "Karamitos",
                EmployeeType = Employee.EmployeeWorkType.MANAGER,
                SallaryPerMonth = 1000

            };

            Employee employee2 = new Employee()
            {
                EmployeeID = Guid.NewGuid(),
                EmployeeName = "Alex",
                EmployeeSurname = "Gad",
                EmployeeType = Employee.EmployeeWorkType.STAFF,
                SallaryPerMonth = 1000

            };
        }
        private void SetControllers()
        {
            bindingSource1.DataSource = PopulateCustomers();
            
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {
            
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {
            
        }
    }
}