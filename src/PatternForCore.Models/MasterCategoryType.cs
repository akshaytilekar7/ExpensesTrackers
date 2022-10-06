﻿namespace ExpenseTracker.Models
{
    public class MasterCategoryType
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string CommaSeparatedTags { get; set; }

        public MasterExpenseType MasterExpenseType { get; set; }

        public int MasterExpenseTypeId { get; set; }


    }
}
