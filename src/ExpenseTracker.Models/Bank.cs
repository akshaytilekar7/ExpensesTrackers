using ExpenseTracker.Models.Common;

namespace ExpenseTracker.Models
{
    public class Bank : BaseEnitity
    {
        public string Name { get; set; }
        public User? User { get; set; }
        public int? UserId { get; set; }

    }
}
