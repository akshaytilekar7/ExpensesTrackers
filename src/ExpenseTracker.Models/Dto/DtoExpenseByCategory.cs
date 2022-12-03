namespace ExpenseTracker.Models.Dto
{
    public class DtoExpenseByExpensesType
    {
        public DtoExpenseByExpensesType(string month)
        {
            Month = month;
        }

        public string ExpensesType { get; set; }
        public decimal Amount { get; set; }
        public string Percent { get; set; }
        public string Month { get; set; }

    }

}
