using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockAnalyzeApp.Core.Services
{
    public interface IService<T> where T : class
    {
        Task<T> GetByIdAsync(int id);
        Task<IEnumerable<T>> GetAllAsync();
        Task AddAsync(T entity);
        Task AddRangeAsync(IEnumerable<T> entities);
        Task Delete(int id);
        Task DeleteRange(IEnumerable<T> entities);
        Task DeleteAll(T entity);
        Task Update(T entity);
        Task UpdateRange(IEnumerable<T> entities);
    }
}
