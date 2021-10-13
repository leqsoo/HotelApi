using HotelApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelApi.Services
{
    public interface IAuthManager
    {
        Task<bool> ValidateUser(LoginUserDto loginUserDto);
        Task<string> CreateToken();
    }
}