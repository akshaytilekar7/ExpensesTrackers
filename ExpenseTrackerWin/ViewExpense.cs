using ExpenseTrackerWin.Utility;
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;
using PatternForCore.Models;
using PatternForCore.Models.Dto;
using PatternForCore.Services.Factory;
using System.Data;

namespace ExpenseTrackerWin
{
    public partial class ViewExpense : Form
    {
        public IServiceFactory _serviceFactory { get; }

        public List<SortBy> lstSortBy = new SortBy().GetList();
        public ViewExpense(IServiceFactory serviceFactory)
        {
            InitializeComponent();
            _serviceFactory = serviceFactory;
            dgvFilter.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvFilter.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dateStart.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            dateEnd.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month));
            LoadAllGrid();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                lblError.Text = string.Empty;
                LoadAllGrid();
            }
            catch (Exception ex)
            {
                var st = string.Empty;
                if (ex.InnerException != null)
                    st = ex.InnerException.Message;
                lblError.Text = "btnSearch_Click : " + ex.Message + " " + st;
            }
        }

        private void FilterData_Load(object sender, EventArgs e)
        {
            try
            {
                LoadCombobox();
            }
            catch (Exception ex)
            {
                var st = string.Empty;
                if (ex.InnerException != null)
                    st = ex.InnerException.Message;
                lblError.Text = "FilterData_Load : " + ex.Message + " " + st;
            }

        }

        private void LoadAllGrid() // async Task
        {
            LoadExpenseFilterGrid(); //LoadExpenseFilterGrid
            LoadExpenseByCategoryGrid();
            LoadIncomeGrid();
        }

        private void LoadExpenseFilterGrid() //async Task
        {
            var res = _serviceFactory.ExpenseServices.GetExpenseFilter(GetFilter()); //await
            SortableBindingList<DtoExpense> sortableBindingList = new SortableBindingList<DtoExpense>(res.Result);
            dgvFilter.DataSource = sortableBindingList;
            dgvFilter.SetGridToFit();
        }
        private async Task LoadExpenseByCategoryGrid()
        {
            try
            {
                var result = await _serviceFactory.YearlyService.GetExpenseByCategory(GetFilter());
                SortableBindingList<DtoExpenseByCategory> sortableBindingList = new SortableBindingList<DtoExpenseByCategory>(result);
                dgvExpenseOverview.DataSource = sortableBindingList;
                dgvExpenseOverview.SetGridToFit();
            }

            catch (Exception ex)
            {
                var st = string.Empty;
                if (ex.InnerException != null)
                    st = ex.InnerException.Message;
                lblError.Text = "SetTotalAmount : " + ex.Message + " " + st;
            }
        }
        private void LoadIncomeGrid()
        {
            try
            {
                List<IncomeSource>? dbIncomes = _serviceFactory.YearlyService.GetIncome(dateStart.Value.Date, dateEnd.Value.Date);
                SortableBindingList<IncomeSource> sortableBindingList = new SortableBindingList<IncomeSource>(dbIncomes);
                dgvIncome.DataSource = sortableBindingList;
                dgvIncome.SetGridToFit();
            }
            catch (Exception ex)
            {
                var st = string.Empty;
                if (ex.InnerException != null)
                    st = ex.InnerException.Message;
                lblError.Text = "SetIncome : " + ex.Message + " " + st;
            }

        }
        private void LoadCombobox()
        {
            try
            {
                var data = _serviceFactory.MasterTableService.GetAllMasterCategoryType();
                data.Insert(0, new MasterCategoryType() { Id = 0, Name = "Please select" });
                cmbCategory.DisplayMember = "Name";
                cmbCategory.ValueMember = "Id";
                cmbCategory.DataSource = data;

                var dataExpenseTypes = _serviceFactory.MasterTableService.GetAllMasterExpenseType();
                // TODO 2
                dataExpenseTypes.Insert(0, new MasterExpenseType() { Id = 0, Name = "Please select" });
                cmbExpensesType.DisplayMember = "Name";
                cmbExpensesType.ValueMember = "Id";
                cmbExpensesType.DataSource = dataExpenseTypes;
            }
            catch (Exception ex)
            {
                var st = string.Empty;
                if (ex.InnerException != null)
                    st = ex.InnerException.Message;
                lblError.Text = "LoadCombobox : " + ex.Message + " " + st;
            }

        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            string workingDirectory = Environment.CurrentDirectory;
            string projectDirectory = Directory.GetParent(workingDirectory).Parent.Parent.FullName;
            projectDirectory += "\\ExcelFiles\\Output\\Output_" + DateTime.Now.Month + "_" + DateTime.Now.Year + "_" + DateTime.Now.TimeOfDay.Minutes + "_" + DateTime.Now.TimeOfDay.Seconds + ".xls";

            ExportToExcel(dgvFilter, projectDirectory);
            ExportToExcel(dgvIncome, projectDirectory);
            ExportToExcel(dgvExpenseOverview, projectDirectory);
            MessageBox.Show("Data saved in Excel format at location " + projectDirectory.ToUpper() + " Successfully Saved");
        }

        private void ExportToExcel(DataGridView dataGridView, string projectDirectory)
        {
            try
            {
                if (dataGridView.Rows.Count > 0)
                {
                    StreamWriter wr = new StreamWriter(projectDirectory, append: true);
                    for (int i = 0; i < dataGridView.Columns.Count; i++)
                    {
                        wr.Write(dataGridView.Columns[i].Name.ToString().ToUpper() + "\t");
                    }

                    wr.WriteLine();

                    foreach (DataGridViewRow row in dataGridView.Rows)
                    {
                        foreach (DataGridViewCell cell in row.Cells)
                        {
                            if (cell != null)
                            {
                                wr.Write(Convert.ToString(cell.Value) + "\t");
                            }
                            else
                            {
                                wr.Write("\t");
                            }
                        }
                        wr.WriteLine();
                    }

                    wr.WriteLine();
                    wr.Close();
                }
                else
                {
                    MessageBox.Show("Zero record to export , perform a operation first" + "Can't export file");
                }
            }
            catch (Exception ex)
            {
                var st = string.Empty;
                if (ex.InnerException != null)
                    st = ex.InnerException.Message;
                lblError.Text = "btnExcel_Click : " + ex.Message + " " + st;
            }
        }
        private void btnForm1_Click(object sender, EventArgs e)
        {
            HomePage Check = new HomePage(_serviceFactory);
            Check.Show();
            Hide();
        }

        private void cmbSort_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtTotalIncome_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblIncome_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            List<Expense> lst = new List<Expense>();
            foreach (DataGridViewRow row in dgvFilter.SelectedRows)
            {
                int id = Convert.ToInt32(row.Cells["Id"].Value);
                lst.Add(new Expense() { Id = id });
            }
            _serviceFactory.ExpenseServices.Delete(lst);
            LoadAllGrid();
        }

        private void dgvFilter_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lblError.Text = string.Empty;
            txtAmount.Clear();
            txtComment.Clear();
            cmbCategory.ResetText();
            cmbExpensesType.ResetText();

            dgvIncome.Rows.Clear();
            dgvIncome.Refresh();

            dgvExpenseOverview.Rows.Clear();
            dgvExpenseOverview.Refresh();

            dgvFilter.Rows.Clear();
            dgvFilter.Refresh();
        }

        private ExpenseFilter GetFilter()
        {
            var filter = new ExpenseFilter()
            {
                Amount = string.IsNullOrEmpty(txtAmount.Text) ? 0 : Convert.ToInt32(txtAmount.Text),
                Comment = txtComment.Text,
                StartDate = dateStart.Value.Date,
                EndDate = dateEnd.Value.Date,
                Category = cmbCategory.Text == "Please select" ? string.Empty : cmbCategory.Text,
                ExpenseType = cmbExpensesType.Text == "Please select" ? string.Empty : cmbExpensesType.Text,
            };
            return filter;
        }


    }
}

