using AutoMapper;
using Microsoft.Extensions.Caching.Memory;
using StockAnalyzeApp.Core.Dto.BaseResponseDtos;
using StockAnalyzeApp.Core.Dto.UserDtos;
using StockAnalyzeApp.Core.Models;
using StockAnalyzeApp.Core.Repositories;
using StockAnalyzeApp.Core.Services;
using StockAnalyzeApp.Core.UnitOfWork;
using StockAnalyzeApp.Repository.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockAnalyzeCache.CacheServices
{
    public class UserCacheService :CacheManager<User> ,IUserService
    {
        private readonly IUserRepository userRepository;
        private readonly IMapper mapper;
        private readonly IMemoryCache memoryCache;
        private readonly IUnitOfWork unitOfWork;
        private const string UserCacheKey = "UserCache";
        private const string UserStocksCacheKey = "UserStocksCache";
        private const string UserOrdersCacheKey = "UserOrdersCacheKey";
        public UserCacheService(IMemoryCache memoryCache, IMapper mapper, IUserRepository userRepository, IUnitOfWork unitOfWork):base(memoryCache,unitOfWork)
        {
            this.memoryCache=memoryCache;
            this.mapper=mapper;
            this.userRepository=userRepository;
            this.unitOfWork=unitOfWork;

            CacheAll(userRepository, UserCacheKey);
        }


     
        public async Task AddAsync(User entity)
        {

            await userRepository.AddAsync(entity);
            await CommitAndRemoveCache(UserCacheKey);
        }

        public async Task AddRangeAsync(IEnumerable<User> entities)
        {
            await userRepository.AddRangeAsync(entities);
            await CommitAndRemoveCache(UserCacheKey);
        }

        public async Task Update(User entity)
        {
            userRepository.Update(entity);
            await CommitAndRemoveCache(UserCacheKey);
        }

        public async Task UpdateRange(IEnumerable<User> entities)
        {
            userRepository.UpdateRange(entities);
            await CommitAndRemoveCache(UserCacheKey);
        }
        public async Task Delete(int id)
        {
            userRepository.Delete(id);
            await CommitAndRemoveCache(UserCacheKey);
        }

        public async Task DeleteAll(User entity)
        {
            userRepository.DeleteAll(entity);
            await CommitAndRemoveCache(UserCacheKey);
        }

        public async Task DeleteRange(IEnumerable<User> entities)
        {
            userRepository.DeleteRange(entities);
            await CommitAndRemoveCache(UserCacheKey);
        }

        public Task<IEnumerable<User>> GetAllAsync()
        {
            var result = memoryCache.Get<IEnumerable<User>>(UserCacheKey);
            if (result ==null)
            {
                throw new Exception(message: $"This is not valid");
            }
            else
            {
                return Task.FromResult(result);
            }
        }
        public Task<User> GetByIdAsync(int id)
        {
            var result = memoryCache.Get<List<User>>(UserCacheKey).FirstOrDefault(x => x.Id==id);
            if (result==null)
            {
                throw new Exception(message: $"This {id} is not valid");
            }
            else
            {
                return Task.FromResult(result);
            }
        }

        public Task<CustomResponseDto<UserResponseDto>> GetUserByUserCode(int userCode)
        {
            var result = memoryCache.Get<IEnumerable<User>>(UserCacheKey).FirstOrDefault(x => x.UserCode==userCode);
            if (result==null)
            {
                throw new Exception(message: $"This {userCode} is not valid");
            }
            else
            {
                var userDto = mapper.Map<UserResponseDto>(result);
                var dto = CustomResponseDto<UserResponseDto>.Success(userDto, 200);
                return Task.FromResult(dto);
            }
        }


        public async Task<CustomResponseDto<UserWithOrdersDto>> GetUsersOrders(int userId)
        {
            User user = await userRepository.GetUsersOrders(userId);
            memoryCache.Set(UserOrdersCacheKey, user);
            var result = memoryCache.Get<User>(UserOrdersCacheKey);
            if (result==null)
            {
                throw new Exception(message: $"This {userId} is not valid");
            }
            else
            {
                var response = mapper.Map<UserWithOrdersDto>(result);
                var dto = CustomResponseDto<UserWithOrdersDto>.Success(response, 200);
                return dto;
            }
        }

        public async Task<CustomResponseDto<UserWithStocksDto>> GetUsersStocks(int userId)
        {

            User user = await userRepository.GetUsersStocks(userId);
            memoryCache.Set(UserStocksCacheKey, user);

            var result = memoryCache.Get<User>(UserStocksCacheKey);
            if (result==null)
            {
                throw new Exception(message: $"This {userId} is not valid");
            }
            else
            {
                var dto = mapper.Map<UserWithStocksDto>(result);
                var response = CustomResponseDto<UserWithStocksDto>.Success(dto, 200);

                return response;
            }
        }


    }
}
