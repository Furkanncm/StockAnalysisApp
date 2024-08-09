using StockAnalyzeApp.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockAnalyzeApp.Core.Repositories
{
    public interface IOrderRepository:IGenericRepository<Order>
    {   
        Task<IEnumerable<Order>> GetGreaterTotalPriceOrder(int price);

        List<int> GetOrderIds();

        List<int> GetOrderCodes();


    }
}
