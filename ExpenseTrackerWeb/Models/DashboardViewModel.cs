using ExpenseTracker.Models;
using ExpenseTracker.Models.Dto;

namespace ExpenseTrackerWeb.Models;

public class DashboardViewModel
{
    public List<BankByYear> BankByYear { get; set; } = new List<BankByYear>();
    public List<TransactionByYear> TransactionByYear { get; set; } = new List<TransactionByYear>();

}

public class AddIncomeViewModel
{
    public List<DtoIncome> DtoIncome { get; set; } = new List<DtoIncome>();
    public Income Income { get; set; } = new Income() { Date = DateTime.Now };
    public List<User> Users { get; set; } = new List<User>();
    public List<Bank> Banks { get; set; } = new List<Bank>();

}
