using ExpenseTracker.Services.Base.Contracts;

namespace ExpenseTracker.Services.Factory
{
    public interface IServiceFactory
    {
        ISubCategoryServices SubCategoryServices { get; }
        ICategoryServices CategoryServices { get; }
        ITransactionServices TransactionServices { get; }
        IIncomeService IncomeService { get; }
        IExcelService ExcelService { get; }
        IYearlyService YearlyService { get; }
        IMasterTableService MasterTableService { get; }
        IUserService UserService { get; }
        IBankService BankService { get; }
        IDecadeService DecadeServices { get; }

    }
}
