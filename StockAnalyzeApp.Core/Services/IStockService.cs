using StockAnalyzeApp.Core.Dto;
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

        Task<CustomResponseDto<StockAddDto>> GetWithStockCode(int stockCode);
        Task<CustomResponseDto<NoContentDto>> DeleteWithStockCode(int stockCode);
    }
}
