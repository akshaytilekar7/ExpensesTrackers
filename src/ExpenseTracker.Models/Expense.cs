using System;

namespace ExpenseTracker.Models
{
    public class Expense
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public CategoryType CategoryType { get; set; }
        public int CategoryTypeId { get; set; }
        public int Amount { get; set; }
        public string Comment { get; set; }
        public int UserId { get; set; }

    }
}
