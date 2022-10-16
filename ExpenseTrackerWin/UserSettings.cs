using ExpenseTracker.Services.Factory;
using ExpenseTracker.Models;
using System.Data;
namespace ExpenseTrackerWin
{
    public partial class UserSettings : Form
    {
        public IServiceFactory _serviceFactory { get; }

        public UserSettings(IServiceFactory serviceFactory)
        {
            InitializeComponent();
            _serviceFactory = serviceFactory;
            LoadExpenseGrid();
            LoadCategoryGrid();
        }

        private void btnSaveExpense_Click(object sender, EventArgs e)
        {
            try
            {
                var list = new List<ExpenseType>();
                foreach (DataGridViewRow row in dgvExpenseType.Rows)
                {
                    int id = 0;
                    if (!string.IsNullOrEmpty(Convert.ToString(row.Cells[0].Value)))
                    {
                        id = Convert.ToInt32(row.Cells[0].Value);
                    }

                    string name = Convert.ToString(row.Cells[1].Value);
                    if (string.IsNullOrEmpty(name))
                        continue;

                    ExpenseType obj = new ExpenseType();
                    obj.Id = id;
                    obj.Name = name;
                    list.Add(obj);
                }
                _serviceFactory.MasterTableService.SaveExpenseType(list);

                string message = "Save Data Sucessfully";
                list.Clear();
                MessageBox.Show(message);
            }
            catch (Exception ex)
            {
                var st = string.Empty;
                if (ex.InnerException != null)
                    st = ex.InnerException.Message;
                MessageBox.Show("btnSaveExpense_Click : " + ex.Message + " " + st);
            }
        }

        private void btnSaveCategory_Click(object sender, EventArgs e)
        {
            CategoryType CategoryType = new CategoryType();
            CategoryType.Name = txtCategory.Text;
            if (!string.IsNullOrEmpty(txtId.Text))
                CategoryType.Id = Convert.ToInt32(txtId.Text);

            CategoryType.ExpenseTypeId = Convert.ToInt32(cmbExpeseType.SelectedValue);

            _serviceFactory.MasterTableService.SaveCategoryType(new List<CategoryType>() { CategoryType });
            LoadCategoryGrid();
            Clear();
        }

        private void Clear()
        {
            txtCategory.Text = string.Empty;
            txtId.Text = string.Empty;
            cmbExpeseType.Text = string.Empty;
        }
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadExpenseGrid();
            LoadCategoryGrid();
        }

        private void UserSettings_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void LoadExpenseGrid()
        {
            dgvExpenseType.Rows.Clear();
            var lstExpense = _serviceFactory.MasterTableService.GetAllExpenseType();

            int index = 0;
            foreach (var item in lstExpense)
            {
                DataGridViewRow row = new DataGridViewRow();

                DataGridViewTextBoxCell cId = new DataGridViewTextBoxCell();
                cId.Value = item.Id;

                DataGridViewTextBoxCell cName = new DataGridViewTextBoxCell();
                cName.Value = item.Name;

                row.Cells.Add(cId);
                row.Cells.Add(cName);

                dgvExpenseType.Rows.Add(row);
                index++;
            }
        }

        private void LoadCategoryGrid()
        {
            dgvCategory.Rows.Clear();
            var lstExpenses = _serviceFactory.MasterTableService.GetAllExpenseType();
            cmbExpeseType.DataSource = lstExpenses;
            cmbExpeseType.DisplayMember = "Name";
            cmbExpeseType.ValueMember = "Id";

            var lstCategories = _serviceFactory.MasterTableService.GetAllCategoryType().OrderBy(x => x.ExpenseType.Name).ToList();
            if (!lstCategories.Any())
                lstCategories.Add(new CategoryType());

            this.dgvCategory.AllowUserToAddRows = true;

            foreach (var item in lstCategories)
            {
                DataGridViewRow row = new DataGridViewRow();

                DataGridViewTextBoxCell cId = new DataGridViewTextBoxCell();
                cId.Value = item.Id;

                DataGridViewComboBoxCell cExpense = new DataGridViewComboBoxCell();
                cExpense.DisplayMember = "Name";
                cExpense.ValueMember = "Id";
                cExpense.DataSource = lstExpenses;
                if (item.ExpenseType != null)
                    cExpense.Value = item.ExpenseType.Id;

                DataGridViewTextBoxCell cName = new DataGridViewTextBoxCell();
                cName.Value = item.Name;

                row.Cells.Add(cId);
                row.Cells.Add(cExpense);
                row.Cells.Add(cName);

                dgvCategory.Rows.Add(row);
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            HomePage Check = new HomePage(_serviceFactory);
            Check.Show();
            Hide();
        }

        private void dgvCategory_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {
            var dbExpense = _serviceFactory.MasterTableService.GetAllExpenseType();

            var row = e.Row;

            DataGridViewTextBoxCell cId = new DataGridViewTextBoxCell();
            DataGridViewComboBoxCell cExpense = new DataGridViewComboBoxCell();
            cExpense.DisplayMember = "Name";
            cExpense.ValueMember = "Id";
            cExpense.DataSource = dbExpense;
            DataGridViewTextBoxCell cName = new DataGridViewTextBoxCell();

            row.Cells.Add(cId);
            row.Cells.Add(cExpense);
            row.Cells.Add(cName);
        }

        private void btnEditSave_Click(object sender, EventArgs e)
        {
            try
            {
                var dbExpense = _serviceFactory.MasterTableService.GetAllExpenseType();
                var list = new List<CategoryType>();
                foreach (DataGridViewRow row in dgvCategory.Rows)
                {
                    int id = 0;
                    if (!string.IsNullOrEmpty(Convert.ToString(row.Cells[0].Value)))
                    {
                        id = Convert.ToInt32(row.Cells[0].Value);
                    }

                    var expenseId = Convert.ToInt32(row.Cells[1].Value);

                    string name = Convert.ToString(row.Cells[2].Value);
                    if (string.IsNullOrEmpty(name))
                        continue;

                    CategoryType obj = new CategoryType();
                    obj.Id = id;
                    obj.Name = name;
                    obj.ExpenseTypeId = expenseId;
                    list.Add(obj);
                }
                _serviceFactory.MasterTableService.SaveCategoryType(list);

                string message = "Edit Data Sucessfully";
                list.Clear();
                MessageBox.Show(message);
            }
            catch (Exception ex)
            {
                var st = string.Empty;
                if (ex.InnerException != null)
                    st = ex.InnerException.Message;
                MessageBox.Show("btnSaveExpense_Click : " + ex.Message + " " + st);
            }
        }
    }
}
