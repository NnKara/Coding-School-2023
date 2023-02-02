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

namespace Session_16 {
    public partial class PetFoodForm : DevExpress.XtraEditors.XtraForm {

        private Populate _populate;
        public PetFoodForm() {
            InitializeComponent();
        }

        private void grdPetFood_Click(object sender, EventArgs e) {

        }

        private void PetFoodForm_Load(object sender, EventArgs e) {

        }

        private void gridView1_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e) {

        }

        private void gridView1_RowDeleting(object sender, DevExpress.Data.RowDeletingEventArgs e) {

        }

        private void SetControlls() {
            PetFoodRepo petFoodRepo = new PetFoodRepo();
            bindingSource1.DataSource = petFoodRepo.GetAll();
            grdPetFood.DataSource = bindingSource1;

        }
    }
}