﻿using System;
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

        public IList<Expense> GetAll()
        {
            var repo = _unitOfWork.GetRepository<Expense>();
            List<Expression<Func<Expense, object>>> includers = new List<Expression<Func<Expense, object>>>();
            includers.Add(x => x.MasterCategoryType);
            includers.Add(x => x.MasterCategoryType.MasterExpenseType);
            return repo.GetAll(includers).OrderByDescending(x => x.Id).ToList();
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
            includers.Add(x => x.MasterCategoryType);
            includers.Add(x => x.MasterCategoryType.MasterExpenseType);
            IEnumerable<Expense> lstExpenses = await expenseRepository.GetAllAsync(includers);

            if (filter.StartDate != DateTime.MinValue && filter.EndDate != DateTime.MinValue)
                lstExpenses = lstExpenses.Where(x => x.Date >= filter.StartDate && x.Date <= filter.EndDate);

            if (filter.Amount >= 1)
                lstExpenses = lstExpenses.Where(x => x.Amount == filter.Amount);

            if (filter.CategoryId > 0)
                lstExpenses = lstExpenses.Where(x => x.MasterCategoryType.Id == filter.CategoryId);

            if (filter.ExpenseTypeId > 0)
                lstExpenses = lstExpenses.Where(x => x.MasterCategoryType.MasterExpenseType.Id == filter.ExpenseTypeId);

            if (!string.IsNullOrEmpty(filter.Comment))
                lstExpenses = lstExpenses.Where(x => x.Comment.ToLower().Contains(filter.Comment.ToLower()));

            if (filter.UserId > 0)
                lstExpenses = lstExpenses.Where(x => x.UserId == filter.UserId);

            lstExpenses = lstExpenses.OrderBy(x => x.Date);

            var userRepository = _unitOfWork.GetRepository<User>();
            var users = userRepository.GetAll();    
            var lstDtoExpense = lstExpenses.Select(s => new DtoExpense()
            {
                Id = s.Id,
                CategoryName = s.MasterCategoryType.Name,
                Date = s.Date,
                Amount = s.Amount,
                ExpenseType = s.MasterCategoryType.MasterExpenseType.Name, 
                Comment = s.Comment,
                User = users.FirstOrDefault(x => x.Id == s.UserId).Name
            });

            return lstDtoExpense.ToList();
        }
    }
}
