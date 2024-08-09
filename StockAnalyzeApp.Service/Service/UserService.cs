using AutoMapper;
using StockAnalyzeApp.Core.Dto.BaseResponseDtos;
using StockAnalyzeApp.Core.Dto.UserDtos;
using StockAnalyzeApp.Core.Models;
using StockAnalyzeApp.Core.Repositories;
using StockAnalyzeApp.Core.Services;
using StockAnalyzeApp.Core.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace StockAnalyzeApp.Service.Service
{
    public class UserService : Service<User>, IUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;
        private readonly ICompanyRepository companyRepository;
        public UserService(IUnitOfWork unitOfWork, IGenericRepository<User> repository, IUserRepository userRepository, IMapper mapper, ICompanyRepository companyRepository) : base(unitOfWork, repository)
        {
            _userRepository=userRepository;
            _mapper=mapper;
            this.companyRepository=companyRepository;
        }


        public async Task<CustomResponseDto<UserResponseDto>> GetUserByUserCode(int userCode)
        {
            var result = await _userRepository.GetUserByUserCode(userCode);
            var dto = _mapper.Map<UserResponseDto>(result);
            return CustomResponseDto<UserResponseDto>.Success(dto, 200);
        }

        public async Task<CustomResponseDto<UserWithOrdersDto>> GetUsersOrders(int userId)
        {
           var result = await _userRepository.GetUsersOrders(userId);
            var dto = _mapper.Map<UserWithOrdersDto>(result);
            return CustomResponseDto<UserWithOrdersDto>.Success(dto, 200);
        }

        public async Task<CustomResponseDto<UserWithStocksDto>> GetUsersStocks(int userId)
        {
            var result = await _userRepository.GetUsersStocks(userId);
            var dto = _mapper.Map<UserWithStocksDto>(result);
            return CustomResponseDto<UserWithStocksDto>.Success(dto, 200);
        }
    }
}
