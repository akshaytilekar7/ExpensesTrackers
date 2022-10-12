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
            _serviceFactory = new ServiceFactory(_unitOfWork);
        }

        public async Task<List<DtoYealry>> GetYearlyData(int year)
        {
            var repoCategory = _unitOfWork.GetRepository<CategoryType>();
            var repoExpense = _unitOfWork.GetRepository<Expense>();
            var repoIncomeSource = _unitOfWork.GetRepository<IncomeSource>();

            var lstCategory = repoCategory.GetAll("ExpenseType");

            List<Expression<Func<Expense, object>>> includers = new List<Expression<Func<Expense, object>>>();
            includers.Add(x => x.CategoryType);
            includers.Add(x => x.CategoryType.ExpenseType);
            var lstExpenses = await repoExpense.GetAllAsync(includers);
            lstExpenses = lstExpenses.OrderByDescending(x => x.Id).Where(x => x.Date.Year == year);

            var lstIncomeSource = repoIncomeSource.GetAll().Where(x => x.Date.Year == year).ToList();

            List<DtoYealry> dtoYealries = new List<DtoYealry>();
            foreach (var itemCategory in lstCategory)
            {
                DtoYealry dtoYealry = new DtoYealry();
                dtoYealry.Category = itemCategory.Name + " (" + itemCategory.ExpenseType.Name + ")";
                var lstExpensesByCategory = lstExpenses.Where(e => e.CategoryType.Name == itemCategory.Name);

                var expensesByMonth = GetExpensesByMonth(lstExpensesByCategory, 1).ToList();
                dtoYealry.Jan = expensesByMonth.Sum(x => x.Amount);
                dtoYealry.JanLst = expensesByMonth;

                expensesByMonth = GetExpensesByMonth(lstExpensesByCategory, 2).ToList();
                dtoYealry.Feb = expensesByMonth.Sum(x => x.Amount);
                dtoYealry.FebLst = expensesByMonth;

                expensesByMonth = GetExpensesByMonth(lstExpensesByCategory, 3).ToList();
                dtoYealry.March = expensesByMonth.Sum(x => x.Amount);
                dtoYealry.MarchLst = expensesByMonth;

                expensesByMonth = GetExpensesByMonth(lstExpensesByCategory, 4).ToList();
                dtoYealry.April = expensesByMonth.Sum(x => x.Amount);
                dtoYealry.AprilLst = expensesByMonth;

                expensesByMonth = GetExpensesByMonth(lstExpensesByCategory, 5).ToList();
                dtoYealry.May = expensesByMonth.Sum(x => x.Amount);
                dtoYealry.MayLst = expensesByMonth;

                expensesByMonth = GetExpensesByMonth(lstExpensesByCategory, 6).ToList();
                dtoYealry.June = expensesByMonth.Sum(x => x.Amount);
                dtoYealry.JuneLst = expensesByMonth;

                expensesByMonth = GetExpensesByMonth(lstExpensesByCategory, 7).ToList();
                dtoYealry.July = expensesByMonth.Sum(x => x.Amount);
                dtoYealry.JulyLst = expensesByMonth;

                expensesByMonth = GetExpensesByMonth(lstExpensesByCategory, 8).ToList();
                dtoYealry.August = expensesByMonth.Sum(x => x.Amount);
                dtoYealry.AugustLst = expensesByMonth;

                expensesByMonth = GetExpensesByMonth(lstExpensesByCategory, 9).ToList();
                dtoYealry.September = expensesByMonth.Sum(x => x.Amount);
                dtoYealry.SeptemberLst = expensesByMonth;

                expensesByMonth = GetExpensesByMonth(lstExpensesByCategory, 10).ToList();
                dtoYealry.October = expensesByMonth.Sum(x => x.Amount);
                dtoYealry.OctoberLst = expensesByMonth;

                expensesByMonth = GetExpensesByMonth(lstExpensesByCategory, 11).ToList();
                dtoYealry.November = expensesByMonth.Sum(x => x.Amount);
                dtoYealry.NovemberLst = expensesByMonth;

                expensesByMonth = GetExpensesByMonth(lstExpensesByCategory, 12).ToList();
                dtoYealry.December = expensesByMonth.Sum(x => x.Amount);
                dtoYealry.DecemberLst = expensesByMonth;

                dtoYealry.CatogoryTotal = lstExpensesByCategory.Sum(s => s.Amount);
                dtoYealries.Add(dtoYealry);
            }

            var dto = new DtoYealry();
            dto.Category = "Z Total";
            dto.Jan = lstExpenses.Where(ec => ec.Date.Date.Month == 1).ToList().Sum(x => x.Amount);
            dto.Feb = lstExpenses.Where(ec => ec.Date.Date.Month == 2).ToList().Sum(x => x.Amount);
            dto.March = lstExpenses.Where(ec => ec.Date.Date.Month == 3).ToList().Sum(x => x.Amount);
            dto.April = lstExpenses.Where(ec => ec.Date.Date.Month == 4).ToList().Sum(x => x.Amount);
            dto.May = lstExpenses.Where(ec => ec.Date.Date.Month == 5).ToList().Sum(x => x.Amount);
            dto.June = lstExpenses.Where(ec => ec.Date.Date.Month == 6).ToList().Sum(x => x.Amount);
            dto.July = lstExpenses.Where(ec => ec.Date.Date.Month == 7).ToList().Sum(x => x.Amount);
            dto.August = lstExpenses.Where(ec => ec.Date.Date.Month == 8).ToList().Sum(x => x.Amount);
            dto.September = lstExpenses.Where(ec => ec.Date.Date.Month == 9).ToList().Sum(x => x.Amount);
            dto.October = lstExpenses.Where(ec => ec.Date.Date.Month == 10).ToList().Sum(x => x.Amount);
            dto.November = lstExpenses.Where(ec => ec.Date.Date.Month == 11).ToList().Sum(x => x.Amount);
            dto.December = lstExpenses.Where(ec => ec.Date.Date.Month == 12).ToList().Sum(x => x.Amount);
            dto.CatogoryTotal = lstExpenses.Sum(s => s.Amount);
            dtoYealries.Add(dto);

            return dtoYealries.OrderBy(x => x.Category).ToList();
        }

        public async Task<List<DtoYearlyExpense>> GetAllMonthsData(int year)
        {
            var filter = new DtoExpenseFilter()
            {
                StartDate = new DateTime(year, 1, 1),
                EndDate = new DateTime(year, 12, 31),
            };

            List<DtoExpense> lstExpenses = await _serviceFactory.ExpenseServices.GetExpenseFilter(filter);

            int[] lstMonths = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
            List<DtoYearlyExpense> yearlyExpense = new List<DtoYearlyExpense>();
            foreach (var month in lstMonths)
            {
                var sDate = new DateTime(year, month, 1);
                var eDate = new DateTime(year, month, DateTime.DaysInMonth(year, month));

                var lst = lstExpenses.Where(x => x.Date >= sDate && x.Date <= eDate).ToList();
                if (lst.Count() != 0 && lst.Any())
                    yearlyExpense.Add(new DtoYearlyExpense() { dtoExpenses = lst, Name = ((Months)month).ToString() });
            }
            return yearlyExpense;
        }

        public async Task<DtoYearlyExpenseByExpensesType> GetAllMonthDataOnExpenseType(int year)
        {

            int[] lstMonths = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
            var row = new DtoYearlyExpenseByExpensesType();

            foreach (var month in lstMonths)
            {
                var sDate = new DateTime(year, month, 1);
                var eDate = new DateTime(year, month, DateTime.DaysInMonth(year, month));
                var filter = new DtoExpenseFilter()
                {
                    StartDate = sDate,
                    EndDate = eDate,
                };

                List<DtoExpenseByExpensesType> dbList = await GetExpenseByExpensesType(filter);
                if (dbList.Any())
                    row.dtoExpenseByCategories.AddRange(dbList);
            }
            return row;
        }
        
        public async Task<List<DtoExpenseByExpensesType>> GetExpenseByExpensesType(DtoExpenseFilter filter)
        {
            var month = string.Empty;
            var lstExpense = await _serviceFactory.ExpenseServices.GetExpenseFilter(filter);
            var income = _serviceFactory.IncomeService.GetAll().Where(x => x.Date >= filter.StartDate && x.Date <= filter.EndDate).Sum(x => x.Amount);
            var lstExpenseTypes = _serviceFactory.MasterTableService.GetAllExpenseType().Select(x => x.Name).Distinct();

            
            var percentSum = 0;
            var dto = new DtoExpenseByExpensesType(month);
            var lstExpenseByCategory = new List<DtoExpenseByExpensesType>();
            foreach (var types in lstExpenseTypes)
            {
                month = filter.StartDate.Month + " - " + filter.EndDate.Month;
                dto.ExpensesType = types;
                dto.Amount = lstExpense.Where(x => x.ExpenseType == types).Sum(x => x.Amount);
                var percentage = (int)Math.Round((double)(100 * dto.Amount) / income);
                dto.Percent = percentage + " %";
                percentSum += percentage;
                lstExpenseByCategory.Add(dto);
            }

            month = filter.StartDate.Month + " - " + filter.EndDate.Month;
            dto.ExpensesType = "Total Income";
            dto.Amount = income;
            dto.Percent = "NA"; ;
            lstExpenseByCategory.Add(dto);

            var sum = lstExpense.Sum(x => x.Amount);
            dto = new DtoExpenseByExpensesType(month);
            dto.ExpensesType = "Total Expense";
            dto.Amount = sum;
            dto.Percent = percentSum + " %"; ;
            lstExpenseByCategory.Add(dto);

            dto = new DtoExpenseByExpensesType(month);
            dto.ExpensesType = "Balance";
            dto.Amount = income - sum;
            dto.Percent = "NA";
            lstExpenseByCategory.Add(dto);

            return lstExpenseByCategory;
        }
        
        public List<IncomeSource> GetIncome(DateTime startDate, DateTime endDate)
        {
            IEnumerable<IncomeSource> lst = _serviceFactory.IncomeService.GetAll().Where(x => x.Date >= startDate && x.Date <= endDate);
            return lst.ToList();
        }

        private static IEnumerable<Expense> GetExpensesByMonth(IEnumerable<Expense> lstExpensesByCategory, int month)
        {
            return lstExpensesByCategory.Where(ec => ec.Date.Date.Month == month);
        }

    }
}
