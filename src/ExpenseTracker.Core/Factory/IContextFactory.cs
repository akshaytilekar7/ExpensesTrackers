using ExpenseTracker.Core.EFContext;

namespace ExpenseTracker.Core.Factory
{
    public interface IContextFactory
    {
        IDatabaseContext DbContext { get; }
    }
}