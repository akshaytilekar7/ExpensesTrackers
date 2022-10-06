using ExpenseTracker.Models;
using System.Collections.Generic;

namespace ExpenseTracker.Services.Base.Contracts
{
    public interface ICategoryServices
    {
        bool Add(MasterCategoryType item);
        IList<MasterCategoryType> GetAll();
    }
}
