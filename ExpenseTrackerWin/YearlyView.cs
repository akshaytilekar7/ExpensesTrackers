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
            var lstDtoYealry = _serviceFactory.YearlyService.GetYearlyData(Convert.ToInt32(datePickerYearly.Text), out int totalSum, out int totalYealyIncome);
            SortableBindingList<DtoYealry> sortableBindingList = new(lstDtoYealry);
            dgvYealy.DataSource = sortableBindingList;
            dgvYealy.SetGridToFit();
            var balance = totalYealyIncome - totalSum;
            lblTotal.Text = "Year " + datePickerYearly.Text + "\nTotal Income: " + totalYealyIncome.ToString("#,##0.00") + " \nTotal Expense: " + totalSum.ToString("#,##0.00") + " \nBalance: " + balance.ToString("#,##0.00");

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
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;

            DataGridView grid = (DataGridView)sender;
            var dtoYealry = (DtoYealry)grid.Rows[e.RowIndex].DataBoundItem;
            var tooltip = ShowTooltip(e.ColumnIndex, dtoYealry, out IEnumerable<Expense> expenses);
            if (!string.IsNullOrEmpty(tooltip))
                MessageBox.Show(tooltip);
            if (expenses != null)
            {
                dgvTooltip.SetGridToFit();
                var lst = expenses.ToList();
                if (lst.Any())
                {
                    var sortlist = lst.Select(x => new DtoTooltip
                    {
                        Date = x.Date.Day + " " + x.Date.ToString("MMM", CultureInfo.InvariantCulture) + " " + x.Date.DayOfWeek.ToString(),
                        Amount = x.Amount,
                        Comment = x.Comment,
                    }).ToList();
                    SortableBindingList<DtoTooltip> sortableBindingList = new(sortlist);
                    dgvTooltip.DataSource = sortableBindingList;
                }
            }
        }

        private static string ShowTooltip(int columnIndex, DtoYealry dtoYealry, out IEnumerable<Expense> expenses)
        {

            var tooltip = string.Empty;
            expenses = new List<Expense>();
            if (dtoYealry == null)
            {
                return tooltip;
            }
            switch (columnIndex)
            {
                case 1:
                    tooltip = dtoYealry.JanTooltip;
                    expenses = dtoYealry.JanLst;
                    break;
                case 2:
                    tooltip = dtoYealry.FebTooltip;
                    expenses = dtoYealry.FebLst;
                    break;
                case 3:
                    tooltip = dtoYealry.MarchTooltip;
                    expenses = dtoYealry.MarchLst;
                    break;
                case 4:
                    tooltip = dtoYealry.AprilTooltip;
                    expenses = dtoYealry.AprilLst;
                    break;
                case 5:
                    tooltip = dtoYealry.MayTooltip;
                    expenses = dtoYealry.MayLst;
                    break;
                case 6:
                    tooltip = dtoYealry.JuneTooltip;
                    expenses = dtoYealry.JuneLst;
                    break;
                case 7:
                    tooltip = dtoYealry.JulyTooltip;
                    expenses = dtoYealry.JulyLst;
                    break;
                case 8:
                    tooltip = dtoYealry.AugustTooltip;
                    expenses = dtoYealry.AugustLst;
                    break;
                case 9:
                    tooltip = dtoYealry.SeptemberTooltip;
                    expenses = dtoYealry.SeptemberLst;
                    break;
                case 10:
                    tooltip = dtoYealry.OctoberTooltip;
                    expenses = dtoYealry.OctoberLst;
                    break;
                case 11:
                    tooltip = dtoYealry.NovemberTooltip;
                    expenses = dtoYealry.NovemberLst;
                    break;
                case 12:
                    tooltip = dtoYealry.DecemberTooltip;
                    expenses = dtoYealry.DecemberLst;
                    break;
                default:
                    break;
            }

            return tooltip;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            HomePage Check = new HomePage(_serviceFactory);
            Check.Show();
            Hide();
        }

        private void datePickerYearly_ValueChanged(object sender, EventArgs e)
        {
            LoadGird();
        }

        private void dgvYealy_CellMouseMove(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;

            DataGridView grid = (DataGridView)sender;
            var dtoYealry = (DtoYealry)grid.Rows[e.RowIndex].DataBoundItem;

            var tooltip = ShowTooltip(e.ColumnIndex, dtoYealry, out IEnumerable<Expense> expenses);
            var cell = grid.Rows[e.RowIndex].Cells[e.ColumnIndex];
            if (!string.IsNullOrEmpty(tooltip))
            {
                cell.ToolTipText = tooltip;
                if (expenses != null)
                {
                    dgvTooltip.SetGridToFit();
                    var lst = expenses.ToList();
                    if (lst.Any())
                    {
                        var sortlist = lst.Select(x => new DtoTooltip
                        {
                            Date = x.Date.Day + " " + x.Date.ToString("MMM", CultureInfo.InvariantCulture) + " " + x.Date.DayOfWeek.ToString(),
                            Amount = x.Amount,
                            Comment = x.Comment,
                        }).ToList();
                        SortableBindingList<DtoTooltip> sortableBindingList = new(sortlist);
                        dgvTooltip.DataSource = sortableBindingList;
                    }
                    else
                    {
                        cell.ToolTipText = "No Tooltip";
                    }
                }
            }
        }
    }
}
