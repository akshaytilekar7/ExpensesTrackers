using ExpenseTracker.Models.Common;

namespace ExpenseTracker.Models
{
    public class SubCategory : BaseEnitity
    {

        public string Name { get; set; }

        public string CommaSeparatedTags { get; set; }

        public Category Category { get; set; }

        public int CategoryId { get; set; }

        public decimal? ExpectedAmount { get; set; }

    }
}
