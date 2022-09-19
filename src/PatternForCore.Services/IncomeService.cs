using System;
using System.Collections.Generic;
using PatternForCore.Core.Uow;
using System.Linq;
using PatternForCore.Models;
using PatternForCore.Services.Base.Contracts;

namespace PatternForCore.Services
{
    public class IncomeService : IIncomeService
    {
        private readonly IUnitOfWork _unitOfWork;

        public IncomeService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public bool Add(IncomeSource category)
        {
            bool result = false;
            try
            {
                if (category != null)
                {
                    var movieRepository = _unitOfWork.GetRepository<IncomeSource>();
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

        public IList<IncomeSource> GetAll()
        {
            var movieRepository = _unitOfWork.GetRepository<IncomeSource>();
            return movieRepository.GetAll().OrderBy(x => x.Date).ToList();
        }
    }
}
