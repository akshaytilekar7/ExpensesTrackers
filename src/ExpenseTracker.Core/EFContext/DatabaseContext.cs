using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ExpenseTracker.Models.Configuration;
using ExpenseTracker.Models;
using Microsoft.EntityFrameworkCore.Infrastructure;
using ExpenseTracker.Core.Factory;
using Microsoft.Extensions.Options;
using System;

namespace ExpenseTracker.Core.EFContext
{
    public class DatabaseContext : IdentityDbContext<ApplicationUser>, IDatabaseContext
    {

        public DatabaseContext()
        {

        }

        public DatabaseContext(IOptions<MyConfig> myConfig) : base(new DefaultContextFactory(myConfig).GetDataContext().Options)
        {

        }

        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {

        }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                var dbName = "ExpenseTracker";
                var connectionString = "Server=localhost;Database=" + dbName + DateTime.Now.Year + "_1;Trusted_Connection=True;";
                optionsBuilder.UseSqlServer(connectionString);
            }

            base.OnConfiguring(optionsBuilder);
        }

        public DbSet<Expense> Expense { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<IncomeSource> IncomeSource { get; set; }
        public DbSet<ExpenseType> ExpenseType { get; set; }
        public DbSet<CategoryType> CategoryType { get; set; }
        public DbSet<Bank> Bank { get; set; }
        public DbSet<YealyTotal> YealyTotal { get; set; }
        public DatabaseFacade DatabaseFacade => this.Database;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

    }
}