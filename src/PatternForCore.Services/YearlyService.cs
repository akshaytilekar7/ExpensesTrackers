using System.Collections.Generic;
using PatternForCore.Core.Uow;
using System.Linq;
using PatternForCore.Models;
using PatternForCore.Services.Base.Contracts;
using PatternForCore.Models.Dto;
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;
using System.Data;
using System;
using PatternForCore.Services.Factory;
using System.Threading.Tasks;
using System.Linq.Expressions;

namespace PatternForCore.Services
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
            var repoExpense = _unitOfWork.GetRepository<Expense>();

            List<Expression<Func<Expense, object>>> includers = new List<Expression<Func<Expense, object>>>();
            includers.Add(x => x.MasterCategoryType);
            includers.Add(x => x.MasterCategoryType.MasterExpenseType);
            var lstExpenses = await repoExpense.GetAllAsync(includers);
            lstExpenses = lstExpenses.OrderByDescending(x => x.Id).Where(x => x.Date.Year == year);
            List<DtoYealry> dtoYealries = new List<DtoYealry>();

            var repoCategory = _unitOfWork.GetRepository<MasterCategoryType>();
            var lstCategory = repoCategory.GetAll("MasterExpenseType");

            var repoIncomeSource = _unitOfWork.GetRepository<IncomeSource>();
            var lstIncomeSource = repoIncomeSource.GetAll().Where(x => x.Date.Year == year).ToList();

            foreach (var itemCategory in lstCategory)
            {
                DtoYealry dtoYealry = new DtoYealry();
                dtoYealry.Category = itemCategory.Name + " (" + itemCategory.MasterExpenseType.Name + ")";
                var lstExpensesByCategory = lstExpenses.Where(e => e.MasterCategoryType.Name == itemCategory.Name);

                dtoYealry.Jan = lstExpensesByCategory.Where(ec => ec.Date.Date.Month == 1).ToList().Sum(x => x.Amount);
                dtoYealry.JanTooltip = lstExpensesByCategory.Where(ec => ec.Date.Date.Month == 1).GetTooltipData();
                dtoYealry.JanLst = lstExpensesByCategory.Where(ec => ec.Date.Date.Month == 1);

                dtoYealry.Feb = lstExpensesByCategory.Where(ec => ec.Date.Date.Month == 2).ToList().Sum(x => x.Amount);
                dtoYealry.FebTooltip = lstExpensesByCategory.Where(ec => ec.Date.Date.Month == 2).GetTooltipData();
                dtoYealry.FebLst = lstExpensesByCategory.Where(ec => ec.Date.Date.Month == 2);

                dtoYealry.March = lstExpensesByCategory.Where(ec => ec.Date.Date.Month == 3).ToList().Sum(x => x.Amount);
                dtoYealry.MarchTooltip = lstExpensesByCategory.Where(ec => ec.Date.Date.Month == 3).GetTooltipData();
                dtoYealry.MarchLst = lstExpensesByCategory.Where(ec => ec.Date.Date.Month == 3);

                dtoYealry.April = lstExpensesByCategory.Where(ec => ec.Date.Date.Month == 4).ToList().Sum(x => x.Amount);
                dtoYealry.AprilTooltip = lstExpensesByCategory.Where(ec => ec.Date.Date.Month == 4).GetTooltipData();
                dtoYealry.AprilLst = lstExpensesByCategory.Where(ec => ec.Date.Date.Month == 4);

                dtoYealry.May = lstExpensesByCategory.Where(ec => ec.Date.Date.Month == 5).ToList().Sum(x => x.Amount);
                dtoYealry.MayTooltip = lstExpensesByCategory.Where(ec => ec.Date.Date.Month == 5).GetTooltipData();
                dtoYealry.MayLst = lstExpensesByCategory.Where(ec => ec.Date.Date.Month == 5);

                dtoYealry.June = lstExpensesByCategory.Where(ec => ec.Date.Date.Month == 6).ToList().Sum(x => x.Amount);
                dtoYealry.JuneTooltip = lstExpensesByCategory.Where(ec => ec.Date.Date.Month == 6).GetTooltipData();
                dtoYealry.JuneLst = lstExpensesByCategory.Where(ec => ec.Date.Date.Month == 6);

                dtoYealry.July = lstExpensesByCategory.Where(ec => ec.Date.Date.Month == 7).ToList().Sum(x => x.Amount);
                dtoYealry.JulyTooltip = lstExpensesByCategory.Where(ec => ec.Date.Date.Month == 7).GetTooltipData();
                dtoYealry.JulyLst = lstExpensesByCategory.Where(ec => ec.Date.Date.Month == 7);

                dtoYealry.August = lstExpensesByCategory.Where(ec => ec.Date.Date.Month == 8).ToList().Sum(x => x.Amount);
                dtoYealry.AugustTooltip = lstExpensesByCategory.Where(ec => ec.Date.Date.Month == 8).GetTooltipData();
                dtoYealry.AugustLst = lstExpensesByCategory.Where(ec => ec.Date.Date.Month == 8);

                dtoYealry.September = lstExpensesByCategory.Where(ec => ec.Date.Date.Month == 9).ToList().Sum(x => x.Amount);
                dtoYealry.SeptemberTooltip = lstExpensesByCategory.Where(ec => ec.Date.Date.Month == 9).GetTooltipData();
                dtoYealry.SeptemberLst = lstExpensesByCategory.Where(ec => ec.Date.Date.Month == 9);

                dtoYealry.October = lstExpensesByCategory.Where(ec => ec.Date.Date.Month == 10).ToList().Sum(x => x.Amount);
                dtoYealry.OctoberTooltip = lstExpensesByCategory.Where(ec => ec.Date.Date.Month == 10).GetTooltipData();
                dtoYealry.OctoberLst = lstExpensesByCategory.Where(ec => ec.Date.Date.Month == 10);

                dtoYealry.November = lstExpensesByCategory.Where(ec => ec.Date.Date.Month == 11).ToList().Sum(x => x.Amount);
                dtoYealry.NovemberTooltip = lstExpensesByCategory.Where(ec => ec.Date.Date.Month == 11).GetTooltipData();
                dtoYealry.NovemberLst = lstExpensesByCategory.Where(ec => ec.Date.Date.Month == 11);

                dtoYealry.December = lstExpensesByCategory.Where(ec => ec.Date.Date.Month == 12).ToList().Sum(x => x.Amount);
                dtoYealry.DecemberTooltip = lstExpensesByCategory.Where(ec => ec.Date.Date.Month == 12).GetTooltipData();
                dtoYealry.DecemberLst = lstExpensesByCategory.Where(ec => ec.Date.Date.Month == 12);

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

        public async Task<List<DtoExpenseByCategory>> GetExpenseByCategory(ExpenseFilter filter)
        {
            List<DtoExpenseByCategory> dtoExpenseByCategories = new List<DtoExpenseByCategory>();
            var lstDtoExpense = await _serviceFactory.ExpenseServices.GetExpenseFilter(filter);
            var dbIncomes = _serviceFactory.IncomeService.GetAll().Where(x => x.Date >= filter.StartDate && x.Date <= filter.EndDate);
            var income = dbIncomes.Sum(x => x.Amount);
            var psum = 0;
            var expenseTypes = _serviceFactory.MasterTableService.GetAllMasterExpenseType().Select(x => x.Name).Distinct();
            foreach (var et in expenseTypes)
            {
                DtoExpenseByCategory dto = new DtoExpenseByCategory();
                dto.ExpensesType = et;
                dto.Amount = lstDtoExpense.Where(x => x.ExpenseType == et).Sum(x => x.Amount);
                var per = (int)Math.Round((double)(100 * dto.Amount) / income);
                dto.Percent = per + " %";
                psum += per;
                dtoExpenseByCategories.Add(dto);
            }

            DtoExpenseByCategory dto1 = new DtoExpenseByCategory();
            dto1.ExpensesType = "Total Income";
            dto1.Amount = income;
            dto1.Percent = "NA"; ;
            dtoExpenseByCategories.Add(dto1);

            var sum = lstDtoExpense.Sum(x => x.Amount);
            dto1 = new DtoExpenseByCategory();
            dto1.ExpensesType = "Total Expense";
            dto1.Amount = sum;
            dto1.Percent = psum + " %"; ;
            dtoExpenseByCategories.Add(dto1);

            dto1 = new DtoExpenseByCategory();
            dto1.ExpensesType = "Balance";
            dto1.Amount = income - sum;
            dto1.Percent = "NA";
            dtoExpenseByCategories.Add(dto1);
            return dtoExpenseByCategories;
        }

        public List<IncomeSource> GetIncome(DateTime startDate, DateTime endDate)
        {
            IEnumerable<IncomeSource> lst = _serviceFactory.IncomeService.GetAll().Where(x => x.Date >= startDate && x.Date <= endDate);
            return lst.ToList();
        }
    }
}
