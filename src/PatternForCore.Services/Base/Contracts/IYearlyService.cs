using PatternForCore.Models.Dto;
using System.Collections.Generic;

namespace PatternForCore.Services.Base.Contracts
{
    public interface IYearlyService
    {
        List<DtoYealry> GetYearlyData(int year, out int total);
    }
}