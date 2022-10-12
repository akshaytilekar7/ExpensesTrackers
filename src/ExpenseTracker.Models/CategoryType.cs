namespace ExpenseTracker.Models
{
    public class CategoryType
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string CommaSeparatedTags { get; set; }

        public ExpenseType ExpenseType { get; set; }

        public int ExpenseTypeId { get; set; }

    }
}
