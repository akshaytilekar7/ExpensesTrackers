using ExpenseTracker.Models;
using ExpenseTracker.Models.Dto;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ExpenseTracker.Services.Base.Contracts
{
    public interface IExpenseServices
    {
        bool Add(Expense item);
        void Add(List<Expense> lst);
        void Delete(List<Expense> lst);
        Task<List<DtoExpense>> GetExpenseFilter(DtoExpenseFilter expenseFilter);
        Task<List<DtoBank>> GetBankData(DateTime startDate, DateTime endDate);
    }
}
