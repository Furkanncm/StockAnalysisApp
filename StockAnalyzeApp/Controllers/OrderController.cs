using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StockAnalyzeApp.Core.Dto.BaseResponseDtos;
using StockAnalyzeApp.Core.Dto.OrderDtos;
using StockAnalyzeApp.Core.Models;
using StockAnalyzeApp.Core.Repositories;
using StockAnalyzeApp.Core.Services;

namespace StockAnalyzeApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IOrderService orderService;
        private readonly IMapper mapper;

        public OrderController(IOrderService orderService, IMapper mapper)
        {
            this.orderService = orderService;
            this.mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var response = await orderService.GetAllAsync();
            var responseDto = mapper.Map<IEnumerable<OrderInfoDto>>(response);
            return Ok(CustomResponseDto<IEnumerable<OrderInfoDto>>.Success(responseDto, 200));
        }

        [HttpGet("[action]/{OrderCode}")]
        public async Task<IActionResult> GetOrderWithUsers(int OrderCode)
        {
            var response = await orderService.GetOrderWithUsers(OrderCode);
            return Ok(response);
        }

        [HttpGet("[action]/{price}")]
        public async Task<IActionResult> GetGreaterTotalPriceOrder(int price)
        {
            var response = await orderService.GetGreaterTotalPriceOrder(price);
            var responseDto = mapper.Map<IEnumerable<OrderInfoDto>>(response.Data);
            return Ok(CustomResponseDto<IEnumerable<OrderInfoDto>>.Success(responseDto, 200));
        }

        [HttpPost]
        public async Task<IActionResult> Add(OrderAddDto orderAddDto)
        {
            var order = mapper.Map<Order>(orderAddDto);
            var ids = orderService.GetOrderIds();
            if (!ids.Contains(order.UserId))
            {
                return Ok(CustomResponseDto<NoContentDto>.Fail("UserId is not valid", 400));
            }
            var ordercodes= orderService.GetOrderCodes();
            if (ordercodes.Contains(order.OrderCode))
            {
                return Ok(CustomResponseDto<NoContentDto>.Fail("OrderCode is not valid", 400));
            }
            await orderService.AddAsync(order);
            return Created();
        }

        [HttpPut]

        public async Task<IActionResult> Update(OrderUpdateDto orderUpdateDto)
        {
            var order = mapper.Map<Order>(orderUpdateDto);
            var ids = orderService.GetOrderIds();
            if (!ids.Contains(order.UserId))
            {
                return Ok(CustomResponseDto<NoContentDto>.Fail("UserId is not valid", 400));
            }

            await orderService.Update(order);
            return NoContent();
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteWithOrderCode(int OrderCode)
        {
            await orderService.Delete(OrderCode);
            return NoContent();
        }



    }
}
