using Microsoft.EntityFrameworkCore;
using ExpenseTracker.Core.EFContext;
using System;
using System.Data.SqlClient;
using Microsoft.Extensions.Options;

namespace ExpenseTracker.Core.Factory
{
    public class DefaultContextFactory : IContextFactory
    {
        public DefaultContextFactory(IOptions<MyConfig> myConfig)
        {
            MyConfig = myConfig;
        }

        public IOptions<MyConfig> MyConfig { get; }

        public DbContextOptionsBuilder<DatabaseContext> GetDataContext()
        {
            var dbName = "ExpenseTracker";
            if (MyConfig.Value.UseDatabaseDummy)
                dbName = "Dummy";

            var con = "Server=localhost;Database=" + dbName + DateTime.Now.Year + ";Trusted_Connection=True;";

            var sqlConnectionBuilder = new SqlConnectionStringBuilder(con);

            var contextOptionsBuilder = new DbContextOptionsBuilder<DatabaseContext>();

            contextOptionsBuilder.UseSqlServer(sqlConnectionBuilder.ConnectionString);

            return contextOptionsBuilder;
        }

    }

    public class SpecialContextFactory : IContextFactory
    {
        public IOptions<MyConfig> MyConfig { get; }
        public SpecialContextFactory(IOptions<MyConfig> myConfig, int year)
        {
            MyConfig = myConfig;
            Year = year;
        }

        public int Year { get; }

        public DbContextOptionsBuilder<DatabaseContext> GetDataContext()
        {
            var dbName = "ExpenseTracker";
            if (MyConfig.Value.UseDatabaseDummy)
                dbName = "Dummy";

            var con = "Server=localhost;Database=" + dbName + Year + ";Trusted_Connection=True;";

            var sqlConnectionBuilder = new SqlConnectionStringBuilder(con);

            var contextOptionsBuilder = new DbContextOptionsBuilder<DatabaseContext>();

            contextOptionsBuilder.UseSqlServer(sqlConnectionBuilder.ConnectionString);

            return contextOptionsBuilder;
        }

    }
}