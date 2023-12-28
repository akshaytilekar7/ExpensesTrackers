using ExpenseTracker.Models.Common;
using System;

namespace ExpenseTracker.Models
{
    public class Income : BaseEnitity
    {
        public decimal Amount { get; set; }
        public DateTime Date { get; set; }
        public string Comment { get; set; }
        public User User { get; set; }
        public int UserId { get; set; }
        public Bank Bank { get; set; }
        public int BankId { get; set; }

    }
}
