using ExpenseTracker.Models;
using System.Collections.Generic;

namespace ExpenseTracker.Services.Base.Contracts
{
    public interface IOpeningBalancekService
    {
        List<OpeningBalance> GetAll(int year);
    }
}