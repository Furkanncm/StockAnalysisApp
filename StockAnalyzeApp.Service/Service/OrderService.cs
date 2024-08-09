﻿using AutoMapper;
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

        public List<int> GetOrderCodes()
        {
            var response= orderRepository.GetOrderCodes();
            return response;
        }

        public List<int> GetOrderIds()
        {
           var response= orderRepository.GetOrderIds();
            return response;
        }
    }
}
