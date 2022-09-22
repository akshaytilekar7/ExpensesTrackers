using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using PatternForCore.Core.EFContext;
using PatternForCore.Models.Configuration;
using System;
using System.Data.SqlClient;

namespace PatternForCore.Core.Factory
{
    /// <summary>
    /// context factory for ef
    /// </summary>
    public class ContextFactory : IContextFactory
    {

        public ContextFactory()
        {
        }

        public IDatabaseContext DbContext => new DatabaseContext(GetDataContext().Options);

        private DbContextOptionsBuilder<DatabaseContext> GetDataContext()
        {
            ValidateDefaultConnection();

            var sqlConnectionBuilder = new SqlConnectionStringBuilder(ConnectionSettings.DefaultConnection);

            var contextOptionsBuilder = new DbContextOptionsBuilder<DatabaseContext>();

            contextOptionsBuilder.UseSqlServer(sqlConnectionBuilder.ConnectionString);

            return contextOptionsBuilder;
        }

        private void ValidateDefaultConnection()
        {
            if (string.IsNullOrEmpty(ConnectionSettings.DefaultConnection))
            {
                throw new ArgumentNullException(nameof(ConnectionSettings.DefaultConnection));
            }
        }
    }
}