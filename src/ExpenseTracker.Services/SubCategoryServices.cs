using System.Collections.Generic;
using ExpenseTracker.Core.Uow;
using System.Linq;
using ExpenseTracker.Services.Base.Contracts;
using ExpenseTracker.Models;
using System.Linq.Expressions;
using System;

namespace ExpenseTracker.Services
{
    public class SubCategoryServices : ISubCategoryServices
    {
        private readonly IUnitOfWork _unitOfWork;

        public SubCategoryServices(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IList<SubCategory> GetAll()
        {
            var repo = _unitOfWork.GetRepository<SubCategory>();

            List<Expression<Func<SubCategory, object>>> includers = new List<Expression<Func<SubCategory, object>>>();
            includers.Add(x => x.Category);

            var lstIncomeSources = repo.GetAll(includers);

            return lstIncomeSources.OrderBy(x => x.Name).ToList();
        }
    }
}
