using PatternForCore.Models;
using PatternForCore.Services.Factory;

namespace ExpenseTrackerWin
{
    public partial class AddIncome : Form
    {
        public AddIncome(IServiceFactory serviceFactory)
        {
            InitializeComponent();
            _serviceFactory = serviceFactory;
        }

        private IServiceFactory _serviceFactory { get; }

        private void AddIncome_Load(object sender, EventArgs e)
        {
            LoadGrid();
        }

        private void LoadGrid()
        {
            var lst = _serviceFactory.IncomeService.GetAll().OrderByDescending(x => x.Date).ToList();
            dgvIncome.DataSource = lst;

            var users = _serviceFactory.UserService.GetAll();
            cmbNames.DataSource = users;
            cmbNames.DisplayMember = "Name";
            cmbNames.ValueMember = "Id";
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            IncomeSource income = new IncomeSource();
            income.Date = Convert.ToDateTime(datePicker.Text);
            income.Amount = Convert.ToInt32(txtAmount.Text);
            income.UserId = Convert.ToInt32(cmbNames.SelectedValue);
            _serviceFactory.IncomeService.Add(income);
            string message = "Save Data Sucessfully";
            MessageBox.Show(message);
            LoadGrid();
        }

        private void btnHomePage_Click(object sender, EventArgs e)
        {
            HomePage Check = new HomePage(_serviceFactory);
            Check.Show();
            Hide();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            List<IncomeSource> lst = new List<IncomeSource>();
            foreach (DataGridViewRow row in dgvIncome.SelectedRows)
            {
                int id = Convert.ToInt32(row.Cells[0].Value);
                lst.Add(new IncomeSource() { Id = id });
            }
            _serviceFactory.IncomeService.Delete(lst);
            LoadGrid();
        }
    }
}
