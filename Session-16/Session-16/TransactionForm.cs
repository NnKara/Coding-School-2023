using DevExpress.XtraEditors;
using Orm.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using Model;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Session_16 {
    public partial class TransactionForm : DevExpress.XtraEditors.XtraForm {

        private Populate _populate;
        private TransactionRepo _transactionRepo;
        private PetRepo _petRepo;
        private PetFoodRepo _petFoodRepo;
        private CustomerRepo _customerRepo;
        private EmployeeRepo _employeeRepo;
        
        public TransactionForm() {
            InitializeComponent();
        }

  

        private void TransactionForm_Load(object sender, EventArgs e) {
            //SetControls();
            List<Customer> customers= new List<Customer>();
            repoCustomerID.DataSource = _populate.PopulateCustomers();
            repoCustomerID.ValueMember = "CustomerID";
            repoCustomerID.DisplayMember = "Surname";
        }

        private void grdTransaction_Click(object sender, EventArgs e) {

        }

        private void gridView1_ValidateRow(object sender, ValidateRowEventArgs e) {
            GridView view = sender as GridView;
            TransactionRepo trasRepo = new TransactionRepo();
            Guid id = Guid.Parse(view.GetRowCellValue(view.FocusedRowHandle, colTransactionID).ToString());
            if (e.Valid) {
                if (trasRepo.GetById(id) == null) {
                    trasRepo.Add((Transaction)bsTransaction.Current);
                } else {
                    trasRepo.Update(id,(Transaction)bsTransaction.Current);
                }
            }
        }

        private void gridView1_RowDeleting(object sender, DevExpress.Data.RowDeletingEventArgs e) {
            GridView view = sender as GridView;
            
            Guid id = Guid.Parse(view.GetRowCellValue(view.FocusedRowHandle, colTransactionID).ToString());
            _transactionRepo.Delete(id);
        }

        public void SetControls() {
            bsTransaction.DataSource = _transactionRepo.GetAll();
            grdTransaction.DataSource = bsTransaction;
        }

        private void btnPopulateTransaction_Click(object sender, EventArgs e) {
            Populate populateEntitys = new Populate();
            List<Transaction> transactions = populateEntitys.PopulateTransactions();
            foreach (Transaction transaction in transactions) {
                _transactionRepo.Add(transaction);
            }
        }

        private void btnOrder_Click(object sender, EventArgs e) {
            Transaction newTras=new Transaction();
            //newTras.Customer = SelectCustomer();
            
        }

        private void btnClose_Click(object sender, EventArgs e) {
            this.Close();
        }



        //public Transaction DoTransaction(Customer customer,Pet pet,Employee employee,PetFood petFood) {

        //    Transaction newTras=new Transaction();
        //    newTras.CustomerID = customer.CustomerID;
        //    newTras.PetID= pet.PetID;
        //    newTras.EmployeeID = employee.EmployeeID;
        //            }
    }
}
