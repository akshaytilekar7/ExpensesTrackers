using System.Collections.Generic;

namespace ExpenseTracker.Models.Dto
{
    public class DtoYearlyTransactionByCategory
    {
        public List<DtoTransactionsByCategory> dtoExpenseByCategories { get; set; } = new List<DtoTransactionsByCategory>();
        // TODO why need separate class
    }
}
