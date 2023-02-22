﻿using FuelStation.EF.Repositorys;
using FuelStation.Model;
using Newtonsoft.Json;
using Session_30.Shared.CustomerDto;
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
    public partial class TransactionLogin : Form {

        private readonly HttpClient _client;
        public TransactionLogin() {
            InitializeComponent();
            _client = new HttpClient();
            _client.BaseAddress = new Uri("https://localhost:7183/");
           
        }

        private void TransactionLogin_Load(object sender, EventArgs e) {

        }

        private async void btnOpenOrder_ClickAsync(object sender, EventArgs e) {
            string cardNumber = textBox1.Text;
            var customer =await FindCustomerByCardNumber(cardNumber);
            if (customer is null) {
                MessageBox.Show("Customer doesn't exist! Redirecting..");
                CustomerForm custForm = new CustomerForm();
                custForm.ShowDialog();
            } else {
                MessageBox.Show("Welcome Back!");
                TransactionForm trasForm = new TransactionForm(customer);
                trasForm.ShowDialog();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e) {

        }

        private async Task<CustomerListDto> FindCustomerByCardNumber(string cardNumber) {
            var response = await _client.GetAsync($"cardNumber/{cardNumber}");
            if (response.IsSuccessStatusCode) {
                var content = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<CustomerListDto>(content);
        }
            return null;
        }

        private void btnClose_Click(object sender, EventArgs e) {
            this.Close();
        }
    }

}
