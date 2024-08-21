using Microsoft.EntityFrameworkCore;
using StockAnalyzeApp.Core.Dto;
using StockAnalyzeApp.Core.Dto.OrderDtos;
using StockAnalyzeApp.Core.Dto.StockDtos;
using StockAnalyzeApp.Core.Models;
using StockAnalyzeApp.Core.Repositories;
using StockAnalyzeApp.Repository.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockAnalyzeApp.Repository.Repository
{
    public class StockRepository : GenericRepository<Stock>, IStockRepository
    {
        public StockRepository(StockAnalyzeAppContext context) : base(context)
        {
        }
        public async Task DeleteWithStocCode(string stockCode)
        {
            var result = await _context.Stock.Where(x => x.StockCode == stockCode).FirstOrDefaultAsync();
             _context.Stock.Remove(result);
            
        }

        public async Task<IEnumerable<Stock>> GetLessThan(int quantity)
        {
            var result= await _context.Stock.Where(x => x.Quantity < quantity).ToListAsync();
            return result;

        }

      
        public async Task<Stock> GetStockWithUser(string stockCode)
        {
            var result=await _context.Stock.Include(x=>x.User).FirstOrDefaultAsync(x => x.StockCode == stockCode);
            if(result==null)
            {
                return null;
            }
            return result;
        }

        public  List<string> StockIds()
        {
            var result=  _context.Stock.Select(x => x.StockCode).ToList();
            return result;
        }
        public async Task<IEnumerable<Stock>> GetDontHaveStocks()
        {
            var result = await _context.Stock.Where(x => x.Quantity == 0).ToListAsync();
            return result;
        }

        public async Task CheckAndAcceptOrder(Stock stock)
        {
            await _context.Stock.AddAsync(new Stock
            {
                Name = stock.Name,
                Quantity = stock.Quantity,
                StockCode = stock.StockCode,
                Type = stock.Type,
                UserId = stock.UserId,
                OrderCode=stock.OrderCode
            });
        }

        public List<string> ContainsOrderCode()
        {
           var result= _context.Stock.Select(x => x.OrderCode).ToList();
            return result;
        }

        public async Task ChangeQuality(Stock stock)
        {
            _context.Stock.Update(stock);
        }

        public  Task<Stock> GetByStockCode(string stockCode)
        {
           var response= _context.Stock.FirstOrDefaultAsync(x => x.StockCode == stockCode);
            return response;
        }
    }
}
