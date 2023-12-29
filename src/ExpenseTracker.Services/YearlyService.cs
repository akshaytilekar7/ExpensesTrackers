using System.Collections.Generic;
using ExpenseTracker.Core.Uow;
using System.Linq;
using ExpenseTracker.Models;
using ExpenseTracker.Services.Base.Contracts;
using ExpenseTracker.Models.Dto;
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;
using System.Data;
using System;
using ExpenseTracker.Services.Factory;
using System.Threading.Tasks;
using System.Linq.Expressions;

namespace ExpenseTracker.Services
{
    public class YearlyService : IYearlyService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ServiceFactory _serviceFactory;
        public YearlyService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _serviceFactory = new ServiceFactory(_unitOfWork, null);
        }

        public async Task<List<TransactionByYear>> GetTransactionByYear(int year)
        {
            var repoExpense = _unitOfWork.GetRepository<Transaction>();
            return await repoExpense.GetTransactionByYear(year);
        }

        public async Task<List<TransactionByMonth>> GetTransactionByMonth(int year, int month, int subCategoryId)
        {
            var repoExpense = _unitOfWork.GetRepository<Transaction>();
            return await repoExpense.GetTransactionByMonth(year, month, subCategoryId);
        }

        public async Task<List<BankByYear>> GetBankSummary(int year)
        {
            var repoExpense = _unitOfWork.GetRepository<Transaction>();
            return await repoExpense.GetBankSummary(year);
        }

        public async Task<List<ExpenseByCategoryForYear>> GetExpenseByCategoryForYear(int year)
        {
            var repoExpense = _unitOfWork.GetRepository<Transaction>();
            return await repoExpense.GetExpenseByCategoryForYear(year);
        }
    }
}
