using ExpenseTracker.Models;
using ExpenseTracker.Models.Dto;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ExpenseTracker.Services.Base.Contracts
{
    public interface IYearlyService
    {
        Task<List<DtoYealry>> GetYearlyData(int year);

        Task<List<DtoExpenseByExpensesType>> GetExpenseByExpensesType(DtoExpenseFilter filter);

        List<IncomeSource> GetIncome(DateTime startDate, DateTime endDate);

        Task<List<DtoYearlyExpense>> GetAllMonthsData(int year);

        Task<DtoYearlyExpenseByExpensesType> GetAllMonthDataOnExpenseType(int year);
    }
}