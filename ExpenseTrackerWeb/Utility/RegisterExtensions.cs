using ExpenseTracker.Core;
using ExpenseTracker.Core.EFContext;
using ExpenseTracker.Core.Factory;
using ExpenseTracker.Core.Repositories.Base;
using ExpenseTracker.Core.Repositories.Interfaces;
using ExpenseTracker.Core.Uow;
using ExpenseTracker.Services;
using ExpenseTracker.Services.Base.Contracts;
using ExpenseTracker.Services.Factory;

namespace ExpenseTrackerWeb.Utility;

public static class RegisterExtensions
{
    public static void AddInjections(this IServiceCollection services)
    {
        services.AddScoped<IMyConfig, MyConfig>();
        services.AddScoped<IContextFactory, DefaultContextFactory>();
        services.AddScoped<IDatabaseContext, DatabaseContext>();
        services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
        services.AddScoped(typeof(ITransactionServices), typeof(TransactionServices));
        services.AddScoped(typeof(IExcelService), typeof(ExcelService));
        services.AddScoped(typeof(IServiceFactory), typeof(ServiceFactory));
        services.AddScoped(typeof(IYearlyService), typeof(YearlyService));
        services.AddScoped(typeof(IMasterTableService), typeof(MasterTableService));
        services.AddScoped<IUnitOfWork, UnitOfWork>();
    }
}
