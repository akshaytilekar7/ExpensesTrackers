﻿using PatternForCore.Models;
using PatternForCore.Models.Dto;
using PatternForCore.Services;
using PatternForCore.Services.Base.Contracts;
using PatternForCore.Services.Factory;
using System.Data;

namespace ExpenseTrackerWin
{
    public partial class ViewExpense : Form
    {
        public IServiceFactory ServiceFactory { get; }

        public List<SortBy> lstSortBy = new SortBy().GetList();
        public ViewExpense(IServiceFactory serviceFactory)
        {
            InitializeComponent();
            ServiceFactory = serviceFactory;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                lblError.Text = string.Empty;

                IEnumerable<DtoExpense> dbList = GetSearchData();
                dgvFilter.DataSource = dbList.ToList().GenereateSrNo();
            }
            catch (Exception ex)
            {
                var st = string.Empty;
                if (ex.InnerException != null)
                    st = ex.InnerException.Message;
                lblError.Text = "btnSearch_Click : " + ex.Message + " " + st;
            }
        }

        private IEnumerable<DtoExpense> GetSearchData()
        {
            DateTime startDate = dateStart.Value.Date;
            DateTime endDate = dateEnd.Value.Date;
            int amount = string.IsNullOrEmpty(txtAmount.Text) ? 0 : Convert.ToInt32(txtAmount.Text);

            string category = cmbCategory.Text == "Please select" ? string.Empty : cmbCategory.Text;
            string expenseType = cmbExpensesType.Text == "Please select" ? string.Empty : cmbExpensesType.Text;
            string comment = txtComment.Text;

            var dbList = ServiceFactory.ExpenseServices.GetAll().ToList().Select(s => new DtoExpense()
            {
                CategoryName = s.Category.CategoryName,
                Date = s.Date,
                Amount = s.Amount,
                ExpenseType = s.Category.ExpensesType,
                Comment = s.Comment
            });

            if (startDate != DateTime.MinValue && endDate != DateTime.MinValue)
                dbList = dbList.Where(x => x.Date >= startDate && x.Date <= endDate);

            if (amount >= 1)
                dbList = dbList.Where(x => x.Amount == amount);

            if (!string.IsNullOrEmpty(category))
                dbList = dbList.Where(x => x.CategoryName.ToLower().Contains(category.ToLower()));
            if (!string.IsNullOrEmpty(expenseType))
                dbList = dbList.Where(x => x.ExpenseType.ToLower().Contains(expenseType.ToLower()));
            if (!string.IsNullOrEmpty(comment))
                dbList = dbList.Where(x => x.Comment.ToLower().Contains(comment.ToLower()));

            SetTotalAmount(dbList.OrderBy(x => x.ExpenseType).ToList());

            if (!dbList.Any())
                lblError.Text = "No Data Fount";
            return dbList;
        }

        private void FilterData_Load(object sender, EventArgs e)
        {
            try
            {
                List<DtoExpense> dbList = LoadGrid();
                dgvFilter.DataSource = dbList.GenereateSrNo();

                dateStart.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
                dateEnd.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month));

