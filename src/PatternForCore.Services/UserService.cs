using System.Collections.Generic;
using PatternForCore.Core.Uow;
using System.Linq;
using PatternForCore.Models;
using PatternForCore.Services.Base.Contracts;
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;

namespace PatternForCore.Services
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
