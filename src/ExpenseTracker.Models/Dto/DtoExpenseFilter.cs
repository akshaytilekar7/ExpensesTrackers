using System;
namespace ExpenseTracker.Models.Dto
{
    public class DtoExpenseFilter
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int? Amount { get; set; }
        public int CategoryId { get; set; }
        public int ExpenseTypeId { get; set; }
        public string Comment { get; set; }
        public int UserId { get; set; }
        public int BankId { get; set; }

    }
}
