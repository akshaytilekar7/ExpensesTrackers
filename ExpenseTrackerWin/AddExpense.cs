using ExpenseTrackerWin.Utility;
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;
using ExpenseTracker.Models.Dto;
using ExpenseTracker.Services.Factory;
using System.Data;
using ExpenseTracker.Services.Base;
using ExpenseTracker.Models;

namespace ExpenseTrackerWin
{
    public partial class AddExpense : Form
    {

        List<Expense> listExpense = new List<Expense>();
        List<DtoExpense> listOldData = new List<DtoExpense>();
        IServiceFactory _serviceFactory { get; }

        public AddExpense(IServiceFactory serviceFactory)
        {
            InitializeComponent();
            _serviceFactory = serviceFactory;
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
                var dbIncomes = _serviceFactory.IncomeService.GetAll().Where(s => s.Date.Month == date.Month && s.Date.Year == date.Year);
                foreach (var item in dbIncomes)
                {
                    txtTotalIncome.AppendText(item.User.Name + " : " + item.Amount); 
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
                var Categories = _serviceFactory.CategoryServices.GetAll().ToList();
                Category.DisplayMember = "Name";
                Category.ValueMember = "Id";
                Category.DataSource = Categories;

                var lstUsers = _serviceFactory.UserService.GetAll().ToList();
                cmbNames.DataSource = lstUsers;
                cmbNames.DisplayMember = "Name";
                cmbNames.ValueMember = "Id";

                var lstBanks = _serviceFactory.BankService.GetAll().ToList();
                cmbBank.DataSource = lstBanks;
                cmbBank.DisplayMember = "Name";
                cmbBank.ValueMember = "Id";
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
                var user = Convert.ToInt32(cmbNames.SelectedValue);
                foreach (DataGridViewRow row in dgvExpenses.Rows)
                {
                    int day = Convert.ToInt32(row.Cells[0].Value);
                    if (day == 0)
                        continue;

                    Expense expense = new Expense();
                    expense.CategoryTypeId = Convert.ToInt32(row.Cells[1].Value);
                    var date = Convert.ToDateTime(DatePicker.Text);
                    expense.Date = new DateTime(date.Year, date.Month, day);
                    expense.Amount = Convert.ToInt32(row.Cells[2].Value);
                    expense.Comment = Convert.ToString(row.Cells[3].Value);
                    expense.BankId = Convert.ToInt32(cmbBank.SelectedValue);
                    expense.UserId = user;
                    listExpense.Add(expense);
                }
                _serviceFactory.ExpenseServices.Add(listExpense);

                string message = "Save Data Sucessfully";
                listExpense.Clear();
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
                listExpense.Clear();
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
            ViewExpense Check = new ViewExpense(_serviceFactory);
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

                    var comment = excelWhatsAppExpense == null ? string.Empty : excelWhatsAppExpense.Comment?.Trim();
                    cComment.Value = comment;

                    DataGridViewComboBoxCell cCategory = new DataGridViewComboBoxCell();
                    var dbCategories = _serviceFactory.CategoryServices.GetAll();
                    cCategory.DisplayMember = "Name";
                    cCategory.ValueMember = "Id";
                    cCategory.DataSource = dbCategories;

                    if (!string.IsNullOrEmpty(comment))
                    {
                        comment = comment.Trim();
                        var dbCategory = dbCategories.FirstOrDefault(x => x.Name.ToLower().Contains(comment.ToLower()));
                        if (dbCategory != null)
                            cCategory.Value = dbCategory.Id;
                        else
                        {
                            int categoryId = GetCategoryBasedOnComment(comment, dbCategories.ToList());
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
                this.dgvExpenses.SetGridToFit();
            }
            catch (Exception ex)
            {
                var st = string.Empty;
                if (ex.InnerException != null)
                    st = ex.InnerException.Message;
                lblError.Text = "btnUpload_Click : " + ex.Message + " " + st;
            }
        }

        private static int GetCategoryBasedOnComment(string comment, List<CategoryType> dbCategories)
        {
            int defaultCategoryId = dbCategories.First(x => x.Name.Contains("Extra")).Id;
            dbCategories = dbCategories.Where(x => x.CommaSeparatedTags != null).ToList();
            foreach (var category in dbCategories)
            {
                var listCommaSeparatedTags = category.CommaSeparatedTags.Split(",").Select(x => x.Trim()).ToList();
                listCommaSeparatedTags = listCommaSeparatedTags.Where(x => x != " ").ToList();
                var CommaSeparatedComment = comment.Split(" ").Select(x => x.Trim());
                var isSameExist = CommaSeparatedComment.Intersect(listCommaSeparatedTags).Any();
                if (isSameExist)
                    return category.Id;
            }

            return defaultCategoryId;
        }

        private IList<DtoExpense> GetWhatsAppData()
        {
            var date = Convert.ToDateTime(DatePicker.Text);
            string projectDirectory2 = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName;
            //projectDirectory2 += "\\ExcelFiles\\Input\\W_" + date.Month + "_" + date.Year + ".xls";
            projectDirectory2 += "\\ExcelFiles\\Input\\W_" + date.Year + ".xls";

            DataTable bankStatement = _serviceFactory.ExcelService.LoadDataTable(projectDirectory2);
            var lstExpenseBankStatement = bankStatement.DatatableToClass<DtoExpense>();
            return lstExpenseBankStatement;
        }

        private List<DtoExpense> GetBankStatementData()
        {
            var date = Convert.ToDateTime(DatePicker.Text);
            string projectDirectory = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName;
            //projectDirectory += "\\ExcelFiles\\Input\\" + date.Month + "_" + date.Year + ".xls";
            projectDirectory += "\\ExcelFiles\\Input\\" + date.Year + ".xls";

            DataTable dt = _serviceFactory.ExcelService.LoadDataTable(projectDirectory);
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
            HomePage Check = new HomePage(_serviceFactory);
            Check.Show();
            Hide();
        }

        private void dgvExpenses_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private async void btnGeData_Click(object sender, EventArgs e)
        {
            var date = Convert.ToDateTime(dpDate.Text);
            DtoExpenseFilter expenseFilter = new DtoExpenseFilter() { StartDate = date, EndDate = date };

            if (!string.IsNullOrEmpty(txtAmount.Text))
            {
                listOldData = new List<DtoExpense>();
                expenseFilter.Amount = Convert.ToInt32(txtAmount.Text);
            }

            List<DtoExpense> newOldaData = await _serviceFactory.ExpenseServices.GetExpenseFilter(expenseFilter);
            listOldData.AddRange(newOldaData);
            listOldData = listOldData.GenereateSrNo().ToList();
            dgvOldData.DataSource = listOldData.MakeSortable();
            dgvOldData.SetGridToFit();
        }

        private void btnGeData_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void brnOldDataCleat_Click(object sender, EventArgs e)
        {
            listOldData = new List<DtoExpense>();
            dgvOldData.DataSource = null;
        }

        private void cmbNames_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
