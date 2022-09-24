using System;
namespace PatternForCore.Models.Dto
{
    public class ExpenseFilter
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int? Amount { get; set; }
        public string Category { get; set; }
        public string ExpenseType { get; set; }
        public string Comment { get; set; }

    }
}
