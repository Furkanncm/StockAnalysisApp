using Microsoft.Extensions.Caching.Memory;
using StockAnalyzeApp.Core.Repositories;
using StockAnalyzeApp.Core.Services;
using StockAnalyzeApp.Core.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockAnalyzeCache.CacheServices
{
    public class CacheManager<T> : ICacheManager<T> where T : class
    {
        private readonly IMemoryCache memoryCache;
        private readonly IUnitOfWork unitOfWork;

        public CacheManager(IMemoryCache memoryCache, IUnitOfWork unitOfWork)
        {
            this.memoryCache=memoryCache;
            this.unitOfWork=unitOfWork;
        }

        public  void CacheAll(IGenericRepository<T> repository, string CacheKey)
        {
            memoryCache.Remove(CacheKey);
            var response = repository.GetAll();
            memoryCache.Set(CacheKey, response);
        }

        public Task<T> CheckNullability(Task<T> Entity, string ErrorMessage)
        {
            if(Entity.Result == null)
            {
                throw new Exception(message:ErrorMessage);
            }
            else
            {
                return Entity;
            }
        }

        public IEnumerable<T> CheckNullability(IEnumerable<T> Entity, string ErrorMessage)
        {
            if(Entity==null)
            {
                throw new Exception(message:ErrorMessage);
            }
            else
            {
                return Entity;
            }

        }

        public async Task CommitAndRemoveCache(string CacheKey)
        {
            await unitOfWork.CommitAsync();
            memoryCache.Remove(CacheKey);
        }
    }
}
