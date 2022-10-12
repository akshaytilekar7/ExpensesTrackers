using ExpenseTracker.Models;
using System.Collections.Generic;

namespace ExpenseTracker.Services.Base.Contracts
{
    public interface ICategoryServices
    {
        bool Add(CategoryType item);
        IList<CategoryType> GetAll();
    }
}
