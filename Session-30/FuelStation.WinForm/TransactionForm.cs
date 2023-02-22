using FuelStation.Model;
using Newtonsoft.Json;
using Session_30.Shared;
using Session_30.Shared.CustomerDto;
using Session_30.Shared.EmployeeDto;
using Session_30.Shared.ItemDto;
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
    public partial class TransactionForm : Form {

      private  HttpClient _client;
      private CustomerListDto _customer;


        public TransactionForm(CustomerListDto customer) {
            InitializeComponent();
            _client = new HttpClient();
            _client.BaseAddress = new Uri("https://localhost:7183/");
            _customer= customer;
            label2.Text= $"Customer: {_customer.CustomerName} {_customer.CustomerSurname} - Card Number: {_customer.CardNumber})";


        }

        private void TransactionForm_Load(object sender, EventArgs e) {
            grdTransactions.AutoGenerateColumns = false;
            SetControlTransactionProperties();
        }


        private void grdTransLines_CellContentClick(object sender, DataGridViewCellEventArgs e) {
            grdTransLines.AutoGenerateColumns= false;
            SetControlTransactionLineProperties();
        }

        private void grdTransactions_CellContentClick(object sender, DataGridViewCellEventArgs e) {

        }

      

        private void btnSave_Click(object sender, EventArgs e) {

        }

        private void btnDelete_Click(object sender, EventArgs e) {

        }

        private void btnClose_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void btnNewLine_Click(object sender, EventArgs e) {
            bsTransactions.Add(new TransactionListDto());
        }
        private void btnRefresh_Click(object sender, EventArgs e) {
            //SetControlProperties();
        }

        private async Task<List<TransactionListDto>> GetTransactions() {
            var response = await _client.GetAsync("transaction");
            if (response.IsSuccessStatusCode) {
                var content = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<List<TransactionListDto>>(content);
            }
            return null;
        }
        
        private async Task<List<TransactionLineListDto>> GetTransactionLines() {
            var response = await _client.GetAsync("transactionLine");
            if (response.IsSuccessStatusCode) {
                var content = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<List<TransactionLineListDto>>(content);
            }
            return null;
        }

        private async Task SetControlTransactionProperties() {
            var transactions = await GetTransactions();
            var employees = await GetEmployees();
            var customers = await GetCustomers();
            var items = await GetItems();
            if (transactions != null) {
                DataGridViewComboBoxColumn colPaymentMethod = grdTransactions.Columns["colPaymentMethod"] as DataGridViewComboBoxColumn;
                colPaymentMethod.DataSource = Enum.GetValues(typeof(PaymentMethod));

                DataGridViewComboBoxColumn colEmployee = grdTransactions.Columns["colEmployee"] as DataGridViewComboBoxColumn;
                colEmployee.DataSource = employees;
                colEmployee.ValueMember = "EmployeeID";
                colEmployee.DisplayMember = "EmployeeSurname";


                bsTransactions.DataSource = transactions;
                grdTransactions.DataSource = bsTransactions;
               
            }
        }

        private async Task SetControlTransactionLineProperties() {
            var transactions = await GetTransactions();
            var items = await GetItems();
            if (transactions != null) {
                DataGridViewComboBoxColumn colItem = grdTransLines.Columns["colItem"] as DataGridViewComboBoxColumn;
                colItem.DataSource = items;
                colItem.ValueMember = "ItemID";
                colItem.DisplayMember = "Code";
                grdTransLines.DataSource = bsTransactions;
                grdTransLines.DataMember = "TransactionLines";
            }
        }


       
        private async Task<List<CustomerListDto>> GetCustomers() {
            var response = await _client.GetAsync("customer");
            if (response.IsSuccessStatusCode) {
                var content = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<List<CustomerListDto>>(content);
            }
            return null;
        }

        private async Task<List<ItemListDto>> GetItems() {
            var response = await _client.GetAsync("item");
            if (response.IsSuccessStatusCode) {
                var content = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<List<ItemListDto>>(content);
            }
            return null;
        }

        private async Task<List<EmployeeListDto>> GetEmployees() {
            var response = await _client.GetAsync("employee");
            if (response.IsSuccessStatusCode) {
                var content = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<List<EmployeeListDto>>(content);
            }
            return null;
        }

        private async void grdTransLines_CellEndEdit(object sender, DataGridViewCellEventArgs e) {
            var items=await GetItems();
            if (e.ColumnIndex == grdTransLines.Columns["colItem"].Index) {
                var selectedItemId = (int)grdTransLines.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
                var selectedItem = items.FirstOrDefault(item => item.ItemID == selectedItemId);
                if (selectedItem != null) {
                    grdTransLines.Rows[e.RowIndex].Cells["colPrice"].Value = selectedItem.Price;
                }
            }
        }

        private void txtLoggedInCustomer_TextChanged(object sender, EventArgs e) {

        }

        private void label2_Click(object sender, EventArgs e) {

        }
    }
 }

