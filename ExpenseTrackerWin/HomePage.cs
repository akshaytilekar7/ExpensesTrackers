using ExpenseTracker.Services.Factory;

namespace ExpenseTrackerWin
{
    public partial class HomePage : Form
    {

        public HomePage(IServiceFactory serviceFactory)
        {
            InitializeComponent();
            _serviceFactory = serviceFactory;
        }

        IServiceFactory _serviceFactory { get; }

        private void btnAddExpensed_Click(object sender, EventArgs e)
        {
            AddExpense Check = new AddExpense(_serviceFactory);
            Check.Show();
            Hide();
        }

        private void btnAddIncome_Click(object sender, EventArgs e)
        {
            AddIncome Check = new AddIncome(_serviceFactory);
            Check.Show();
            Hide();
        }

        private void btnViewExpense_Click(object sender, EventArgs e)
        {
            ViewExpense Check = new ViewExpense(_serviceFactory);
            Check.Show();
            Hide();

        }

        private void HomePage_Load(object sender, EventArgs e)
        {

        }

        private void btnYealry_Click(object sender, EventArgs e)
        {
            YearlyView Check = new YearlyView(_serviceFactory);
            Check.Show();
            Hide();
        }

        private void btnUserSettings_Click(object sender, EventArgs e)
        {
            UserSettings Check = new UserSettings(_serviceFactory);
            Check.Show();
            Hide();
        }
    }
}
