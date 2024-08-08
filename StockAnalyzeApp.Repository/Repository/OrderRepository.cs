using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using StockAnalyzeApp.Core.Models;
using StockAnalyzeApp.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockAnalyzeApp.Repository.Repository
{
    public class OrderRepository : GenericRepository<Order>, IOrderRepository
    {
        
        public OrderRepository(StockAnalyzeAppContext context) : base(context)
        {
        }

        public async Task<IEnumerable<Order>> GetGreaterTotalPriceOrder(int price)
        {
            var response= await _context.Orders.Where(x => x.TotalPrice > price).ToListAsync();
            return response;
        }
    }
}
