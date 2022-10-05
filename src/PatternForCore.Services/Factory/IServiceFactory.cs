using PatternForCore.Services.Base.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace PatternForCore.Services.Factory
{
    public interface IServiceFactory
    {
        ICategoryServices CategoryServices { get; }
        IExpenseServices ExpenseServices { get; }
        IIncomeService IncomeService { get; }
        IExcelService ExcelService { get; }
        IExcelInteropService ExcelInteropService { get; }
        IYearlyService YearlyService { get; }
        IMasterTableService MasterTableService { get; }
        IUserService UserService { get; }

    }
}
