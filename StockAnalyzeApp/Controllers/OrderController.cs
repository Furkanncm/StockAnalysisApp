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

        [HttpGet("[action]")]
        public async Task<IActionResult> GetWithOrderCode([FromQuery] string OrderCode)
        {
            var response = await orderService.GetWithOrderCode(OrderCode);
            return Ok(response);
        }

        [HttpGet("[action]")]
        public async Task<IActionResult> GetOrderWithUser([FromQuery] string OrderCode)
        {
            var response = await orderService.GetOrderWithUser(OrderCode);
            return Ok(response);
        }

        [HttpGet("[action]/{price}")]
        public async Task<IActionResult> GetGreaterTotalPriceOrder([FromRoute] int price)
        {
            var response = await orderService.GetGreaterTotalPriceOrder(price);
            var responseDto = mapper.Map<IEnumerable<OrderInfoDto>>(response.Data);
            return Ok(CustomResponseDto<IEnumerable<OrderInfoDto>>.Success(responseDto, 200));
        }

        [HttpPost]
        public async Task<IActionResult> Add([FromBody] OrderAddDto orderAddDto)
        {
            var order = mapper.Map<Order>(orderAddDto);
            var ids = orderService.GetOrderIds();
            if (!ids.Contains(order.UserId))
            {
                return Ok(CustomResponseDto<NoContentDto>.Fail("UserId is not valid", 400));
            }
            var ordercodes = orderService.GetOrderCodes();
            if (ordercodes.Contains(order.OrderCode))
            {
                return Ok(CustomResponseDto<NoContentDto>.Fail("OrderCode is not valid", 400));
            }
            await orderService.AddAsync(order);
            return Created();
        }

        [HttpPut]

        public async Task<IActionResult> Update([FromBody] OrderUpdateDto orderUpdateDto)
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
        public async Task<IActionResult> DeleteWithOrderCode([FromQuery] int id)
        {
            await orderService.Delete(id);
            return NoContent();
        }



    }
}
