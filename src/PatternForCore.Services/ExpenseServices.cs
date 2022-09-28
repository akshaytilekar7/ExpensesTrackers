﻿using System;
using System.Collections.Generic;
using PatternForCore.Core.Uow;
using System.Linq;
using PatternForCore.Models;
using PatternForCore.Services.Base.Contracts;
using PatternForCore.Models.Dto;
using System.Threading.Tasks;

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
            return movieRepository.GetAll("Category").OrderByDescending(x => x.Id).ToList();
        }

        public void Delete(List<Expense> lst)
        {
            var repository = _unitOfWork.GetRepository<Expense>();
            foreach (var item in lst)
                repository.HardDelete(item);
            _unitOfWork.Commit();
        }

        public Task<List<DtoExpense>> GetExpenseFilter(ExpenseFilter expenseFilter)
        {
            var movieRepository = _unitOfWork.GetRepository<Expense>();
            IEnumerable<Expense> dbList = movieRepository.GetAll("MasterCategoryType"); //GetAllAsybc .ResultS

            if (expenseFilter.StartDate != DateTime.MinValue && expenseFilter.EndDate != DateTime.MinValue)
                dbList = dbList.Where(x => x.Date >= expenseFilter.StartDate && x.Date <= expenseFilter.EndDate);

            if (expenseFilter.Amount >= 1)
                dbList = dbList.Where(x => x.Amount == expenseFilter.Amount);

            if (!string.IsNullOrEmpty(expenseFilter.Category))
                dbList = dbList.Where(x => x.MasterCategoryType.Name.ToLower().Contains(expenseFilter.Category.ToLower()));
            if (!string.IsNullOrEmpty(expenseFilter.ExpenseType))
                dbList = dbList.Where(x => x.MasterCategoryType.MasterExpenseType.Name.Contains(expenseFilter.ExpenseType.ToLower()));
            if (!string.IsNullOrEmpty(expenseFilter.Comment))
                dbList = dbList.Where(x => x.Comment.ToLower().Contains(expenseFilter.Comment.ToLower()));

            dbList = dbList.OrderBy(x => x.Date);

            var result = dbList.Select(s => new DtoExpense()
            {
                Id = s.Id,
                CategoryName = s.MasterCategoryType.Name,
                Date = s.Date,
                Amount = s.Amount,
                //ExpenseType = s.MasterCategoryType.MasterExpenseType.Name, //TODO include
                Comment = s.Comment
            });

            return Task.FromResult(result.ToList());
        }
    }
}
