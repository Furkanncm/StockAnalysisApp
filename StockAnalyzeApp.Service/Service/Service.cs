using StockAnalyzeApp.Core.Repositories;
using StockAnalyzeApp.Core.Services;
using StockAnalyzeApp.Core.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockAnalyzeApp.Service.Service
{
    public class Service<T> : IService<T> where T : class
    {
        private readonly IGenericRepository<T> _repository;
        private readonly IUnitOfWork _unitOfWork;

        public Service(IUnitOfWork unitOfWork, IGenericRepository<T> repository)
        {
            _unitOfWork=unitOfWork;
            _repository=repository;
        }

        public async Task AddAsync(T entity)
        {
            await _repository.AddAsync(entity);
            await _unitOfWork.CommitAsync();
        }

        public async Task AddRangeAsync(IEnumerable<T> entities)
        {
            await _repository.AddRangeAsync(entities);
            await _unitOfWork.CommitAsync();
        }

        public async Task Delete(int id)
        {
             _repository.Delete(id);
            await _unitOfWork.CommitAsync();
        }

        public async Task DeleteAll(T entity)
        {
            _repository.DeleteAll(entity);
            await _unitOfWork.CommitAsync();
        }

        public async Task DeleteRange(IEnumerable<T> entities)
        {
            _repository.DeleteRange(entities);
            await _unitOfWork.CommitAsync();
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await _repository.GetAllAsync();
        }

        public async Task<T> GetByIdAsync(int id)
        {
            return await _repository.GetByIdAsync(id);
        }

        public async Task Update(T entity)
        {
           _repository.Update(entity);
             await _unitOfWork.CommitAsync();
        }

        public async Task UpdateRange(IEnumerable<T> entities)
        {
            _repository.UpdateRange(entities);
             await _unitOfWork.CommitAsync();
           
        }
    }
}
