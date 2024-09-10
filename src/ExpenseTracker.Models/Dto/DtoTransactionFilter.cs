using System;
using System.ComponentModel.DataAnnotations;
namespace ExpenseTracker.Models.Dto
{
    public class DtoTransactionFilter
    {
        [Display(Name = "Start Date")]
        public DateTime StartDate { get; set; }

        [Display(Name = "End Date")]
        public DateTime EndDate { get; set; }
        public decimal? Amount { get; set; }

        [Display(Name = "Sub category")]
        public int SubCategoryId { get; set; }
        
        [Display(Name = "Category")]
        public int CategoryId { get; set; }
        public string Comment { get; set; }

        [Display(Name = "User name")]
        public int UserId { get; set; }
        
        [Display(Name = "Bank Name")]
        public int BankId { get; set; }

    }
}
