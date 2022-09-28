using PatternForCore.Services.Factory;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
namespace ExpenseTrackerWin
{
    public partial class UserSettings : Form
    {
        public IServiceFactory _serviceFactory { get; }

        public UserSettings(IServiceFactory serviceFactory)
        {
            InitializeComponent();
            _serviceFactory = serviceFactory;
        }

        private void btnSaveExpense_Click(object sender, EventArgs e)
        {

        }

        private void btnSaveCategory_Click(object sender, EventArgs e)
        {

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {

        }

        private void UserSettings_Load(object sender, EventArgs e)
        {

        }

        private void LoadExpenseGrid()
        {

        }
    }
}
