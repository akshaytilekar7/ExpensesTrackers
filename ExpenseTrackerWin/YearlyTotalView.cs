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
    public partial class YearlyTotalView : Form
    {
        public IServiceFactory _serviceFactory { get; set; }
        public IOptions<MyConfig> MyConfig { get; }

        public YearlyTotalView(IOptions<MyConfig> myConfig)
        {
            InitializeComponent();
            MyConfig = myConfig;
            _serviceFactory = new ServiceFactory(new UnitOfWork(new SpecialContextFactory(MyConfig, DateTime.Now.Year)), myConfig);
        }

        private void YearlyView_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            LoadGird();
        }

        private void LoadGird()
        {
            var lstDtoYealry = _serviceFactory.YearlyTotalService.GetYearlyData();
            dataGridView1.DataSource = lstDtoYealry.MakeSortable();
            dataGridView1.SetGridToFit();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            HomePage Check = new HomePage(MyConfig, _serviceFactory);
            Check.Show();
            Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            int columnIndex = e.ColumnIndex;

            if (rowIndex < 0 || columnIndex < 0)
                return;

            dataGridView1.Rows[rowIndex].DefaultCellStyle.BackColor = Color.CadetBlue;
        }

        private void dataGridView1_CellLeave(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.Rows[e.RowIndex].DefaultCellStyle.BackColor = dataGridView1.DefaultCellStyle.BackColor;
        }

        private async void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvExpenseByCategory.Rows.Clear();
            dgvExpenseByCategory.Refresh();
            lblWait.Text = "Loading...";
            int rowIndex = e.RowIndex;
            int columnIndex = e.ColumnIndex;

            if (rowIndex < 0 || columnIndex < 0)
                return;

            var selectedCategory = Convert.ToString(dataGridView1.Rows[rowIndex].Cells[0].Value);
            int selectedYear = -1;

            if (!int.TryParse(dataGridView1.SelectedCells[0].OwningColumn.HeaderText, out selectedYear))
            {
                lblWait.Text = string.Empty;
                return;
            }
            var _unitOfWork = new UnitOfWork(new SpecialContextFactory(MyConfig, selectedYear));
            _serviceFactory = new ServiceFactory(_unitOfWork, MyConfig);

            var lstDtoYealry = await _serviceFactory.YearlyTotalService.GetYearlyForTooltip(selectedYear, selectedCategory);

            dgvExpenseByCategory.DataSource = lstDtoYealry.GenereateSrNo().MakeSortable();
            dgvExpenseByCategory.SetGridToFit();
            lblWait.Text = string.Empty;
        }
    }
}
