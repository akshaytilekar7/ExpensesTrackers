using System;

namespace ExpenseTracker.Models.Common
{
    public class BaseEnitity
    {
        public int Id { get; set; }
        public DateTime? CreatedDate
        {
            get 
            {
                return DateTime.Now; 
            }
            set
            {
                value = DateTime.Now.Date;
            }
        }

    }
}
