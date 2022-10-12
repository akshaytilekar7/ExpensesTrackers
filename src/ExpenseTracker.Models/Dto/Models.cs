using System.Collections.Generic;

namespace ExpenseTracker.Models.Dto
{
    public class DtoYearlyExpense
    {
        public List<DtoExpense> dtoExpenses { get; set; }
        public string Name { get; set; }

    }

    public class DtoYearlyExpenseByExpensesType
    {
        public DtoYearlyExpenseByExpensesType()
        {
            dtoExpenseByCategories = new List<DtoExpenseByExpensesType>();
        }
        public List<DtoExpenseByExpensesType> dtoExpenseByCategories { get; set; }

    }

    public enum Models
    {
        January = 1,
        February,
        March,
        April,
        May,
        June,
        July,
        August,
        September,
        October,
        November,
        December
    }
}
