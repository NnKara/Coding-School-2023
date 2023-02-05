using DevExpress.XtraEditors;
using Model;
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

namespace Session_16 {
    public partial class PetForm : DevExpress.XtraEditors.XtraForm {

        private Populate _populate;

        public PetForm() {
            InitializeComponent();
        }

        private void PetForm_Load(object sender, EventArgs e) {
            SetControls();
        }


        private void gridControl1_Click(object sender, EventArgs e) {

        }


        private void gridViewPet_ValidateRow(object sender, ValidateRowEventArgs e) {
            GridView view = sender as GridView;
            PetRepo petRepo = new PetRepo();
            Guid id = Guid.Parse(view.GetRowCellValue(view.FocusedRowHandle, colPetID).ToString());
            try {
                if (e.Valid) {
                
                    if (petRepo.GetById(id) == null) {
                        petRepo.Add((Pet)bsPet.Current);
                    } else {
                        petRepo.Update(id, (Pet)bsPet.Current);
                    }
                }
            } catch (Exception ex) {
                MessageBox.Show("You have to fill every Cell!");
            }
        }

        private void gridViewPet_RowDeleting(object sender, DevExpress.Data.RowDeletingEventArgs e) {
            GridView view = sender as GridView;
            PetRepo employeeRepo = new PetRepo();
            Guid id = Guid.Parse(view.GetRowCellValue(view.FocusedRowHandle, colPetID).ToString());
            employeeRepo.Delete(id);
        }

        
        public void SetControls() {
           PetRepo petRepo=new PetRepo();
            bsPet.DataSource=petRepo.GetAll();
            gridControl1.DataSource=bsPet;
        }

        private void btnPopulatePets_Click(object sender, EventArgs e) {
            PetRepo petRepo = new PetRepo();
            Populate populateEntitys = new Populate();
            List<Pet> pets = populateEntitys.PopulatePets();
            foreach (Pet pet in pets) {
                petRepo.Add(pet);
            }
        }

        private void btnClose_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}