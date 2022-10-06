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

namespace PatternForCore.Services
{
    public class MasterTableService : IMasterTableService
    {
        private readonly IUnitOfWork _unitOfWork;
        public MasterTableService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public List<MasterCategoryType> GetAllMasterCategoryType()
        {
            var repository = _unitOfWork.GetRepository<MasterCategoryType>();
            return repository.GetAll("MasterExpenseType").ToList();
        }

        public List<MasterExpenseType> GetAllMasterExpenseType()
        {
            var repository = _unitOfWork.GetRepository<MasterExpenseType>();
            return repository.GetAll().ToList();
        }

        public void SaveMasterExpenseType(List<MasterExpenseType> masterExpenseTypes)
        {
            var repository = _unitOfWork.GetRepository<MasterExpenseType>();
            var dbMasterExpenseType = repository.GetAll();

            foreach (var item in masterExpenseTypes)
            {
                if (item.Id <= 0)
                {
                    repository.Add(item);
                }
                else if (dbMasterExpenseType.Any(x => x.Id == item.Id))
                {
                    repository.Update(item);
                }
                _unitOfWork.Commit();
            }
        }

        public void SaveMasterCategoryType(List<MasterCategoryType> masterCategoryTypes)
        {
            var repository = _unitOfWork.GetRepository<MasterCategoryType>();
            var dbMasterCategoryTypes = repository.GetAll();

            foreach (var item in masterCategoryTypes)
            {
                if (item.Id <= 0)
                {
                    repository.Add(item);
                }
                else if (dbMasterCategoryTypes.Any(x => x.Id == item.Id))
                {
                    repository.Update(item);
                }

                _unitOfWork.Commit();
            }
        }

    }
}
