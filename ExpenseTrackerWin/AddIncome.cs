﻿using ExpenseTracker.Core;
using ExpenseTracker.Models;
using ExpenseTracker.Services.Factory;
using ExpenseTrackerWin.Utility;
using Microsoft.Extensions.Options;

namespace ExpenseTrackerWin
{
    public partial class AddIncome : Form
    {
        public AddIncome(IOptions<MyConfig> myConfig, IServiceFactory serviceFactory)
        {
            InitializeComponent();
            MyConfig = myConfig;
            _serviceFactory = serviceFactory;
        }

        public IOptions<MyConfig> MyConfig { get; }
        private IServiceFactory _serviceFactory { get; }

        private void AddIncome_Load(object sender, EventArgs e)
        {
            LoadGrid();
            WindowState = FormWindowState.Maximized;
            
        }

        private void LoadGrid()
        {
            var startDate = new DateTime(DateTime.Now.Year, 1, 1);
            var endDate = new DateTime(DateTime.Now.Year, 12, 31);
            var lstIncome = _serviceFactory.IncomeService.GetIncome(startDate, endDate).OrderByDescending(x => x.Date).ToList();
            dgvIncome.SetGridToFit();
            dgvIncome.DataSource = lstIncome.MakeSortable();

            var lstUsers = _serviceFactory.UserService.GetAll();
            cmbNames.DataSource = lstUsers;
            cmbNames.DisplayMember = "Name";
            cmbNames.ValueMember = "Id";

            var lstBanks = _serviceFactory.BankService.GetAll();
            cmbBank.DataSource = lstBanks;
            cmbBank.DisplayMember = "Name";
            cmbBank.ValueMember = "Id";
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            Income income = new Income();
            income.Date = Convert.ToDateTime(datePicker.Text);
            income.Amount = Convert.ToDecimal(txtAmount.Text);
            income.UserId = Convert.ToInt32(cmbNames.SelectedValue);
            income.BankId = Convert.ToInt32(cmbBank.SelectedValue);
            income.Comment = Convert.ToString(cmbComment.Text);
            _serviceFactory.IncomeService.Add(income);
            string message = "Save Data Sucessfully";
            MessageBox.Show(message);
            LoadGrid();
        }

        private void btnHomePage_Click(object sender, EventArgs e)
        {
            HomePage Check = new HomePage(MyConfig, _serviceFactory);
            Check.Show();
            Hide();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            List<Income> lst = new List<Income>();
            foreach (DataGridViewRow row in dgvIncome.SelectedRows)
            {
                int id = Convert.ToInt32(row.Cells[0].Value);
                lst.Add(new Income() { Id = id });
            }
            _serviceFactory.IncomeService.Delete(lst);
            LoadGrid();
        }

        private void cmbNames_SelectionChangeCommitted(object sender, EventArgs e)
        {
            var userId = Convert.ToInt32(cmbNames.SelectedValue);
            var lstBanks = _serviceFactory.BankService.GetAll().Where(x => x.UserId == userId).ToList();
            cmbBank.DataSource = lstBanks;
            cmbBank.DisplayMember = "Name";
            cmbBank.ValueMember = "Id";
        }
    }
}
