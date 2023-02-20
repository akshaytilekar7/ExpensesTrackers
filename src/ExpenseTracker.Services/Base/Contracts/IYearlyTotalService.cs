using ExpenseTracker.Models.Dto;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ExpenseTracker.Services.Base.Contracts
{
    public interface IYearlyTotalService
    {
        List<DtoYealryTotal> GetYearlyData();
    }
}