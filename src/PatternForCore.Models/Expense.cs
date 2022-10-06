﻿using System;

namespace ExpenseTracker.Models
{
    public class Expense
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public MasterCategoryType MasterCategoryType { get; set; }
        public int MasterCategoryTypeId { get; set; }
        public int Amount { get; set; }
        public string Comment { get; set; }
        public int UserId { get; set; }

    }
}
