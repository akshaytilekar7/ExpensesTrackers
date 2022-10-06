﻿using ExpenseTracker.Models;
using ExpenseTracker.Models.Dto;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ExpenseTracker.Services.Base.Contracts
{
    public interface IExpenseServices
    {
        bool Add(Expense item);
        void Add(List<Expense> lst);
        IList<Expense> GetAll();
        void Delete(List<Expense> lst);
        Task<List<DtoExpense>> GetExpenseFilter(DtoExpenseFilter expenseFilter);

    }
}