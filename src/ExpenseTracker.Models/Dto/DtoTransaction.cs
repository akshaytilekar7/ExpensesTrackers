using System;

namespace ExpenseTracker.Models.Dto
{
    public class DtoTransaction
    {
        public int Id { get; set; }
        public int SrNo { get; set; }
        public DateTime Date { get; set; }
        public string SubCategoryName { get; set; }
        public string CategoryName { get; set; }
        public decimal Amount { get; set; }
        public string Comment { get; set; }
        public string User { get; set; }
        public string BankName { get; set; }
        public decimal Balance { get; set; }

    }
}
