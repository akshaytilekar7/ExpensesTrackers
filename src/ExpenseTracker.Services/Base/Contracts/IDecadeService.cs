using ExpenseTracker.Models.Dto;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ExpenseTracker.Services.Base.Contracts
{
    public interface IDecadeService
    {
        List<DtoDecadeView> GetDecadeData();

        Task<List<DtoTransaction>> GetYearlyForTooltip(int year, string category);
    }
}