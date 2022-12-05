﻿using ExpenseTracker.Models;
using ExpenseTracker.Services.Factory;
using ExpenseTrackerWin.Utility;

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
            WindowState = FormWindowState.Maximized;
        }

        private void LoadGrid()
        {
            var startDate = new DateTime(DateTime.Now.Year, 1, 1);
            var endDate = new DateTime(DateTime.Now.Year, 12, 31);
            var lstIncome = _serviceFactory.IncomeService.GetIncome(startDate, endDate).OrderByDescending(x => x.Date).ToList();
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
            IncomeSource income = new IncomeSource();
            income.Date = Convert.ToDateTime(datePicker.Text);
            income.Amount = Convert.ToInt32(txtAmount.Text);
            income.UserId = Convert.ToInt32(cmbNames.SelectedValue);
            income.BankId = Convert.ToInt32(cmbBank.SelectedValue);
            income.Comment =  Convert.ToString(string.IsNullOrEmpty(txtComment.Text) ? cmbComment.Text : txtAmount.Text);
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
