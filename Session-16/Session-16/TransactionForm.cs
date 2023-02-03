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

namespace Session_16 {
    public partial class TransactionForm : DevExpress.XtraEditors.XtraForm {

        public Populate _populate;
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
                    trasRepo.Update(id, (Transaction)bsTransaction.Current);
                }
            }
        }

        private void gridView1_RowDeleting(object sender, DevExpress.Data.RowDeletingEventArgs e) {
            GridView view = sender as GridView;
            TransactionRepo trasRepo = new TransactionRepo();
            Guid id = Guid.Parse(view.GetRowCellValue(view.FocusedRowHandle, colTransactionID).ToString());
            trasRepo.Delete(id);
        }

        public void SetControls() {
            TransactionRepo newTrasRepo=new TransactionRepo();
            bsTransaction.DataSource=newTrasRepo.GetAll();
            grdTransaction.DataSource = bsTransaction;
        }
    }
}