using ExpenseTracker.Core;
using ExpenseTrackerWin.Startup;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace ExpenseTrackerWin
{
    internal static class Program
    {
        public static IConfiguration Configuration { get; set; }
        public static IServiceProvider ServiceProvider { get; private set; }

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var builder = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json");  //reloadOnChange: true
            Configuration = builder.Build();

            var host = CreateHostBuilder().Build();
            ServiceProvider = host.Services;
            Application.Run(ServiceProvider.GetRequiredService<HomePage>());
        }
        static IHostBuilder CreateHostBuilder()
        {
            return Host.CreateDefaultBuilder().ConfigureServices((context, services) =>
            {
                services.Configure<MyConfig>(Configuration.GetSection("MyConfig"));
                services.AddInjections(Configuration);
                services.AddIdentity();
                services.AddScoped<HomePage>();
            });
        }

    }
}