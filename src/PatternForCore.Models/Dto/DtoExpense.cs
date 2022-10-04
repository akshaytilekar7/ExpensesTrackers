using System;
using System.Collections.Generic;

namespace PatternForCore.Models.Dto
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

    }

    public static class DtoExpenseExtenstion
    {
        public static List<DtoExpense> GenereateSrNo(this List<DtoExpense> dtoExpenses)
        {
            int index = 1;
            for (int i = 0; i < dtoExpenses.Count; i++)

            {
                var x = index++;
                dtoExpenses[i].SrNo = x;
            }

            return dtoExpenses;
        }
    }
}
