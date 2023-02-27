﻿using FuelStation.EF.Repositorys;
using FuelStation.Model;

using Session_30.Server.Controllers;
using Session_30.Shared.CustomerDto;
using Newtonsoft.Json;
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
using Session_30.Shared.ItemDto;
using System.Xml.Linq;
using Session_30.Client.Pages.Customer;
using DevExpress.XtraEditors;

namespace FuelStation.WinForm {
    public partial class CustomerForm : Form {

        private List<CustomerListDto> customerListDtos= new List<CustomerListDto>();
        private readonly HttpClient _client;
        public CustomerForm() {
            InitializeComponent();
            _client = new HttpClient();
            _client.BaseAddress = new Uri("https://localhost:7183/");
        }

        private void CustomerForm_Load(object sender, EventArgs e) {
           _= SetControlProperties();
        }

        private void grdCustomers_CellContentClick(object sender, DataGridViewCellEventArgs e) {

        }

        private void btnClose_Click(object sender, EventArgs e) {

            this.Close();
        }

        private async Task SetControlProperties() {
            customerListDtos = await _client.GetFromJsonAsync<List<CustomerListDto>>("customer");
            if (customerListDtos != null) {
                bsCustomers.DataSource = customerListDtos;
                gridCustomers.DataSource = bsCustomers;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e) {
            grdCustomers.AddNewRow();
        }

        private void btnSave_Click(object sender, EventArgs e) {
            _=OnSave();
            
        }

        private async Task OnSave() {
            HttpResponseMessage response = null;
            CustomerListDto customer = (CustomerListDto)bsCustomers.Current;
            if (customer != null)
            {
                if (customer.CardNumber is null)
                {
                    response = await _client.PostAsJsonAsync("customer", customer);
                }
                else
                {
                    response = await _client.PutAsJsonAsync("customer", customer);
                }

                if (response.IsSuccessStatusCode)
                {
                    XtraMessageBox.Show("Customer saved successfully!","Success Message");
                    SetControlProperties();
                }
                else
                {
                    XtraMessageBox.Show("Error saving customer.","Erros Message");
                }
            }

        }

        private void btnRefresh_Click(object sender, EventArgs e) {
            _=SetControlProperties();
        }

        private void btnDelete_Click(object sender, EventArgs e) {
           _=OnDelete();
        }

        private async Task OnDelete() {
            HttpResponseMessage response = null;
            CustomerListDto customer = (CustomerListDto)bsCustomers.Current;
            if (customer.CustomerID != null) {
                response = await _client.DeleteAsync($"customer/{customer.CustomerID}");
                if (response.IsSuccessStatusCode) {
                    bsCustomers.RemoveCurrent();
                    XtraMessageBox.Show("Customer deleted successfully!","Success Message");
                } else {
                    XtraMessageBox.Show("Error deleting customer.");
                }
            }
        }
    }

}
