using PatternForCore.Models;
using PatternForCore.Models.Dto;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PatternForCore.Services.Base.Contracts
{
    public interface IUserService
    {
        List<User> GetAll();
    }
}