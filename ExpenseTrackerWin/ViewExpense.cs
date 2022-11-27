using ExpenseTrackerWin.Utility;
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;
using ExpenseTracker.Models;
using ExpenseTracker.Models.Dto;
using ExpenseTracker.Services.Factory;
using ExpenseTracker.Services.Base;
namespace ExpenseTrackerWin
{
    public partial class ViewExpense : Form
    {
        public IServiceFactory _serviceFactory { get; }

        public ViewExpense(IServiceFactory serviceFactory)
        {
            InitializeComponent();
            _serviceFactory = serviceFactory;
            dgvFilter.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvFilter.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dateStart.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            dateEnd.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month));
            LoadCombobox();
            this.WindowState = FormWindowState.Maximized;
        }

        private async void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                lblError.Text = string.Empty;
                await LoadAllGrid();
            }
            catch (Exception ex)
            {
                var st = string.Empty;
                if (ex.InnerException != null)
                    st = ex.InnerException.Message;
                lblError.Text = "btnSearch_Click : " + ex.Message + " " + st;
            }
        }

        private async void FilterData_Load(object sender, EventArgs e)
        {
            try
            {
                await LoadAllGrid();
            }
            catch (Exception ex)
            {
                var st = string.Empty;
                if (ex.InnerException != null)
                    st = ex.InnerException.Message;
                lblError.Text = "FilterData_Load : " + ex.Message + " " + st;
            }

        }

        private async Task LoadAllGrid()
        {
            await LoadExpenseFilterGrid();
            await LoadExpenseByCategoryGrid();
            LoadIncomeGrid();
        }

        private async Task LoadExpenseFilterGrid()
        {
            var res = await _serviceFactory.ExpenseServices.GetExpenseFilter(GetFilter());
            dgvFilter.DataSource = res.GenereateSrNo().MakeSortable();
            dgvFilter.SetGridToFit();
        }

        private async Task LoadExpenseByCategoryGrid()
        {
            try
            {
                var result = await _serviceFactory.YearlyService.GetExpenseByExpensesType(GetFilter());
                dgvExpenseOverview.DataSource = result.MakeSortable();
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
                List<DtoIncome> dbIncomes = _serviceFactory.IncomeService.GetIncome(dateStart.Value.Date, dateEnd.Value.Date);
                dgvIncome.DataSource = dbIncomes.MakeSortable();
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
                var lstCategoryType = _serviceFactory.MasterTableService.GetAllCategoryType().ToList();
                lstCategoryType.Insert(0, new CategoryType() { Id = 0, Name = "Please select" });
                cmbCategory.DisplayMember = "Name";
                cmbCategory.ValueMember = "Id";
                cmbCategory.DataSource = lstCategoryType;

                var lstExpenseTypes = _serviceFactory.MasterTableService.GetAllExpenseType().ToList();
                lstExpenseTypes.Insert(0, new ExpenseType() { Id = 0, Name = "Please select" });
                cmbExpensesType.DisplayMember = "Name";
                cmbExpensesType.ValueMember = "Id";
                cmbExpensesType.DataSource = lstExpenseTypes;

                var lstUsers = _serviceFactory.UserService.GetAll().ToList();
                lstUsers.Insert(0, new User() { Id = 0, Name = "Please select" });
                cmbUsers.DataSource = lstUsers;
                cmbUsers.DisplayMember = "Name";
                cmbUsers.ValueMember = "Id";

                var lstBanks = _serviceFactory.BankService.GetAll().ToList();
                lstBanks.Insert(0, new Bank() { Id = 0, Name = "Please select" });
                cmbBank.DataSource = lstBanks;
                cmbBank.DisplayMember = "Name";
                cmbBank.ValueMember = "Id";
            }
            catch (Exception ex)
            {
                var st = string.Empty;
                if (ex.InnerException != null)
                    st = ex.InnerException.Message;
                lblError.Text = "LoadCombobox : " + ex.Message + " " + st;
            }

        }

        private async void btnExcel_Click(object sender, EventArgs e)
        {
            string workingDirectory = Environment.CurrentDirectory;
            string projectDirectory = Directory.GetParent(workingDirectory).Parent.Parent.FullName;
            projectDirectory += "\\ExcelFiles\\Output\\Output.xls";

            List<ExcelDto> dataExpenseTypes = new List<ExcelDto>();

            var lstExpense = await _serviceFactory.ExpenseServices.GetExpenseFilter(GetFilter());
            var lstIncomes = _serviceFactory.IncomeService.GetIncome(dateStart.Value.Date, dateEnd.Value.Date);
            var lstExpenseCategory = await _serviceFactory.YearlyService.GetExpenseByExpensesType(GetFilter());

            dataExpenseTypes.Add(new ExcelDto() { DataTable = lstExpense.GenereateSrNo().ToDataTable(), SheetName = "Expense" });
            dataExpenseTypes.Add(new ExcelDto() { DataTable = lstIncomes.ToDataTable(), SheetName = "Income" });
            dataExpenseTypes.Add(new ExcelDto() { DataTable = lstExpenseCategory.ToDataTable(), SheetName = "Overview" });

            GridExcel.ExportToExcel(dataExpenseTypes, projectDirectory);
            MessageBox.Show("Data saved in Excel format at location " + projectDirectory.ToUpper() + " Successfully Saved");
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

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            List<Expense> lst = new List<Expense>();
            foreach (DataGridViewRow row in dgvFilter.SelectedRows)
            {
                int id = Convert.ToInt32(row.Cells["Id"].Value);
                lst.Add(new Expense() { Id = id });
            }
            _serviceFactory.ExpenseServices.Delete(lst);
            await LoadAllGrid();
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

        private DtoExpenseFilter GetFilter()
        {
            var filter = new DtoExpenseFilter()
            {
                Amount = string.IsNullOrEmpty(txtAmount.Text) ? 0 : Convert.ToInt32(txtAmount.Text),
                Comment = txtComment.Text,
                StartDate = dateStart.Value.Date,
                EndDate = dateEnd.Value.Date,
                CategoryId = Convert.ToInt32(cmbCategory.SelectedValue),
                ExpenseTypeId = Convert.ToInt32(cmbExpensesType.SelectedValue),
                UserId = Convert.ToInt32(cmbUsers.SelectedValue),
                BankId = Convert.ToInt32(cmbBank.SelectedValue),
            };
            return filter;
        }


    }
}

