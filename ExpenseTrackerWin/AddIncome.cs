using PatternForCore.Models;
using PatternForCore.Services.Factory;

namespace ExpenseTrackerWin
{
    public partial class AddIncome : Form
    {
        public AddIncome(IServiceFactory serviceFactory)
        {
            InitializeComponent();
            ServiceFactory = serviceFactory;
        }

        public IServiceFactory ServiceFactory { get; }

        private void AddIncome_Load(object sender, EventArgs e)
        {
            var lst = ServiceFactory.IncomeService.GetAll().OrderByDescending(x => x.Date).ToList();
            dgvIncome.DataSource = lst;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            IncomeSource income = new IncomeSource();
            income.Date = Convert.ToDateTime(datePicker.Text);
            income.Amount = Convert.ToInt32(txtAmount.Text);
            income.Name = txtName.Text;
            ServiceFactory.IncomeService.Add(income);
            string message = "Save Data Sucessfully";
            MessageBox.Show(message);
        }

        private void btnHomePage_Click(object sender, EventArgs e)
        {
            HomePage Check = new HomePage(ServiceFactory);
            Check.Show();
            Hide();
        }
    }
}
