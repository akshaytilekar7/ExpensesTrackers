using PatternForCore.Models;
using PatternForCore.Models.Dto;
using PatternForCore.Services;
using PatternForCore.Services.Factory;
using System.Data;

namespace ExpenseTrackerWin
{
    public partial class AddExpense : Form
    {

        List<Expense> list = new List<Expense>();

        public IServiceFactory ServiceFactory { get; }

        public AddExpense(IServiceFactory serviceFactory)
        {
            InitializeComponent();
            ServiceFactory = serviceFactory;
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

        private void SetIncome()
        {
            try
            {
                txtTotalIncome.Clear();
                string Total = string.Empty;
                var date = Convert.ToDateTime(DatePicker.Text);
                var dbIncomes = ServiceFactory.IncomeService.GetAll().Where(s => s.Date.Month == date.Month);
                foreach (var item in dbIncomes)
                {
                    txtTotalIncome.AppendText(item.Name + " : " + item.Amount);
                    txtTotalIncome.AppendText(Environment.NewLine);
                }
                txtTotalIncome.AppendText("Total Income : " + Convert.ToString(dbIncomes.Sum(x => x.Amount)));
            }

            catch (Exception ex)
            {
                var st = string.Empty;
                if (ex.InnerException != null)
                    st = ex.InnerException.Message;
                lblError.Text = "SetIncome : " + ex.Message + " " + st;
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            dgvExpenses.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            LoadCombobox();
            SetIncome();
        }

        private void LoadCombobox()
        {
            try
            {
                var Categories = ServiceFactory.CategoryServices.GetAll();
                Category.DisplayMember = "CategoryName";
                Category.ValueMember = "Id";
                Category.DataSource = Categories;
            }
            catch (Exception ex)
            {
                var st = string.Empty;
                if (ex.InnerException != null)
                    st = ex.InnerException.Message;
                lblError.Text = "LoadCombobox : " + ex.Message + " " + st;
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
                ServiceFactory.ExpenseServices.Add(list);

                string message = "Save Data Sucessfully";
                list.Clear();
                dgvExpenses.Rows.Clear();
                dgvExpenses.Refresh();
                MessageBox.Show(message);

            }
            catch (Exception ex)
            {
                var st = string.Empty;
                if (ex.InnerException != null)
                    st = ex.InnerException.Message;
                lblError.Text = "btnSave_Click : " + ex.Message + " " + st;
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
            ViewExpense Check = new ViewExpense(ServiceFactory);
            Check.Show();
            Hide();
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            try
            {
                ClearGrid();

                string workingDirectory = Environment.CurrentDirectory;
                string projectDirectory = Directory.GetParent(workingDirectory).Parent.Parent.FullName;
                projectDirectory += "\\ExcelFiles\\Input\\" + DateTime.Now.Month + "_" + DateTime.Now.Year + ".xls";
                DataTable dt = ServiceFactory.ExcelService.LoadDataTable(projectDirectory);
                var lstExpense = dt.DatatableToClass<DtoExpense>();

                int index = 0;
                foreach (var item in lstExpense)
                {

                    DataGridViewRow row = new DataGridViewRow();

                    DataGridViewTextBoxCell cDay = new DataGridViewTextBoxCell();
                    cDay.Value = item.Date.Day;

                    DataGridViewComboBoxCell cCategory = new DataGridViewComboBoxCell();
                    var data = ServiceFactory.CategoryServices.GetAll();
                    cCategory.DisplayMember = "CategoryName";
                    cCategory.ValueMember = "Id";
                    cCategory.DataSource = data;

                    DataGridViewTextBoxCell cAmount = new DataGridViewTextBoxCell();
                    cAmount.Value = item.Amount;

                    DataGridViewTextBoxCell cComment = new DataGridViewTextBoxCell();
                    cComment.Value = string.Empty;

                    row.Cells.Add(cDay);
                    row.Cells.Add(cCategory);
                    row.Cells.Add(cAmount);
                    row.Cells.Add(cComment);

                    this.dgvExpenses.Rows.Add(row);
                    index++;
                }
            }
            catch (Exception ex)
            {
                var st = string.Empty;
                if (ex.InnerException != null)
                    st = ex.InnerException.Message;
                lblError.Text = "btnUpload_Click : " + ex.Message + " " + st;
            }
        }

        private void ClearGrid()
        {
            dgvExpenses.Rows.Clear();
            dgvExpenses.Refresh();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //if (dgvExpenses.SelectedRows.Count > 0)
            //{
            //    dgvExpenses.Rows.Remove(dgvExpenses.SelectedRows[0]);

            //    // Don't call this if you have a DB to update.
            //    // (myGridView.DataSource as DataTable).AcceptChanges();
            //}

            foreach (DataGridViewRow row in dgvExpenses.SelectedRows)
            {
                dgvExpenses.Rows.Remove(row);
            }
        }

        private void txtTotalIcome_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnHomePage_Click(object sender, EventArgs e)
        {
            HomePage Check = new HomePage(ServiceFactory);
            Check.Show();
            Hide();
        }
    }
}

//SELECT CAST(ex.Date AS DATE) as Date, ct.CategoryName, ct.ExpensesType, ex.Amount
//  FROM[dbo].[Expense] as ex join[dbo].[Category] as ct
//  on ex.CategoryId = ct.Id