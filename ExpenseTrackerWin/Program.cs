using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using PatternForCore.Core.EFContext;
using PatternForCore.Core.Factory;
using PatternForCore.Core.Repositories.Base;
using PatternForCore.Core.Repositories.Interfaces;
using PatternForCore.Core.Uow;
using PatternForCore.Services;
using PatternForCore.Services.Base.Contracts;

namespace ExpenseTrackerWin
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var host = CreateHostBuilder().Build();
            ServiceProvider = host.Services;

            Application.Run(ServiceProvider.GetRequiredService<Form1>()); 
        }
        public static IServiceProvider ServiceProvider { get; private set; }
        static IHostBuilder CreateHostBuilder()
        {
            return Host.CreateDefaultBuilder()
                .ConfigureServices((context, services) => {
                    services.AddInjections();
                    services.AddTransient<Form1>();
                });
        }

        internal static void AddInjections(this IServiceCollection services)
        {
            services.AddScoped<IDatabaseContext, DatabaseContext>();
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
            services.AddTransient(typeof(IExpenseServices), typeof(ExpenseServices));
            services.AddTransient(typeof(ICategoryServices), typeof(CategoryServices));
            services.AddTransient<IContextFactory, ContextFactory>();
            services.AddTransient<IUnitOfWork, UnitOfWork>();
        }
    }
}