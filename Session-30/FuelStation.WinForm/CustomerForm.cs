using FuelStation.EF.Repositorys;
using FuelStation.Model;

using Session_30.Server.Controllers;
using Session_30.Shared.CustomerDto;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http.Json;
using System.Net.Http.Headers;
using System.Text.Json.Serialization;
using Newtonsoft.Json;
using Session_30.Shared.ItemDto;
using System.Xml.Linq;

namespace FuelStation.WinForm {
    public partial class CustomerForm : Form {


        private readonly HttpClient _client;
        public CustomerForm() {
            InitializeComponent();
            _client = new HttpClient();
            _client.BaseAddress = new Uri("https://localhost:7183/");
        }

        private void CustomerForm_Load(object sender, EventArgs e) {
            grdCustomers.AutoGenerateColumns = false;
            SetControlProperties();
        }

        private void grdCustomers_CellContentClick(object sender, DataGridViewCellEventArgs e) {

        }

        private void btnClose_Click(object sender, EventArgs e) {
            this.Close();
        }

        private async Task SetControlProperties() {

            var customers = await GetCustomers();
            if (customers != null) {
                bsCustomers.DataSource = customers;
                grdCustomers.DataSource = bsCustomers;
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

        private void btnAdd_Click(object sender, EventArgs e) {
            bsCustomers.Add(new CustomerListDto());
        }

        private void btnSave_Click(object sender, EventArgs e) {
            OnSave();
            SetControlProperties();
        }

        private async Task OnSave() {
            HttpResponseMessage response = null;
            CustomerListDto customer = (CustomerListDto)bsCustomers.Current;
            if  (customer.CardNumber is null) {
                response = await _client.PostAsJsonAsync("customer", customer);
            } else {
                response = await _client.PutAsJsonAsync("customer", customer);
            }

            if (response.IsSuccessStatusCode) {
                MessageBox.Show("Customer saved successfully!");
            } else {
                MessageBox.Show("Error saving customer.");
            }

        }

        private void btnRefresh_Click(object sender, EventArgs e) {
            SetControlProperties();
        }

        private void btnDelete_Click(object sender, EventArgs e) {
           OnDelete();
        }

        private async Task OnDelete() {
            HttpResponseMessage response = null;
            CustomerListDto customer = (CustomerListDto)bsCustomers.Current;
            if (customer.CustomerID != null) {
                response = await _client.DeleteAsync($"customer/{customer.CustomerID}");
                if (response.IsSuccessStatusCode) {
                    bsCustomers.RemoveCurrent();
                    MessageBox.Show("Customer deleted successfully!");
                } else {
                    MessageBox.Show("Error deleting customer.");
                }
            }
        }
    }

}
