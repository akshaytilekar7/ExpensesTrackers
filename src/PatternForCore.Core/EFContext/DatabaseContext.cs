﻿using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PatternForCore.Models;
using PatternForCore.Models.Configuration;

namespace PatternForCore.Core.EFContext
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

        //public DbSet<Category> Category { get; set; }
        public DbSet<Expense> Expense { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<IncomeSource> IncomeSource { get; set; }
        public DbSet<MasterExpenseType> MasterExpenseType { get; set; }
        public DbSet<MasterCategoryType> MasterCategoryType { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}