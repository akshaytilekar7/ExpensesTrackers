using ExpenseTracker.Core;
using ExpenseTracker.Core.Factory;
using ExpenseTracker.Core.Uow;
using ExpenseTracker.Models;
using ExpenseTracker.Models.Dto;
using ExpenseTracker.Services.Factory;
using ExpenseTrackerWin2.Utility;
using MaterialSkin;
using MaterialSkin.Controls;
using Microsoft.Extensions.Options;
using System.Data;
using ExpenseTracker.Services.Base;

namespace ExpenseTrackerWin2;

public partial class Index : MaterialForm
{
    public IServiceFactory _serviceFactory { get; set; }
    public IOptions<MyConfig> myConfig { get; }

    public Index(IOptions<MyConfig> myConfig)
    {
        InitializeComponent();
        this.WindowState = FormWindowState.Maximized;
        this.myConfig = myConfig;
        _serviceFactory = new ServiceFactory(new UnitOfWork(new SpecialContextFactory(this.myConfig, DateTime.Now.Year)), myConfig);
        var materialSkinManager = MaterialSkinManager.Instance;
        materialSkinManager.AddFormToManage(this);
        materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
        materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey900, Primary.BlueGrey900, Primary.BlueGrey500, Accent.DeepOrange700, TextShade.WHITE);
    }


    private async Task LoadGird()
    {
        if (string.IsNullOrEmpty(cmbDatabasePicker.Text) || cmbDatabasePicker.Text == "Please select")
            return;

        int year = Convert.ToInt32(cmbDatabasePicker.Text);
        var _unitOfWork = new UnitOfWork(new SpecialContextFactory(myConfig, year));
        //if (!_unitOfWork.CanConnect())
        //{
        //    MessageBox.Show("Database does not exist : " + year + ". Setting view to current year");
        //    datePickerYearly.Value = DateTime.Now;
        //    return;
        //}
        _serviceFactory = new ServiceFactory(_unitOfWork, myConfig);

        var lstDtoYealry = await _serviceFactory.YearlyService.GetTransactionByYear(year);
        dgvYearly.DataSource = lstDtoYealry.MakeSortable();
        dgvYearly.SetGridToFit();

        foreach (DataGridViewRow row in dgvYearly.Rows)
        {
            int count = 0;
            foreach (DataGridViewCell cell in row.Cells)
            {
                count++;
                if (count > 2)
                {
                    var expectedAmount = Convert.ToDecimal(row.Cells[2].Value == null ? 0 : row.Cells[2].Value);
                    if (expectedAmount == -1) continue;
                    var actualAmount = Convert.ToDecimal(cell.Value);
                    if (actualAmount > expectedAmount)
                        cell.Style.BackColor = Color.Orange;
                }
            }
        }

        await LoadBankGrid();
    }

    private async Task LoadBankGrid()
    {
        if (string.IsNullOrEmpty(cmbDatabasePicker.Text) || cmbDatabasePicker.Text == "Please select")
            return;


        int year = Convert.ToInt32(cmbDatabasePicker.Text);
        var _unitOfWork = new UnitOfWork(new SpecialContextFactory(myConfig, year));

        _serviceFactory = new ServiceFactory(_unitOfWork, myConfig);

        var lstBanks = await _serviceFactory.YearlyService.GetBankSummary(year);
        dgvBankAmount.DataSource = lstBanks;
        dgvBankAmount.SetGridToFit();
    }

    private async void cmbDatabasePicker_SelectedIndexChanged(object sender, EventArgs e)
    {
        dgvBankAmount.DataSource = null;
        dgvYearly.DataSource = null;
        dgvTooltip.DataSource = null;
        await LoadGird();
    }

    private void dgvYearly_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {
        SetTooltipGrid(sender, e.RowIndex, e.ColumnIndex);
    }

    private async void SetTooltipGrid(object sender, int rowIndex, int columnIndex)
    {
        if (rowIndex < 0 || columnIndex < 0)
            return;

        var lstDetails = await GetDetails(columnIndex, rowIndex);
        dgvTooltip.SetGridToFit();
        dgvTooltip.DataSource = lstDetails.MakeSortable();
    }

    private async Task<List<TransactionByMonth>> GetDetails(int columnIndex, int rowIndex)
    {
        int year = Convert.ToInt32(cmbDatabasePicker.Text);
        var _unitOfWork = new UnitOfWork(new SpecialContextFactory(myConfig, year));
        _serviceFactory = new ServiceFactory(_unitOfWork, myConfig);

        var lstBanks = await _serviceFactory.YearlyService.GetBankSummary(year);

        var name = dgvYearly.Rows[rowIndex].Cells[1].Value;

        var obj = _serviceFactory.MasterTableService.GetAllSubCategory().FirstOrDefault(x => x.Name.Equals(name.ToString()));

        List<TransactionByMonth> lstDtoYealry = await _serviceFactory.YearlyService.GetTransactionByMonth(year, columnIndex - 2, obj.Id);
        return lstDtoYealry;
    }

    private async void cmbDatabasePicker_SelectedValueChanged(object sender, EventArgs e)
    {
        await LoadGird();
    }

    private void cmbNames_SelectionChangeCommitted(object sender, EventArgs e)
    {
        var userId = Convert.ToInt32(cmbNames.SelectedValue);
        var lstBanks = _serviceFactory.BankService.GetAll().Where(x => x.UserId == userId).ToList();
        cmbBank.DataSource = lstBanks;
        cmbBank.DisplayMember = "Name";
        cmbBank.ValueMember = "Id";
    }

    private void tabAddIncome_Click(object sender, EventArgs e)
    {

    }

    private void LoadGrid()
    {
        var startDate = new DateTime(DateTime.Now.Year, 1, 1);
        var endDate = new DateTime(DateTime.Now.Year, 12, 31);
        var lstIncome = _serviceFactory.IncomeService.GetIncome(startDate, endDate).OrderByDescending(x => x.Date).ToList();
        dgvIncome.SetGridToFit();
        dgvIncome.DataSource = lstIncome.MakeSortable();

        var lstUsers = _serviceFactory.UserService.GetAll();
        cmbNames.DataSource = lstUsers;
        cmbNames.DisplayMember = "Name";
        cmbNames.ValueMember = "Id";

        var lstBanks = _serviceFactory.BankService.GetAll();
        cmbBank.DataSource = lstBanks;
        cmbBank.DisplayMember = "Name";
        cmbBank.ValueMember = "Id";
    }


    private void btnSave_Click(object sender, EventArgs e)
    {
        Income income = new Income();
        income.Date = Convert.ToDateTime(datePicker.Text);
        income.Amount = Convert.ToDecimal(txtAmount.Text);
        income.UserId = Convert.ToInt32(cmbNames.SelectedValue);
        income.BankId = Convert.ToInt32(cmbBank.SelectedValue);
        income.Comment = Convert.ToString(cmbComment.Text);
        _serviceFactory.IncomeService.Add(income);
        string message = "Save Data Sucessfully";
        MessageBox.Show(message);
        LoadGrid();
    }

    private void btnDelete_Click(object sender, EventArgs e)
    {
        List<Income> lst = new List<Income>();
        foreach (DataGridViewRow row in dgvIncome.SelectedRows)
        {
            int id = Convert.ToInt32(row.Cells[0].Value);
            lst.Add(new Income() { Id = id });
        }
        _serviceFactory.IncomeService.Delete(lst);
        LoadGrid();
    }

    List<Transaction> listExpense = new List<Transaction>();
    List<DtoTransaction> listOldData = new List<DtoTransaction>();

    private void btnATSave_Click(object sender, EventArgs e)
    {
        try
        {
            var user = Convert.ToInt32(cmbNames.SelectedValue);
            foreach (DataGridViewRow row in dgvExpenses.Rows)
            {
                int day = Convert.ToInt32(row.Cells[0].Value);
                if (day == 0)
                    continue;

                Transaction expense = new Transaction();
                expense.SubCategoryId = Convert.ToInt32(row.Cells[1].Value);
                var date = Convert.ToDateTime(datePickerAT.Text);
                expense.Date = new DateTime(date.Year, date.Month, day);
                expense.Amount = Convert.ToDecimal(row.Cells[2].Value);
                expense.Comment = Convert.ToString(row.Cells[3].Value);
                expense.BankId = Convert.ToInt32(cmbBank.SelectedValue);
                expense.UserId = user;
                listExpense.Add(expense);
            }
            _serviceFactory.TransactionServices.Add(listExpense);

            string message = "Save Data Sucessfully";
            listExpense.Clear();
            dgvExpenses.Rows.Clear();
            dgvExpenses.Refresh();
            MessageBox.Show(message);

        }
        catch (Exception ex)
        {
            var st = string.Empty;
            if (ex.InnerException != null)
                st = ex.InnerException.Message;
            lblATError.Text = "btnSave_Click : " + ex.Message + " " + st;
        }
    }

    private void ClearGrid()
    {
        dgvExpenses.Rows.Clear();
        dgvExpenses.Refresh();
    }

    private IList<DtoTransaction> GetWhatsAppData()
    {
        var date = Convert.ToDateTime(datePickerAT.Text);
        string projectDirectory2 = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName;
        //projectDirectory2 += "\\ExcelFiles\\Input\\W_" + date.Month + "_" + date.Year + ".xls";
        projectDirectory2 += "\\ExcelFiles\\Input\\W_" + date.Year + ".xls";

        DataTable bankStatement = _serviceFactory.ExcelService.LoadDataTable(projectDirectory2);
        var lstExpenseBankStatement = bankStatement.DatatableToClass<DtoTransaction>();
        return lstExpenseBankStatement;
    }

    private List<DtoTransaction> GetBankStatementData()
    {
        var date = Convert.ToDateTime(datePickerAT.Text);
        string projectDirectory = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName;
        //projectDirectory += "\\ExcelFiles\\Input\\" + date.Month + "_" + date.Year + ".xls";
        projectDirectory += "\\ExcelFiles\\Input\\" + date.Year + ".xls";

        DataTable dt = _serviceFactory.ExcelService.LoadDataTable(projectDirectory);
        var lstExpense = dt.DatatableToClass<DtoTransaction>();
        return lstExpense.Where(x => x.Amount > 0 && x.Date.Date >= date.Date).ToList();
    }

    private void btnATUpload_Click(object sender, EventArgs e)
    {
        try
        {
            ClearGrid();
            IList<DtoTransaction> lstBankStatementData = GetBankStatementData();
            IList<DtoTransaction> lstWhatsAppData = GetWhatsAppData();

            int index = 0;
            foreach (var item in lstBankStatementData)
            {
                DataGridViewRow row = new DataGridViewRow();
                DataGridViewTextBoxCell cDay = new DataGridViewTextBoxCell();
                cDay.Value = item.Date.Day;

                DataGridViewTextBoxCell cAmount = new DataGridViewTextBoxCell();
                cAmount.Value = item.Amount;

                DataGridViewTextBoxCell cComment = new DataGridViewTextBoxCell();
                var excelWhatsAppExpense = lstWhatsAppData
                    .FirstOrDefault(x => (x.Date.Day == item.Date.Day || x.Date.Day == item.Date.AddDays(-1).Day)
                    && x.Amount == item.Amount);

                var comment = excelWhatsAppExpense == null ? string.Empty : excelWhatsAppExpense.Comment?.Trim();
                cComment.Value = comment?.Trim();

                DataGridViewComboBoxCell cCategory = new DataGridViewComboBoxCell();
                var dbCategories = _serviceFactory.MasterTableService.GetAllSubCategory();
                cCategory.DisplayMember = "Name";
                cCategory.ValueMember = "Id";
                cCategory.DataSource = dbCategories;

                if (!string.IsNullOrEmpty(comment))
                {
                    comment = comment.Trim();
                    var dbCategory = dbCategories.FirstOrDefault(x => x.Name.ToLower().Contains(comment.ToLower()));
                    if (dbCategory != null)
                        cCategory.Value = dbCategory.Id;
                    else
                    {
                        int categoryId = GetCategoryBasedOnComment(comment, dbCategories.ToList());
                        if (categoryId != 0)
                            cCategory.Value = categoryId;
                    }
                }

                row.Cells.Add(cDay);
                row.Cells.Add(cCategory);
                row.Cells.Add(cAmount);
                row.Cells.Add(cComment);

                this.dgvExpenses.Rows.Add(row);
                index++;
            }
            this.dgvExpenses.SetGridToFit();
        }
        catch (Exception ex)
        {
            var st = string.Empty;
            if (ex.InnerException != null)
                st = ex.InnerException.Message;
            lblATError.Text = "btnUpload_Click : " + ex.Message + " " + st;
        }
    }

    private static int GetCategoryBasedOnComment(string comment, List<SubCategory> dbCategories)
    {
        int defaultCategoryId = dbCategories.First(x => x.Name.Contains("Extra")).Id;
        dbCategories = dbCategories.Where(x => x.CommaSeparatedTags != null).ToList();
        foreach (var category in dbCategories)
        {
            var listCommaSeparatedTags = category.CommaSeparatedTags.Split(",").Select(x => x.Trim()).ToList();
            listCommaSeparatedTags = listCommaSeparatedTags.Where(x => x != " ").ToList();
            var CommaSeparatedComment = comment.Split(" ").Select(x => x.Trim());
            var isSameExist = CommaSeparatedComment.Intersect(listCommaSeparatedTags).Any();
            if (isSameExist)
                return category.Id;
        }

        return defaultCategoryId;
    }

    private void btnATClear_Click(object sender, EventArgs e)
    {
        try
        {
            listExpense.Clear();
            dgvExpenses.Rows.Clear();
            dgvExpenses.Refresh();
        }
        catch (Exception ex)
        {
            lblATError.Text = "btnClear_Click : " + ex.Message;
        }
    }

    private async Task LoadAllGrid()
    {
        await LoadExpenseFilterGrid();
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

    private async Task LoadExpenseFilterGrid()
    {
        var res = await _serviceFactory.TransactionServices.GetTransactions(GetFilter());
        dgvFilter.DataSource = res.GenereateSrNo().MakeSortable();
        dgvFilter.SetGridToFit();
    }
    private async void btnVTSearch_Click(object sender, EventArgs e)
    {
        try
        {
            lblATError.Text = string.Empty;
            await LoadAllGrid();
        }
        catch (Exception ex)
        {
            var st = string.Empty;
            if (ex.InnerException != null)
                st = ex.InnerException.Message;
            lblVTError.Text = "btnSearch_Click : " + ex.Message + " " + st;
        }
    }

    private async void btnVTDelete_Click(object sender, EventArgs e)
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

    private void btnVTClear_Click(object sender, EventArgs e)
    {
        lblVTError.Text = string.Empty;
        txtAmount.Clear();
        txtComment.Clear();
        cmbCategory.ResetText();
        cmbExpensesType.ResetText();

        dgvIncome.Rows.Clear();
        dgvIncome.Refresh();

        dgvFilter.Rows.Clear();
        dgvFilter.Refresh();
    }
}