using Microsoft.EntityFrameworkCore;
using StockAnalyzeApp.Core.Dto;
using StockAnalyzeApp.Core.Models;
using StockAnalyzeApp.Core.Repositories;
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
        public async Task DeleteWithStocCode(int stockCode)
        {
            var result = await _context.Stock.Where(x => x.StockCode == stockCode).FirstOrDefaultAsync();
             _context.Stock.Remove(result);
            
        }

        public async Task<IEnumerable<Stock>> GetLessThan(int quantity)
        {
            var result= await _context.Stock.Where(x => x.Quantity < quantity).ToListAsync();
            return result;

        }

        public async Task<Stock> GetWithStockCode(int stockCode)
        {
            var result=await _context.Stock.Where(x => x.StockCode == stockCode).FirstOrDefaultAsync();
            if(result==null)
            {
                return null;
            }
            return result;
        }

        public  List<int> StockIds()
        {
            var result=  _context.Stock.Select(x => x.StockCode).ToList();
            return result;
        }
    }
}
