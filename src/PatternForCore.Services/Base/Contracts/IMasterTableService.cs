using PatternForCore.Models;
using PatternForCore.Models.Dto;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PatternForCore.Services.Base.Contracts
{
    public interface IMasterTableService
    {
        List<MasterExpenseType> GetAllMasterExpenseType();

        List<MasterCategoryType> GetAllMasterCategoryType();

        public void SaveMasterExpenseType(List<MasterExpenseType> lst);

        public void SaveMasterCategoryType(List<MasterCategoryType> lst);

    }
}