using PatternForCore.Models;
using PatternForCore.Models.Dto;
using System.Collections.Generic;

namespace PatternForCore.Services.Base.Contracts
{
    public interface IExpenseServices
    {
        bool Add(Expense expense);
        void Add(List<Expense> lst);
        IList<Expense> GetAll();
        void Delete(List<Expense> lst);
        List<DtoExpense> GetExpenseFilter(ExpenseFilter expenseFilter);

    }
}
