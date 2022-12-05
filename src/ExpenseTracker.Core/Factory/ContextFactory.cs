using Microsoft.EntityFrameworkCore;
using ExpenseTracker.Core.EFContext;
using System;
using System.Data.SqlClient;

namespace ExpenseTracker.Core.Factory
{
    /// <summary>
    /// context factory for ef
    /// </summary>
    public class ContextFactory : IContextFactory
    {
        public ContextFactory()
        {
        }

        public DbContextOptionsBuilder<DatabaseContext> GetDataContext(int year = 2022)
        {
            if (year == -1)
                year = DateTime.Now.Year;

            var con = "Server=localhost;Database=ExpenseTracker" + year + "_1;Trusted_Connection=True;";

            var sqlConnectionBuilder = new SqlConnectionStringBuilder(con);

            var contextOptionsBuilder = new DbContextOptionsBuilder<DatabaseContext>();

            contextOptionsBuilder.UseSqlServer(sqlConnectionBuilder.ConnectionString);

            return contextOptionsBuilder;
        }
        
    }
}