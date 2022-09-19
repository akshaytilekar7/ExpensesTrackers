using PatternForCore.Models;
using PatternForCore.Services;
using PatternForCore.Services.Base.Contracts;
using PatternForCore.Services.Factory;
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
    public partial class HomePage : Form
    {

        public HomePage(IServiceFactory serviceFactory)
        {
            InitializeComponent();
            ServiceFactory = serviceFactory;
        }

        public IServiceFactory ServiceFactory { get; }

        private void btnAddExpensed_Click(object sender, EventArgs e)
        {
            AddExpense Check = new AddExpense(ServiceFactory);
            Check.Show();
            Hide();
        }

        private void btnAddIncome_Click(object sender, EventArgs e)
        {
            AddIncome Check = new AddIncome(ServiceFactory);
            Check.Show();
            Hide();
        }

        private void btnViewExpense_Click(object sender, EventArgs e)
        {
            ViewExpense Check = new ViewExpense(ServiceFactory);
            Check.Show();
            Hide();

        }

        private void HomePage_Load(object sender, EventArgs e)
        {

        }
    }
}
