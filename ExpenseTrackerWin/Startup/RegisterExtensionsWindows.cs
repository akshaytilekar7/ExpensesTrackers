using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ExpenseTracker.Core.EFContext;
using ExpenseTracker.Core.Factory;
using ExpenseTracker.Core.Repositories.Base;
using ExpenseTracker.Core.Repositories.Interfaces;
using ExpenseTracker.Core.Uow;
using ExpenseTracker.Models.Configuration;
using ExpenseTracker.Services;
using ExpenseTracker.Services.Base.Contracts;
using ExpenseTracker.Services.Factory;

namespace ExpenseTrackerWin.Startup
{
    public static class RegisterExtensionsWindows
    {
        public static void AddDbContexts(this IServiceCollection services, IConfiguration configuration)
        {
            var contextConnectionString = ConnectionSettings.DefaultConnection;

            services.AddDbContext<DatabaseContext>(x => x.UseSqlServer(contextConnectionString, o =>
            {
                o.EnableRetryOnFailure(3);
            })
            .UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking), ServiceLifetime.Transient); // 
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
            services.AddScoped(typeof(IYearlyService), typeof(YearlyService));
            services.AddScoped(typeof(IMasterTableService), typeof(MasterTableService));
            services.AddScoped<IContextFactory, ContextFactory>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();
        }

        internal static void AddIdentity(this IServiceCollection services)
        {
            services.AddIdentity<ApplicationUser, IdentityRole>()
                .AddEntityFrameworkStores<DatabaseContext>()
                .AddDefaultTokenProviders();

            services.Configure<IdentityOptions>(options =>
            {
                // Password settings
                options.Password.RequireDigit = false;
                options.Password.RequiredLength = 1;
                options.Password.RequireNonAlphanumeric = false;
                options.Password.RequireUppercase = false;
                options.Password.RequireLowercase = false;
                options.Password.RequiredUniqueChars = 1;

                // Lockout settings
                options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(30);
                options.Lockout.MaxFailedAccessAttempts = 5;
                options.Lockout.AllowedForNewUsers = true;

                // User settings
                options.User.RequireUniqueEmail = false;
            });
        }
    }
}
