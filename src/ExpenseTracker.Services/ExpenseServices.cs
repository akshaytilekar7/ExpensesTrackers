using System;
using System.Collections.Generic;
using ExpenseTracker.Core.Uow;
using System.Linq;
using ExpenseTracker.Services.Base.Contracts;
using ExpenseTracker.Models.Dto;
using System.Threading.Tasks;
using System.Linq.Expressions;
using ExpenseTracker.Models;
using ExpenseTracker.Services.Factory;

namespace ExpenseTracker.Services
{
    public class ExpenseServices : IExpenseServices
    {
        private readonly IUnitOfWork _unitOfWork;

        public ExpenseServices(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public bool Add(Expense item)
        {
            bool result = false;
            try
            {
                if (item != null)
                {
                    var repo = _unitOfWork.GetRepository<Expense>();
                    repo.Add(item);
                    _unitOfWork.Commit();
                    result = true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw;
            }

            return result;
        }

        public void Add(List<Expense> lst)
        {
            var repo = _unitOfWork.GetRepository<Expense>();
            foreach (var item in lst)
            {
                repo.Add(item);
                _unitOfWork.Commit();
            }
        }

        public void Delete(List<Expense> lst)
        {
            var repository = _unitOfWork.GetRepository<Expense>();
            foreach (var item in lst)
                repository.HardDelete(item);
            _unitOfWork.Commit();
        }

        public async Task<List<DtoExpense>> GetExpenseFilter(DtoExpenseFilter filter)
        {
            var expenseRepository = _unitOfWork.GetRepository<Expense>();
            List<Expression<Func<Expense, object>>> includers = new List<Expression<Func<Expense, object>>>();
            includers.Add(x => x.CategoryType);
            includers.Add(x => x.CategoryType.ExpenseType);
            includers.Add(x => x.Bank);
            includers.Add(x => x.User);

            IEnumerable<Expense> lstExpenses = await expenseRepository.GetAllAsync(includers);

            if (filter.StartDate != DateTime.MinValue && filter.EndDate != DateTime.MinValue)
            {
                lstExpenses = lstExpenses.Where(x => x.Date >= filter.StartDate && x.Date <= filter.EndDate);
            }
            else
            {
                throw new Exception("Date is mandatory");
            }

            if (filter.Amount >= 1)
                lstExpenses = lstExpenses.Where(x => x.Amount == filter.Amount);

            if (filter.CategoryId > 0)
                lstExpenses = lstExpenses.Where(x => x.CategoryType.Id == filter.CategoryId);

            if (filter.ExpenseTypeId > 0)
                lstExpenses = lstExpenses.Where(x => x.CategoryType.ExpenseType.Id == filter.ExpenseTypeId);

            if (!string.IsNullOrEmpty(filter.Comment))
                lstExpenses = lstExpenses.Where(x => x.Comment.ToLower().Contains(filter.Comment.ToLower()));

            if (filter.UserId > 0)
                lstExpenses = lstExpenses.Where(x => x.UserId == filter.UserId);

            if (filter.BankId > 0)
                lstExpenses = lstExpenses.Where(x => x.BankId == filter.BankId);

            lstExpenses = lstExpenses.OrderBy(x => x.Date);

            var userRepository = _unitOfWork.GetRepository<User>();
            var users = userRepository.GetAll();

            var incomeSourceRepository = _unitOfWork.GetRepository<IncomeSource>();

            var lstDtoExpense = lstExpenses.Select(s => new DtoExpense()
            {
                Id = s.Id,
                CategoryName = s.CategoryType.Name,
                Date = s.Date,
                Amount = s.Amount,
                ExpenseType = s.CategoryType.ExpenseType.Name,
                Comment = s.Comment,
                User = s.User.Name,
                BankName = s.Bank.Name,
            }).ToList();

            if (filter.BankId > 0)
            {
                if (filter.StartDate != DateTime.MinValue && filter.EndDate != DateTime.MinValue)
                {
                    var income = incomeSourceRepository.GetAll().Where(x => x.BankId == filter.BankId).Sum(x => x.Amount);
                    var ExpenseTillStartDate = expenseRepository.GetAll().Where(x => x.Date <= filter.StartDate.AddDays(-1) && x.BankId == filter.BankId).Sum(x => x.Amount);
                    ExpenseTillStartDate = income - ExpenseTillStartDate;
                    foreach (var item in lstDtoExpense)
                    {
                        ExpenseTillStartDate = ExpenseTillStartDate - item.Amount;
                        item.Balance = ExpenseTillStartDate;
                    }
                }
            }
            return lstDtoExpense;
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
