using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ExpenseTracker.Models.Configuration;
using ExpenseTracker.Models;
using Microsoft.EntityFrameworkCore.Infrastructure;
using ExpenseTracker.Core.Factory;
using Microsoft.Extensions.Options;
using System;
using ExpenseTracker.Models.Dto;

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
            // AKSHAY MAIN DB
            if (!optionsBuilder.IsConfigured)
            {
                var dbName = "DbExpenseTracker";
                var connectionString = "Server=localhost;Database=" + dbName + 2023 + ";Trusted_Connection=True;";
                optionsBuilder.UseSqlServer(connectionString);
            }

            base.OnConfiguring(optionsBuilder);
        }

        public DbSet<Transaction> Transaction { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<Income> Income { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<SubCategory> SubCategory { get; set; }
        public DbSet<Bank> Bank { get; set; }
        public DbSet<DecadeView> YealyTotal { get; set; }
        public DbSet<TransactionByYear> TransactionByYear { get; set; }
        public DbSet<TransactionByMonth> TransactionByMonth { get; set; }
        public DbSet<BankByYear> BankByYear { get; set; }
        public DbSet<ExpenseByCategoryForYear> ExpenseByCategoryForYear { get; set; }

        public DatabaseFacade DatabaseFacade => this.Database;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TransactionByYear>().HasNoKey();
            modelBuilder.Entity<TransactionByMonth>().HasNoKey();
            modelBuilder.Entity<ExpenseByCategoryForYear>().HasNoKey();
            modelBuilder.Entity<BankByYear>().HasNoKey();
            base.OnModelCreating(modelBuilder);
        }

    }
}