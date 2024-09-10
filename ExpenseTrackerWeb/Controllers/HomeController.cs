using ExpenseTracker.Models;
using ExpenseTracker.Models.Dto;
using ExpenseTracker.Services.Factory;
using ExpenseTrackerWeb.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Diagnostics;
using System.Globalization;
namespace ExpenseTrackerWeb.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly IServiceFactory _serviceFactory;
    private int _year = 2024;
    public HomeController(ILogger<HomeController> logger, IServiceFactory serviceFactory)
    {
        _logger = logger;
        _serviceFactory = serviceFactory;
    }

    public async Task<IActionResult> Index(int year = 2024)
    {
        _year = year;
        List<TransactionByYear> lstDtoYealry = await _serviceFactory.YearlyService.GetTransactionByYear(year);
        List<BankByYear> lstBanks = await _serviceFactory.YearlyService.GetBankSummary(year);
        var dashboardViewModel = new DashboardViewModel()
        {
            BankByYear = lstBanks,
            TransactionByYear = lstDtoYealry,
        };

        return View(dashboardViewModel);
    }

    [HttpGet]
    public async Task<ActionResult> GetTransactionData(string month, string category)
    {

        var m = DateTime.ParseExact(month, "MMMM", CultureInfo.CurrentCulture).Month;

        var lstBanks = await _serviceFactory.YearlyService.GetBankSummary(_year);

        var obj = _serviceFactory.MasterTableService.GetAllSubCategory().FirstOrDefault(x => x.Name.Equals(category));

        List<TransactionByMonth> lstDtoYealry = await _serviceFactory.YearlyService.GetTransactionByMonth(_year, m, obj.Id);

        return Json(lstDtoYealry);
    }

    [HttpGet]
    public IActionResult AddIncome()
    {
        var startDate = new DateTime(DateTime.Now.Year, 1, 1);
        var endDate = new DateTime(DateTime.Now.Year, 12, 31);
        var lstIncome = _serviceFactory.IncomeService.GetIncome(startDate, endDate).OrderByDescending(x => x.Date).ToList();
        var lstUsers = _serviceFactory.UserService.GetAll();
        var lstBanks = _serviceFactory.BankService.GetAll();

        var vm = new AddIncomeViewModel()
        {
            Banks = lstBanks,
            Users = lstUsers,
            DtoIncome = lstIncome
        };

        return View(vm);
    }

    [HttpPost]
    public IActionResult AddIncome(Income income)
    {
         _serviceFactory.IncomeService.Add(income);
        return AddIncome();
    }


    [HttpGet]
    public async Task<IActionResult> ViewExpense()
    {
        var startDate = new DateTime(DateTime.Now.Year, 1, 1);
        var endDate = new DateTime(DateTime.Now.Year, 12, 31);
        var lstIncome = _serviceFactory.IncomeService.GetIncome(startDate, endDate).OrderByDescending(x => x.Date).ToList();
        var lstUsers = _serviceFactory.UserService.GetAll();
        var lstBanks = _serviceFactory.BankService.GetAll();

        var vm = new TransactionViewModel()
        {
            Filter = new DtoTransactionFilter() { StartDate = DateTime.Now.AddDays(-15), EndDate = DateTime.Now.AddDays(15) },
            Banks = lstBanks.Select(b => new SelectListItem
            {
                Value = b.Id.ToString(),
                Text = b.Name
            }).ToList(),
            Categories = _serviceFactory.MasterTableService.GetAllCategory().Select(b => new SelectListItem
            {
                Value = b.Id.ToString(),
                Text = b.Name
            }).ToList(),
            SubCategories = _serviceFactory.MasterTableService.GetAllSubCategory().Select(b => new SelectListItem
            {
                Value = b.Id.ToString(),
                Text = b.Name
            }).ToList(),
            Users = _serviceFactory.UserService.GetAll().Select(b => new SelectListItem
            {
                Value = b.Id.ToString(),
                Text = b.Name
            }).ToList(),
            Transactions = new List<DtoTransaction>()
        };

        return View(vm);
    }

    [HttpPost]
    public async Task<IActionResult> ViewExpense(DtoTransactionFilter filter)
    {
        var startDate = new DateTime(DateTime.Now.Year, 1, 1);
        var endDate = new DateTime(DateTime.Now.Year, 12, 31);
        var lstIncome = _serviceFactory.IncomeService.GetIncome(startDate, endDate).OrderByDescending(x => x.Date).ToList();
        var lstUsers = _serviceFactory.UserService.GetAll();
        var lstBanks = _serviceFactory.BankService.GetAll();

        var vm = new TransactionViewModel()
        {
            Filter = filter,
            Banks = lstBanks.Select(b => new SelectListItem
            {
                Value = b.Id.ToString(),
                Text = b.Name
            }).ToList(),
            Categories = _serviceFactory.MasterTableService.GetAllCategory().Select(b => new SelectListItem
            {
                Value = b.Id.ToString(),
                Text = b.Name
            }).ToList(),
            SubCategories = _serviceFactory.MasterTableService.GetAllSubCategory().Select(b => new SelectListItem
            {
                Value = b.Id.ToString(),
                Text = b.Name
            }).ToList(),
            Users = _serviceFactory.UserService.GetAll().Select(b => new SelectListItem
            {
                Value = b.Id.ToString(),
                Text = b.Name
            }).ToList(),
            Transactions = filter is not null ? await _serviceFactory.TransactionServices.GetTransactions(filter) : new List<DtoTransaction>()
        };

        return View(vm);
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
