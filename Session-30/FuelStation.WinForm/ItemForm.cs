using DevExpress.Utils.Drawing.Animation;
using DevExpress.XtraEditors;
using DevExpress.XtraScheduler.Outlook.Interop;
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
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FuelStation.WinForm {
    public partial class ItemForm : Form {

        private readonly HttpClient _client;
        private List<ItemListDto> _itemList = new();
        public ItemForm() {
            InitializeComponent();
            _client = new HttpClient();
            _client.BaseAddress = new Uri("https://localhost:7183/");
        }

        private void grdItems_CellContentClick(object sender, DataGridViewCellEventArgs e) {
            
        }

        private void ItemForm_Load(object sender, EventArgs e) {
            _=SetControlProperties();
        }

        private void btnNewLine_Click(object sender, EventArgs e) {
            gridView1.AddNewRow();
        }

        private void btnSave_Click(object sender, EventArgs e) {
            _=OnSave();
        }

        private void btnDelete_Click(object sender, EventArgs e) {
            _=OnDelete();
        }

        private void btnRefresh_Click(object sender, EventArgs e) {
            _=SetControlProperties();
        }

        private void btnClose_Click(object sender, EventArgs e) {
            this.Close();
        }

        private async Task SetControlProperties() {
            _itemList = await _client.GetFromJsonAsync<List<ItemListDto>>("item");

            if (_itemList != null) {
                bsItems.DataSource = _itemList;
                gridControl1.DataSource = bsItems;
            }
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
                XtraMessageBox.Show("Item saved successfully!","Success Message");
                SetControlProperties();
            }
            else
            {
                XtraMessageBox.Show("Error saving item." +
                                "\nPossible  Erros: " +
                                "\n1. Item is associated with Transactions and its not Editable." +
                                "\n2. Code is taken by another Item. Each code is unique."+
                                "\n3. Cell is empty or does not have proper value.","Error Message");
                SetControlProperties();                
            }
        }

        private async Task OnDelete() {
            HttpResponseMessage response = null;
            ItemListDto item = (ItemListDto)bsItems.Current;
            if (item.ItemID != null) {
                response = await _client.DeleteAsync($"item/{item.ItemID}");
                if (response.IsSuccessStatusCode) {
                    bsItems.RemoveCurrent();
                   XtraMessageBox.Show("Item Deleted Successfully!","Success Message");
                } else {
                    XtraMessageBox.Show("Error deleting item." +
                                   " \n1. Item is associated with Transactions and cannot be Deleted.","Error Message");
                }
            }
        }
      
    }
}
