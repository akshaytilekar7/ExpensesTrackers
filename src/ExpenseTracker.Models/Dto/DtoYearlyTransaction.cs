using System.Collections.Generic;

namespace ExpenseTracker.Models.Dto
{
    public class DtoYearlyTransaction
    {
        public List<DtoTransaction> dtoTransaction { get; set; }
        public string Name { get; set; }

    }
}
