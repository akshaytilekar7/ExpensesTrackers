using ExpenseTrackerWin.Utility;
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;
using ExpenseTracker.Models;
using ExpenseTracker.Models.Dto;
using ExpenseTracker.Services.Factory;
using System.Data;
using System.Globalization;
using ExpenseTracker.Services.Base;
using ExpenseTracker.Core.Uow;
using ExpenseTracker.Core.Factory;
using ExpenseTracker.Core;
using Microsoft.Extensions.Options;

namespace ExpenseTrackerWin
{
    public partial class YearlyTotalView : Form
    {
        public IServiceFactory _serviceFactory { get; set; }
        public IOptions<MyConfig> MyConfig { get; }

        public YearlyTotalView(IOptions<MyConfig> myConfig)
        {
            InitializeComponent();
            MyConfig = myConfig;
            _serviceFactory = new ServiceFactory(new UnitOfWork(new SpecialContextFactory(MyConfig, DateTime.Now.Year)), myConfig);
        }

        private void YearlyView_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            LoadGird();
        }

        private void LoadGird()
        {
            var lstDtoYealry = _serviceFactory.YearlyTotalService.GetYearlyData();
            dataGridView1.DataSource = lstDtoYealry.MakeSortable();
            dataGridView1.SetGridToFit();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            HomePage Check = new HomePage(MyConfig, _serviceFactory);
            Check.Show();
            Hide();
        }
    }
}
