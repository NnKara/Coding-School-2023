using DevExpress.ChartRangeControlClient.Core;
using DevExpress.XtraEditors;
using Orm.Repository;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;

namespace Session_16 {
    public partial class FormEmployees : DevExpress.XtraEditors.XtraForm {

        private Populate _populate;
        private EmployeeRepo _employeeRepo;
        public FormEmployees() {
            InitializeComponent();
        }

        private void gridControl1_Click(object sender, EventArgs e) {

        }

        private void FormEmployees_Load(object sender, EventArgs e) {
            SetControllers();
        }

        private void SetControllers() {
            EmployeeRepo employeeRepo = new EmployeeRepo();
            employeeBindingSource.DataSource = employeeRepo.GetAll();
            gridControl1.DataSource = employeeBindingSource;
        }

        private void btnPopulateEmployees_Click(object sender, EventArgs e) {
            EmployeeRepo employeeRepo=new EmployeeRepo();
            Populate populateEntitys = new Populate();
            List<Employee> employees = populateEntitys.PopulateEmployees();
            foreach (Employee employee in employees) {
                employeeRepo.Add(employee);
            }
        }

        private void grdEmployees_ValidateRow(object sender, ValidateRowEventArgs e) {
            GridView view = sender as GridView;
            Guid id = Guid.Parse(view.GetRowCellValue(view.FocusedRowHandle, colEmployeeID).ToString());
            EmployeeRepo employeeRepo = new EmployeeRepo();
            try {
                if (e.Valid) {
                    if (employeeRepo.GetById(id) == null) {
                        employeeRepo.Add((Employee)employeeBindingSource.Current);
                    } else {
                        employeeRepo.Update(id, (Employee)employeeBindingSource.Current);
                    }
                }
            }catch(Exception ex) {
                MessageBox.Show("Fill every Cell!");
            }
        }

        private void grdEmployees_RowDeleting(object sender, DevExpress.Data.RowDeletingEventArgs e) {
            GridView view = sender as GridView;
            Guid id = Guid.Parse(view.GetRowCellValue(view.FocusedRowHandle, colEmployeeID).ToString());
            _employeeRepo.Delete(id);
        }

        private void btnClose_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}