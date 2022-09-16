using PatternForCore.Models;
using PatternForCore.Services.Base.Contracts;
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
                dbList = dbList.Where(x => x.CategoryName.Contains(category));
            if (!string.IsNullOrEmpty(expenseType))
                dbList = dbList.Where(x => x.ExpenseType.Contains(expenseType));
            if (!string.IsNullOrEmpty(comment))
                dbList = dbList.Where(x => x.Comment.Contains(comment));

            SetTotalAmount(dbList.ToList());

            if (!dbList.Any())
                lblError.Text = "No Data Fount";
            dgvFilter.DataSource = dbList.ToList();
        }

        private void FilterData_Load(object sender, EventArgs e)
        {
            List<DtoExpense> dbList = ExpenseServices.GetAll().ToList().Select(s => new DtoExpense()
            {
                CategoryName = s.Category.CategoryName,
                Date = s.Date,
                Amount = s.Amount,
                ExpenseType = s.Category.ExpensesType,
                Comment = s.Comment
            }).ToList();
            dgvFilter.DataSource = dbList;

            dateStart.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            dateEnd.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month));

            SetTotalAmount(dbList);
            LoadCombobox();
        }

        private void SetTotalAmount(List<DtoExpense> dbList)
        {
            string Total = string.Empty;
            foreach (var item in dbList.DistinctBy(x => x.ExpenseType).Select(x => x.ExpenseType))
            {
                Total += "\n";
                var sum = Convert.ToString(dbList.Where(x => x.ExpenseType == item).Sum(x => x.Amount));
                Total += item + " : " + sum;
                Total += "\n";
            }
            txtTotalAmount.Text = Total;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lblError.Text = string.Empty;
        }

        private void LoadCombobox()
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
    }
}
