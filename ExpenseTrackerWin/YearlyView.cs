using ExpenseTrackerWin.Utility;
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;
using ExpenseTracker.Models;
using ExpenseTracker.Models.Dto;
using ExpenseTracker.Services.Factory;
using System.Data;
using System.Globalization;
using ExpenseTracker.Services.Base;
using ExpenseTracker.Core.Uow;
using ExpenseTracker.Core.Factory;
using ExpenseTracker.Core;
using Microsoft.Extensions.Options;

namespace ExpenseTrackerWin
{
    public partial class YearlyView : Form
    {
        public IServiceFactory _serviceFactory { get; set; }
        public IOptions<MyConfig> MyConfig { get; }

        public YearlyView(IOptions<MyConfig> myConfig)
        {
            InitializeComponent();
            MyConfig = myConfig;
            _serviceFactory = new ServiceFactory(new UnitOfWork(new SpecialContextFactory(MyConfig, DateTime.Now.Year)), myConfig);

        }

        private void YearlyView_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            cmbDatabasePicker.Items.Add("Please select");

            foreach (var item in MyConfig.Value.Database)
                cmbDatabasePicker.Items.Add(item);
            cmbDatabasePicker.Items.Add(DateTime.Now.Year);

            cmbDatabasePicker.SelectedIndex = cmbDatabasePicker.Items.Count - 1;
        }

        private async Task LoadGird()
        {
            if (string.IsNullOrEmpty(cmbDatabasePicker.Text) || cmbDatabasePicker.Text == "Please select")
                return;

            int year = Convert.ToInt32(cmbDatabasePicker.Text);
            var _unitOfWork = new UnitOfWork(new SpecialContextFactory(MyConfig, year));
            //if (!_unitOfWork.CanConnect())
            //{
            //    MessageBox.Show("Database does not exist : " + year + ". Setting view to current year");
            //    datePickerYearly.Value = DateTime.Now;
            //    return;
            //}
            _serviceFactory = new ServiceFactory(_unitOfWork, MyConfig);

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
            var _unitOfWork = new UnitOfWork(new SpecialContextFactory(MyConfig, year));

            _serviceFactory = new ServiceFactory(_unitOfWork, MyConfig);

            var lstBanks = await _serviceFactory.YearlyService.GetBankSummary(year);
            dgvBankAmount.DataSource = lstBanks;
            dgvBankAmount.SetGridToFit();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            SetTooltipGrid(sender, e.RowIndex, e.ColumnIndex);
        }

        private async Task<List<TransactionByMonth>> GetDetails(int columnIndex, int rowIndex)
        {
            int year = Convert.ToInt32(cmbDatabasePicker.Text);
            var _unitOfWork = new UnitOfWork(new SpecialContextFactory(MyConfig, year));
            _serviceFactory = new ServiceFactory(_unitOfWork, MyConfig);

            var lstBanks = await _serviceFactory.YearlyService.GetBankSummary(year);

            var name = dgvYearly.Rows[rowIndex].Cells[1].Value;

            var obj = _serviceFactory.MasterTableService.GetAllSubCategory().FirstOrDefault(x => x.Name.Equals(name.ToString()));

            List<TransactionByMonth> lstDtoYealry = await _serviceFactory.YearlyService.GetTransactionByMonth(year, columnIndex - 2, obj.Id);
            return lstDtoYealry;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            HomePage Check = new HomePage(MyConfig, _serviceFactory);
            Check.Show();
            Hide();
        }

        private async void datePickerYearly_ValueChanged(object sender, EventArgs e)
        {
            await LoadGird();
        }

        private void dgvYearly_CellMouseMove(object sender, DataGridViewCellMouseEventArgs e)
        {
        }

