using System;

namespace ExpenseTracker.Models.Dto
{
    public class DtoExpense
    {
        public int Id { get; set; }
        public int SrNo { get; set; }
        public DateTime Date { get; set; }
        public string CategoryName { get; set; }
        public string ExpenseType { get; set; }
        public int Amount { get; set; }
        public string Comment { get; set; }
        public string User { get; set; }
        public string BankName { get; set; }

    }
}
