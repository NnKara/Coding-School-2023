using DevExpress.Data;
using DevExpress.DataAccess.Native;
using DevExpress.XtraCharts;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraExport.Helpers;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using FuelStation.EF.Repositorys;
using FuelStation.Model;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
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
using System.Windows.Controls;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using GridView = DevExpress.XtraGrid.Views.Grid.GridView;

namespace FuelStation.WinForm
{
    public partial class TransactionForm : Form
    {

        private HttpClient _client;
        private CustomerListDto _customer;
        private List<TransactionListDto> _transactions;
        private List<ItemListDto> _items;
        private List<EmployeeListDto> _employees;


        public TransactionForm(CustomerListDto customer)
        {
            InitializeComponent();
            _client = new HttpClient();
            _client.BaseAddress = new Uri("https://localhost:7183/");
            _customer = customer;
            label2.Text = $"Customer: {_customer.CustomerName} {_customer.CustomerSurname} - Card Number: {_customer.CardNumber})";
        }

        private void TransactionForm_Load(object sender, EventArgs e)
        {
            _ = SetControlProperties();
           
        }



        //BTN ADD NEW TRANSACTION
        private void btnOpenTransaction_Click(object sender, EventArgs e)
        {
            TransactionListDto transEdit = new TransactionListDto();
            gridView1.AddNewRow();
        }


        //BTN SAVE/UPDATE TRANSACTION
        private void BtnSaveUpdateTransaction_Click(object sender, EventArgs e)
        {
            if (IsGridFilled(gridView1) && IsGridFilled(grdTransLines))
            {
                if (gridView1.GetFocusedRow() != null)
                {
                    TransactionListDto? transaction = gridView1.GetFocusedRow() as TransactionListDto;
                    if (transaction != null)
                    {
                        transaction.CustomerID = _customer.CustomerID;
                        if (transaction.TransactionID == 0)
                        {
                            _ = OnSaveTransaction(transaction);
                        }
                        else
                        {
                            _ = OnEditTransaction(transaction);
                        }
                    }
                }
            }
            else
            {
                XtraMessageBox.Show("Please fill in all cells before saving.","Error Message");
            }
        }

        //METHOD EDIT TRANSACTION
        private async Task OnEditTransaction(TransactionListDto transaction)
        {
            var response = await _client.PutAsJsonAsync("transaction", transaction);
            if (response.IsSuccessStatusCode)
            {
                XtraMessageBox.Show("Item saved successfully!","Success Message");
            }
            else
            {
                XtraMessageBox.Show("Error saving item.","Error Message");
            }
        }

        //METHOD SAVE TRANSACTION

        private async Task OnSaveTransaction(TransactionListDto transaction)
        {
            var response = await _client.PostAsJsonAsync("transaction", transaction);
            if (response.IsSuccessStatusCode)
            {

                XtraMessageBox.Show("Transaction saved successfully!", "Success Message");
                SetControlProperties();
                
            }
            else
            {
                XtraMessageBox.Show("Error saving Transaction!", "Error Message");
            }
        }

        //BTN ADD TRANSACTION-LINE
        private void btnAddTransLine_Click(object sender, EventArgs e)
        {

            TransactionListDto? transaction = gridView1.GetFocusedRow() as TransactionListDto;

            if (transaction != null)
            {
                TransactionLineEditDto newTransLine = new TransactionLineEditDto();
                newTransLine.TransactionID = transaction.TransactionID;
                bsTransLines.Add(newTransLine);
            }

        }


        //BTN DELETE TRANSACTION
        private void btnDeleteTrans_Click(object sender, EventArgs e)
        {
            if (gridView1.GetFocusedRow() != null)
            {
                TransactionListDto? transaction = gridView1.GetFocusedRow() as TransactionListDto;
                if (transaction != null)
                {
                    _ = OnDeleteTransaction(transaction.TransactionID);
                }
            }
        }


        //DELETE TRANSACTION METHOD
        private async Task OnDeleteTransaction(int transactionID)
        {
            var response = await _client.DeleteAsync($"transaction/{transactionID}");

            if (response.IsSuccessStatusCode)
            {

                bsTransactions.RemoveCurrent();
                XtraMessageBox.Show("Transaction Deleted Successfully!", "Success Message!");
            }
            else
            {
                XtraMessageBox.Show("Error deleting transaction.You have to delete Transaction-Lines first!", "Error Message");
            }
        }

