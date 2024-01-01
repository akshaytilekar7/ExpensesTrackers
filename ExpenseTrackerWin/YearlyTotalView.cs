using ExpenseTrackerWin.Utility;
using ExpenseTracker.Services.Factory;
using ExpenseTracker.Core.Uow;
using ExpenseTracker.Core.Factory;
using ExpenseTracker.Core;
using Microsoft.Extensions.Options;
using ExpenseTracker.Models.Dto;

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
            _serviceFactory = new ServiceFactory(new UnitOfWork(new SpecialContextFactory(MyConfig, DateTime.Now.Year)), MyConfig);

        }

        private void YearlyView_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            LoadGird();
        }

        private async void LoadGird()
        {
            var years = new int[] { 2022 ,2023, 2024 };
            List<SubCategoryData> subCategories = new List<SubCategoryData>();
            var res = _serviceFactory.MasterTableService.GetAllSubCategory();
            foreach (var item in res)
                subCategories.Add(new SubCategoryData() { SubCategoryName = item.Name, CategoryName = item.Category.Name });

            foreach (var year in years)
            {

                if (year == 2023)
                {
                    _serviceFactory = new ServiceFactory(new UnitOfWork(new SpecialContextFactory(MyConfig, year)), MyConfig);

                    List<ExpenseByCategoryForYear>? data = await _serviceFactory.YearlyService.GetExpenseByCategoryForYear(year);

                    foreach (var x in data)
                    {
                        var itemToUpdate = subCategories.FirstOrDefault(item => item.SubCategoryName == x.Name);
                        if (itemToUpdate != null)
                            itemToUpdate.Year2023 = x.Year;
                    }
                }

                if (year == 2022)
                {
                    _serviceFactory = new ServiceFactory(new UnitOfWork(new SpecialContextFactory(MyConfig, year)), MyConfig);

                    List<ExpenseByCategoryForYear> list = await _serviceFactory.YearlyService.GetExpenseByCategoryForYear(year);
                    foreach (ExpenseByCategoryForYear item in list)
                    {
                        var itemToUpdate = subCategories.FirstOrDefault(c => c.SubCategoryName == item.Name);
                        if (itemToUpdate != null)
                            itemToUpdate.Year2022 = item.Year;
                    }
                }
                if (year == 2024)
                {
                    _serviceFactory = new ServiceFactory(new UnitOfWork(new SpecialContextFactory(MyConfig, year)), MyConfig);

                    List<ExpenseByCategoryForYear> list = await _serviceFactory.YearlyService.GetExpenseByCategoryForYear(year);
                    foreach (ExpenseByCategoryForYear item in list)
                    {
                        var itemToUpdate = subCategories.FirstOrDefault(c => c.SubCategoryName == item.Name);
                        if (itemToUpdate != null)
                            itemToUpdate.Year2024 = item.Year;
                    }
                }
            }
            dgvAllYears.DataSource = subCategories.MakeSortable();
            dgvAllYears.SetGridToFit();
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

            dgvAllYears.Rows[rowIndex].DefaultCellStyle.BackColor = Color.CadetBlue;
        }

        private void dataGridView1_CellLeave(object sender, DataGridViewCellEventArgs e)
        {
            dgvAllYears.Rows[e.RowIndex].DefaultCellStyle.BackColor = dgvAllYears.DefaultCellStyle.BackColor;
        }

        private async void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvExpenseByCategory.Rows.Clear();
            dgvExpenseByCategory.Refresh();
            lblWait.ForeColor = Color.Red;
            lblWait.Text = "Loading...";
            int rowIndex = e.RowIndex;
            int columnIndex = e.ColumnIndex;

            if (rowIndex < 0 || columnIndex < 0)
                return;

            var selectedCategory = Convert.ToString(dgvAllYears.Rows[rowIndex].Cells[1].Value);
            int selectedYear = -1;

            var year = dgvAllYears.Columns[e.ColumnIndex].HeaderText;

            if (year.Contains("2023"))
                selectedYear = 2023;
            if (year.Contains("2022"))
                selectedYear = 2022;
            if (year.Contains("2024"))
                selectedYear = 2024;

            var _unitOfWork = new UnitOfWork(new SpecialContextFactory(MyConfig, selectedYear));
            _serviceFactory = new ServiceFactory(_unitOfWork, MyConfig);

            var lstDtoYealry = await _serviceFactory.TransactionServices.GetYearlyForTooltip(selectedYear, selectedCategory);

            dgvExpenseByCategory.DataSource = lstDtoYealry.GenereateSrNo().MakeSortable();
            dgvExpenseByCategory.SetGridToFit();
            lblWait.Text = string.Empty;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow r in dgvAllYears.Rows)
            {
                if (r.Cells[1] != null && r.Cells[1].Value != null)
                {
                    if ((r.Cells[1].Value).ToString().ToUpper().Contains(txtSearch.Text.ToUpper()))
                    {
                        dgvAllYears.Rows[r.Index].Visible = true;
                        dgvAllYears.Rows[r.Index].Selected = true;
                    }
                    else
                    {
                        dgvAllYears.CurrentCell = null;
                        dgvAllYears.Rows[r.Index].Visible = false;
                    }
                }
            }
        }
    }
}
