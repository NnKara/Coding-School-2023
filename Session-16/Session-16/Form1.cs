using System.Data;
using System.Data.SqlClient;

namespace Session_16
{
    public partial class Form1 : Form
    {
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
    }
}