using StockAnalyzeApp.Core.Dto.OrderDtos;
using StockAnalyzeApp.Core.Dto.StockDtos;
using StockAnalyzeApp.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockAnalyzeApp.Core.Repositories
{
    public interface IStockRepository:IGenericRepository<Stock>
    {
        Task<IEnumerable<Stock>> GetLessThan(int quantity);

        Task<Stock> GetStockWithUser(string stockCode);

        Task DeleteWithStocCode(string stockCode);

        List<string> StockIds();

        List<string> ContainsOrderCode();

        Task<IEnumerable<Stock>> GetNoStocks();

        Task CheckAndAcceptOrder(Stock stock);

    }
}
