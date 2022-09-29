using ExpenseTrackerWin.Utility;
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;
using PatternForCore.Models;
using PatternForCore.Models.Dto;
using PatternForCore.Services.Factory;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            SortableBindingList<DtoYealry> sortableBindingList = new(lstDtoYealry);
            dgvYealy.DataSource = sortableBindingList;
            dgvYealy.SetGridToFit();

            //var balance = totalYealyIncome - totalSum;
            //lblTotal.Text = "Year " + datePickerYearly.Text + "\nTotal Income: " + totalYealyIncome.ToString("#,##0.00") + " \nTotal Expense: " + totalSum.ToString("#,##0.00") + " \nBalance: " + balance.ToString("#,##0.00");

            await LoadExpenseByCategoryGrid();

        }

        private async Task LoadExpenseByCategoryGrid()
        {
            int year = Convert.ToInt32(datePickerYearly.Text);
            var filter = new ExpenseFilter()
            {
                StartDate = new DateTime(year, 1, 1),
                EndDate = new DateTime(year, 12, 31),
            };
            List<DtoExpenseByCategory>? result = await _serviceFactory.YearlyService.GetExpenseByCategory(filter);
            SortableBindingList<DtoExpenseByCategory> sortableBindingList = new SortableBindingList<DtoExpenseByCategory>(result);
            dgvExpenseOverview.DataSource = sortableBindingList;
            dgvExpenseOverview.SetGridToFit();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            SetTooltipGrid(sender, e.RowIndex, e.ColumnIndex);
        }

        private static List<DtoTooltip> GetTooltipList(int columnIndex, DtoYealry dtoYealry)
        {
            IEnumerable<Expense> expenses = new List<Expense>();
            List<DtoTooltip> lstDtoTooltip = new List<DtoTooltip>();

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
                return expenses.Select(x => new DtoTooltip
                {
                    Date = x.Date.Day + " " + x.Date.ToString("MMM", CultureInfo.InvariantCulture) + " " + x.Date.DayOfWeek.ToString(),
                    Amount = x.Amount,
                    Comment = x.Comment,
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
            // SetTooltipGrid(sender, e.RowIndex, e.ColumnIndex);
        }

        private void SetTooltipGrid(object sender, int rowIndex, int columnIndex)
        {
            if (rowIndex < 0 || columnIndex < 0)
                return;

            DataGridView grid = (DataGridView)sender;
            var dtoYealry = (DtoYealry)grid.Rows[rowIndex].DataBoundItem;
            var lstDtoTooltip = GetTooltipList(columnIndex, dtoYealry);
            SortableBindingList<DtoTooltip> sortableBindingList = new(lstDtoTooltip);
            dgvTooltip.SetGridToFit();
            dgvTooltip.DataSource = sortableBindingList;
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            string workingDirectory = Environment.CurrentDirectory;
            string projectDirectory = Directory.GetParent(workingDirectory).Parent.Parent.FullName;
            projectDirectory += "\\ExcelFiles\\Output\\OutputYearly_" + DateTime.Now.Month + "_" + DateTime.Now.Year + "_" + DateTime.Now.TimeOfDay.Minutes + "_" + DateTime.Now.TimeOfDay.Seconds + ".xls";
            GridExcel.ExportToExcel(dgvYealy, projectDirectory);
            MessageBox.Show("Data saved in Excel format at location " + projectDirectory.ToUpper() + " Successfully Saved");
        }
    }
}
