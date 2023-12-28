namespace ExpenseTracker.Models.Dto
{
    public class DtoTransactionsByCategory
    {
        public DtoTransactionsByCategory(string month)
        {
            Month = month;
        }

        public string CategoryName { get; set; } //TODO
        public decimal Amount { get; set; }
        public string Percent { get; set; }
        public string Month { get; set; }

    }

}
