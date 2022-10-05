using PatternForCore.Models;
using PatternForCore.Models.Dto;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using static PatternForCore.Services.YearlyService;

namespace PatternForCore.Services.Base.Contracts
{
    public interface IYearlyService
    {
        Task<List<DtoYealry>> GetYearlyData(int year);

        Task<List<DtoExpenseByCategory>> GetExpenseByCategory(ExpenseFilter filter);

        List<IncomeSource> GetIncome(DateTime startDate, DateTime endDate);

        Task<List<ExcelYearly>> YearlyMonthlywise(int year);
    }
}