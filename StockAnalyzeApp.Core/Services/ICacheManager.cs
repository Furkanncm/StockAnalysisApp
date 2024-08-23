using StockAnalyzeApp.Core.Models;
using StockAnalyzeApp.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockAnalyzeApp.Core.Services
{
    public interface ICacheManager<T> where T : class
    {
         Task<T> CheckNullability(Task<T> Entity, String ErrorMessage);
         IEnumerable<T> CheckNullability(IEnumerable<T> Entity, String ErrorMessage);

        void CacheAll(IGenericRepository<T> repository,string CacheKey); 

        Task CommitAndRemoveCache(string CacheKey);
    }
}
