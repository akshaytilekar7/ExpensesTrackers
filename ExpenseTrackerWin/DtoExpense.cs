namespace ExpenseTrackerWin
{
    public class DtoExpense
    {
        public DateTime Date { get; set; }
        public string CategoryName { get; set; }
        public string ExpenseType { get; set; }
        public int Amount { get; set; }
        public string Comment { get; set; }
    }
}
