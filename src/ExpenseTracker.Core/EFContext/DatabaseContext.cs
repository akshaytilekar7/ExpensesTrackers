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
                var connectionString = "Server=localhost;Database=" + dbName + DateTime.Now.Year + ";Trusted_Connection=True;";
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
        public DbSet<YealyTotal> YealyTotal { get; set; }
        public DatabaseFacade DatabaseFacade => this.Database;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

    }
}