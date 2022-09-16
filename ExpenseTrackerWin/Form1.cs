using PatternForCore.Models;
using PatternForCore.Services;
using PatternForCore.Services.Base.Contracts;

namespace ExpenseTrackerWin
{
    public partial class Form1 : Form
    {
        public ICategoryServices CategoryServices { get; }
        public IExpenseServices ExpenseServices { get; }

        List<Expense> list = new List<Expense>();

        public Form1(ICategoryServices categoryServices, IExpenseServices expenseServices)
        {
            InitializeComponent();
            CategoryServices = categoryServices;
            ExpenseServices = expenseServices;
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
            var data = CategoryServices.GetAll();
            CategoryCombo.DisplayMember = "CategoryName";
            CategoryCombo.ValueMember = "Id";
            CategoryCombo.DataSource = data;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvExpenses.Rows)
            {
                int day = Convert.ToInt32(row.Cells[0].Value); ; // (int)row.Cells[0].Value;
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
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            list.Clear();
            dgvExpenses.Rows.Clear();
            dgvExpenses.Refresh();
        }
       
    }
}

//SELECT CAST(ex.Date AS DATE) as Date, ct.CategoryName, ct.ExpensesType, ex.Amount
//  FROM[dbo].[Expense] as ex join[dbo].[Category] as ct
//  on ex.CategoryId = ct.Id