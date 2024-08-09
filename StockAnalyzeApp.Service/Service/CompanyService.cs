using AutoMapper;
using StockAnalyzeApp.Core.Dto.BaseResponseDtos;
using StockAnalyzeApp.Core.Dto.CompanyDtos;
using StockAnalyzeApp.Core.Models;
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
    public class CompanyService : Service<Company>, ICompanyService
    {
        private readonly ICompanyRepository _companyRepository;
        private readonly IMapper mapper;
        public CompanyService(IUnitOfWork unitOfWork, IGenericRepository<Company> repository, ICompanyRepository companyRepository, IMapper mapper) : base(unitOfWork, repository)
        {
            _companyRepository=companyRepository;
            this.mapper=mapper;
        }

        public async Task<List<int>> GetCompanyIds()
        {
            var response = _companyRepository.GetCompanyIds();
            return response;
        }

        public async Task<CustomResponseDto<CompanywithUsers>> GetCompanyUsers(int companyId)
        {
            var response =await _companyRepository.GetCompanyUsers(companyId);
            var dto= mapper.Map<CompanywithUsers>(response);
            return CustomResponseDto<CompanywithUsers>.Success(dto,200);

        }
    }
}
