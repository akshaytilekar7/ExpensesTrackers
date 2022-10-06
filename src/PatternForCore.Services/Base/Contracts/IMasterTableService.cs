using System.Collections.Generic;
using ExpenseTracker.Models;

namespace ExpenseTracker.Services.Base.Contracts
{
    public interface IMasterTableService
    {
        List<MasterExpenseType> GetAllMasterExpenseType();

        List<MasterCategoryType> GetAllMasterCategoryType();

        public void SaveMasterExpenseType(List<MasterExpenseType> lst);

        public void SaveMasterCategoryType(List<MasterCategoryType> lst);

    }
}