                SetTotalAmount(dbList);
                LoadCombobox();
            }
            catch (Exception ex)
            {
                var st = string.Empty;
                if (ex.InnerException != null)
                    st = ex.InnerException.Message;
                lblError.Text = "FilterData_Load : " + ex.Message + " " + st;
            }

        }

        private List<DtoExpense> LoadGrid()
        {
            List<DtoExpense> dbList = ServiceFactory.ExpenseServices.GetAll().ToList().Select(s => new DtoExpense()
            {
                CategoryName = s.Category.CategoryName,
                Date = s.Date,
                Amount = s.Amount,
                ExpenseType = s.Category.ExpensesType,
                Comment = s.Comment
            }).OrderBy(x => x.Date).ToList();
            return dbList;
        }

        private void SetTotalAmount(List<DtoExpense> dbList)
        {
            try
            {
                txtTotalAmount.Clear();
                string Total = string.Empty;
                foreach (var item in dbList.DistinctBy(x => x.ExpenseType).Select(x => x.ExpenseType))
                {
                    var sum = Convert.ToString(dbList.Where(x => x.ExpenseType == item).Sum(x => x.Amount));
                    txtTotalAmount.AppendText(item + " : " + sum);
                    txtTotalAmount.AppendText(Environment.NewLine);
                }
                txtTotalAmount.AppendText("Total Expenses : " + Convert.ToString(dbList.Sum(x => x.Amount)));
                SetIncome(dbList);
            }

            catch (Exception ex)
            {
                var st = string.Empty;
                if (ex.InnerException != null)
                    st = ex.InnerException.Message;
                lblError.Text = "SetTotalAmount : " + ex.Message + " " + st;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lblError.Text = string.Empty;
            txtAmount.Clear();
            txtComment.Clear();
            txtTotalAmount.Clear();
            cmbCategory.ResetText();
            cmbExpensesType.ResetText();
        }

        private void SetIncome(List<DtoExpense> dbList)
        {
            try
            {
                txtTotalIncome.Clear();
                string Total = string.Empty;
                var date = Convert.ToDateTime(dateStart.Text);
                var dbIncomes = ServiceFactory.IncomeService.GetAll().Where(s => s.Date.Month == date.Month);
                foreach (var item in dbIncomes)
                {
                    txtTotalIncome.AppendText(item.Name + " : " + item.Amount);
                    txtTotalIncome.AppendText(Environment.NewLine);
                }
                var income = dbIncomes.Sum(x => x.Amount);
                var expense = dbList.Sum(x => x.Amount);
                txtTotalIncome.AppendText("Total Income : " + Convert.ToString(income));
                txtTotalIncome.AppendText(Environment.NewLine);
                txtTotalIncome.AppendText("Total Expenses : " + expense);
                txtTotalIncome.AppendText(Environment.NewLine);
                txtTotalIncome.AppendText("Balance : " + Convert.ToString(income - expense));
                txtTotalIncome.AppendText(Environment.NewLine);
            }

            catch (Exception ex)
            {
                var st = string.Empty;
                if (ex.InnerException != null)
                    st = ex.InnerException.Message;
                lblError.Text = "SetIncome : " + ex.Message + " " + st;
            }
        }
        private void LoadCombobox()
        {
            try
            {
                var data = ServiceFactory.CategoryServices.GetAll();
                data.Insert(0, new Category() { Id = 0, CategoryName = "Please select", ExpensesType = "Please select" });
                cmbCategory.DisplayMember = "CategoryName";
                cmbCategory.ValueMember = "Id";
                cmbCategory.DataSource = data;

                IList<Category> data2 = data.DistinctBy(x => x.ExpensesType).OrderBy(x => x.ExpensesType).ToList();
                data2.Insert(0, new Category() { Id = 0, CategoryName = "Please select", ExpensesType = "Please select" });
                cmbExpensesType.DisplayMember = "ExpensesType";
                cmbExpensesType.ValueMember = "Id";
                cmbExpensesType.DataSource = data2;


                cmbSort.DisplayMember = "Name";
                cmbSort.ValueMember = "Id";
                cmbSort.DataSource = lstSortBy;
            }
            catch (Exception ex)
            {
                var st = string.Empty;
                if (ex.InnerException != null)
                    st = ex.InnerException.Message;
                lblError.Text = "LoadCombobox : " + ex.Message + " " + st;
            }

        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            try
            {
                //SaveFileDialog savefile = new SaveFileDialog();
                //savefile.FileName = "Response.xls";
                //savefile.Filter = "Excel Files|*.xls;*.xlsx;*.xlsm";

                string workingDirectory = Environment.CurrentDirectory;
                string projectDirectory = Directory.GetParent(workingDirectory).Parent.Parent.FullName;
                projectDirectory += "\\ExcelFiles\\Output\\Output_" + DateTime.Now.Month + "_" + DateTime.Now.Year + "_" + DateTime.Now.TimeOfDay.Minutes + "_" + DateTime.Now.TimeOfDay.Seconds + ".xls";

                if (dgvFilter.Rows.Count > 0)
                {
                    StreamWriter wr = new StreamWriter(projectDirectory);
                    for (int i = 0; i < dgvFilter.Columns.Count; i++)
                    {
                        wr.Write(dgvFilter.Columns[i].Name.ToString().ToUpper() + "\t");
                    }

                    wr.WriteLine();

                    foreach (DataGridViewRow row in dgvFilter.Rows)
                    {
                        foreach (DataGridViewCell cell in row.Cells)
                        {
                            if (cell != null)
                            {
                                wr.Write(Convert.ToString(cell.Value) + "\t");
                            }
                            else
                            {
                                wr.Write("\t");
                            }
                        }
                        wr.WriteLine();
                    }

                    wr.Close();
                    MessageBox.Show("Data saved in Excel format at location " + projectDirectory.ToUpper() + " Successfully Saved");
                }
                else
                {
                    MessageBox.Show("Zero record to export , perform a operation first" + "Can't export file");
                }
            }
            catch (Exception ex)
            {
                var st = string.Empty;
                if (ex.InnerException != null)
                    st = ex.InnerException.Message;
                lblError.Text = "btnExcel_Click : " + ex.Message + " " + st;
            }
        }

        private void btnForm1_Click(object sender, EventArgs e)
        {
            HomePage Check = new HomePage(ServiceFactory);
            Check.Show();
            Hide();
        }

        private void cmbSort_SelectedIndexChanged(object sender, EventArgs e)
        {
            IOrderedEnumerable<DtoExpense>? res = null;
            var dbList = GetSearchData();
            var sortOn = cmbSort.Text;
            switch (sortOn)
            {
                case "CategoryName":
                    res = dbList.OrderBy(d => d.CategoryName);
                    break;
                case "ExpensesType":
                    res = dbList.OrderBy(d => d.ExpenseType);
                    break;
                case "Date":
                    res = dbList.OrderBy(d => d.Date);
                    break;
                case "Amount":
                    res = dbList.OrderBy(d => d.Amount);
                    break;
                case "Comment":
                    res = dbList.OrderBy(d => d.Comment);
                    break;
                default:
                    break;
            }

            dgvFilter.DataSource = res.ToList().GenereateSrNo();
        }

        private void txtTotalIncome_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
