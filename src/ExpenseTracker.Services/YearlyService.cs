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
            _serviceFactory = new ServiceFactory(_unitOfWork, null);
        }

        public async Task<List<DtoYealryView>> GetYearlyData(int year)
        {
            var repoSubCategory = _unitOfWork.GetRepository<SubCategory>();
            var repoTransaction = _unitOfWork.GetRepository<Transaction>();
            var repoIncomeSource = _unitOfWork.GetRepository<Income>();
            var lstCategory = repoSubCategory.GetAll("Category");

            List<Expression<Func<Transaction, object>>> includers = new List<Expression<Func<Transaction, object>>>();
            includers.Add(x => x.SubCategory);
            includers.Add(x => x.SubCategory.Category);
            includers.Add(x => x.Bank);
            includers.Add(x => x.User);

            var lstTransaction = await repoTransaction.GetAllAsync(includers);
            lstTransaction = lstTransaction.OrderByDescending(x => x.Id).Where(x => x.Date.Year == year);

            var lstIncomeSource = repoIncomeSource.GetAll().Where(x => x.Date.Year == year).ToList();

            List<DtoYealryView> dtoYealries = new List<DtoYealryView>();
            foreach (var itemCategory in lstCategory)
            {
                DtoYealryView dtoYealry = new DtoYealryView();
                dtoYealry.SubCategoryName = itemCategory.Name;
                dtoYealry.CategoryName = itemCategory.Category.Name;
                dtoYealry.ExpectedAmount = itemCategory.ExpectedAmount;

                var lstExpensesByCategory = lstTransaction.Where(e => e.SubCategory.Name == itemCategory.Name);

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

            var dto = new DtoYealryView();
            dto.SubCategoryName = "Z Monthly Expense";
            dto.Jan = lstTransaction.Where(ec => ec.Date.Date.Month == 1).ToList().Sum(x => x.Amount);
            dto.Feb = lstTransaction.Where(ec => ec.Date.Date.Month == 2).ToList().Sum(x => x.Amount);
            dto.March = lstTransaction.Where(ec => ec.Date.Date.Month == 3).ToList().Sum(x => x.Amount);
            dto.April = lstTransaction.Where(ec => ec.Date.Date.Month == 4).ToList().Sum(x => x.Amount);
            dto.May = lstTransaction.Where(ec => ec.Date.Date.Month == 5).ToList().Sum(x => x.Amount);
            dto.June = lstTransaction.Where(ec => ec.Date.Date.Month == 6).ToList().Sum(x => x.Amount);
            dto.July = lstTransaction.Where(ec => ec.Date.Date.Month == 7).ToList().Sum(x => x.Amount);
            dto.August = lstTransaction.Where(ec => ec.Date.Date.Month == 8).ToList().Sum(x => x.Amount);
            dto.September = lstTransaction.Where(ec => ec.Date.Date.Month == 9).ToList().Sum(x => x.Amount);
            dto.October = lstTransaction.Where(ec => ec.Date.Date.Month == 10).ToList().Sum(x => x.Amount);
            dto.November = lstTransaction.Where(ec => ec.Date.Date.Month == 11).ToList().Sum(x => x.Amount);
            dto.December = lstTransaction.Where(ec => ec.Date.Date.Month == 12).ToList().Sum(x => x.Amount);
            dto.CatogoryTotal = lstTransaction.Sum(s => s.Amount);
            dtoYealries.Add(dto);

            dto = new DtoYealryView();
            dto.Jan = lstIncomeSource.Where(ec => ec.Date.Date.Month == 1).ToList().Sum(x => x.Amount);
            dto.Feb = lstIncomeSource.Where(ec => ec.Date.Date.Month == 2).ToList().Sum(x => x.Amount);
            dto.March = lstIncomeSource.Where(ec => ec.Date.Date.Month == 3).ToList().Sum(x => x.Amount);
            dto.April = lstIncomeSource.Where(ec => ec.Date.Date.Month == 4).ToList().Sum(x => x.Amount);
            dto.May = lstIncomeSource.Where(ec => ec.Date.Date.Month == 5).ToList().Sum(x => x.Amount);
            dto.June = lstIncomeSource.Where(ec => ec.Date.Date.Month == 6).ToList().Sum(x => x.Amount);
            dto.July = lstIncomeSource.Where(ec => ec.Date.Date.Month == 7).ToList().Sum(x => x.Amount);
            dto.August = lstIncomeSource.Where(ec => ec.Date.Date.Month == 8).ToList().Sum(x => x.Amount);
            dto.September = lstIncomeSource.Where(ec => ec.Date.Date.Month == 9).ToList().Sum(x => x.Amount);
            dto.October = lstIncomeSource.Where(ec => ec.Date.Date.Month == 10).ToList().Sum(x => x.Amount);
            dto.November = lstIncomeSource.Where(ec => ec.Date.Date.Month == 11).ToList().Sum(x => x.Amount);
            dto.December = lstIncomeSource.Where(ec => ec.Date.Date.Month == 12).ToList().Sum(x => x.Amount);
            dto.CatogoryTotal = lstIncomeSource.Sum(s => s.Amount);
            dtoYealries.Add(dto);
            dto.SubCategoryName = "Z Monthly Income";
            return dtoYealries.OrderBy(x => x.SubCategoryName).ToList();
        }

        public async Task<List<DtoYearlyTransaction>> GetTransactions(int year)
        {
            var filter = new DtoTransactionFilter()
            {
                StartDate = new DateTime(year, 1, 1),
                EndDate = new DateTime(year, 12, 31),
            };

            List<DtoTransaction> lstExpenses = await _serviceFactory.TransactionServices.GetTransactions(filter);

            int[] lstMonths = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
            List<DtoYearlyTransaction> yearlyExpense = new List<DtoYearlyTransaction>();
            foreach (var month in lstMonths)
            {
                var sDate = new DateTime(year, month, 1);
                var eDate = new DateTime(year, month, DateTime.DaysInMonth(year, month));

                var lst = lstExpenses.Where(x => x.Date >= sDate && x.Date <= eDate).ToList();
                if (lst.Count() != 0 && lst.Any())
                    yearlyExpense.Add(new DtoYearlyTransaction() { dtoTransaction = lst, Name = ((EnumMonths)month).ToString() });
            }
            return yearlyExpense;
        }

        public async Task<DtoYearlyTransactionByCategory> GetAllMonthDataOnExpenseType(int year)
        {

            int[] lstMonths = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
            var row = new DtoYearlyTransactionByCategory();

            foreach (var month in lstMonths)
            {
                var sDate = new DateTime(year, month, 1);
                var eDate = new DateTime(year, month, DateTime.DaysInMonth(year, month));
                var filter = new DtoTransactionFilter()
                {
                    StartDate = sDate,
                    EndDate = eDate,
                };

                List<DtoTransactionsByCategory> dbList = await GetExpenseByExpensesType(filter);
                if (dbList.Any())
                    row.dtoExpenseByCategories.AddRange(dbList);
            }
            return row;
        }

        public async Task<List<DtoTransactionsByCategory>> GetExpenseByExpensesType(DtoTransactionFilter filter)
        {
            var month = string.Empty;
            var lstExpense = await _serviceFactory.TransactionServices.GetTransactions(filter);
            var income = _serviceFactory.IncomeService.GetIncome(filter.StartDate, filter.EndDate).Sum(x => x.Amount);
            var lstExpenseTypes = _serviceFactory.MasterTableService.GetAllCategory().Select(x => x.Name).Distinct();

            decimal percentSum = 0;
            var dto = new DtoTransactionsByCategory(month);
            var lstExpenseByCategory = new List<DtoTransactionsByCategory>();
            foreach (var types in lstExpenseTypes)
            {
                month = filter.StartDate.Month + " - " + filter.EndDate.Month;
                dto = new DtoTransactionsByCategory(month);
                dto.CategoryName = types;
                dto.Amount = lstExpense.Where(x => x.CategoryName == types).Sum(x => x.Amount);
                if (dto.Amount > 0 && income > 0)
                {
                    var percentage = (decimal)Math.Round((double)(100 * dto.Amount) / (int)income);
                    dto.Percent = percentage + " %";
                    percentSum += percentage;
                }
                lstExpenseByCategory.Add(dto);
            }

            month = filter.StartDate.Month + " - " + filter.EndDate.Month;
            dto = new DtoTransactionsByCategory(month);
            dto.CategoryName = "Total Income";
            dto.Amount = income;
            dto.Percent = "NA"; ;
            lstExpenseByCategory.Add(dto);

            var sum = lstExpense.Sum(x => x.Amount);
            dto = new DtoTransactionsByCategory(month);
            dto.CategoryName = "Total Expense";
            dto.Amount = sum;
            dto.Percent = percentSum + " %"; ;
            lstExpenseByCategory.Add(dto);

            dto = new DtoTransactionsByCategory(month);
            dto.CategoryName = "Balance";
            dto.Amount = income - sum;
            dto.Percent = "NA";
            lstExpenseByCategory.Add(dto);

            return lstExpenseByCategory;
        }

        private static IEnumerable<Transaction> GetExpensesByMonth(IEnumerable<Transaction> lstExpensesByCategory, int month)
        {
            return lstExpensesByCategory.Where(ec => ec.Date.Date.Month == month);
        }

        public async Task<List<TransactionByYear>> GetTransactionByYear(int year)
        {
            var repoExpense = _unitOfWork.GetRepository<Transaction>();
            return await repoExpense.GetTransactionByYear(year);
        }

        public async Task<List<TransactionByMonth>> GetTransactionByMonth(int year, int month, int subCategoryId)
        {
            var repoExpense = _unitOfWork.GetRepository<Transaction>();
            return await repoExpense.GetTransactionByMonth(year, month, subCategoryId);
        }

        public async Task<List<BankByYear>> GetBankSummary(int year)
        {
            var repoExpense = _unitOfWork.GetRepository<Transaction>();
            return await repoExpense.GetBankSummary(year);
        }
    }
}
