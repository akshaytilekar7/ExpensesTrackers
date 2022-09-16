using PatternForCore.Models;
using System.Collections.Generic;

namespace PatternForCore.Services.Base.Contracts
{
    public interface IExpenseServices
    {
        bool Add(Expense expense);
        void Add(List<Expense> lst);
        IList<Expense> GetAll();
    }
}
