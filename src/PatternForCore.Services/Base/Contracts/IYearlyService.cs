using PatternForCore.Models;
using PatternForCore.Models.Dto;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PatternForCore.Services.Base.Contracts
{
    public interface IYearlyService
    {
        List<DtoYealry> GetYearlyData(int year, out int total, out int totalYealyIncome);

        Task<List<DtoExpenseByCategory>> GetExpenseByCategory(ExpenseFilter filter);

        List<IncomeSource> GetIncome(DateTime startDate, DateTime endDate);
    }
}