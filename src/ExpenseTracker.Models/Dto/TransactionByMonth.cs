using System;

namespace ExpenseTracker.Models.Dto
{
    public class TransactionByMonth
    {
        public decimal Amount { get; set; }
        public string Bank { get; set; }
        public string Comment { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CategoryName { get; set; }
        public string SubCategoryName { get; set; }

    }
}
