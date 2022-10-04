using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace PatternForCore.Models
{
    public class IncomeSource
    {
        public int Id { get; set; }
        public int Amount { get; set; }
        public DateTime Date { get; set; }
        
        [NotMapped]
        public string Name { get; set; }
        public int UserId { get; set; }

    }
}
