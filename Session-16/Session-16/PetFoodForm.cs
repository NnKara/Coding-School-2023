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
    public partial class PetFoodForm : DevExpress.XtraEditors.XtraForm {

        private Populate _populate;
        public PetFoodForm() {
            InitializeComponent();
        }

        private void grdPetFood_Click(object sender, EventArgs e) {

        }

        private void PetFoodForm_Load(object sender, EventArgs e) {
            SetControls();
        }

        private void gridView1_ValidateRow(object sender, ValidateRowEventArgs e) {
            GridView view = sender as GridView;
            PetFoodRepo petFoodRepo = new PetFoodRepo();
            Guid id = Guid.Parse(view.GetRowCellValue(view.FocusedRowHandle, colPetFoodID).ToString());
            if (e.Valid) {
                if (petFoodRepo.GetById(id) == null) {
                    petFoodRepo.Add((PetFood)bindingSource1.Current);
                } else {
                    petFoodRepo.Update(id, (PetFood)bindingSource1.Current);
                }
            }
        }

        private void gridView1_RowDeleting(object sender, DevExpress.Data.RowDeletingEventArgs e) {
            GridView view = sender as GridView;
            PetFoodRepo petFoodRepo = new PetFoodRepo();
            Guid id = Guid.Parse(view.GetRowCellValue(view.FocusedRowHandle, colPetFoodID).ToString());
            petFoodRepo.Delete(id);
        }

        private void SetControls() {
            PetFoodRepo petFoodRepo = new PetFoodRepo();
            bindingSource1.DataSource = petFoodRepo.GetAll();
            grdPetFood.DataSource = bindingSource1;
        }
    }
}