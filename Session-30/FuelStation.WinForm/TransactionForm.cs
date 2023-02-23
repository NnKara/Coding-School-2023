using FuelStation.EF.Repositorys;
using FuelStation.Model;
using Newtonsoft.Json;
using Session_30.Shared;
using Session_30.Shared.CustomerDto;
using Session_30.Shared.EmployeeDto;
using Session_30.Shared.ItemDto;
using Session_30.Shared.TransactionDto;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FuelStation.WinForm {
    public partial class TransactionForm : Form {

        private HttpClient _client;
        private CustomerListDto _customer;
        private List<TransactionListDto> _transactions;
        private List<TransactionLineListDto> _transactionLines;
        private List<ItemListDto> _itemList;


        public TransactionForm(CustomerListDto customer) {
            InitializeComponent();
            _client = new HttpClient();
            _client.BaseAddress = new Uri("https://localhost:7183/");
            _customer = customer;
            label2.Text = $"Customer: {_customer.CustomerName} {_customer.CustomerSurname} - Card Number: {_customer.CardNumber})";


        }

        private void TransactionForm_Load(object sender, EventArgs e) {
            grdTransactions.AutoGenerateColumns = false;
            grdTransLines.AutoGenerateColumns = false;
            SetControlTransactionProperties();
        }


        private void grdTransLines_CellContentClick(object sender, DataGridViewCellEventArgs e) {
            SetControlTransactionProperties();
        }

        private void grdTransactions_CellContentClick(object sender, DataGridViewCellEventArgs e) {

        }



        private async void btnSave_Click(object sender, EventArgs e) {
            await OnSaveTransLine();

        }

        private async void btnNewLine_Click(object sender, EventArgs e) {
            TransactionLineListDto trasEdit = new TransactionLineListDto();
            bsTransLines.Add(trasEdit);

        }

        private void btnNewTrans_Click(object sender, EventArgs e) {
            TransactionListDto transEdit = new TransactionListDto();
            //colCustomerID = _customer.CustomerID;
            bsTransactions.Add(transEdit);

        }

        private void btnRefresh_Click(object sender, EventArgs e) {
            SetControlTransactionProperties();
        }

        private async Task<List<TransactionListDto>?> GetTransactions() {
            var response = await _client.GetAsync("transaction");
            if (response.IsSuccessStatusCode) {
                var content = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<List<TransactionListDto>>(content);
            }
            return null;
        }

        private async Task<List<TransactionListDto>> GetTransactions(int id) {
            var response = await _client.GetAsync($"transaction/customer/{id}");
            if (response.IsSuccessStatusCode) {
                var content = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<List<TransactionListDto>>(content);
            }
            return null;
        }

        private async void SetControlTransactionProperties() {
            _transactions = await GetTransactions(_customer.CustomerID);
            //_transactionLines = await _client.GetFromJsonAsync<List<TransactionLineListDto>>("transactionLine");
            var employees = await GetEmployees();
            _itemList = await GetItems();


            if (_transactions != null) {

                bsTransactions.DataSource = _transactions;
                grdTransactions.DataSource = bsTransactions;
                bsTransLines.DataSource = bsTransactions;
                bsTransLines.DataMember = "TransactionLines";
                grdTransLines.DataSource = bsTransLines;




                DataGridViewComboBoxColumn colPayment = grdTransactions.Columns["colPaymentMethod"] as DataGridViewComboBoxColumn;
                if (colPayment != null) {
                    colPayment.DataSource = Enum.GetValues(typeof(PaymentMethod))
                                                 .Cast<PaymentMethod>()
                                                 .Select(e => e.ToString())
                                                 .ToList();
                    grdTransactions.Refresh();
                }


                bsEmployees.DataSource = employees;
                colEmployee.DataSource = bsEmployees;
                colEmployee.ValueMember = "EmployeeID";
                colEmployee.DisplayMember = "EmployeeSurname";

                bsItems.DataSource = _itemList;
                colItem.DataSource = bsItems;
                colItem.ValueMember = "ItemID";
                colItem.DisplayMember = "Code";

                //bsTransactions.DataSource = _transactions;
                //grdTransactions.DataSource = bsTransactions;

                //bsTransLines.DataSource = _transactionLines;
                //grdTransLines.DataSource = bsTransLines;



            }
        }


        private async Task<List<CustomerListDto>?> GetCustomers() {
            var response = await _client.GetAsync("customer");
            if (response.IsSuccessStatusCode) {
                var content = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<List<CustomerListDto>>(content);
            }
            return null;
        }

        //private async Task<List<TransactionLineListDto>?> GetTransLines() {
        //    var response = await _client.GetAsync("transactionLine");
        //    if (response.IsSuccessStatusCode) {
        //        var content = await response.Content.ReadAsStringAsync();
        //        return JsonConvert.DeserializeObject<List<TransactionLineListDto>>(content);
        //    }
        //    return null;
        //}

        private async Task<List<ItemListDto>?> GetItems() {
            var response = await _client.GetAsync("item");
            if (response.IsSuccessStatusCode) {
                var content = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<List<ItemListDto>>(content);
            }
            return null;
        }

        private async Task<List<EmployeeListDto>?> GetEmployees() {
            var response = await _client.GetAsync("employee");
            if (response.IsSuccessStatusCode) {
                var content = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<List<EmployeeListDto>>(content);
            }
            return null;
        }

        private async Task OnSave() {
            HttpResponseMessage response = null;
            TransactionListDto tras = (TransactionListDto)bsTransactions.Current;
            //tras.CustomerID = _customer.CustomerID;

            if (tras.TransactionID == 0) {
                response = await _client.PostAsJsonAsync("transaction", tras);
            } else {
                response = await _client.PutAsJsonAsync("transaction", tras);
            }

            if (response.IsSuccessStatusCode) {
                MessageBox.Show("Item saved successfully!");
            } else {
                MessageBox.Show("Error saving item.");
            }
        }
        private async Task OnSaveTransLine() {
            HttpResponseMessage response = null;
            TransactionLineListDto trasLine = (TransactionLineListDto)bsTransLines.Current;
            //tras.TransactionID = _customer.CustomerID;

            if (trasLine.TransactionLineID == 0) {
                response = await _client.PostAsJsonAsync("transactionLine", trasLine);
            } else {
                response = await _client.PutAsJsonAsync("transactionLine", trasLine);
            }

            if (response.IsSuccessStatusCode) {
                MessageBox.Show("Item saved successfully!");
            } else {
                MessageBox.Show("Error saving item.");
            }
        }

        private async Task OnDelete() {
            HttpResponseMessage response = null;
            TransactionListDto tras = (TransactionListDto)bsTransactions.Current;
            if (tras.TransactionID != 0) {
                response = await _client.DeleteAsync($"transaction/{tras.TransactionID}");
                if (response.IsSuccessStatusCode) {
                    bsTransactions.RemoveCurrent();
                    MessageBox.Show("Item Deleted Successfully!");
                } else {
                    MessageBox.Show("Error deleting item.");
                }
            }
        }

        private void txtLoggedInCustomer_TextChanged(object sender, EventArgs e) {

        }

        private void label2_Click(object sender, EventArgs e) {

        }

        private void grdTransLines_CellValueChangedAsync(object sender, DataGridViewCellEventArgs e) {
            if (e.ColumnIndex == colItem.Index && e.RowIndex >= 0) {
                // Get the selected item from the cell value
                var selectedCell = grdTransLines.Rows[e.RowIndex].Cells[e.ColumnIndex];
                if (selectedCell.Value is Item selectedItem) {
                    // Find the corresponding item in the list of items
                    ItemListDto item = _itemList.FirstOrDefault(i => i.ItemID == selectedItem.ItemID);

                    // If the item was found, update the value of the "colItemPrice" column
                    if (item != null) {
                        grdTransLines.Rows[e.RowIndex].Cells[colItemPrice.Index].Value = item.Price;
                    }
                }
            }
        
        }

            private void grdTransactions_SelectionChanged(object sender, EventArgs e) {
            }


            private async void btnDelete_Click(object sender, EventArgs e) {
                await OnDelete();
            }

            private void btnClose_Click(object sender, EventArgs e) {
                this.Close();
            }

        }
    }








