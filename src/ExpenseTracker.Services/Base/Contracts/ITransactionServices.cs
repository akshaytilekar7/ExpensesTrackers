using ExpenseTracker.Models;
using ExpenseTracker.Models.Dto;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ExpenseTracker.Services.Base.Contracts
{
    public interface ITransactionServices
    {
        bool Add(Transaction item);
        void Add(List<Transaction> lst);
        void Delete(List<Transaction> lst);
        Task<List<DtoTransaction>> GetTransactions(DtoTransactionFilter expenseFilter);
    }
}
