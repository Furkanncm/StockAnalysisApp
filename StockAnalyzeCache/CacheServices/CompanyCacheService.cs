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
using System.ComponentModel.Design;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace StockAnalyzeCache.CacheServices
{
    public class CompanyCacheService : CacheManager<Company>, ICompanyService
    {
        private readonly ICompanyRepository companyRepository;
        private readonly IMapper mapper;
        private readonly IUnitOfWork unitOfWork;
        private readonly IMemoryCache memoryCache;
        private const string CompanyWithUserskey = "CompanyWithUserskey";
        private const string CompanyCacheKey = "CompanyCacheKey";

        public CompanyCacheService(IMemoryCache memoryCache, IUnitOfWork unitOfWork, IMapper mapper, ICompanyRepository companyRepository) : base(memoryCache, unitOfWork)
        {

            this.memoryCache=memoryCache;
            this.unitOfWork=unitOfWork;
            this.mapper=mapper;
            this.companyRepository=companyRepository;

            CacheAll(companyRepository, CompanyCacheKey);
        }

        public async Task AddAsync(Company entity)
        {
            await companyRepository.AddAsync(entity);
            await CommitAndRemoveCache(CompanyCacheKey);
        }


        public async Task AddRangeAsync(IEnumerable<Company> entities)
        {
            await companyRepository.AddRangeAsync(entities);
            await CommitAndRemoveCache(CompanyCacheKey);
        }

        public async Task Delete(int id)
        {
            companyRepository.Delete(id);
            await CommitAndRemoveCache(CompanyCacheKey);
        }

        public async Task DeleteAll(Company entity)
        {
            companyRepository.DeleteAll(entity);
            await CommitAndRemoveCache(CompanyCacheKey);
        }

        public async Task DeleteRange(IEnumerable<Company> entities)
        {
            companyRepository.DeleteRange(entities);
            await CommitAndRemoveCache(CompanyCacheKey);
        }

        public async Task<IEnumerable<Company>> GetAllAsync()
        {
            CacheAll(companyRepository,CompanyCacheKey);
            var response = await companyRepository.GetAllAsync();
            CheckNullability(response, $"There is no Company here");
            return response;

        }

        public Task<Company> GetByIdAsync(int id)
        {
            CacheAll(companyRepository, CompanyCacheKey);
            var response = companyRepository.GetByIdAsync(id);
            CheckNullability(response, $"This {id} is Invalid");
            return response;
        }

        public Task<List<int>> GetCompanyIds()
        {
            CacheAll(companyRepository, CompanyCacheKey);
            var response = companyRepository.GetCompanyIds();
            return Task.FromResult(response);
        }

        public async Task<CustomResponseDto<CompanywithUsers>> GetCompanyUsers(int companyId)
        {
            CacheAll(companyRepository, CompanyCacheKey);
            var response = await companyRepository.GetCompanyUsers(companyId);
            await CheckNullability(Task.FromResult(response), $"This {companyId} is Invalid");
            var dto = mapper.Map<CompanywithUsers>(response);
            return CustomResponseDto<CompanywithUsers>.Success(dto, 200);

        }

        public async Task Update(Company entity)
        {
            companyRepository.Update(entity);
            await CommitAndRemoveCache(CompanyCacheKey);
        }

        public async Task UpdateRange(IEnumerable<Company> entities)
        {
            companyRepository.UpdateRange(entities);
            await CommitAndRemoveCache(CompanyCacheKey);
        }
    }
}
