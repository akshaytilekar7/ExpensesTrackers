using ExpenseTracker.Models.Dto;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ExpenseTracker.Services.Base.Contracts
{
    public interface IYearlyService
    {
        Task<List<DtoYealryView>> GetYearlyData(int year);

        Task<List<DtoTransactionsByCategory>> GetExpenseByExpensesType(DtoTransactionFilter filter);

        Task<List<DtoYearlyTransaction>> GetTransactions(int year);

        Task<DtoYearlyTransactionByCategory> GetAllMonthDataOnExpenseType(int year);

        Task<List<TransactionByYear>> GetTransactionByYear(int year);

        Task<List<TransactionByMonth>> GetTransactionByMonth(int year, int month, int subCategoryId);

        Task<List<BankByYear>> GetBankSummary(int year);

        Task<List<ExpenseByCategoryForYear>> GetExpenseByCategoryForYear(int year);
    }
}