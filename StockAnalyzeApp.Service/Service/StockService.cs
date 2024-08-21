using AutoMapper;
using FirebaseAdmin.Auth;
using StockAnalyzeApp.Core.Dto.BaseResponseDtos;
using StockAnalyzeApp.Core.Dto.StockDtos;
using StockAnalyzeApp.Core.Models;
using StockAnalyzeApp.Core.Repositories;
using StockAnalyzeApp.Core.Services;
using StockAnalyzeApp.Core.UnitOfWork;
using StockAnalyzeApp.Repository.Repository;
using StockAnalyzeApp.Service.Validator.StockValidators;
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
        private readonly IUserRepository userRepository;
        private readonly IMapper    _mapper;
        public StockService(IUnitOfWork unitOfWork, IGenericRepository<Stock> repository, IStockRepository stockRepository, IMapper mapper, IOrderRepository orderRepository, IUserRepository userRepository) : base(unitOfWork, repository)
        {
            _stockRepository=stockRepository;
            _mapper=mapper;
            _orderRepository=orderRepository;
            this.userRepository=userRepository;
        }



        public async Task<CustomResponseDto<Stock>> CheckAndAcceptOrder(AddStockWithAcceptOrder addStockWithAcceptOrder)
        {
            var stock = _mapper.Map<Stock>(addStockWithAcceptOrder);
            var res = _stockRepository.StockIds();
            var orderRes = _orderRepository.GetOrderCodes();
            var stockOrderRes = _stockRepository.ContainsOrderCode();
            var order = await _orderRepository.GetWithOrderCode(stock.OrderCode);
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
                        stock.UserId = order.UserId;
                        stock.Quantity = order.Quantity;
                        stock.StockCode = $"{stock.OrderCode}{stock.Quantity}";
                        await _stockRepository.CheckAndAcceptOrder(stock);
                        await _unitOfWork.CommitAsync();

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
            var response = _stockRepository.ContainsOrderCode();    
            return response;
        }

        public async Task<CustomResponseDto<NoContentDto>> DeleteWithStockCode(string stockCode)
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

        public async Task<CustomResponseDto<IEnumerable<StockDto>>> GetDontHaveStocks()
        {
            var response = await _stockRepository.GetDontHaveStocks();
            var dto = _mapper.Map<IEnumerable<StockDto>>(response);
            return CustomResponseDto<IEnumerable<StockDto>>.Success(dto, 200);
        }

        public List<string> GetStockCodes()
        {
            var response = _stockRepository.StockIds();
            return response;
        }

        public async Task<CustomResponseDto<StockWithUserDto>> GetStockWithUser(string stockCode)
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

        public async Task<CustomResponseDto<StockDto>> ChangeQuantityStockWithBarcode(AddQuantityWithtStockCode addQuantityWithtStockCode)
        {
            var response= await _stockRepository.GetByStockCode(addQuantityWithtStockCode.StockCode);
            var dto= _mapper.Map<Stock>(response);
            dto.Quantity += addQuantityWithtStockCode.Quantity;
          await _unitOfWork.CommitAsync();
            dto.StockCode = $"{dto.OrderCode}{dto.Quantity}";
            var dto2= _mapper.Map<StockDto>(dto);
            return CustomResponseDto<StockDto>.Success(dto2, 200);
            
        }

        public async Task<CustomResponseDto<StockDto>> GetByStockCode(string stockCode)
        {
            var response= await _stockRepository.GetByStockCode(stockCode);
            if (response==null)
            {
                return CustomResponseDto<StockDto>.Fail("Stock not found", 404);
            }
            else
            {
                var dto = _mapper.Map<StockDto>(response);
                return CustomResponseDto<StockDto>.Success(dto, 200);
            }
        }
    }
}
