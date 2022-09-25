using ExpenseTrackerWin.Utility;
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;
using PatternForCore.Models.Dto;
using PatternForCore.Services.Factory;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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

        private void YearlyView_Load(object sender, EventArgs e)
        {
            datePickerYearly.Format = DateTimePickerFormat.Custom;
            datePickerYearly.CustomFormat = "yyyy";
            datePickerYearly.ShowUpDown = true;
            LoadGird();
        }

        private void LoadGird()
        {
            var lstDtoYealry = _serviceFactory.YearlyService.GetYearlyData(Convert.ToInt32(datePickerYearly.Text), out int totalSum, out int totalYealyIncome);
            SortableBindingList<DtoYealry> sortableBindingList = new(lstDtoYealry);
            dgvYealy.DataSource = sortableBindingList;
            dgvYealy.SetGridToFit();
            lblTotal.Text = "Year " + datePickerYearly.Text + " Total Income: " + totalYealyIncome + " Total Expense:" + totalSum;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;

            DataGridView grid = (DataGridView)sender;
            var dtoYealry = (DtoYealry)grid.Rows[e.RowIndex].DataBoundItem;
            var tooltip = ShowTooltip(e.ColumnIndex, dtoYealry);
            if (!string.IsNullOrEmpty(tooltip))
                MessageBox.Show(tooltip);
        }

        private static string ShowTooltip(int columnIndex, DtoYealry dtoYealry)
        {

            var tooltip = string.Empty;

            if (dtoYealry == null)
                return tooltip;

            switch (columnIndex)
            {
                case 1:
                    tooltip = dtoYealry.JanTooltip;
                    break;
                case 2:
                    tooltip = dtoYealry.FebTooltip;
                    break;
                case 3:
                    tooltip = dtoYealry.MarchTooltip;
                    break;
                case 4:
                    tooltip = dtoYealry.AprilTooltip;
                    break;
                case 5:
                    tooltip = dtoYealry.MayTooltip;
                    break;
                case 6:
                    tooltip = dtoYealry.JuneTooltip;
                    break;
                case 7:
                    tooltip = dtoYealry.JulyTooltip;
                    break;
                case 8:
                    tooltip = dtoYealry.AugustTooltip;
                    break;
                case 9:
                    tooltip = dtoYealry.SeptemberTooltip;
                    break;
                case 10:
                    tooltip = dtoYealry.OctoberTooltip;
                    break;
                case 11:
                    tooltip = dtoYealry.NovemberTooltip;
                    break;
                case 12:
                    tooltip = dtoYealry.DecemberTooltip;
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

            var tooltip = ShowTooltip(e.ColumnIndex, dtoYealry);
            var cell = grid.Rows[e.RowIndex].Cells[e.ColumnIndex];
            cell.ToolTipText = string.IsNullOrEmpty(tooltip) ? "No Tooltip" : tooltip;

        }
    }
}
