using System.Collections.Generic;
using ExpenseTracker.Core.Uow;
using System.Linq;
using ExpenseTracker.Models;
using ExpenseTracker.Services.Base.Contracts;
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;

namespace ExpenseTracker.Services
{
    public class UserService : IUserService
    {
        private readonly IUnitOfWork _unitOfWork;
        public UserService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public List<User> GetAll()
        {
            var repoExpense = _unitOfWork.GetRepository<User>();
            return repoExpense.GetAll().ToList();
        }
    }
}
