using DevExpress.XtraGrid.Views.Base;
using Model;
using Orm.Repository;
using System;
using System.Linq;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid;

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
            SetControls();
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
            TransactionRepo transaction = new TransactionRepo();
            GridView view = sender as GridView;          
            Guid id = Guid.Parse(view.GetRowCellValue(view.FocusedRowHandle, colTransactionID).ToString());
            _transactionRepo.Delete(id);
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
            repoPetFoodID.DisplayMember = "AnimalType";


            TransactionRepo transactionRepo = new TransactionRepo();
            bsTransaction.DataSource = transactionRepo.GetAll();
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
            //Transaction newTras=new Transaction();
            //Pet pet = new Pet();
            //PetFood petFood = new PetFood();
        }

        private void btnClose_Click(object sender, EventArgs e) {
            this.Close();
        }


        public decimal SetPetFoods(Pet pet, PetFood petFood, int qty) {
            int petFoodTotalPrice = 0;
            PetFoodRepo petFoodRepo = new PetFoodRepo();
            IList<PetFood> petFoodList = petFoodRepo.GetAll();

            switch (pet.AnimalType) {
                case AnimalType.Dog:
                    return petFood.Price = petFoodList[0].Price * qty;


                case AnimalType.Cat:
                    return petFood.Price = petFoodList[1].Price * qty;


                case AnimalType.Bird:
                    return petFood.Price = petFoodList[2].Price * qty;
            }
            return petFoodTotalPrice;
        }

        private void gridView1_CellValueChanged(object sender, CellValueChangedEventArgs e) {
            PetFood newPetFood = new PetFood();
            Populate populate = new Populate();
            Pet pet = new Pet();
            PetRepo petRepo = new PetRepo();
            PetFoodRepo petFoodRepo = new PetFoodRepo();


            IList<Pet> pets = petRepo.GetAll();
            GridView view=sender as GridView;
            // get the PetID value from the selected row in the Transaction grid control
            Guid selectedPetId = (Guid)view.GetFocusedRowCellValue("PetID");

            // find the corresponding Pet object in the Pets entity based on the PetID
            Pet selectedPet = pets.FirstOrDefault(p => p.PetID == selectedPetId);

            if (selectedPet != null) {
                // set the PetPrice column value in the Transaction grid control with the price of the selected Pet
                view.SetFocusedRowCellValue("PetPrice", selectedPet.Price);
            }
            //int currentRowHandle = gridView1.FocusedRowHandle;
            //if (currentRowHandle >= 0) {
            //    object row = gridView1.GetRow(currentRowHandle);
            //    Transaction currentTransaction=(Transaction)row;
            //    int currentColumnQty = currentTransaction.PetFoodQty;
            //    pet = currentTransaction.Pet;
            //    newPetFood = currentTransaction.PetFood;
            //    SetPetFoods(pet, newPetFood, currentColumnQty);
            //}
            //GridView gridView = gridControl1.DefaultView as GridView;
            //int rowHandle = gridView.FocusedRowHandle;
            //Guid columnValue = Guid.Parse(gridView.GetRowCellValue(rowHandle, "PetID").ToString());

            //int row = gridView.FocusedRowHandle;
            //gridView.SetRowCellValue(rowHandle, "Price",Guid.NewGuid() );



            //int selectedRowIndex = e.RowHandle;
            //Guid selectedPetID = Guid.Parse(view.GetRowCellValue(view.FocusedRowHandle, colPetID).ToString());
            //Pet selectedPet = petRepo.GetAll().Where(x => x.PetID == selectedPetID).FirstOrDefault();

            //PetFood selectedPetFood = petFoodRepo.GetAll().Where(x => x.AnimalType == selectedPet.AnimalType).FirstOrDefault();
            //repoPetFoodPrice.DataSource = petFoodRepo.GetAll().Where(x => x.AnimalType == selectedPet.AnimalType).ToList();

        }

        private void gridView1_FocusedRowChanged(object sender, FocusedRowChangedEventArgs e) {
            //    // Get the selected pet from the grid
            //    PetRepo petRepo = new PetRepo();
            //    Pet pet=new Pet();
            //    Guid selectedPetId = (Guid)gridView1.GetRowCellValue(e.FocusedRowHandle, "PetID");
            //    Pet selectedPet = petRepo.GetById(selectedPetId);
            //    // Create a new transaction
            //    Transaction transaction = new Transaction();

            //    // Set the PetPrice property of the transaction to the price of the selected pet
            //    transaction.PetPrice = selectedPet.Price;

            //    // Do other necessary operations for the transaction here...
            //PetRepo petRepo=new PetRepo();
            //IList<Pet> pets=petRepo.GetAll();
            //Guid selectedPetId = (Guid)grdTransaction.GetRowCellValue(e.FocusedRowHandle, "PetID");
            //Pet selectedPet = pets.FirstOrDefault(p => p.PetID == selectedPetId);
            //if (selectedPet != null) {
            //    gridView1.SetRowCellValue(e.FocusedRowHandle, "Price", selectedPet.Price);

        }
    }
}