        private async void SetTooltipGrid(object sender, int rowIndex, int columnIndex)
        {
            if (rowIndex < 0 || columnIndex < 0)
                return;

            //dgvYearly.Rows[0].Cells[columnIndex].Style.BackColor = Color.CadetBlue;
            //dgvYearly.Rows[rowIndex].Cells[0].Style.BackColor = Color.CadetBlue;

            var lstDetails = await GetDetails(columnIndex, rowIndex);
            dgvTooltip.SetGridToFit();
            dgvTooltip.DataSource = lstDetails.MakeSortable();
        }

        private async void btnExport_Click(object sender, EventArgs e)
        {
            //if (string.IsNullOrEmpty(cmbDatabasePicker.Text) || cmbDatabasePicker.Text == "Please select")
            //    return;

            //string workingDirectory = Environment.CurrentDirectory;
            //string projectDirectory = Directory.GetParent(workingDirectory).Parent.Parent.FullName;
            //projectDirectory += "\\ExcelFiles\\Output\\OutputYearly_" + DateTime.Now.Month + "_" + DateTime.Now.Year + "_" + DateTime.Now.TimeOfDay.Minutes + "_" + DateTime.Now.TimeOfDay.Seconds + ".xls";

            //int year = Convert.ToInt32(cmbDatabasePicker.Text);
            //var filter = new DtoTransactionFilter()
            //{
            //    StartDate = new DateTime(year, 1, 1),
            //    EndDate = new DateTime(year, 12, 31),
            //};

            //var lstYealry = await _serviceFactory.YearlyService.GetYearlyData(Convert.ToInt32(cmbDatabasePicker.Text));
            //var lstAllMonthsData = await _serviceFactory.YearlyService.GetTransactions(year);

            //var lstMonthDataOnExpenseType = await _serviceFactory.YearlyService.GetAllMonthDataOnExpenseType(year);
            //var lstExpenseByExpensesTypes = await _serviceFactory.YearlyService.GetExpenseByExpensesType(filter);
            //var lstBanks = await _serviceFactory.BankService.GetBankData(filter.StartDate, filter.EndDate);

            //List<DtoIncome> lstIncomeYearly = _serviceFactory.IncomeService.GetIncome(filter.StartDate, filter.EndDate).OrderBy(x => x.Date).ToList();

            //List<ExcelDto> excelDtos = new List<ExcelDto>();

            //excelDtos.Add(new ExcelDto() { DataTable = lstYealry.ToDataTable(), SheetName = "Yearly Overview" });
            //excelDtos.Add(new ExcelDto() { DataTable = lstIncomeYearly.ToDataTable(), SheetName = "Yearly Income" });
            //excelDtos.Add(new ExcelDto() { DataTable = lstBanks.ToDataTable(), SheetName = "Bank Overview" });

            //foreach (var item in lstAllMonthsData)
            //    excelDtos.Add(new ExcelDto() { DataTable = item.dtoTransaction.ToDataTable(), SheetName = item.Name });

            //excelDtos.Add(new ExcelDto() { DataTable = lstMonthDataOnExpenseType.dtoExpenseByCategories.ToDataTable(), SheetName = "Percentage overview" });
            //excelDtos.Add(new ExcelDto() { DataTable = lstExpenseByExpensesTypes.ToDataTable(), SheetName = "Yealry Expense By Categories" });

            //GridExcel.ExportToExcel(excelDtos, projectDirectory);

            //MessageBox.Show("Data saved in Excel format at location " + projectDirectory.ToUpper() + " Successfully Saved");
        }

        private void dgvYearly_CellLeave(object sender, DataGridViewCellEventArgs e)
        {
            //dgvYearly.Rows[0].Cells[e.ColumnIndex].Style.BackColor = dgvYearly.DefaultCellStyle.BackColor;
            //dgvYearly.Rows[e.RowIndex].Cells[0].Style.BackColor = dgvYearly.DefaultCellStyle.BackColor;
        }

        private async void cmbDatabasePicker_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvBankAmount.DataSource = null;
            dgvYearly.DataSource = null;
            dgvTooltip.DataSource = null;
            await LoadGird();
        }
    }
}
