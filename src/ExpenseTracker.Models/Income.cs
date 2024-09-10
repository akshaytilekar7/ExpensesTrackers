using ExpenseTracker.Models.Common;
using System;
using System.ComponentModel.DataAnnotations;

namespace ExpenseTracker.Models
{
    public class Income : BaseEnitity
    {
        public decimal Amount { get; set; }
        public DateTime Date { get; set; }
        public string Comment { get; set; }
        public User User { get; set; }

        [Display(Name = "User Name")]
        public int UserId { get; set; }
        public Bank Bank { get; set; }

        [Display(Name = "Bank Name")]
        public int BankId { get; set; }

    }
}
