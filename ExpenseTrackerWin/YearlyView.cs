using ExpenseTrackerWin.Utility;
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;
using ExpenseTracker.Models;
using ExpenseTracker.Models.Dto;
using ExpenseTracker.Services.Factory;
using System.Data;
using System.Globalization;
using ExpenseTracker.Services.Base;

namespace ExpenseTrackerWin
{
    public partial class YearlyView : Form
    {
        public IServiceFactory _serviceFactory { get; }

        public YearlyView(IServiceFactory serviceFactory)
        {
            InitializeComponent();
            _serviceFactory = serviceFactory;
        }

        private async void YearlyView_Load(object sender, EventArgs e)
        {
            datePickerYearly.Format = DateTimePickerFormat.Custom;
            datePickerYearly.CustomFormat = "yyyy";
            datePickerYearly.ShowUpDown = true;
            await LoadGird();
        }

        private async Task LoadGird()
        {
            var lstDtoYealry = await _serviceFactory.YearlyService.GetYearlyData(Convert.ToInt32(datePickerYearly.Text));
            dgvYealy.DataSource = lstDtoYealry.MakeSortable();
            dgvYealy.SetGridToFit();

            await LoadExpenseByCategoryGrid();
            await LoadBankGrid();
        }
       
        private async Task LoadBankGrid()
        {
            var res = await _serviceFactory.ExpenseServices.GetBankData();
            dgvBankAmount.DataSource = res;
            dgvBankAmount.SetGridToFit();
        }

        private async Task LoadExpenseByCategoryGrid()
        {
            int year = Convert.ToInt32(datePickerYearly.Text);
            var filter = new DtoExpenseFilter()
            {
                StartDate = new DateTime(year, 1, 1),
                EndDate = new DateTime(year, 12, 31),
            };
            var lst = await _serviceFactory.YearlyService.GetExpenseByExpensesType(filter);
            dgvExpenseOverview.DataSource = lst.MakeSortable(); ;
            dgvExpenseOverview.SetGridToFit();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            SetTooltipGrid(sender, e.RowIndex, e.ColumnIndex);
        }

        private static List<DtoDetails> GetDetails(int columnIndex, DtoYealry dtoYealry)
        {
            IEnumerable<Expense> expenses = new List<Expense>();
            List<DtoDetails> lstDtoTooltip = new List<DtoDetails>();

            switch (columnIndex)
            {
                case 1:
                    expenses = dtoYealry.JanLst;
                    break;
                case 2:
                    expenses = dtoYealry.FebLst;
                    break;
                case 3:
                    expenses = dtoYealry.MarchLst;
                    break;
                case 4:
                    expenses = dtoYealry.AprilLst;
                    break;
                case 5:
                    expenses = dtoYealry.MayLst;
                    break;
                case 6:
                    expenses = dtoYealry.JuneLst;
                    break;
                case 7:
                    expenses = dtoYealry.JulyLst;
                    break;
                case 8:
                    expenses = dtoYealry.AugustLst;
                    break;
                case 9:
                    expenses = dtoYealry.SeptemberLst;
                    break;
                case 10:
                    expenses = dtoYealry.OctoberLst;
                    break;
                case 11:
                    expenses = dtoYealry.NovemberLst;
                    break;
                case 12:
                    expenses = dtoYealry.DecemberLst;
                    break;
                default:
                    break;
            }

            if (expenses != null && expenses.Any())
            {
                return expenses.Select(x => new DtoDetails
                {
                    Date = x.Date.Day + " " + x.Date.ToString("MMM", CultureInfo.InvariantCulture) + " " + x.Date.DayOfWeek.ToString(),
                    Amount = x.Amount,
                    Comment = x.Comment,
                    BankName = x.Bank.Name,
                    UserName = x.User.Name
                }).ToList();
            }
            return lstDtoTooltip;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            HomePage Check = new HomePage(_serviceFactory);
            Check.Show();
            Hide();
        }

        private async void datePickerYearly_ValueChanged(object sender, EventArgs e)
        {
            await LoadGird();
        }

        private void dgvYealy_CellMouseMove(object sender, DataGridViewCellMouseEventArgs e)
        {
        }

        private void SetTooltipGrid(object sender, int rowIndex, int columnIndex)
        {
            if (rowIndex < 0 || columnIndex < 0)
                return;

            DataGridView grid = (DataGridView)sender;
            var dtoYealry = (DtoYealry)grid.Rows[rowIndex].DataBoundItem;
            var lstDetails = GetDetails(columnIndex, dtoYealry);
            dgvTooltip.SetGridToFit();
            dgvTooltip.DataSource = lstDetails.MakeSortable();
        }

        private async void btnExport_Click(object sender, EventArgs e)
        {
            string workingDirectory = Environment.CurrentDirectory;
            string projectDirectory = Directory.GetParent(workingDirectory).Parent.Parent.FullName;
            projectDirectory += "\\ExcelFiles\\Output\\OutputYearly_" + DateTime.Now.Month + "_" + DateTime.Now.Year + "_" + DateTime.Now.TimeOfDay.Minutes + "_" + DateTime.Now.TimeOfDay.Seconds + ".xls";

            int year = Convert.ToInt32(datePickerYearly.Text);
            var filter = new DtoExpenseFilter()
            {
                StartDate = new DateTime(year, 1, 1),
                EndDate = new DateTime(year, 12, 31),
            };

            var lstYealry = await _serviceFactory.YearlyService.GetYearlyData(Convert.ToInt32(datePickerYearly.Text));
            var lstAllMonthsData = await _serviceFactory.YearlyService.GetAllMonthsData(year);
            
            var lstMonthDataOnExpenseType = await _serviceFactory.YearlyService.GetAllMonthDataOnExpenseType(year);
            var lstExpenseByExpensesTypes = await _serviceFactory.YearlyService.GetExpenseByExpensesType(filter);

            List<ExcelDto> excelDtos = new List<ExcelDto>();
          
            excelDtos.Add(new ExcelDto() { DataTable = lstYealry.ToDataTable(), SheetName = "Yealry Overview" });

            foreach (var item in lstAllMonthsData)
                excelDtos.Add(new ExcelDto() { DataTable = item.dtoExpenses.ToDataTable(), SheetName = item.Name });

            excelDtos.Add(new ExcelDto() { DataTable = lstMonthDataOnExpenseType.dtoExpenseByCategories.ToDataTable(), SheetName = "Percentage overview" });
            excelDtos.Add(new ExcelDto() { DataTable = lstExpenseByExpensesTypes.ToDataTable(), SheetName = "Yealry Expense By Categories" });

            GridExcel.ExportToExcel(excelDtos, projectDirectory);
            
            MessageBox.Show("Data saved in Excel format at location " + projectDirectory.ToUpper() + " Successfully Saved");
        }
    }
}
