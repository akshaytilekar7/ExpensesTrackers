using ExpenseTracker.Core;
using ExpenseTracker.Services.Factory;
using Microsoft.Extensions.Options;
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
    public partial class Index : Form
    {
        public Index(IOptions<MyConfig> myConfig, IServiceFactory serviceFactory)
        {
            InitializeComponent();
            MyConfig = myConfig;
            _serviceFactory = serviceFactory;
            SetFormSizeToPrimaryScreen();
            ApplyMenuStripTheme(menuStrip1);
        }

        private void SetFormSizeToPrimaryScreen()
        {
            // Get the primary screen
            Screen primaryScreen = Screen.PrimaryScreen;

            // Set the form size to match the primary screen size
            this.Width = primaryScreen.WorkingArea.Width;
            this.Height = primaryScreen.WorkingArea.Height;
            panleIndexPage.Width = primaryScreen.WorkingArea.Width - 10;
            panleIndexPage.Height = primaryScreen.WorkingArea.Width - 10;

            this.StartPosition = FormStartPosition.Manual;
            this.Location = new System.Drawing.Point(0, 0);
            SetYealry();
        }

        public IOptions<MyConfig> MyConfig { get; }
        IServiceFactory _serviceFactory { get; }

        private void addExpenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddExpense addExpense = new AddExpense(MyConfig, _serviceFactory);
            panleIndexPage.Controls.Clear();

            // Create and add the new form to the panel
            addExpense.TopLevel = false;
            addExpense.FormBorderStyle = FormBorderStyle.None;
            addExpense.Dock = DockStyle.Fill;
            panleIndexPage.Controls.Add(addExpense);

            // Show the form
            addExpense.Show();
        }

        private void addIncomeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddIncome addIncome = new AddIncome(MyConfig, _serviceFactory);
            panleIndexPage.Controls.Clear();

            // Create and add the new form to the panel
            addIncome.TopLevel = false;
            addIncome.FormBorderStyle = FormBorderStyle.None;
            addIncome.Dock = DockStyle.Fill;
            panleIndexPage.Controls.Add(addIncome);

            // Show the form
            ApplyCommonButtonStyle(addIncome.Controls.OfType<Button>());
            addIncome.Show();
        }

        private void viewExpenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewExpense obj = new ViewExpense(MyConfig, _serviceFactory);
            panleIndexPage.Controls.Clear();

            // Create and add the new form to the panel
            obj.TopLevel = false;
            obj.FormBorderStyle = FormBorderStyle.None;
            obj.Dock = DockStyle.Fill;
            panleIndexPage.Controls.Add(obj);

            ApplyCommonButtonStyle(obj.Controls.OfType<Button>());
            // Show the form
            obj.Show();
        }

        private void yearlyOverviewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetYealry();
        }

        public void SetYealry()
        {
            YearlyView obj = new YearlyView(MyConfig);
            panleIndexPage.Controls.Clear();

            // Create and add the new form to the panel
            obj.TopLevel = false;
            obj.FormBorderStyle = FormBorderStyle.None;
            obj.Dock = DockStyle.Fill;
            panleIndexPage.Controls.Add(obj);

            ApplyCommonButtonStyle(obj.Controls.OfType<Button>());
            // Show the form
            obj.Show();
        }

        private void historyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            YearlyTotalView obj = new YearlyTotalView(MyConfig);
            panleIndexPage.Controls.Clear();

            // Create and add the new form to the panel
            obj.TopLevel = false;
            obj.FormBorderStyle = FormBorderStyle.None;
            obj.Dock = DockStyle.Fill;
            panleIndexPage.Controls.Add(obj);
            ApplyCommonButtonStyle(obj.Controls.OfType<Button>());
            // Show the form
            obj.Show();
        }

        private void ApplyMenuStripTheme(MenuStrip menuStrip)
        {
            menuStrip.BackColor = Color.LightGray;
            menuStrip.ForeColor = Color.Black;
            menuStrip.Font = new Font("Arial", 9, FontStyle.Bold);
        }

        private void ApplyCommonButtonStyle(IEnumerable<Button> buttons)
        {
            foreach (var button in buttons)
            {
                // Set a flat style for a cleaner appearance
                button.FlatStyle = FlatStyle.Flat;

                // Set a background color for the button
                button.BackColor = Color.LightGray;

                // Set text color
                button.ForeColor = Color.Black;
            }
        }
    }
}
