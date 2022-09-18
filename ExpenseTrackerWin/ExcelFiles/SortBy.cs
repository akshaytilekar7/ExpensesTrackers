namespace ExpenseTrackerWin.ExcelFiles
{
    public class SortBy
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<SortBy> GetList()
        {
            List<SortBy> lstSort = new List<SortBy>()
            {
            new SortBy() { Id = 1, Name = "Date" },
            new SortBy() { Id = 2, Name = "CategoryName" },
            new SortBy() { Id = 3, Name = "ExpensesType" },
            new SortBy() { Id = 4, Name = "Amount" },
            new SortBy() { Id = 5, Name = "Comment" },
            };
            return lstSort;
        }

    }
}
