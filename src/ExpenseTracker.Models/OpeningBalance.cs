using System;
using System.Collections.Generic;
using System.Text;

namespace ExpenseTracker.Models
{
    public class OpeningBalance
    {
        public int Id { get; set; }
        public int Year { get; set; }
        public Bank Bank { get; set; }
        public int BankId { get; set; }
        public decimal Amount { get; set; }
    }
}
