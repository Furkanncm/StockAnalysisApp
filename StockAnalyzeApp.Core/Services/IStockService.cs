using StockAnalyzeApp.Core.Dto.BaseResponseDtos;
using StockAnalyzeApp.Core.Dto.StockDtos;
using StockAnalyzeApp.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockAnalyzeApp.Core.Services
{
    public interface IStockService:IService<Stock>
    {
        Task<CustomResponseDto<IEnumerable<StockDto>>> GetLessThan(int quantity);

        Task<CustomResponseDto<StockWithUserDto>> GetStockWithUser(string stockCode);
        Task<CustomResponseDto<NoContentDto>> DeleteWithStockCode(string stockCode);

        Task<CustomResponseDto<StockDto>> ChangeQuantityStockWithBarcode(string barcode,int quantity);

        List<string> GetStockCodes();

        List<string> ContainsOrderCode();

        Task<CustomResponseDto<IEnumerable<StockDto>>> GetNoStocks();
        Task<CustomResponseDto<Stock>> CheckAndAcceptOrder(StockAddDto stockAddDto);
    }
}