        //REMOVE CURRENT TRANSACTIONLINE
        private void btnDeleteLine_Click(object sender, EventArgs e)
        {
            if (bsTransLines.Current != null)
            {
                TransactionLineEditDto? transactionL = bsTransLines.Current as TransactionLineEditDto;
                if (transactionL != null)
                {
                    _ = OnDeleteTransactionLine(transactionL.TransactionLineID);
                }
            }
        }

        //METHOD REMOVE TRANSACTION-LINE
        private async Task OnDeleteTransactionLine(int id)
        {

            var response = await _client.DeleteAsync($"transactionLine/{id}");

            if (response.IsSuccessStatusCode)
            {
                bsTransLines.RemoveCurrent();
                XtraMessageBox.Show("Transaction-Line Deleted Successfully!", "Success Message");
            }
            else
            {
                XtraMessageBox.Show("Error deleting Transaction-Line!", "Error Message");
            }
        }


        //METHOD EVERY CELL IS FULL-FILL
        public bool IsGridFilled(GridView gridView)
        {
            if (gridView.RowCount == 0)
            {
                return false;
            }
            for (int rowHandle = 0; rowHandle < gridView.RowCount; rowHandle++)
            {
                for (int colHandle = 0; colHandle < gridView.VisibleColumns.Count; colHandle++)
                {
                    object cellValue = gridView.GetRowCellValue(rowHandle, gridView.VisibleColumns[colHandle]);

                    if (cellValue == null || string.IsNullOrEmpty(cellValue.ToString()))
                    {
                        return false;
                    }
                }
            }

            // If all cells are filled, return true
            return true;
        }

            private void btnRemoveTempLineTransLine_Click(object sender, EventArgs e)
        {
            bsTransLines.RemoveCurrent();
        }

        private void gridTransactions_CellValueChanged(object sender, CellValueChangedEventArgs e)
        {

        }

        //METHOD CALCULATE THE TOTAL VALUE OF TRANSACTION
        private decimal CalcTransTotalValue()
        {
            decimal totalValue = 0;
            for (int i = 0; i < grdTransLines.RowCount; i++)
            {
                totalValue += (decimal)grdTransLines.GetRowCellValue(i, "TotalValue");
            }
            // Set the total value for the current transaction
            var grdTrans = grdTransactions.FocusedView as GridView;
            if (grdTrans != null)
            {
                grdTrans.SetRowCellValue(grdTrans.FocusedRowHandle, "TotalValue", totalValue);
            }
            return totalValue;
        }


        //METHOD GET ALL TRANSACTIONS
        private async Task<List<TransactionListDto>> GetTransactions(int id)
        {
            var response = await _client.GetAsync($"transactions/customer/{id}");
            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<List<TransactionListDto>>(content);
            }
            return null;
        }


        //CONTROL-PROPERTIES
        private async Task SetControlProperties()
        {
            repQuantity.MinValue = 0;
            _transactions = await GetTransactions(_customer.CustomerID);
            _employees = await GetEmployees();
            _items = await GetItems();

            if (_transactions != null)
            {

                bsTransactions.DataSource = _transactions;
                bsTransLines.DataSource = bsTransactions;
                bsTransLines.DataMember = "TransactionLines";


                grdTransactions.DataSource = bsTransactions;
                grdTransactionLines.DataSource = bsTransLines;

                bsEmployees.DataSource = _employees;
                repoEmployee.DataSource = bsEmployees;
                repoEmployee.ValueMember = "EmployeeID";
                repoEmployee.DisplayMember = "EmployeeSurname";

                bsItems.DataSource = _items;
                repoItem.DataSource = bsItems;
                repoItem.ValueMember = "ItemID";
                repoItem.DisplayMember = "Code";

            }
        }

