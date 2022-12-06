using ExpenseTracker.Core.EFContext;
using Microsoft.EntityFrameworkCore;

namespace ExpenseTracker.Core.Factory
{
    public interface IContextFactory
    {
        DbContextOptionsBuilder<DatabaseContext> GetDataContext();
    }
}