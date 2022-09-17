using PatternForCore.Core.ExcelUtility;
using PatternForCore.Models;
using PatternForCore.Services;
using PatternForCore.Services.Base.Contracts;
using System.Data;

namespace ExpenseTrackerWin
{
    public partial class Form1 : Form
    {
        public ICategoryServices CategoryServices { get; }
        public IExpenseServices ExpenseServices { get; }
        public IExcelService ExcelService { get; }

        List<Expense> list = new List<Expense>();

        public Form1(ICategoryServices categoryServices, IExpenseServices expenseServices, IExcelService excelService)
        {
            InitializeComponent();
            CategoryServices = categoryServices;
            ExpenseServices = expenseServices;
            ExcelService = excelService;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DatePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dgvExpenses.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            LoadCombobox();
        }

        private void LoadCombobox()
        {
            try
            {
                var data = CategoryServices.GetAll();
                CategoryCombo.DisplayMember = "CategoryName";
                CategoryCombo.ValueMember = "Id";
                CategoryCombo.DataSource = data;
            }
            catch (Exception ex)
            {
                lblError.Text = "LoadCombobox : " + ex.Message;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (DataGridViewRow row in dgvExpenses.Rows)
                {
                    int day = Convert.ToInt32(row.Cells[0].Value);
                    if (day == 0)
                        continue;

                    Expense expense = new Expense();
                    expense.CategoryId = Convert.ToInt32(row.Cells[1].Value);
                    var date = Convert.ToDateTime(DatePicker.Text);
                    expense.Date = new DateTime(date.Year, date.Month, day);
                    expense.Amount = Convert.ToInt32(row.Cells[2].Value);
                    expense.Comment = Convert.ToString(row.Cells[3].Value);
                    list.Add(expense);
                }
                ExpenseServices.Add(list);

                string message = "Save Data Sucessfully";
                list.Clear();
                dgvExpenses.Rows.Clear();
                dgvExpenses.Refresh();
                MessageBox.Show(message);

            }
            catch (Exception ex)
            {
                lblError.Text = "btnSave_Click : " + ex.Message;
            }

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            try
            {
                list.Clear();
                dgvExpenses.Rows.Clear();
                dgvExpenses.Refresh();
            }
            catch (Exception ex)
            {
                lblError.Text = "btnClear_Click : " + ex.Message;
            }
        }

        private void btnFilterPage_Click(object sender, EventArgs e)
        {
            FilterData Check = new FilterData(CategoryServices, ExpenseServices, ExcelService);
            Check.Show();
            Hide();
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            try
            {
                var path = "D:\\100.xlsx";
                DataTable dt = ExcelService.LoadDataTable(path);
                var lstExpense = dt.DatatableToClass<DtoExpense>();

                foreach (var item in lstExpense)
                {
                    this.dgvExpenses.Rows.Add(item.Date.Day, item.CategoryName, item.Amount, string.Empty);
                }
            }
            catch (Exception ex)
            {

            }
        }
    }
}

//SELECT CAST(ex.Date AS DATE) as Date, ct.CategoryName, ct.ExpensesType, ex.Amount
//  FROM[dbo].[Expense] as ex join[dbo].[Category] as ct
//  on ex.CategoryId = ct.Id