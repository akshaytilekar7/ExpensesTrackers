using System.Collections.Generic;
using ExpenseTracker.Core.Uow;
using System.Linq;
using ExpenseTracker.Services.Base.Contracts;
using ExpenseTracker.Models;
using System.Threading.Tasks;
using System.Linq.Expressions;
using System;
using ExpenseTracker.Models.Dto;

namespace ExpenseTracker.Services
{
    public class BankService : IBankService
    {
        private readonly IUnitOfWork _unitOfWork;

        public BankService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        List<Bank> IBankService.GetAll()
        {
            var banks = _unitOfWork.GetRepository<Bank>().GetAll().ToList();
            return banks;
        }

        public async Task<List<DtoBank>> GetBankData(DateTime startDate, DateTime endDate)
        {
            var repoIncomeSource = _unitOfWork.GetRepository<IncomeSource>();
            List<Expression<Func<IncomeSource, object>>> includers = new List<Expression<Func<IncomeSource, object>>>();
            includers.Add(x => x.User);
            includers.Add(x => x.Bank);
            IEnumerable<IncomeSource> lstIncomeSources = await repoIncomeSource.GetAllAsync(includers);

            List<DtoBank> lstDtoBanks = new List<DtoBank>();
            var expenseRepository = _unitOfWork.GetRepository<Expense>();
            List<Expression<Func<Expense, object>>> includersE = new List<Expression<Func<Expense, object>>>();
            includersE.Add(x => x.CategoryType);
            includersE.Add(x => x.CategoryType.ExpenseType);
            includersE.Add(x => x.Bank);
            includersE.Add(x => x.User);

            IEnumerable<Expense> lstExpenses = await expenseRepository.GetAllAsync(includersE);

            if (startDate != DateTime.MinValue && endDate != DateTime.MinValue)
            {
                lstIncomeSources = lstIncomeSources.Where(x => x.Date >= startDate && x.Date <= endDate);
                lstExpenses = lstExpenses.Where(x => x.Date >= startDate && x.Date <= endDate);
            }

            var repoBank = _unitOfWork.GetRepository<Bank>();
            var lstBanks = repoBank.GetAll().ToList();

            var DistinctItems = lstIncomeSources.GroupBy(x => x.BankId);

            foreach (var _bank in lstBanks)
            {
                decimal amount = lstIncomeSources.Where(x => x.BankId == _bank.Id).Sum(x => x.Amount);
                var expense = lstExpenses.Where(x => x.BankId == _bank.Id).Sum(x => x.Amount);

                lstDtoBanks.Add(new DtoBank()
                {
                    BankName = _bank.Name,
                    Amount = amount,
                    Expense = expense,
                    Balance = amount - expense
                });
            }

            lstDtoBanks.Add(new DtoBank()
            {
                BankName = "Total",
                Amount = lstDtoBanks.Sum(x => x.Amount),
                Expense = lstDtoBanks.Sum(x => x.Expense),
                Balance = lstDtoBanks.Sum(x => x.Amount) - lstDtoBanks.Sum(x => x.Expense)
            });

            return lstDtoBanks;
        }


    }
}
