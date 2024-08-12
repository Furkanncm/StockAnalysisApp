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

        List<int> GetOrderCodes();

        Task<CustomResponseDto<OrderWithUserDto>> GetOrderWithUsers(int OrderCode);


    }
}
