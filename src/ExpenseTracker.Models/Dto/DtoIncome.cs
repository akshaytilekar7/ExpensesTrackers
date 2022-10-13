using System;

namespace ExpenseTracker.Models.Dto
{
    public class DtoIncome
    {
        public int Id { get; set; }
        public int Amount { get; set; }
        public DateTime Date { get; set; }
        public string UserName { get; set; }
        public string BankName { get; set; }
        public string Comment { get; set; }

    }
}
