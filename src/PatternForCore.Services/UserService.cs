using System.Collections.Generic;
using PatternForCore.Core.Uow;
using System.Linq;
using PatternForCore.Models;
using PatternForCore.Services.Base.Contracts;
using PatternForCore.Models.Dto;
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;
using System.Data;
using System;
using PatternForCore.Services.Factory;
using System.Threading.Tasks;
using System.Linq.Expressions;

namespace PatternForCore.Services
{
    public class UserService : IUserService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ServiceFactory _serviceFactory;
        public UserService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _serviceFactory = new ServiceFactory(_unitOfWork);
        }

        public List<User> GetAll()
        {
            var repoExpense = _unitOfWork.GetRepository<User>();
            return repoExpense.GetAll().ToList();
        }
    }
}
