using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PatternForCore.Core.EFContext;
using PatternForCore.Core.Factory;
using PatternForCore.Core.Repositories.Base;
using PatternForCore.Core.Repositories.Interfaces;
using PatternForCore.Core.Uow;
using PatternForCore.Models.Configuration;
using PatternForCore.Services;
using PatternForCore.Services.Base.Contracts;
using PatternForCore.Services.Factory;

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
            .UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking)); // ServiceLifetime.Transient
        }

        public static void AddInjections(this IServiceCollection services)
        {
            services.AddTransient<IDatabaseContext, DatabaseContext>();
            services.AddTransient<IHttpContextAccessor, HttpContextAccessor>();
            services.AddTransient(typeof(IGenericRepository<>), typeof(GenericRepository<>));
            services.AddTransient(typeof(IExpenseServices), typeof(ExpenseServices));
            services.AddTransient(typeof(ICategoryServices), typeof(CategoryServices));
            services.AddTransient(typeof(IExcelService), typeof(ExcelService));
            services.AddTransient(typeof(IServiceFactory), typeof(ServiceFactory));
            services.AddTransient(typeof(IYearlyService), typeof(YearlyService));
            services.AddTransient<IContextFactory, ContextFactory>();
            services.AddTransient<IUnitOfWork, UnitOfWork>();
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
