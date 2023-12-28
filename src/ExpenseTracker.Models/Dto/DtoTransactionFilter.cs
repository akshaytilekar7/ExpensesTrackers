using System;
namespace ExpenseTracker.Models.Dto
{
    public class DtoTransactionFilter
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public decimal? Amount { get; set; }
        public int SubCategoryId { get; set; }
        public int CategoryId { get; set; }
        public string Comment { get; set; }
        public int UserId { get; set; }
        public int BankId { get; set; }

    }
}
