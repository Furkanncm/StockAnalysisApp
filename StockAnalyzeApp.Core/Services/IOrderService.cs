using StockAnalyzeApp.Core.Dto.BaseResponseDtos;
using StockAnalyzeApp.Core.Dto.OrderDtos;
using StockAnalyzeApp.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockAnalyzeApp.Core.Services
{
    public interface IOrderService: IService<Order>
    {
        Task<CustomResponseDto<IEnumerable<OrderInfoDto>>> GetGreaterTotalPriceOrder(int price);

        List<int> GetOrderIds();

        List<string> GetOrderCodes();

        Task<CustomResponseDto<OrderWithUserDto>> GetOrderWithUser(string OrderCode);

        Task<CustomResponseDto<OrderWithOrderCodeDto>> GetWithOrderCode(string OrderCode);


    }
}
