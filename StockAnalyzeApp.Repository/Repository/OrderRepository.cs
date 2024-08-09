using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using StockAnalyzeApp.Core.Models;
using StockAnalyzeApp.Core.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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

        public List<int> GetOrderCodes()
        {
            var response = _context.Orders.Select(x => x.OrderCode).ToList();
            return response;
        }

        public List<int> GetOrderIds()
        {
            var response=  _context.Orders.Select(x => x.UserId).ToList();
            return response;
        }
    }
}
