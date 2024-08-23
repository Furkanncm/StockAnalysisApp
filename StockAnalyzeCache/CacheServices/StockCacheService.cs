using AutoMapper;
using Microsoft.Extensions.Caching.Memory;
using StockAnalyzeApp.Core.Dto.BaseResponseDtos;
using StockAnalyzeApp.Core.Dto.StockDtos;
using StockAnalyzeApp.Core.Models;
using StockAnalyzeApp.Core.Repositories;
using StockAnalyzeApp.Core.Services;
using StockAnalyzeApp.Core.UnitOfWork;
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
    public class StockCacheService : IStockService
    {
        private const string stockCacheKey = "StockCacheKey";
        private const string stockWithUserKey = "stockWithUserKey";
        private readonly IStockRepository stockRepository;
        private readonly IOrderRepository orderRepository;
        private readonly IUserRepository userRepository;
        private readonly IMapper mapper;
        private readonly IUnitOfWork unitOfWork;
        private readonly IMemoryCache memoryCache;

        public StockCacheService(IMemoryCache memoryCache, IUnitOfWork unitOfWork, IMapper mapper, IStockRepository stockRepository, IOrderRepository orderRepository, IUserRepository userRepository)
        {
            this.memoryCache=memoryCache;
            this.unitOfWork=unitOfWork;
            this.mapper=mapper;
            this.stockRepository=stockRepository;
            this.orderRepository=orderRepository;
            this.userRepository=userRepository;

            if (!memoryCache.TryGetValue(stockCacheKey, out _))
            {
                var response = stockRepository.GetAll().ToList();
                memoryCache.Set(stockCacheKey, response);
            }

      
        }

        public async Task<Stock> CheckNullability(Task<Stock> stock, String ErrorMessage)
        {
            if (stock.Result==null)
            {
                throw new Exception(message: ErrorMessage);
            }
            else
            {
                return await stock;
            }
        }
        public IEnumerable<Stock> CheckNullability(IEnumerable<Stock> stock, String ErrorMessage)
        {
            if (stock==null)
            {
                throw new Exception(message: ErrorMessage);
            }
            else
            {
                return stock;
            }
        }

        public void CacheAllStocks(string CacheKey)
        {
            memoryCache.Remove(CacheKey);
            var response = stockRepository.GetAll().ToList();
            memoryCache.Set(CacheKey, response);
        }

        public async Task AddAsync(Stock entity)
        {
            await stockRepository.AddAsync(entity);
            await unitOfWork.CommitAsync();
            memoryCache.Remove(stockCacheKey);
        }

        public async Task AddRangeAsync(IEnumerable<Stock> entities)
        {
            await stockRepository.AddRangeAsync(entities);
            await unitOfWork.CommitAsync();
            memoryCache.Remove(stockCacheKey);
        }

        public async Task<CustomResponseDto<StockDto>> ChangeQuantityStockWithBarcode(AddQuantityWithtStockCode addQuantityWithtStockCode)
        {
            var response = await stockRepository.GetByStockCode(addQuantityWithtStockCode.StockCode);
            response.Quantity += addQuantityWithtStockCode.Quantity;
            response.StockCode = $"{response.OrderCode}{response.Quantity}";
            await unitOfWork.CommitAsync();
            var dto2 = mapper.Map<StockDto>(response);
            memoryCache.Remove(stockCacheKey);
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
                        await stockRepository.CheckAndAcceptOrder(stock);
                        await unitOfWork.CommitAsync();

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
            await unitOfWork.CommitAsync();
            memoryCache.Remove(stockCacheKey);
        }

        public async Task DeleteAll(Stock entity)
        {
            stockRepository.DeleteAll(entity);
            await unitOfWork.CommitAsync();
            memoryCache.Remove(stockCacheKey);
        }

        public async Task DeleteRange(IEnumerable<Stock> entities)
        {
            stockRepository.DeleteRange(entities);
            await unitOfWork.CommitAsync();
            memoryCache.Remove(stockCacheKey);
        }

        public async Task<CustomResponseDto<NoContentDto>> DeleteWithStockCode(string stockCode)
        {
            await stockRepository.DeleteWithStocCode(stockCode);
            await unitOfWork.CommitAsync();
            memoryCache.Remove(stockCacheKey);
            return CustomResponseDto<NoContentDto>.Success(200);

        }

        public Task<IEnumerable<Stock>> GetAllAsync()
        {
            CacheAllStocks(stockCacheKey);
            var result = stockRepository.GetAll().ToList();
            var response = CheckNullability(result, "Got Zero Stocks");
            return Task.FromResult(response);
        }

        public Task<Stock> GetByIdAsync(int id)
        {
            CacheAllStocks(stockCacheKey);
            var result = stockRepository.GetByIdAsync(id);
            var response = CheckNullability(result, "Stock's Not Valid");
            return response;
        }

        public async Task<CustomResponseDto<StockDto>> GetByStockCode(string stockCode)
        {
            CacheAllStocks(stockCacheKey);
            var result = await stockRepository.GetByStockCode(stockCode);
            var response = await CheckNullability(Task.FromResult(result), $"{stockCode} is Not Valid");
            var dto = mapper.Map<StockDto>(result);
            return CustomResponseDto<StockDto>.Success(dto, 200);

        }

        public async Task<CustomResponseDto<IEnumerable<StockDto>>> GetDontHaveStocks()
        {
            CacheAllStocks(stockCacheKey);
            var response = await stockRepository.GetDontHaveStocks();
            var dto = mapper.Map<IEnumerable<StockDto>>(response);
            return CustomResponseDto<IEnumerable<StockDto>>.Success(dto, 200);
        }

        public async Task<CustomResponseDto<IEnumerable<StockDto>>> GetLessThan(int quantity)
        {
            CacheAllStocks(stockCacheKey);
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
                CacheAllStocks(stockWithUserKey);
            }
            var response = await stockRepository.GetStockWithUser(stockCode);
            var dto = mapper.Map<StockWithUserDto>(response);
            return CustomResponseDto<StockWithUserDto>.Success(dto, 200);

        }

        public async Task Update(Stock entity)
        {
            stockRepository.Update(entity);
            await unitOfWork.CommitAsync();
            CacheAllStocks(stockCacheKey);
        }

        public async Task UpdateRange(IEnumerable<Stock> entities)
        {
            stockRepository.UpdateRange(entities);
            await unitOfWork.CommitAsync();
            CacheAllStocks(stockCacheKey);
        }
    }
}
