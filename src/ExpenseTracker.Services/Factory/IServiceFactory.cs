using ExpenseTracker.Services.Base.Contracts;

namespace ExpenseTracker.Services.Factory
{
    public interface IServiceFactory
    {
        ICategoryServices CategoryServices { get; }
        IExpenseServices ExpenseServices { get; }
        IIncomeService IncomeService { get; }
        IExcelService ExcelService { get; }
        IYearlyService YearlyService { get; }
        IMasterTableService MasterTableService { get; }
        IUserService UserService { get; }
        IBankService BankService { get; }
    }
}
