using Microsoft.EntityFrameworkCore;
using StockAnalyzeApp.Core.Repositories;
using StockAnalyzeApp.Repository.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockAnalyzeApp.Repository.Repository
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        protected readonly StockAnalyzeAppContext _context;
        public readonly DbSet<T> _dbSet;
        private StockAnalyzeAppContext context;

        public GenericRepository( StockAnalyzeAppContext context)
        {
            _context=context;
            _dbSet = _context.Set<T>();
        }


     
        public async Task AddAsync(T entity)
        {
           await  _dbSet.AddAsync(entity);
        }

        public async Task AddRangeAsync(IEnumerable<T> entities)
        {
            await _dbSet.AddRangeAsync(entities);
        }

        public void Delete(int id)
        {
            _dbSet.Remove(_dbSet.Find(id)) ;
        }

        public void DeleteAll(T entity)
        {
            _dbSet.Remove(entity);
        }

        public void DeleteRange(IEnumerable<T> entities)
        {
            _dbSet.RemoveRange(entities);
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return  _dbSet.AsNoTracking().AsQueryable();
        }

        public IEnumerable<T> GetAll()
        {
            return _dbSet.AsNoTracking().AsQueryable().ToList();
        }
        public async Task<T> GetByIdAsync(int id)
        {
           return await _dbSet.FindAsync(id);
        }

        public void Update(T entity)
        {
            _dbSet.Update(entity);
        }

        public void UpdateRange(IEnumerable<T> entities)
        {
            _dbSet.UpdateRange(entities);
        }

        public Task<IEnumerable<int>> GetValidIdsAsync()
        {
            throw new NotImplementedException();
        }

 
    }
}
