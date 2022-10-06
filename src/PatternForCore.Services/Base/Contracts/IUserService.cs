using System.Collections.Generic;
using ExpenseTracker.Models;

namespace ExpenseTracker.Services.Base.Contracts
{
    public interface IUserService
    {
        List<User> GetAll();
    }
}