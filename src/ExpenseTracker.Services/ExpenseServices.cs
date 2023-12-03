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

        public async Task<List<DtoExpense>> GetExpense(DtoExpenseFilter filter)
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
                    var income = incomeSourceRepository.GetAll().Where(x => x.BankId == filter.BankId && x.Date.Year == filter.StartDate.Year).Sum(x => x.Amount);

                    var ExpenseTillStartDate = expenseRepository.GetAll()
                        .Where(x => x.Date <= filter.StartDate.AddDays(-1) && x.BankId == filter.BankId)
                        .Sum(x => x.Amount);
                    ExpenseTillStartDate = income - ExpenseTillStartDate;
                    foreach (var item in lstDtoExpense)
                    {
                        ExpenseTillStartDate = ExpenseTillStartDate - item.Amount;
                        item.Balance = ExpenseTillStartDate;
                    }
                }
            }

            lstDtoExpense = lstDtoExpense.OrderBy(x => x.Id).ToList();

            //List<int> indexes = new List<int>();
            //var month = lstDtoExpense.FirstOrDefault().Date.Month;
            //if (filter.StartDate.Month != filter.EndDate.Month)
            //{
            //    for (int i = 0; i < lstDtoExpense.Count; i++)
            //    {
            //        DtoExpense item = lstDtoExpense[i];
            //        if (item.Date.Month != month)
            //        {
            //            month = item.Date.Month;
            //            indexes.Add(i);
            //        }
            //    }
            //}
            //foreach (var item in indexes)
            //{
            //    lstDtoExpense.Insert(item, new DtoExpense());
            //}
            return lstDtoExpense;
        }

    }
}
