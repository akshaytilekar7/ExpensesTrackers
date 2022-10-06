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

        public bool Add(IncomeSource item)
        {
            bool result = false;
            try
            {
                if (item != null)
                {
                    var movieRepository = _unitOfWork.GetRepository<IncomeSource>();
                    movieRepository.Add(item);
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

        public void Delete(List<IncomeSource> lst)
        {
            var repository = _unitOfWork.GetRepository<IncomeSource>();
            foreach (var item in lst)
                repository.HardDelete(item);
            _unitOfWork.Commit();
        }

        public IList<IncomeSource> GetAll()
        {
            var movieRepository = _unitOfWork.GetRepository<IncomeSource>();
            var users = _unitOfWork.GetRepository<User>().GetAll().ToList();

            var result = movieRepository.GetAll().OrderBy(x => x.Date).ToList();
            result.ForEach(i => i.Name = users.FirstOrDefault(x => x.Id == i.UserId).Name); ;
            return result;
        }
    }
}
