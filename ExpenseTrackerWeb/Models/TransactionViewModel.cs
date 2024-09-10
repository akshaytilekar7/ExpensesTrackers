using ExpenseTracker.Models.Dto;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace ExpenseTrackerWeb.Models
{
    public class TransactionViewModel
    {
        public DtoTransactionFilter Filter { get; set; }
        public IEnumerable<DtoTransaction> Transactions { get; set; }  // Adjust this to your actual transaction model
        public IEnumerable<SelectListItem> SubCategories { get; set; }
        public IEnumerable<SelectListItem> Categories { get; set; }
        public IEnumerable<SelectListItem> Users { get; set; }
        public IEnumerable<SelectListItem> Banks { get; set; }
    }

}
