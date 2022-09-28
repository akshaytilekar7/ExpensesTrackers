using System;
using System.Collections.Generic;
using PatternForCore.Core.Uow;
using System.Linq;
using PatternForCore.Models;
using PatternForCore.Services.Base.Contracts;

namespace PatternForCore.Services
{
    public class CategoryServices : ICategoryServices
    {
        private readonly IUnitOfWork _unitOfWork;

        public CategoryServices(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public bool Add(MasterCategoryType category)
        {
            bool result = false;
            try
            {
                if (category != null)
                {
                    var movieRepository = _unitOfWork.GetRepository<MasterCategoryType>();
                    movieRepository.Add(category);
                    _unitOfWork.Commit();
                    result = true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw;
            }

            return result;
        }

        public IList<MasterCategoryType> GetAll()
        {
            var movieRepository = _unitOfWork.GetRepository<MasterCategoryType>();
            return movieRepository.GetAll().OrderBy(x => x.Name).ToList();
        }
    }
}
