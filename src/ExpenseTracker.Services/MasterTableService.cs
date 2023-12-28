using System.Collections.Generic;
using ExpenseTracker.Core.Uow;
using System.Linq;
using ExpenseTracker.Models;
using ExpenseTracker.Services.Base.Contracts;
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;

namespace ExpenseTracker.Services
{
    public class MasterTableService : IMasterTableService
    {
        private readonly IUnitOfWork _unitOfWork;
        public MasterTableService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public List<SubCategory> GetAllSubCategory()
        {
            var repository = _unitOfWork.GetRepository<SubCategory>();
            return repository.GetAll("Category").OrderBy(x => x.Name).ToList();
        }

        public List<Category> GetAllCategory()
        {
            var repository = _unitOfWork.GetRepository<Category>();
            return repository.GetAll().OrderBy(x => x.Name).ToList();
        }

        public void AddCategory(List<Category> ExpenseTypes)
        {
            var repository = _unitOfWork.GetRepository<Category>();
            var dbExpenseType = repository.GetAll();

            foreach (var item in ExpenseTypes)
            {
                if (item.Id <= 0)
                {
                    repository.Add(item);
                }
                else if (dbExpenseType.Any(x => x.Id == item.Id))
                {
                    repository.Update(item);
                }
                _unitOfWork.Commit();
            }
        }

        public void AddSubCategory(List<SubCategory> CategoryTypes)
        {
            var repository = _unitOfWork.GetRepository<SubCategory>();
            var dbCategoryTypes = repository.GetAll();

            foreach (var item in CategoryTypes)
            {
                if (item.Id <= 0)
                {
                    repository.Add(item);
                }
                else if (dbCategoryTypes.Any(x => x.Id == item.Id))
                {
                    repository.Update(item);
                }

                _unitOfWork.Commit();
            }
        }

    }
}
