using ExpenseTracker.Core;
using ExpenseTracker.Core.Factory;
using ExpenseTracker.Core.Uow;
using ExpenseTracker.Models.Dto;
using ExpenseTracker.Services.Factory;
using ExpenseTrackerWin2.Utility;
using MaterialSkin;
using MaterialSkin.Controls;
using Microsoft.Extensions.Options;
using System.Windows.Forms;

namespace ExpenseTrackerWin2;

public partial class Index : MaterialForm
{
    public IServiceFactory _serviceFactory { get; set; }
    public IOptions<MyConfig> myConfig { get; }

    public Index(IOptions<MyConfig> myConfig)
    {
        InitializeComponent();
        this.WindowState = FormWindowState.Maximized;
        this.myConfig = myConfig;
        _serviceFactory = new ServiceFactory(new UnitOfWork(new SpecialContextFactory(this.myConfig, DateTime.Now.Year)), myConfig);
        var materialSkinManager = MaterialSkinManager.Instance;
        materialSkinManager.AddFormToManage(this);
        materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
        materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey900, Primary.BlueGrey900, Primary.BlueGrey500, Accent.DeepOrange700, TextShade.WHITE);
    }


    private async Task LoadGird()
    {
        if (string.IsNullOrEmpty(cmbDatabasePicker.Text) || cmbDatabasePicker.Text == "Please select")
            return;

        int year = Convert.ToInt32(cmbDatabasePicker.Text);
        var _unitOfWork = new UnitOfWork(new SpecialContextFactory(myConfig, year));
        //if (!_unitOfWork.CanConnect())
        //{
        //    MessageBox.Show("Database does not exist : " + year + ". Setting view to current year");
        //    datePickerYearly.Value = DateTime.Now;
        //    return;
        //}
        _serviceFactory = new ServiceFactory(_unitOfWork, myConfig);

        var lstDtoYealry = await _serviceFactory.YearlyService.GetTransactionByYear(year);
        dgvYearly.DataSource = lstDtoYealry.MakeSortable();
        dgvYearly.SetGridToFit();

        foreach (DataGridViewRow row in dgvYearly.Rows)
        {
            int count = 0;
            foreach (DataGridViewCell cell in row.Cells)
            {
                count++;
                if (count > 2)
                {
                    var expectedAmount = Convert.ToDecimal(row.Cells[2].Value == null ? 0 : row.Cells[2].Value);
                    if (expectedAmount == -1) continue;
                    var actualAmount = Convert.ToDecimal(cell.Value);
                    if (actualAmount > expectedAmount)
                        cell.Style.BackColor = Color.Orange;
                }
            }
        }

        await LoadBankGrid();
    }

    private async Task LoadBankGrid()
    {
        if (string.IsNullOrEmpty(cmbDatabasePicker.Text) || cmbDatabasePicker.Text == "Please select")
            return;


        int year = Convert.ToInt32(cmbDatabasePicker.Text);
        var _unitOfWork = new UnitOfWork(new SpecialContextFactory(myConfig, year));

        _serviceFactory = new ServiceFactory(_unitOfWork, myConfig);

        var lstBanks = await _serviceFactory.YearlyService.GetBankSummary(year);
        dgvBankAmount.DataSource = lstBanks;
        dgvBankAmount.SetGridToFit();
    }

    private async void cmbDatabasePicker_SelectedIndexChanged(object sender, EventArgs e)
    {
        dgvBankAmount.DataSource = null;
        dgvYearly.DataSource = null;
        dgvTooltip.DataSource = null;
        await LoadGird();
    }

    private void dgvYearly_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {
        SetTooltipGrid(sender, e.RowIndex, e.ColumnIndex);
    }

    private async void SetTooltipGrid(object sender, int rowIndex, int columnIndex)
    {
        if (rowIndex < 0 || columnIndex < 0)
            return;

        var lstDetails = await GetDetails(columnIndex, rowIndex);
        dgvTooltip.SetGridToFit();
        dgvTooltip.DataSource = lstDetails.MakeSortable();
    }

    private async Task<List<TransactionByMonth>> GetDetails(int columnIndex, int rowIndex)
    {
        int year = Convert.ToInt32(cmbDatabasePicker.Text);
        var _unitOfWork = new UnitOfWork(new SpecialContextFactory(myConfig, year));
        _serviceFactory = new ServiceFactory(_unitOfWork, myConfig);

        var lstBanks = await _serviceFactory.YearlyService.GetBankSummary(year);

        var name = dgvYearly.Rows[rowIndex].Cells[1].Value;

        var obj = _serviceFactory.MasterTableService.GetAllSubCategory().FirstOrDefault(x => x.Name.Equals(name.ToString()));

        List<TransactionByMonth> lstDtoYealry = await _serviceFactory.YearlyService.GetTransactionByMonth(year, columnIndex - 2, obj.Id);
        return lstDtoYealry;
    }

    private async void cmbDatabasePicker_SelectedValueChanged(object sender, EventArgs e)
    {
        await LoadGird();
    }

    private void cmbNames_SelectionChangeCommitted(object sender, EventArgs e)
    {
        var userId = Convert.ToInt32(cmbNames.SelectedValue);
        var lstBanks = _serviceFactory.BankService.GetAll().Where(x => x.UserId == userId).ToList();
        cmbBank.DataSource = lstBanks;
        cmbBank.DisplayMember = "Name";
        cmbBank.ValueMember = "Id";
    }

    private void tabAddIncome_Click(object sender, EventArgs e)
    {

    }
}