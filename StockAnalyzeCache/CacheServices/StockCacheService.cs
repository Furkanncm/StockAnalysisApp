using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Memory;
using StockAnalyzeApp.Core.Dto.BaseResponseDtos;
using StockAnalyzeApp.Core.Dto.StockDtos;
using StockAnalyzeApp.Core.Models;
using StockAnalyzeApp.Core.Repositories;
using StockAnalyzeApp.Core.Services;
using StockAnalyzeApp.Core.UnitOfWork;
using StockAnalyzeApp.Repository.Context;
using StockAnalyzeApp.Repository.Repository;
using StockAnalyzeApp.Repository.UnitOfWork;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockAnalyzeCache.CacheServices
{
    public class StockCacheService : CacheManager<Stock>,IStockService
    {
        private const string stockCacheKey = "StockCacheKey";
        private const string stockWithUserKey = "stockWithUserKey";
        private readonly IStockRepository stockRepository;
        private readonly IOrderRepository orderRepository;
        private readonly IUserRepository userRepository;
        private readonly IMapper mapper;
        private readonly IUnitOfWork unitOfWork;
        private readonly IMemoryCache memoryCache;
        private readonly StockAnalyzeAppContext context;

        public StockCacheService(IMemoryCache memoryCache, IUnitOfWork unitOfWork, IMapper mapper, IStockRepository stockRepository, IOrderRepository orderRepository, IUserRepository userRepository, StockAnalyzeAppContext context):base(memoryCache,unitOfWork)
        {
            this.memoryCache=memoryCache;
            this.unitOfWork=unitOfWork;
            this.mapper=mapper;
            this.stockRepository=stockRepository;
            this.orderRepository=orderRepository;
            this.userRepository=userRepository;
            this.context=context;

            CacheAll(stockRepository, stockCacheKey);

        }
        public async Task AddAsync(Stock entity)
        {
            await stockRepository.AddAsync(entity);
            await CommitAndRemoveCache(stockCacheKey);
        }

        public async Task AddRangeAsync(IEnumerable<Stock> entities)
        {
            await stockRepository.AddRangeAsync(entities);
            await CommitAndRemoveCache(stockCacheKey);
        }

        public async Task<CustomResponseDto<StockDto>> ChangeQuantityStockWithBarcode(AddQuantityWithtStockCode addQuantityWithtStockCode)
        {
            var response = await stockRepository.GetByStockCode(addQuantityWithtStockCode.StockCode);
            response.Quantity += addQuantityWithtStockCode.Quantity;
            response.StockCode = $"{response.OrderCode}{response.Quantity}";
            var dto2 = mapper.Map<StockDto>(response);
            await CommitAndRemoveCache(stockCacheKey);
            return CustomResponseDto<StockDto>.Success(dto2, 200);
        }

        public async Task<CustomResponseDto<Stock>> CheckAndAcceptOrder(AddStockWithAcceptOrder addStockWithAcceptOrder)
        {
            var stock = mapper.Map<Stock>(addStockWithAcceptOrder);
            var res = stockRepository.StockIds();
            var orderRes = orderRepository.GetOrderCodes();
            var stockOrderRes = stockRepository.ContainsOrderCode();
            var order = await orderRepository.GetWithOrderCode(stock.OrderCode);
            if (res.Contains(stock.StockCode))
            {
                return CustomResponseDto<Stock>.Fail("Stock code must be unique", 400);
            }
            else
            {
                if (!orderRes.Contains(stock.OrderCode))
                {
                    return CustomResponseDto<Stock>.Fail("Order code not found", 404);
                }
                else
                {
                    if (stockOrderRes.Contains(stock.OrderCode))
                    {
                        return CustomResponseDto<Stock>.Fail("This Order Already Stocked", 400);
                    }
                    else
                    {
                        stock.UserId = order.UserId;
                        stock.Quantity = order.Quantity;
                        stock.StockCode = $"{stock.OrderCode}{stock.Quantity}";
                        stock.CreatedDate = DateTime.Now;
                        await stockRepository.CheckAndAcceptOrder(stock);
                        await CommitAndRemoveCache(stockCacheKey);
                        var user = await userRepository.GetByIdAsync(stock.UserId);
                        if (user?.DeviceToken != null)
                        {
                            var firebaseService = new FirebaseService();
                            await firebaseService.SendNotificationAsync(
                                user.DeviceToken,
                                "Sipariş Kabul Edildi",
                                "Sipariş kabul edildi ve stoklara eklendi."
                            );
                        }

                        return CustomResponseDto<Stock>.Success(stock, 200);
                    }
                }
            }
        }

        public List<string> ContainsOrderCode()
        {
            var response = stockRepository.ContainsOrderCode();
            return response;
        }

        public async Task Delete(int id)
        {
            stockRepository.Delete(id);
            await CommitAndRemoveCache(stockCacheKey);
        }

        public async Task DeleteAll(Stock entity)
        {
            stockRepository.DeleteAll(entity);
            await CommitAndRemoveCache(stockCacheKey);
        }

        public async Task DeleteRange(IEnumerable<Stock> entities)
        {
            stockRepository.DeleteRange(entities);
            await CommitAndRemoveCache(stockCacheKey);
        }

        public async Task<CustomResponseDto<NoContentDto>> DeleteWithStockCode(string stockCode)
        {
            await stockRepository.DeleteWithStocCode(stockCode);
            await CommitAndRemoveCache(stockCacheKey);
            return CustomResponseDto<NoContentDto>.Success(200);

        }

        public Task<IEnumerable<Stock>> GetAllAsync()
        {
            CacheAll(stockRepository, stockCacheKey);
            var result = stockRepository.GetAll().ToList();
            var response = CheckNullability(result, "Got Zero Stocks");
            return Task.FromResult(response);
        }

        public Task<Stock> GetByIdAsync(int id)
        {
            CacheAll(stockRepository, stockCacheKey);
            var result = stockRepository.GetByIdAsync(id);
            var response = CheckNullability(result, "Stock's Not Valid");
            return response;
        }

        public async Task<CustomResponseDto<StockDto>> GetByStockCode(string stockCode)
        {
            CacheAll(stockRepository, stockCacheKey);
            var result = await stockRepository.GetByStockCode(stockCode);
            var response = await CheckNullability(Task.FromResult(result), $"{stockCode} is Not Valid");
            var dto = mapper.Map<StockDto>(result);
            return CustomResponseDto<StockDto>.Success(dto, 200);

        }

        public async Task<CustomResponseDto<IEnumerable<StockDto>>> GetDontHaveStocks()
        {
            CacheAll(stockRepository, stockCacheKey);
            var response = await stockRepository.GetDontHaveStocks();
            var dto = mapper.Map<IEnumerable<StockDto>>(response);
            return CustomResponseDto<IEnumerable<StockDto>>.Success(dto, 200);
        }

        public async Task<CustomResponseDto<IEnumerable<StockDto>>> GetLessThan(int quantity)
        {
            CacheAll(stockRepository, stockCacheKey);
            var response = await stockRepository.GetLessThan(quantity);
            var dto = mapper.Map<IEnumerable<StockDto>>(response);
            return CustomResponseDto<IEnumerable<StockDto>>.Success(dto, 200);
        }

        public List<string> GetStockCodes()
        {
            var response = stockRepository.StockIds();
            return response;
        }

        public async Task<CustomResponseDto<StockWithUserDto>> GetStockWithUser(string stockCode)
        {

            if (!memoryCache.TryGetValue(stockCode, out _))
            {
                CacheAll(stockRepository, stockWithUserKey);
            }
            var response = await stockRepository.GetStockWithUser(stockCode);
            var dto = mapper.Map<StockWithUserDto>(response);
            return CustomResponseDto<StockWithUserDto>.Success(dto, 200);

        }

        public async Task Update(Stock entity)
        {
            var response = await context.Stock.AsNoTracking().FirstOrDefaultAsync(o => o.Id == entity.Id);
            entity.CreatedDate = response.CreatedDate;
            entity.UpdatedDate=DateTime.Now;
            entity.StockCode = response.StockCode;
            entity.OrderCode = response.OrderCode;
            stockRepository.Update(entity);
            await CommitAndRemoveCache(stockCacheKey);
        }

        public async Task UpdateRange(IEnumerable<Stock> entities)
        {
            stockRepository.UpdateRange(entities);
            await CommitAndRemoveCache(stockCacheKey);
        }
    }
}
