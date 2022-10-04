using System;
using System.Collections.Generic;
using PatternForCore.Core.Uow;
using System.Linq;
using PatternForCore.Models;
using PatternForCore.Services.Base.Contracts;
using PatternForCore.Models.Dto;
using System.Threading.Tasks;
using System.Linq.Expressions;

namespace PatternForCore.Services
{
    public class ExpenseServices : IExpenseServices
    {
        private readonly IUnitOfWork _unitOfWork;

        public ExpenseServices(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public bool Add(Expense expense)
        {
            bool result = false;
            try
            {
                if (expense != null)
                {
                    var movieRepository = _unitOfWork.GetRepository<Expense>();
                    movieRepository.Add(expense);
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
            var movieRepository = _unitOfWork.GetRepository<Expense>();
            foreach (var item in lst)
            {
                movieRepository.Add(item);
                _unitOfWork.Commit();
            }
        }

        public IList<Expense> GetAll()
        {
            var movieRepository = _unitOfWork.GetRepository<Expense>();
            List<Expression<Func<Expense, object>>> includers = new List<Expression<Func<Expense, object>>>();
            includers.Add(x => x.MasterCategoryType);
            includers.Add(x => x.MasterCategoryType.MasterExpenseType);
            return movieRepository.GetAll(includers).OrderByDescending(x => x.Id).ToList();
        }

        public void Delete(List<Expense> lst)
        {
            var repository = _unitOfWork.GetRepository<Expense>();
            foreach (var item in lst)
                repository.HardDelete(item);
            _unitOfWork.Commit();
        }

        public async Task<List<DtoExpense>> GetExpenseFilter(ExpenseFilter expenseFilter)
        {
            var expenseRepository = _unitOfWork.GetRepository<Expense>();

            List<Expression<Func<Expense, object>>> includers = new List<Expression<Func<Expense, object>>>();
            includers.Add(x => x.MasterCategoryType);
            includers.Add(x => x.MasterCategoryType.MasterExpenseType);
            var dbList = await expenseRepository.GetAllAsync(includers);

            if (expenseFilter.StartDate != DateTime.MinValue && expenseFilter.EndDate != DateTime.MinValue)
                dbList = dbList.Where(x => x.Date >= expenseFilter.StartDate && x.Date <= expenseFilter.EndDate);

            if (expenseFilter.Amount >= 1)
                dbList = dbList.Where(x => x.Amount == expenseFilter.Amount);

            if (expenseFilter.CategoryId > 0)
                dbList = dbList.Where(x => x.MasterCategoryType.Id == expenseFilter.CategoryId);

            if (expenseFilter.ExpenseTypeId > 0)
                dbList = dbList.Where(x => x.MasterCategoryType.MasterExpenseType.Id == expenseFilter.ExpenseTypeId);

            if (!string.IsNullOrEmpty(expenseFilter.Comment))
                dbList = dbList.Where(x => x.Comment.ToLower().Contains(expenseFilter.Comment.ToLower()));

            if (expenseFilter.UserId > 0)
                dbList = dbList.Where(x => x.UserId == expenseFilter.UserId);

            dbList = dbList.OrderBy(x => x.Date);

            var userRepository = _unitOfWork.GetRepository<User>();
            var users = userRepository.GetAll();    
            var result = dbList.Select(s => new DtoExpense()
            {
                Id = s.Id,
                CategoryName = s.MasterCategoryType.Name,
                Date = s.Date,
                Amount = s.Amount,
                ExpenseType = s.MasterCategoryType.MasterExpenseType.Name, 
                Comment = s.Comment,
                User = users.FirstOrDefault(x => x.Id == s.UserId).Name
            });

            return result.ToList();
        }
    }
}
