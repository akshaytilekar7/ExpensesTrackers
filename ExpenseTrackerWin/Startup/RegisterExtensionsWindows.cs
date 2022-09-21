using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PatternForCore.Core.EFContext;
using PatternForCore.Core.Factory;
using PatternForCore.Core.Repositories.Base;
using PatternForCore.Core.Repositories.Interfaces;
using PatternForCore.Core.Uow;
using PatternForCore.Services;
using PatternForCore.Services.Base.Contracts;
using PatternForCore.Services.Factory;

namespace ExpenseTrackerWin.Startup
{
    public static class RegisterExtensionsWindows
    {
        public static void AddDbContexts(this IServiceCollection services, IConfiguration configuration)
        {
            var contextConnectionString = configuration.GetConnectionString("DefaultConnection");
            services.AddDbContextPool<DatabaseContext>(x => x.UseSqlServer(contextConnectionString, o =>
            {
                o.EnableRetryOnFailure(3);
            })
            .UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking));
        }

        public static void AddInjections(this IServiceCollection services)
        {
            services.AddScoped<IDatabaseContext, DatabaseContext>();
            services.AddScoped<IHttpContextAccessor, HttpContextAccessor>();
            services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
            services.AddScoped(typeof(IExpenseServices), typeof(ExpenseServices));
            services.AddScoped(typeof(ICategoryServices), typeof(CategoryServices));
            services.AddScoped(typeof(IExcelService), typeof(ExcelService));
            services.AddScoped(typeof(IServiceFactory), typeof(ServiceFactory));
            services.AddScoped<IContextFactory, ContextFactory>();
            services.AddTransient<IUnitOfWork, UnitOfWork>();
        }
    }
}
