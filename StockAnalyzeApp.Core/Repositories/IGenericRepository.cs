using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockAnalyzeApp.Core.Repositories
{
    public interface IGenericRepository<T> where T : class
    {
        Task<T> GetByIdAsync(int id);
        Task<IEnumerable<T>> GetAllAsync();
        Task AddAsync(T entity);
        Task AddRangeAsync(IEnumerable<T> entities);
        void Delete(int id);
        void DeleteRange(IEnumerable<T> entities);
        void DeleteAll(T entity);
        void Update(T entity);
        void UpdateRange(IEnumerable<T> entities);
    }
}
