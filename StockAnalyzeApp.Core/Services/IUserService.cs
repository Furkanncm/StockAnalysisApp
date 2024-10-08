﻿using StockAnalyzeApp.Core.Dto.BaseResponseDtos;
using StockAnalyzeApp.Core.Dto.UserDtos;
using StockAnalyzeApp.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockAnalyzeApp.Core.Services
{
    public interface IUserService:IService<User>
    {

        Task<CustomResponseDto<UserResponseDto>> GetUserByUserCode(int userCode);

        Task<CustomResponseDto<UserWithOrdersDto>> GetUsersOrders(int userId);

        Task<CustomResponseDto<UserWithStocksDto>> GetUsersStocks(int userId);
    }
}
