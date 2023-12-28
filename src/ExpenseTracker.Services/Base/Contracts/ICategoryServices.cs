using ExpenseTracker.Models;
using System.Collections.Generic;

namespace ExpenseTracker.Services.Base.Contracts
{
    public interface ICategoryServices
    {
        IList<SubCategory> GetAll();
    }
}
