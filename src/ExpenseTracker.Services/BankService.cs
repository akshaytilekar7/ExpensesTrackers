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
            var repoIncomeSource = _unitOfWork.GetRepository<Income>();
            List<Expression<Func<Income, object>>> includers = new List<Expression<Func<Income, object>>>();
            includers.Add(x => x.User);
            includers.Add(x => x.Bank);
            IEnumerable<Income> lstIncomeSources = await repoIncomeSource.GetAllAsync(includers);

            List<DtoBank> lstDtoBanks = new List<DtoBank>();
            var expenseRepository = _unitOfWork.GetRepository<Transaction>();
            List<Expression<Func<Transaction, object>>> includersE = new List<Expression<Func<Transaction, object>>>();
            includersE.Add(x => x.SubCategory);
            includersE.Add(x => x.SubCategory.Category);
            includersE.Add(x => x.Bank);
            includersE.Add(x => x.User);

            IEnumerable<Transaction> lstTransaction = await expenseRepository.GetAllAsync(includersE);

            if (startDate != DateTime.MinValue && endDate != DateTime.MinValue)
            {
                lstIncomeSources = lstIncomeSources.Where(x => x.Date >= startDate && x.Date <= endDate);
                lstTransaction = lstTransaction.Where(x => x.Date >= startDate && x.Date <= endDate);
            }

            var repoBank = _unitOfWork.GetRepository<Bank>();
            var lstBanks = repoBank.GetAll().ToList();

            var DistinctItems = lstIncomeSources.GroupBy(x => x.BankId);

            foreach (var _bank in lstBanks)
            {
                decimal amount = lstIncomeSources.Where(x => x.BankId == _bank.Id).Sum(x => x.Amount);
                var transaction = lstTransaction.Where(x => x.BankId == _bank.Id).Sum(x => x.Amount);

                lstDtoBanks.Add(new DtoBank()
                {
                    Name = _bank.Name,
                    Amount = amount,
                    Expense = transaction,
                    Balance = amount - transaction
                });
            }

            lstDtoBanks.Add(new DtoBank()
            {
                Name = "Total",
                Amount = lstDtoBanks.Sum(x => x.Amount),
                Expense = lstDtoBanks.Sum(x => x.Expense),
                Balance = lstDtoBanks.Sum(x => x.Amount) - lstDtoBanks.Sum(x => x.Expense)
            });

            return lstDtoBanks;
        }


    }
}
