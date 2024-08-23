using AutoMapper;
using Microsoft.Extensions.Caching.Memory;
using StockAnalyzeApp.Core.Dto.BaseResponseDtos;
using StockAnalyzeApp.Core.Dto.OrderDtos;
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

namespace StockAnalyzeCache.CacheServices
{
    public class OrderCacheService : CacheManager<Order>, IOrderService
    {
        private const string OrderCacheKey = "OrderCacheKey";
        private const string OrderWithUserKey = "OrderWithUserKey";
        private readonly IOrderRepository orderRepository;
        private readonly IMapper mapper;
        private readonly IUnitOfWork unitOfWork;
        private readonly IMemoryCache memoryCache;

        public OrderCacheService(IMemoryCache memoryCache, IUnitOfWork unitOfWork, IMapper mapper, IOrderRepository orderRepository) : base(memoryCache, unitOfWork)
        {
            this.memoryCache=memoryCache;
            this.unitOfWork=unitOfWork;
            this.mapper=mapper;
            this.orderRepository=orderRepository;


            if (!memoryCache.TryGetValue(OrderCacheKey, out _))
            {
                CacheAll(orderRepository, OrderCacheKey);
            }

        }

        public void CacheAllOrder(string cacheKey)
        {
            CacheAll(orderRepository, cacheKey);
        }
        public async Task AddAsync(Order entity)
        {
            await orderRepository.AddAsync(entity);
            await CommitAndRemoveCache(OrderCacheKey);
        }

        public async Task AddRangeAsync(IEnumerable<Order> entities)
        {
            await orderRepository.AddRangeAsync(entities);
            await CommitAndRemoveCache(OrderCacheKey);
        }

        public async Task Delete(int id)
        {
            orderRepository.Delete(id);
            await CommitAndRemoveCache(OrderCacheKey);
        }

        public async Task DeleteAll(Order entity)
        {
            orderRepository.DeleteAll(entity);
            await CommitAndRemoveCache(OrderCacheKey);
        }

        public async Task DeleteRange(IEnumerable<Order> entities)
        {
            orderRepository.DeleteRange(entities);
            await CommitAndRemoveCache(OrderCacheKey);
        }

        public async Task<IEnumerable<Order>> GetAllAsync()
        {
            CacheAllOrder(OrderCacheKey);
            var response= await orderRepository.GetAllAsync();
            CheckNullability(response, "There is no Order");
            return response;
        }

        public Task<Order> GetByIdAsync(int id)
        {
            CacheAllOrder(OrderCacheKey);
            var response= orderRepository.GetByIdAsync(id);
            CheckNullability(response, $"This {id} is Invalid");
            return response;
        }

        public async Task<CustomResponseDto<IEnumerable<OrderInfoDto>>> GetGreaterTotalPriceOrder(int price)
        {
            CacheAllOrder(OrderCacheKey);
            var response = await orderRepository.GetGreaterTotalPriceOrder(price);
            CheckNullability(response, "There is no Order");
            var dto = mapper.Map<IEnumerable<OrderInfoDto>>(response);
            return CustomResponseDto<IEnumerable<OrderInfoDto>>.Success(dto, 200);
        }

        public List<string> GetOrderCodes()
        {
            return orderRepository.GetOrderCodes();
        }

        public List<int> GetOrderIds()
        {
            return orderRepository.GetOrderIds();
        }

        public async Task<CustomResponseDto<OrderWithUserDto>> GetOrderWithUser(string OrderCode)
        {
            CacheAllOrder(OrderWithUserKey);
            var response = await orderRepository.GetOrdersWithUser(OrderCode);
            await CheckNullability(Task.FromResult(response), "There is no Order");
            var dto = mapper.Map<OrderWithUserDto>(response);
            return CustomResponseDto<OrderWithUserDto>.Success(dto, 200);
        }

        public async Task<CustomResponseDto<OrderWithOrderCodeDto>> GetWithOrderCode(string OrderCode)
        {
            CacheAllOrder(OrderCacheKey);
            var response = await orderRepository.GetWithOrderCode(OrderCode);
            await CheckNullability(Task.FromResult(response), "There is no Order");
            var dto = mapper.Map<OrderWithOrderCodeDto>(response);
            return CustomResponseDto<OrderWithOrderCodeDto>.Success(dto, 200);
        }

        public async Task Update(Order entity)
        {
            orderRepository.Update(entity);
            await CommitAndRemoveCache(OrderCacheKey);
        }

        public async Task UpdateRange(IEnumerable<Order> entities)
        {
            orderRepository.UpdateRange(entities);
            await CommitAndRemoveCache(OrderCacheKey);
        }
    }
}
