using PatternForCore.Models;
using PatternForCore.Services.Base.Contracts;
using System.Data;

namespace ExpenseTrackerWin
{
    public partial class FilterData : Form
    {
        public ICategoryServices CategoryServices { get; }
        public IExpenseServices ExpenseServices { get; }
        public FilterData(ICategoryServices categoryServices, IExpenseServices expenseServices)
        {
            InitializeComponent();
            CategoryServices = categoryServices;
            ExpenseServices = expenseServices;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                lblError.Text = string.Empty;

                DateTime startDate = dateStart.Value.Date;
                DateTime endDate = dateEnd.Value.Date;
                int amount = string.IsNullOrEmpty(txtAmount.Text) ? 0 : Convert.ToInt32(txtAmount.Text);

                string category = cmbCategory.Text == "Please select" ? string.Empty : cmbCategory.Text;
                string expenseType = cmbExpensesType.Text == "Please select" ? string.Empty : cmbExpensesType.Text;
                string comment = txtComment.Text;

                var dbList = ExpenseServices.GetAll().ToList().Select(s => new DtoExpense()
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
                dgvFilter.DataSource = dbList.ToList();
            }
            catch (Exception ex)
            {
                lblError.Text = "btnSearch_Click : " + ex.Message;
            }
        }

        private void FilterData_Load(object sender, EventArgs e)
        {
            try
            {
                List<DtoExpense> dbList = ExpenseServices.GetAll().ToList().Select(s => new DtoExpense()
                {
                    CategoryName = s.Category.CategoryName,
                    Date = s.Date,
                    Amount = s.Amount,
                    ExpenseType = s.Category.ExpensesType,
                    Comment = s.Comment
                }).OrderBy(x => x.ExpenseType).ToList();
                dgvFilter.DataSource = dbList;

                dateStart.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
                dateEnd.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month));

                SetTotalAmount(dbList);
                LoadCombobox();
            }
            catch (Exception ex)
            {
                lblError.Text = "FilterData_Load : " + ex.Message;
            }

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
            }

            catch (Exception ex)
            {
                lblError.Text = "SetTotalAmount : " + ex.Message;
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

        private void LoadCombobox()
        {
            try
            {
                var data = CategoryServices.GetAll();
                data.Insert(0, new Category() { Id = 0, CategoryName = "Please select", ExpensesType = "Please select" });
                cmbCategory.DisplayMember = "CategoryName";
                cmbCategory.ValueMember = "Id";
                cmbCategory.DataSource = data;

                IList<Category> data2 = data.DistinctBy(x => x.ExpensesType).OrderBy(x => x.ExpensesType).ToList();
                data2.Insert(0, new Category() { Id = 0, CategoryName = "Please select", ExpensesType = "Please select" });
                cmbExpensesType.DisplayMember = "ExpensesType";
                cmbExpensesType.ValueMember = "Id";
                cmbExpensesType.DataSource = data2;
            }
            catch (Exception ex)
            {
                lblError.Text = "LoadCombobox : " + ex.Message;
            }

        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog savefile = new SaveFileDialog();
                savefile.FileName = "Response.xls";
                savefile.Filter = "Excel Files|*.xls;*.xlsx;*.xlsm";
                if (dgvFilter.Rows.Count > 0)
                {
                    if (savefile.ShowDialog() == DialogResult.OK)
                    {
                        StreamWriter wr = new StreamWriter(savefile.FileName);
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
                    }
                    MessageBox.Show("Data saved in Excel format at location " + savefile.FileName + "Successfully Saved");
                }
                else
                {
                    MessageBox.Show("Zero record to export , perform a operation first" + "Can't export file");
                }
            }
            catch (Exception ex)
            {
                lblError.Text = "btnExcel_Click : " + ex.Message;
            }
        }

        private void btnForm1_Click(object sender, EventArgs e)
        {
            Form1 Check = new Form1(CategoryServices, ExpenseServices);
            Check.Show();
            Hide();
        }
    }
}
