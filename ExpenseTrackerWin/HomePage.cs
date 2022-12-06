using ExpenseTracker.Core;
using ExpenseTracker.Services.Factory;
using Microsoft.Extensions.Options;

namespace ExpenseTrackerWin
{
    public partial class HomePage : Form
    {

        public HomePage(IOptions<MyConfig> myConfig, IServiceFactory serviceFactory)
        {
            InitializeComponent();
            MyConfig = myConfig;
            _serviceFactory = serviceFactory;
        }

        public IOptions<MyConfig> MyConfig { get; }
        IServiceFactory _serviceFactory { get; }

        private void btnAddExpensed_Click(object sender, EventArgs e)
        {
            AddExpense Check = new AddExpense(MyConfig, _serviceFactory);
            Check.Show();
            Hide();
        }

        private void btnAddIncome_Click(object sender, EventArgs e)
        {
            AddIncome Check = new AddIncome(MyConfig, _serviceFactory);
            Check.Show();
            Hide();
        }

        private void btnViewExpense_Click(object sender, EventArgs e)
        {
            ViewExpense Check = new ViewExpense(MyConfig, _serviceFactory);
            Check.Show();
            Hide();

        }

        private void HomePage_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void btnYealry_Click(object sender, EventArgs e)
        {
            YearlyView Check = new YearlyView(MyConfig);
            Check.Show();
            Hide();
        }

        private void btnUserSettings_Click(object sender, EventArgs e)
        {
            UserSettings Check = new UserSettings(MyConfig, _serviceFactory);
            Check.Show();
            Hide();
        }
    }
}
