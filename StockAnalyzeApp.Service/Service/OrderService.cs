using AutoMapper;
using StockAnalyzeApp.Core.Dto.BaseResponseDtos;
using StockAnalyzeApp.Core.Dto.OrderDtos;
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
    public class OrderService : Service<Order>, IOrderService
    { 
        private readonly IOrderRepository orderRepository;
        private readonly IMapper mapper;
        public OrderService(IUnitOfWork unitOfWork, IGenericRepository<Order> repository, IMapper mapper, IOrderRepository orderRepository) : base(unitOfWork, repository)
        {

            this.mapper=mapper;
            this.orderRepository=orderRepository;
        }

        public async Task<CustomResponseDto<IEnumerable<OrderInfoDto>>> GetGreaterTotalPriceOrder(int price)
        {
           var response= await orderRepository.GetGreaterTotalPriceOrder(price);
            var data = mapper.Map<IEnumerable<OrderInfoDto>>(response);
            return  CustomResponseDto<IEnumerable<OrderInfoDto>>.Success(data,200);        }

        public List<string> GetOrderCodes()
        {
            var response= orderRepository.GetOrderCodes();
            return response;
        }

        public List<int> GetOrderIds()
        {
           var response= orderRepository.GetOrderIds();
            return response;
        }

        public async Task<CustomResponseDto<OrderWithUserDto>> GetOrderWithUsers(string OrderCode)
        {
           var response= await orderRepository.GetOrdersWithUsers(OrderCode);
            var data = mapper.Map<OrderWithUserDto>(response);
            return CustomResponseDto<OrderWithUserDto>.Success(data,200);
        }

        public async Task<CustomResponseDto<OrderWithOrderCodeDto>> GetWithOrderCode(string OrderCode)
        {
            var response= await orderRepository.GetWithOrderCode(OrderCode);
            var data = mapper.Map<OrderWithOrderCodeDto>(response);
            return CustomResponseDto<OrderWithOrderCodeDto>.Success(data,200);
           
        }
    }
}
