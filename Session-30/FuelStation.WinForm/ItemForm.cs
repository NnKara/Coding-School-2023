using FuelStation.Model;
using Newtonsoft.Json;
using Session_30.Shared.CustomerDto;
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
    public partial class ItemForm : Form {

        private readonly HttpClient _client;
        public ItemForm() {
            InitializeComponent();
            _client = new HttpClient();
            _client.BaseAddress = new Uri("https://localhost:7183/");
        }

        private void grdItems_CellContentClick(object sender, DataGridViewCellEventArgs e) {
            
        }

        private void ItemForm_Load(object sender, EventArgs e) {
            grdItems.AutoGenerateColumns = false;
            SetControlProperties();
        }

        private void btnNewLine_Click(object sender, EventArgs e) {
       
            bsItems.Add(new ItemListDto());
        }

        private void btnSave_Click(object sender, EventArgs e) {
            OnSave();
        }

        private void btnDelete_Click(object sender, EventArgs e) {
            OnDelete();
        }

        private void btnRefresh_Click(object sender, EventArgs e) {
            SetControlProperties();
        }

        private void btnClose_Click(object sender, EventArgs e) {
            this.Close();
        }

        private async Task SetControlProperties() {
            var items = await GetItems();
            if (items != null) {
                DataGridViewComboBoxColumn colItemType = grdItems.Columns["colItemType"] as DataGridViewComboBoxColumn;
                colItemType.DataSource = Enum.GetValues(typeof(ItemType));
                bsItems.DataSource = items;
                grdItems.DataSource = bsItems;
            }        
        }



        private async Task<List<ItemListDto>> GetItems() {
            var response = await _client.GetAsync("item");
            if (response.IsSuccessStatusCode) {
                var content = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<List<ItemListDto>>(content);
            }
            return null;
        }

        private async Task OnSave() {
            HttpResponseMessage response = null;
            ItemListDto item = (ItemListDto)bsItems.Current;
            if (item.ItemID == 0) {
                response = await _client.PostAsJsonAsync("item", item);
            } else {
                response = await _client.PutAsJsonAsync("item", item);
            }

            if (response.IsSuccessStatusCode) {
                MessageBox.Show("Item saved successfully!");
            } else {
                MessageBox.Show("Error saving item.");
            }
        }

        private async Task OnDelete() {
            HttpResponseMessage response = null;
            ItemListDto item = (ItemListDto)bsItems.Current;
            if (item.ItemID != null) {
                response = await _client.DeleteAsync($"item/{item.ItemID}");
                if (response.IsSuccessStatusCode) {
                    bsItems.RemoveCurrent();
                    MessageBox.Show("Item Deleted Successfully!");
                } else {
                    MessageBox.Show("Error deleting item.");
                }
            }
        }

      
    }
}
