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

        public bool Add(Category category)
        {
            bool result = false;
            try
            {
                if (category != null)
                {
                    var movieRepository = _unitOfWork.GetRepository<Category>();
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

        public IList<Category> GetAll()
        {
            var movieRepository = _unitOfWork.GetRepository<Category>();
            return movieRepository.GetAll().ToList();
        }
    }
}
