﻿using AuthServer.Core.Dtos;
using AuthServer.Shared.Dtos;
using System.Threading.Tasks;

namespace AuthServer.Core.Services
{
    public interface IUserService
    {
        Task<Response<UserAppDto>> CreateUserAsync(CreateUserDto userDto);

        Task<Response<UserAppDto>> GetUserByNameAsync(string userName);
    }
}