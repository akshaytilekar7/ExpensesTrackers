using System.Collections.Generic;
using PatternForCore.Core.Uow;
using System.Linq;
using PatternForCore.Models;
using PatternForCore.Services.Base.Contracts;
using PatternForCore.Models.Dto;
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;

namespace PatternForCore.Services
{
    public class YearlyService : IYearlyService
    {
        private readonly IUnitOfWork _unitOfWork;

        public YearlyService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public List<DtoYealry> GetYearlyData(int year, out int total)
        {
            var repoExpense = _unitOfWork.GetRepository<Expense>();
            var lstExpenses = repoExpense.GetAll("Category").Where(x => x.Date.Year == year).ToList();

            List<DtoYealry> dtoYealries = new List<DtoYealry>();
            var repoCategory = _unitOfWork.GetRepository<Category>();
            var lstCategory = repoCategory.GetAll();

            foreach (var itemCategory in lstCategory)
            {
                DtoYealry dtoYealry = new DtoYealry();
                dtoYealry.Category = itemCategory.CategoryName + " (" + itemCategory.ExpensesType + ")";
                var lstExpensesByCategory = lstExpenses.Where(e => e.Category.CategoryName == itemCategory.CategoryName);
                dtoYealry.Jan = lstExpensesByCategory.Where(ec => ec.Date.Date.Month == 1).ToList().Sum(x => x.Amount);
                dtoYealry.Feb = lstExpensesByCategory.Where(ec => ec.Date.Date.Month == 2).ToList().Sum(x => x.Amount);
                dtoYealry.March = lstExpensesByCategory.Where(ec => ec.Date.Date.Month == 3).ToList().Sum(x => x.Amount);
                dtoYealry.April = lstExpensesByCategory.Where(ec => ec.Date.Date.Month == 4).ToList().Sum(x => x.Amount);
                dtoYealry.May = lstExpensesByCategory.Where(ec => ec.Date.Date.Month == 5).ToList().Sum(x => x.Amount);
                dtoYealry.June = lstExpensesByCategory.Where(ec => ec.Date.Date.Month == 6).ToList().Sum(x => x.Amount);
                dtoYealry.July = lstExpensesByCategory.Where(ec => ec.Date.Date.Month == 7).ToList().Sum(x => x.Amount);
                dtoYealry.August = lstExpensesByCategory.Where(ec => ec.Date.Date.Month == 8).ToList().Sum(x => x.Amount);
                dtoYealry.September = lstExpensesByCategory.Where(ec => ec.Date.Date.Month == 9).ToList().Sum(x => x.Amount);
                dtoYealry.October = lstExpensesByCategory.Where(ec => ec.Date.Date.Month == 10).ToList().Sum(x => x.Amount);
                dtoYealry.November = lstExpensesByCategory.Where(ec => ec.Date.Date.Month == 11).ToList().Sum(x => x.Amount);
                dtoYealry.December = lstExpensesByCategory.Where(ec => ec.Date.Date.Month == 12).ToList().Sum(x => x.Amount);
                dtoYealry.CatogoryTotal = lstExpensesByCategory.Sum(s => s.Amount);
                dtoYealries.Add(dtoYealry);
            }
            
            total = lstExpenses.Sum(x => x.Amount); 
            return dtoYealries.OrderBy(x => x.Category).ToList();
        }
    }
}
