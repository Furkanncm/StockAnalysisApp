﻿using AutoMapper;
using StockAnalyzeApp.Core.Dto.BaseResponseDtos;
using StockAnalyzeApp.Core.Dto.StockDtos;
using StockAnalyzeApp.Core.Models;
using StockAnalyzeApp.Core.Repositories;
using StockAnalyzeApp.Core.Services;
using StockAnalyzeApp.Core.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockAnalyzeApp.Service.Service
{
    public class StockService : Service<Stock>, IStockService
    {
        private readonly IStockRepository _stockRepository;
        private readonly IOrderRepository _orderRepository;
        private readonly IMapper    _mapper;
        public StockService(IUnitOfWork unitOfWork, IGenericRepository<Stock> repository, IStockRepository stockRepository, IMapper mapper, IOrderRepository orderRepository) : base(unitOfWork, repository)
        {
            _stockRepository=stockRepository;
            _mapper=mapper;
            _orderRepository=orderRepository;
        }

        public async Task<CustomResponseDto<StockDto>> ChangeQuantityStockWithBarcode(int barcode,int quantity)
        {
            if (quantity==0)
            {
                return CustomResponseDto<StockDto>.Fail("Quantity must not equals to 0",400);
            }
            else
            {
                var response = await _stockRepository.GetStockWithUser(barcode);
                if (response==null)
                {
                    return CustomResponseDto<StockDto>.Fail("Stock not found",404);
                }
                else
                {
                    response.Quantity += quantity;
                    await _unitOfWork.CommitAsync();
                    return CustomResponseDto<StockDto>.Success(_mapper.Map<StockDto>(response), 200);
                }
                
            }
            
        }

        public async Task<CustomResponseDto<Stock>> CheckAndAcceptOrder(StockAddDto stockAddDto)
        {
            var stock = _mapper.Map<Stock>(stockAddDto);
            var res = _stockRepository.StockIds();
            var orderRes = _orderRepository.GetOrderCodes();
            var stockOrderRes = _stockRepository.ContainsOrderCode();
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
                    if(stockOrderRes.Contains(stock.OrderCode))
                        {
                        return CustomResponseDto<Stock>.Fail("This Order Already Stocked", 400);
                    }
                    else
                    {
                        await _stockRepository.AddAsync(stock);
                        await _unitOfWork.CommitAsync();
                        return CustomResponseDto<Stock>.Success(stock, 200);
                    }
                }
            }
            
        }

        public List<string> ContainsOrderCode()
        {
            var response = _stockRepository.ContainsOrderCode();    
            return response;
        }

        public async Task<CustomResponseDto<NoContentDto>> DeleteWithStockCode(int stockCode)
        {
            await _stockRepository.DeleteWithStocCode(stockCode);
            await _unitOfWork.CommitAsync();
            return CustomResponseDto<NoContentDto>.Success(204);
        }

        public async Task<CustomResponseDto<IEnumerable<StockDto>>> GetLessThan(int quantity)
        {
            var response= await _stockRepository.GetLessThan(quantity);
            var dto = _mapper.Map<IEnumerable<StockDto>>(response);
            return CustomResponseDto<IEnumerable<StockDto>>.Success(dto,200);
        }

        public async Task<CustomResponseDto<IEnumerable<StockDto>>> GetNoStocks()
        {
            var response = await _stockRepository.GetNoStocks();
            var dto = _mapper.Map<IEnumerable<StockDto>>(response);
            return CustomResponseDto<IEnumerable<StockDto>>.Success(dto, 200);
        }

        public List<int> GetStockCodes()
        {
            var response = _stockRepository.StockIds();
            return response;
        }

        public async Task<CustomResponseDto<StockWithUserDto>> GetStockWithUser(int stockCode)
        {
            var response= await _stockRepository.GetStockWithUser(stockCode);
            if (response==null)
            {
                return CustomResponseDto<StockWithUserDto>.Fail("Stock not found", 404);
            }
            else
            {
                var dto = _mapper.Map<StockWithUserDto>(response);
                return CustomResponseDto<StockWithUserDto>.Success(dto, 200);
            }
        }
    }
}
