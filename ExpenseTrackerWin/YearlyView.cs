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
    }
}
