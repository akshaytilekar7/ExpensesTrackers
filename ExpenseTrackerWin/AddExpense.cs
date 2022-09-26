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
            SetIncome();
        }

        private void SetIncome()
        {
            try
            {
                txtTotalIncome.Clear();
                string Total = string.Empty;
                var date = Convert.ToDateTime(DatePicker.Text);
                var dbIncomes = ServiceFactory.IncomeService.GetAll().Where(s => s.Date.Month == date.Month && s.Date.Year == date.Year);
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
                IList<DtoExpense> lstBankStatementData = GetBankStatementData();
                IList<DtoExpense> lstWhatsAppData = GetWhatsAppData();

                int index = 0;
                foreach (var item in lstBankStatementData)
                {
                    DataGridViewRow row = new DataGridViewRow();
                    DataGridViewTextBoxCell cDay = new DataGridViewTextBoxCell();
                    cDay.Value = item.Date.Day;

                    DataGridViewTextBoxCell cAmount = new DataGridViewTextBoxCell();
                    cAmount.Value = item.Amount;

                    DataGridViewTextBoxCell cComment = new DataGridViewTextBoxCell();
                    var excelWhatsAppExpense = lstWhatsAppData.FirstOrDefault(x => x.Date.Day == item.Date.Day && x.Amount == item.Amount);

                    var comment = excelWhatsAppExpense == null ? string.Empty : excelWhatsAppExpense.Comment;
                    cComment.Value = comment;

                    DataGridViewComboBoxCell cCategory = new DataGridViewComboBoxCell();
                    var dbCategories = ServiceFactory.CategoryServices.GetAll();
                    cCategory.DisplayMember = "CategoryName";
                    cCategory.ValueMember = "Id";
                    cCategory.DataSource = dbCategories;

                    if (!string.IsNullOrEmpty(comment))
                    {
                        var dbCategory = dbCategories.FirstOrDefault(x => x.CategoryName.ToLower().Contains(comment.ToLower()));
                        if (dbCategory != null)
                            cCategory.Value = dbCategory.Id;
                        else
                        {
                            int categoryId = GetCategoryBasedOnComment(comment, dbCategories);
                            if (categoryId != 0)
                                cCategory.Value = categoryId;
                        }
                    }

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

        private static int GetCategoryBasedOnComment(string comment, IList<Category> dbCategories)
        {
            foreach (var catLst in CategoryTags.GetTags())
            {
                foreach (var tg in catLst.Tags)
                {
                    var arr = comment.Split(" ");
                    foreach (var itemarr in arr)
                    {
                        if (itemarr != " " && tg.Contains(itemarr))
                        {
                            var dbCategory1 = dbCategories.FirstOrDefault(x => x.CategoryName.ToLower().Contains(catLst.CategoryName.ToLower()));
                            if (dbCategory1 != null)
                            {
                                return dbCategory1.Id;
                            }
                        }
                    }
                }
            }

            return 0;
        }

        private List<DtoExpense> GetWhatsAppData()
        {
            try
            {
                var date = Convert.ToDateTime(DatePicker.Text);
                string projectDirectory2 = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName;
                projectDirectory2 += "\\ExcelFiles\\Input\\W_" + date.Month + "_" + date.Year + ".xls";
                DataTable bankStatement = ServiceFactory.ExcelService.LoadDataTable(projectDirectory2);
                var lstExpenseBankStatement = bankStatement.DatatableToClass<DtoExpense>();
                return lstExpenseBankStatement.Where(x=> x.Date.Date >= date.Date).ToList();
            }
            catch (Exception ex)
            {
                lblError.Text = ex.Message;
                return new List<DtoExpense>();
            }
           
        }

        private List<DtoExpense> GetBankStatementData()
        {
            var date = Convert.ToDateTime(DatePicker.Text);
            string projectDirectory = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName;
            projectDirectory += "\\ExcelFiles\\Input\\" + date.Month + "_" + date.Year + ".xls";

            DataTable dt = ServiceFactory.ExcelService.LoadDataTable(projectDirectory);
            var lstExpense = dt.DatatableToClass<DtoExpense>();
            return lstExpense.Where(x => x.Amount > 0 && x.Date.Date >= date.Date).ToList();
        }

        private void ClearGrid()
        {
            dgvExpenses.Rows.Clear();
            dgvExpenses.Refresh();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvExpenses.SelectedRows)
                dgvExpenses.Rows.Remove(row);
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

        private void dgvExpenses_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

//SELECT CAST(ex.Date AS DATE) as Date, ct.CategoryName, ct.ExpensesType, ex.Amount
//  FROM[dbo].[Expense] as ex join[dbo].[Category] as ct
//  on ex.CategoryId = ct.Id