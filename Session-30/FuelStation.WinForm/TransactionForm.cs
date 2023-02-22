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
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FuelStation.WinForm {
    public partial class TransactionForm : Form {

        private HttpClient _client;
        private CustomerListDto _customer;


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
            _ = SetControlTransactionProperties();
           

        }


        private void grdTransLines_CellContentClick(object sender, DataGridViewCellEventArgs e) {

        }

        private void grdTransactions_CellContentClick(object sender, DataGridViewCellEventArgs e) {

        }



        private async void btnSave_Click(object sender, EventArgs e) {
           await OnSave();
        }

        private async void btnDelete_Click(object sender, EventArgs e) {
            await OnDelete();
        }

        private void btnClose_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void btnNewLine_Click(object sender, EventArgs e) {
            bsTransLines.Add(new TransactionLineListDto());
        }

        private void btnNewTrans_Click(object sender, EventArgs e) {
            bsTransactions.Add(new TransactionListDto());
        }

        private void btnRefresh_Click(object sender, EventArgs e) {
            _ = SetControlTransactionProperties();
        }

        private async Task<List<TransactionListDto>?> GetTransactions() {
            var response = await _client.GetAsync("transaction");
            if (response.IsSuccessStatusCode) {
                var content = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<List<TransactionListDto>>(content);
            }
            return null;
        }

        private async Task<List<TransactionLineListDto>?> GetTransactionLines() {
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
            var transLines = await GetTransLines();
            var items = await GetItems();

            if (transactions != null && transLines!=null) {

                DataGridViewComboBoxColumn colPaymentMethod = grdTransactions.Columns["colPaymentMethod"] as DataGridViewComboBoxColumn;
                colPaymentMethod.ValueType = typeof(PaymentMethod);
                colPaymentMethod.DataSource = Enum.GetValues(typeof(PaymentMethod));

                DataGridViewComboBoxColumn colEmployee = grdTransactions.Columns["colEmployee"] as DataGridViewComboBoxColumn;
                colEmployee.DataSource = employees;
                colEmployee.ValueMember = "EmployeeID";
                colEmployee.DisplayMember = "EmployeeName";


                bsTransactions.DataSource = transactions;
                grdTransactions.DataSource = bsTransactions;

                DataGridViewComboBoxColumn colItem = grdTransLines.Columns["colItem"] as DataGridViewComboBoxColumn;
                colItem.DataSource = items;
                colItem.ValueMember = "ItemID";
                colItem.DisplayMember = "Code";
                grdTransLines.Columns["colItemPrice"].ReadOnly = true;

                bsTransLines.DataSource = transLines;
                grdTransLines.DataSource = bsTransLines;
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
        
        private async Task<List<TransactionLineListDto>> GetTransLines() {
            var response = await _client.GetAsync("transactionLine");
            if (response.IsSuccessStatusCode) {
                var content = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<List<TransactionLineListDto>>(content);
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

        private async Task OnSave() {
            HttpResponseMessage response = null;
            TransactionListDto tras = (TransactionListDto)bsTransactions.Current;
            if (tras.TransactionID==0 ) {
                response = await _client.PostAsJsonAsync("Transaction", tras);
            } else {
                response = await _client.PutAsJsonAsync("Transaction", tras);
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
            //if (grdTransLines.CurrentRow != null && grdTransLines.CurrentRow.Cells[colItem.Index] != null) {
            //    int itemId = (int)grdTransLines.CurrentRow.Cells[colItem.Index].Value;
            //    ItemListDto item = FindItem(itemId).Result;
            //    if (item != null) {
            //        Invoke(new Action(() => {
            //            grdTransLines.CurrentRow.Cells[colItemPrice.Index].Value = item.Price;
            //        }));
            //    }
            //}
        }

        //private async Task<ItemListDto> FindItem(int itemID) {
        //        var response = await _client.GetAsync($"item/{itemID}");
        //        if (response.IsSuccessStatusCode) {
        //            var content = await response.Content.ReadAsStringAsync();
        //            var itemDto = JsonConvert.DeserializeObject<ItemEditDto>(content);
        //            var item = new ItemListDto {
        //                ItemID = itemDto.ItemID,
        //                Description = itemDto.Description,
        //                Price = itemDto.Price,
        //                Cost = itemDto.Cost,
        //                ItemType = itemDto.ItemType
        //            };
        //            return item;
        //        }
        //        return null;
        //    }
    }
}






