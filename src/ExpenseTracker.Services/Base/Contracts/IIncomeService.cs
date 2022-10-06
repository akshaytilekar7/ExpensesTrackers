using ExpenseTracker.Models;
using System.Collections.Generic;

namespace ExpenseTracker.Services.Base.Contracts
{
    public interface IIncomeService
    {
        bool Add(IncomeSource item);
        IList<IncomeSource> GetAll();
        void Delete(List<IncomeSource> lst);

    }
}
