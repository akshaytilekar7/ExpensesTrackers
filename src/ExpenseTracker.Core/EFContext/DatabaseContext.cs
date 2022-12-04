using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ExpenseTracker.Models.Configuration;
using ExpenseTracker.Models;

namespace ExpenseTracker.Core.EFContext
{
    public class DatabaseContext : IdentityDbContext<ApplicationUser>, IDatabaseContext
    {
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
        public DbSet<OpeningBalance> OpeningBalance { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}