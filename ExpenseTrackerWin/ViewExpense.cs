﻿using ExpenseTrackerWin.Utility;
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;
using ExpenseTracker.Models;
using ExpenseTracker.Models.Dto;
using ExpenseTracker.Services.Factory;
using ExpenseTracker.Services.Base;
using ExpenseTracker.Core;
using Microsoft.Extensions.Options;

namespace ExpenseTrackerWin
{
    public partial class ViewExpense : Form
    {
        public IOptions<MyConfig> MyConfig { get; }
        public IServiceFactory _serviceFactory { get; }

        public ViewExpense(IOptions<MyConfig> myConfig, IServiceFactory serviceFactory)
        {
            InitializeComponent();
            MyConfig = myConfig;
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
            LoadIncomeGrid();
        }

        private async Task LoadExpenseFilterGrid()
        {
            var res = await _serviceFactory.TransactionServices.GetTransactions(GetFilter());
            dgvFilter.DataSource = res.GenereateSrNo().MakeSortable();
            dgvFilter.SetGridToFit();
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
                var lstCategoryType = _serviceFactory.MasterTableService.GetAllSubCategory().ToList();
                lstCategoryType.Insert(0, new SubCategory() { Id = 0, Name = "Please select" });
                cmbCategory.DisplayMember = "Name";
                cmbCategory.ValueMember = "Id";
                cmbCategory.DataSource = lstCategoryType;

                var lstExpenseTypes = _serviceFactory.MasterTableService.GetAllCategory().ToList();
                lstExpenseTypes.Insert(0, new Category() { Id = 0, Name = "Please select" });
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
            //string workingDirectory = Environment.CurrentDirectory;
            //string projectDirectory = Directory.GetParent(workingDirectory).Parent.Parent.FullName;
            //projectDirectory += "\\ExcelFiles\\Output\\Output.xls";

            //List<ExcelDto> dataExpenseTypes = new List<ExcelDto>();

            //var lstExpense = await _serviceFactory.TransactionServices.GetTransactions(GetFilter());
            //var lstIncomes = _serviceFactory.IncomeService.GetIncome(dateStart.Value.Date, dateEnd.Value.Date);
            //var lstExpenseCategory = await _serviceFactory.YearlyService.GetExpenseByExpensesType(GetFilter());

            //dataExpenseTypes.Add(new ExcelDto() { DataTable = lstExpense.GenereateSrNo().ToDataTable(), SheetName = "Expense" });
            //dataExpenseTypes.Add(new ExcelDto() { DataTable = lstIncomes.ToDataTable(), SheetName = "Income" });
            //dataExpenseTypes.Add(new ExcelDto() { DataTable = lstExpenseCategory.ToDataTable(), SheetName = "Overview" });

            //GridExcel.ExportToExcel(dataExpenseTypes, projectDirectory);
            //MessageBox.Show("Data saved in Excel format at location " + projectDirectory.ToUpper() + " Successfully Saved");
        }

        private void btnForm1_Click(object sender, EventArgs e)
        {
            HomePage Check = new HomePage(MyConfig, _serviceFactory);
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
            List<Transaction> lst = new List<Transaction>();
            foreach (DataGridViewRow row in dgvFilter.SelectedRows)
            {
                int id = Convert.ToInt32(row.Cells["Id"].Value);
                lst.Add(new Transaction() { Id = id });
            }
            _serviceFactory.TransactionServices.Delete(lst);
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

            dgvFilter.Rows.Clear();
            dgvFilter.Refresh();
        }

        private DtoTransactionFilter GetFilter()
        {
            var filter = new DtoTransactionFilter()
            {
                Amount = string.IsNullOrEmpty(txtAmount.Text) ? 0 : Convert.ToDecimal(txtAmount.Text),
                Comment = txtComment.Text,
                StartDate = dateStart.Value.Date,
                EndDate = dateEnd.Value.Date,
                SubCategoryId = Convert.ToInt32(cmbCategory.SelectedValue),
                CategoryId = Convert.ToInt32(cmbExpensesType.SelectedValue),
                UserId = Convert.ToInt32(cmbUsers.SelectedValue),
                BankId = Convert.ToInt32(cmbBank.SelectedValue),
            };
            return filter;
        }

        private void cmbExpensesType_SelectionChangeCommitted(object sender, EventArgs e)
        {
            var expenseTypeId = Convert.ToInt32(cmbExpensesType.SelectedValue);
            var lstCategoryType = _serviceFactory.MasterTableService.GetAllSubCategory().Where(x => x.CategoryId == expenseTypeId).ToList();
            lstCategoryType.Insert(0, new SubCategory() { Id = 0, Name = "Please select" });
            cmbCategory.DisplayMember = "Name";
            cmbCategory.ValueMember = "Id";
            cmbCategory.DataSource = lstCategoryType;
        }

        private void cmbUsers_SelectionChangeCommitted(object sender, EventArgs e)
        {
            var userId = Convert.ToInt32(cmbUsers.SelectedValue);
            var lstBanks = _serviceFactory.BankService.GetAll().Where(x => x.UserId == userId).ToList();
            lstBanks.Insert(0, new Bank() { Id = 0, Name = "Please select" });
            cmbBank.DataSource = lstBanks;
            cmbBank.DisplayMember = "Name";
            cmbBank.ValueMember = "Id";
        }
    }
}

