using System;
using System.Collections.Generic;
using ExpenseTracker.Core.Uow;
using System.Linq;
using ExpenseTracker.Services.Base.Contracts;
using ExpenseTracker.Models.Dto;
using System.Threading.Tasks;
using System.Linq.Expressions;
using ExpenseTracker.Models;

namespace ExpenseTracker.Services
{
    public class TransactionServices : ITransactionServices
    {
        private readonly IUnitOfWork _unitOfWork;

        public TransactionServices(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public bool Add(Transaction item)
        {
            bool result = false;
            try
            {
                if (item != null)
                {
                    var repo = _unitOfWork.GetRepository<Transaction>();
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

        public void Add(List<Transaction> lst)
        {
            var repo = _unitOfWork.GetRepository<Transaction>();
            foreach (var item in lst)
            {
                repo.Add(item);
                _unitOfWork.Commit();
            }
        }

        public void Delete(List<Transaction> lst)
        {
            var repository = _unitOfWork.GetRepository<Transaction>();
            foreach (var item in lst)
                repository.HardDelete(item);
            _unitOfWork.Commit();
        }

        public async Task<List<DtoTransaction>> GetTransactions(DtoTransactionFilter filter)
        {
            var transactionRepo = _unitOfWork.GetRepository<Transaction>();
            List<Expression<Func<Transaction, object>>> includers = new List<Expression<Func<Transaction, object>>>();
            includers.Add(x => x.SubCategory);
            includers.Add(x => x.SubCategory.Category);
            includers.Add(x => x.Bank);
            includers.Add(x => x.User);

            IEnumerable<Transaction> transactions = await transactionRepo.GetAllAsync(includers);

            if (filter.StartDate != DateTime.MinValue && filter.EndDate != DateTime.MinValue)
                transactions = transactions.Where(x => x.Date >= filter.StartDate && x.Date <= filter.EndDate);
            else
                throw new Exception("Date is mandatory");

            if (filter.Amount >= 1)
                transactions = transactions.Where(x => x.Amount == filter.Amount);

            if (filter.SubCategoryId > 0)
                transactions = transactions.Where(x => x.SubCategory.Id == filter.SubCategoryId);

            if (filter.CategoryId > 0)
                transactions = transactions.Where(x => x.SubCategory.Category.Id == filter.CategoryId);

            if (!string.IsNullOrEmpty(filter.Comment))
                transactions = transactions.Where(x => x.Comment.ToLower().Contains(filter.Comment.ToLower()));

            if (filter.UserId > 0)
                transactions = transactions.Where(x => x.UserId == filter.UserId);

            if (filter.BankId > 0)
                transactions = transactions.Where(x => x.BankId == filter.BankId);

            transactions = transactions.OrderBy(x => x.Date);

            var userRepository = _unitOfWork.GetRepository<User>();
            var users = userRepository.GetAll();

            var incomeSourceRepo = _unitOfWork.GetRepository<Income>();

            var lstDtoTransactions = transactions.Select(s => new DtoTransaction()
            {
                Id = s.Id,
                SubCategoryName = s.SubCategory.Name,
                Date = s.Date,
                Amount = s.Amount,
                CategoryName = s.SubCategory.Category.Name,
                Comment = s.Comment,
                User = s.User.Name,
                BankName = s.Bank.Name,
            }).ToList();

            if (filter.BankId > 0)
            {
                if (filter.StartDate != DateTime.MinValue && filter.EndDate != DateTime.MinValue)
                {
                    var income = incomeSourceRepo.GetAll().Where(x => x.BankId == filter.BankId && x.Date.Year == filter.StartDate.Year).Sum(x => x.Amount);

                    var ExpenseTillStartDate = transactionRepo.GetAll()
                        .Where(x => x.Date <= filter.StartDate.AddDays(-1) && x.BankId == filter.BankId)
                        .Sum(x => x.Amount);
                    ExpenseTillStartDate = income - ExpenseTillStartDate;
                    foreach (var item in lstDtoTransactions)
                    {
                        ExpenseTillStartDate = ExpenseTillStartDate - item.Amount;
                        item.Balance = ExpenseTillStartDate;
                    }
                }
            }

            lstDtoTransactions = lstDtoTransactions.OrderBy(x => x.Id).ToList();

            
            return lstDtoTransactions;
        }

        public async Task<List<DtoTransaction>> GetYearlyForTooltip(int year, string category)
        {
            var _categoryRepository = _unitOfWork.GetRepository<SubCategory>();
            SubCategory dbCategory = _categoryRepository.FindBy(x => x.Name == category).FirstOrDefault();
            if (dbCategory == null)
                return new List<DtoTransaction>();

            DtoTransactionFilter dtoExpenseFilter = new DtoTransactionFilter()
            {
                SubCategoryId = dbCategory.Id,
                StartDate = new DateTime(year, 1, 1),
                EndDate = new DateTime(year, 12, 31),
            };

            var lstDtoExpense = await GetTransactions(dtoExpenseFilter);
            return lstDtoExpense;
        }

    }
}