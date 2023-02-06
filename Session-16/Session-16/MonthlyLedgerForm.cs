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
    public partial class MonthlyLedgerForm : DevExpress.XtraEditors.XtraForm {
        public MonthlyLedgerForm() {
            InitializeComponent();
        }
        private void MonthlyLedgerForm_Load(object sender, EventArgs e) {
            SetControls();
        }

        private void button1_Click(object sender, EventArgs e) {
            MonthlyLedgerRepo ledgerRepo= new MonthlyLedgerRepo();
            Populate populateEntitys = new Populate();
            List<MonthlyLedger> ledgers = populateEntitys.PopulateMonthlyLedgers();
            foreach (MonthlyLedger ledger in ledgers) {
                ledgerRepo.Add(ledger);
            }
        }


        public void SetControls() {
            MonthlyLedgerRepo ledgers= new MonthlyLedgerRepo();
            bsMonthlyLedger.DataSource=ledgers.GetAll();
            grdMonthlyLedger.DataSource = bsMonthlyLedger;
        }

        
    }
}