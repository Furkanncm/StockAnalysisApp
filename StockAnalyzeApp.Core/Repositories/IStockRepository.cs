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

        Task<Stock> GetWithStockCode(int stockCode);

        Task DeleteWithStocCode(int stockCode);
    }
}
