using System.Collections.Generic;
using ExpenseTracker.Models;

namespace ExpenseTracker.Services.Base.Contracts
{
    public interface IMasterTableService
    {
        List<ExpenseType> GetAllExpenseType();

        List<CategoryType> GetAllCategoryType();

        public void SaveExpenseType(List<ExpenseType> lst);

        public void SaveCategoryType(List<CategoryType> lst);

    }
}