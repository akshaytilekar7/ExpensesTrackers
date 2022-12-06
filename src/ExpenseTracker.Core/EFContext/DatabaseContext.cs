using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ExpenseTracker.Models.Configuration;
using ExpenseTracker.Models;
using Microsoft.EntityFrameworkCore.Infrastructure;
using ExpenseTracker.Core.Factory;
using Microsoft.Extensions.Options;

namespace ExpenseTracker.Core.EFContext
{
    public class DatabaseContext : IdentityDbContext<ApplicationUser>, IDatabaseContext
    {
        public DatabaseContext(IOptions<MyConfig> myConfig) : base(new DefaultContextFactory(myConfig).GetDataContext().Options)
        {

        }
        /// <summary>
        /// initializes a new instance of DbContext class.
        /// </summary>
        /// <param name="options"></param>
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {

        }

        public DbSet<Expense> Expense { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<IncomeSource> IncomeSource { get; set; }
        public DbSet<ExpenseType> ExpenseType { get; set; }
        public DbSet<CategoryType> CategoryType { get; set; }
        public DbSet<Bank> Bank { get; set; }
        public DatabaseFacade DatabaseFacade => this.Database;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

    }
}