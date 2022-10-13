using ExpenseTracker.Models.Common;

namespace ExpenseTracker.Models
{
    public class CategoryType : BaseEnitity
    {

        public string Name { get; set; }

        public string CommaSeparatedTags { get; set; }

        public ExpenseType ExpenseType { get; set; }

        public int ExpenseTypeId { get; set; }

    }
}
