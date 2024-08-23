using AutoMapper;
using Microsoft.Extensions.Caching.Memory;
using StockAnalyzeApp.Core.Dto.BaseResponseDtos;
using StockAnalyzeApp.Core.Dto.CompanyDtos;
using StockAnalyzeApp.Core.Models;
using StockAnalyzeApp.Core.Repositories;
using StockAnalyzeApp.Core.Services;
using StockAnalyzeApp.Core.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace StockAnalyzeCache.CacheServices
{
    public class CompanyCacheService : ICompanyService
    {
        private readonly ICompanyRepository companyRepository;
        private readonly IMapper mapper;
        private readonly IUnitOfWork unitOfWork;
        private readonly IMemoryCache memoryCache;
        private const string CompanyWithUserskey = "CompanyWithUserskey";
        private const string CompanyCacheKey = "CompanyCacheKey";

        public CompanyCacheService(IMemoryCache memoryCache, IUnitOfWork unitOfWork, IMapper mapper, ICompanyRepository companyRepository)
        {
            this.memoryCache=memoryCache;
            this.unitOfWork=unitOfWork;
            this.mapper=mapper;
            this.companyRepository=companyRepository;

            if (!memoryCache.TryGetValue(CompanyCacheKey, out _))
            {
                var response = companyRepository.GetAll();
                memoryCache.Set(CompanyCacheKey, response);
            }
        }

        public void CacheAllCompany(string cacheKey)
        {
            memoryCache.Remove(cacheKey);
            var response = companyRepository.GetAll().ToList();
            memoryCache.Set(cacheKey, response);
        }
        public async Task AddAsync(Company entity)
        {
            await companyRepository.AddAsync(entity);
            await unitOfWork.CommitAsync();
            memoryCache.Remove(CompanyCacheKey);
        }


        public async Task AddRangeAsync(IEnumerable<Company> entities)
        {
            await companyRepository.AddRangeAsync(entities);
            await unitOfWork.CommitAsync();
            memoryCache.Remove(CompanyCacheKey);
        }

        public async Task Delete(int id)
        {
            companyRepository.Delete(id);
            await unitOfWork.CommitAsync();
            memoryCache.Remove(CompanyCacheKey);
        }

        public async Task DeleteAll(Company entity)
        {
            companyRepository.DeleteAll(entity);
            await unitOfWork.CommitAsync();
            memoryCache.Remove(CompanyCacheKey);
        }

        public async Task DeleteRange(IEnumerable<Company> entities)
        {
            companyRepository.DeleteRange(entities);
            await unitOfWork.CommitAsync();
            memoryCache.Remove(CompanyCacheKey);
        }

        public async Task<IEnumerable<Company>> GetAllAsync()
        {
            CacheAllCompany(CompanyCacheKey);
            return await companyRepository.GetAllAsync();

        }

        public Task<Company> GetByIdAsync(int id)
        {
            CacheAllCompany(CompanyCacheKey);
            return companyRepository.GetByIdAsync(id);
        }

        public Task<List<int>> GetCompanyIds()
        {
            CacheAllCompany(CompanyCacheKey);
            var response = companyRepository.GetCompanyIds();
            return Task.FromResult(response);
        }

        public async Task<CustomResponseDto<CompanywithUsers>> GetCompanyUsers(int companyId)
        {
            CacheAllCompany(CompanyWithUserskey);
            var response= await companyRepository.GetCompanyUsers(companyId);
            var dto = mapper.Map<CompanywithUsers>(response);
            return CustomResponseDto<CompanywithUsers>.Success(dto, 200);

        }

        public async Task Update(Company entity)
        {
            companyRepository.Update(entity);
            await unitOfWork.CommitAsync();
            memoryCache.Remove(CompanyCacheKey);
        }

        public async Task UpdateRange(IEnumerable<Company> entities)
        {
            companyRepository.UpdateRange(entities);
            await unitOfWork.CommitAsync();
            memoryCache.Remove(CompanyCacheKey);
        }
    }
}
