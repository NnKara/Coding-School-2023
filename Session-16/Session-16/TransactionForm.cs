﻿using DevExpress.XtraGrid.Views.Base;
using Model;
using Orm.Repository;
using System;
using System.Linq;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid;
using DevExpress.XtraRichEdit.Layout;
using DevExpress.CodeParser;
using DevExpress.XtraEditors.Repository;
using System.Windows.Markup.Localizer;

namespace Session_16 {
    public partial class TransactionForm : DevExpress.XtraEditors.XtraForm {




        public TransactionForm() {
            InitializeComponent();
        }



        private void TransactionForm_Load(object sender, EventArgs e) {
            SetControls();

        }

        private void grdTransaction_Click(object sender, EventArgs e) {

        }

        private void gridView1_ValidateRow(object sender, ValidateRowEventArgs e) {
            GridView view = sender as GridView;

            //Guid id = Guid.Parse(view.GetRowCellValue(view.FocusedRowHandle, colTransactionID).ToString());
            if (e.Valid) {
                try {
                    TransactionRepo trasRepo = new TransactionRepo();
                    Guid id = Guid.Parse(view.GetRowCellValue(view.FocusedRowHandle, colTransactionID).ToString());
                    if (trasRepo.GetById(id) == null) {
                        trasRepo.Add((Transaction)bsTransaction.Current);
                    } else {
                        trasRepo.Update(id, (Transaction)bsTransaction.Current);
                    }
                } catch (Exception ex) {
                    MessageBox.Show("You have to fill every Cell!");
                }
            }
        }



        private void gridView1_RowDeleting(object sender, DevExpress.Data.RowDeletingEventArgs e) {
            TransactionRepo transactionRepo = new TransactionRepo();
            GridView view = sender as GridView;
            Guid id = Guid.Parse(view.GetRowCellValue(view.FocusedRowHandle, colTransactionID).ToString());
            transactionRepo.Delete(id);
        }


        public void SetControls() {


            CustomerRepo customerRepo = new CustomerRepo();
            repoCustomerID.DataSource = customerRepo.GetAll();
            repoCustomerID.ValueMember = "CustomerID";
            repoCustomerID.DisplayMember = "CustomerSurname";

            EmployeeRepo employeeRepo = new EmployeeRepo();
            repoEmployee.DataSource = employeeRepo.GetAll();
            repoEmployee.ValueMember = "EmployeeID";
            repoEmployee.DisplayMember = "EmployeeSurname";

            PetRepo petRepo = new PetRepo();
            repoPet.DataSource = petRepo.GetAll();
            repoPet.ValueMember = "PetID";
            repoPet.DisplayMember = "Breed";

            PetFoodRepo petFoodRepo = new PetFoodRepo();
            repoPetFoodID.DataSource = petFoodRepo.GetAll();
            repoPetFoodID.ValueMember = "PetFoodID";
            repoPetFoodID.DisplayMember = "Price";


            TransactionRepo transactionRepo = new TransactionRepo();
            bsTransaction.DataSource = transactionRepo.GetAll();
            grdTransaction.DataSource = bsTransaction;
        }

        private void btnOrder_Click(object sender, EventArgs e) {
        }

        private void btnClose_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void gridView1_CellValueChanged(object sender, CellValueChangedEventArgs e) {


            PetRepo petRepo = new PetRepo();
            PetFoodRepo petFoodRepo = new PetFoodRepo();
            GridView view = sender as GridView;
            TransactionRepo trasRepo = new TransactionRepo();

           

            if (e.Column.Caption == "PetID") {
                Transaction tras = view.GetFocusedRow() as Transaction;
                Pet petTmp = petRepo.GetById(tras.PetID);
                tras.PetID = (Guid)view.GetRowCellValue(view.FocusedRowHandle, colPetID);
                if (view.GetRowCellValue(view.FocusedRowHandle, colPetID) != null) {
                    tras.PetPrice = petTmp.Price;
                    view.SetFocusedRowCellValue("Price", tras.PetPrice);
                }
            }

            if (e.Column.Caption == "PetFoodID") {
                Transaction tras = view.GetFocusedRow() as Transaction;
                PetFood petFood = petFoodRepo.GetById(tras.PetFoodID);
                tras.PetFoodID = (Guid)view.GetRowCellValue(view.FocusedRowHandle, colPetFoodID);
                if (view.GetRowCellValue(view.FocusedRowHandle, colPetFoodID) != null) {
                    tras.PetFoodPrice = petFood.Price;
                    view.SetFocusedRowCellValue("Price", tras.PetFoodPrice);
                }
            }

            //Calculate Total Price
            decimal petPrice = 0;
            decimal petFoodPrice = 0;
            int qty = 0;

            if (view.GetRowCellValue(view.FocusedRowHandle, view.Columns["PetPrice"]) != null) {
                petPrice = (decimal)view.GetRowCellValue(view.FocusedRowHandle, view.Columns["PetPrice"]);
            }


            if (view.GetRowCellValue(view.FocusedRowHandle, view.Columns["PetFoodPrice"]) != null) {
                petFoodPrice = (decimal)view.GetRowCellValue(view.FocusedRowHandle, view.Columns["PetFoodPrice"]);
            }

            if (view.GetRowCellValue(view.FocusedRowHandle, view.Columns["PetFoodQty"]) != null) {
                qty = (int)view.GetRowCellValue(view.FocusedRowHandle, view.Columns["PetFoodQty"]);
            }

            if (petFoodPrice!=0  &&  petFoodPrice!=0 && qty!=0 ) {
                Transaction tras = view.GetFocusedRow() as Transaction;
                decimal totalPrice = petPrice + (petFoodPrice * qty);
                tras.TotalPrice = totalPrice;
                view.SetRowCellValue(view.FocusedRowHandle, view.Columns["colTotalPrice"], totalPrice);
            }



        }
    }
}