        //METHOD GET ALL ITEMS
        private async Task<List<ItemListDto>?> GetItems()
        {
            var response = await _client.GetAsync("item");
            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<List<ItemListDto>>(content);
            }
            return null;
        }

        //METHOD GET ALL EMPLOYEES
        private async Task<List<EmployeeListDto>?> GetEmployees()
        {
            var response = await _client.GetAsync("employee");
            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<List<EmployeeListDto>>(content);
            }
            return null;
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();

        }


        private void grdTransLines_CellValueChanged(object sender, CellValueChangedEventArgs e)
        {
            if (e.Column.FieldName == "ItemID" && e.Value != null)
            {
                int transactionLineIndex = e.RowHandle;
                int itemID = (int)e.Value;
                if (itemID != 0)
                {
                    decimal itemPrice = _items.FirstOrDefault(i => i.ItemID == itemID).Price;
                    grdTransLines.SetRowCellValue(transactionLineIndex, "ItemPrice", itemPrice);
                    decimal quantity = Convert.ToDecimal(grdTransLines.GetRowCellValue(transactionLineIndex, "Quantity"));
                    decimal netValue = itemPrice * quantity;
                    grdTransLines.SetRowCellValue(transactionLineIndex, "NetValue", netValue);
                    var item = _items.FirstOrDefault(i => i.ItemID == itemID);
                    if (item.ItemType == ItemType.Fuel && netValue > 20)
                    {
                        decimal discPercent = 0.1m;
                        decimal discValue = netValue * discPercent;
                        grdTransLines.SetRowCellValue(transactionLineIndex, "DiscountPercent", discPercent);
                        grdTransLines.SetRowCellValue(transactionLineIndex, "DiscountValue", Convert.ToInt32(discValue));
                        decimal totalValue = netValue - discValue;
                        grdTransLines.SetRowCellValue(transactionLineIndex, "TotalValue", Convert.ToInt32(totalValue));
                    }
                    else
                    {
                        grdTransLines.SetRowCellValue(transactionLineIndex, "DiscountPercent", 0m);
                        grdTransLines.SetRowCellValue(transactionLineIndex, "DiscountValue", 0m);
                        grdTransLines.SetRowCellValue(transactionLineIndex, "TotalValue", netValue);
                    }
                }
            }
            else if (e.Column.FieldName == "Quantity")
            {

                int transactionLineIndex = e.RowHandle;

                int itemID = (int)grdTransLines.GetRowCellValue(transactionLineIndex, "ItemID");

                decimal itemPrice = (decimal)grdTransLines.GetRowCellValue(transactionLineIndex, "ItemPrice");
                decimal quantity = Convert.ToDecimal(e.Value);

                decimal netValue = itemPrice * quantity;
                grdTransLines.SetRowCellValue(transactionLineIndex, "NetValue", netValue);
                var item = _items.FirstOrDefault(i => i.ItemID == itemID);
                if (item != null)
                {
                    if (item.ItemType == ItemType.Fuel && netValue > 20)
                    {
                        decimal discPercent = 0.1m;
                        decimal discValue = netValue * discPercent;
                        grdTransLines.SetRowCellValue(transactionLineIndex, "DiscountPercent", discPercent);
                        grdTransLines.SetRowCellValue(transactionLineIndex, "DiscountValue", Convert.ToInt32(discValue));
                        decimal totalValue = netValue - discValue;
                        grdTransLines.SetRowCellValue(transactionLineIndex, "TotalValue", Convert.ToInt32(totalValue));
                    }
                    else
                    {
                        grdTransLines.SetRowCellValue(transactionLineIndex, "DiscountPercent", 0m);
                        grdTransLines.SetRowCellValue(transactionLineIndex, "DiscountValue", 0m);
                        grdTransLines.SetRowCellValue(transactionLineIndex, "TotalValue", netValue);
                    }
                }
                else
                {
                    XtraMessageBox.Show("Please select an item in order to procceed..");
                }
            }
        }

        

        private void grdTransLines_RowUpdated(object sender, RowObjectEventArgs e)
        {
            if (e.RowHandle >= 0 && e.RowHandle < grdTransLines.RowCount)
            {
                TransactionListDto transaction = gridView1.GetFocusedRow() as TransactionListDto;
                if (transaction != null)
                {
                    int transactionID = transaction.TransactionID;

                    if (HasMultipleItems())
                    {
                        XtraMessageBox.Show("A transaction can have only one fuel type item.", "Error Message");
                        grdTransLines.DeleteRow(e.RowHandle);
                        return;
                    }

                    UpdateTransactionPaymentMethod(transaction);

                    // Calculate the total value
                    decimal totalValue = CalcTransTotalValue();
                    var gridView = grdTransactions.FocusedView as GridView;
                    if (gridView != null)
                    {
                        int rowHandle = gridView.FocusedRowHandle;
                        if (gridView.GetRowCellValue(rowHandle, "TransactionID").Equals(transactionID))
                        {
                            gridView.SetRowCellValue(rowHandle, "TotalValue", totalValue);
                        }
                    }
                    
                }
            }
        }


        private void UpdateTransactionPaymentMethod(TransactionListDto transaction)
        {
            // Calculate the total value
            decimal totalValue = CalcTransTotalValue();

            if (totalValue > 50 && transaction.PaymentMethod != PaymentMethod.Cash)
            {
                XtraMessageBox.Show("The only acceptable payment method for transactions above 50 Euros is Cash!", "Error Message");
                transaction.PaymentMethod = PaymentMethod.Cash;
            }
        }
        private bool HasMultipleItems()
        {
            int fuelItemCount = 0;
            for (int i = 0; i < grdTransLines.RowCount; i++)
            {
                int itemID = (int)grdTransLines.GetRowCellValue(i, "ItemID");
                var item = _items.FirstOrDefault(it => it.ItemID == itemID);
                if (item != null && item.ItemType == ItemType.Fuel)
                {
                    fuelItemCount++;
                    if (fuelItemCount > 1)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        private void btnRemoveCurrentRow_Click(object sender, EventArgs e)
        {
            int selectedRowHandle = grdTransLines.FocusedRowHandle;
            if (selectedRowHandle >= 0)
            {
                TransactionLineEditDto transactionLine = grdTransLines.GetRow(selectedRowHandle) as TransactionLineEditDto;
                if (transactionLine != null && transactionLine.TransactionLineID != 0)
                {
                    XtraMessageBox.Show("You cannot remove locally a saved Transaction-Line. To remove it, you must delete it permanently!", "Errot Message");
                }
                else
                {
                    grdTransLines.DeleteRow(selectedRowHandle);
                    decimal totalValue = CalcTransTotalValue();
                    var gridView = grdTransactions.FocusedView as GridView;
                    if (gridView != null)
                    {
                        int rowHandle = gridView.FocusedRowHandle;
                        int transactionID = Convert.ToInt32(gridView.GetRowCellValue(rowHandle, "TransactionID"));
                        gridView.SetRowCellValue(rowHandle, "TotalValue", totalValue);
                    }
                    
                }
            }
        }

        private void btnRemoveCurrentTransaction_Click(object sender, EventArgs e)
        {
            int selectedRowHandle = gridView1.FocusedRowHandle;
            if (selectedRowHandle >= 0)
            {
                TransactionListDto transaction = gridView1.GetRow(selectedRowHandle) as TransactionListDto;
                if (transaction != null && transaction.TransactionID != 0)
                {
                    XtraMessageBox.Show("You cannot remove locally a saved Transaction. To remove it, you must delete it permanently!", "Errot Message");
                }
                else
                {
                    gridView1.DeleteRow(selectedRowHandle);
                }
            }
        }

        private void gridView1_RowUpdated(object sender, RowObjectEventArgs e)
        {
            if (e.RowHandle >= 0 && e.RowHandle < gridView1.RowCount)
            {
                TransactionListDto transaction = gridView1.GetFocusedRow() as TransactionListDto;
                if (transaction != null)
                {
                    UpdateTransactionPaymentMethod(transaction);
                }
            }
        }

        private void btnRef_Click(object sender, EventArgs e)
        {
            SetControlProperties();
        }

        private void grdTransLines_ValidateRow(object sender, ValidateRowEventArgs e)
        {
            //int transactionLineIndex = e.RowHandle;
            //int itemID = (int)grdTransLines.GetRowCellValue(transactionLineIndex, "ItemID");
            ////int quantityRow = (int)grdTransLines.GetRowCellValue(transactionLineIndex, "Quantity");

            //decimal itemPrice = (decimal)grdTransLines.GetRowCellValue(transactionLineIndex, "ItemPrice");
            //int quantity =(int) grdTransLines.GetRowCellValue(transactionLineIndex,"Quantity");
            //if (quantity < 0)
            //{
            //    XtraMessageBox.Show("Quantity cannot be less than or equal to 0.", "Error Message");

            //    //TODO
            //    /*grdTransLines.SetRowCellValue(transactionLineIndex, "Quantity", 1);*/ // reset the value to 1
            //    return;
            }
        }
    }














