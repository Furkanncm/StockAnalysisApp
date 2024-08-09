using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StockAnalyzeApp.Core.Dto.BaseResponseDtos;
using StockAnalyzeApp.Core.Dto.CompanyDtos;
using StockAnalyzeApp.Core.Models;
using StockAnalyzeApp.Core.Repositories;

namespace StockAnalyzeApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompanyController : ControllerBase
    {
        private readonly ICompanyRepository _companyRepository;
        private readonly IMapper mapper;
        public CompanyController(ICompanyRepository companyRepository, IMapper mapper)
        {
            _companyRepository=companyRepository;
            this.mapper=mapper;
        }


        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var response = await _companyRepository.GetAllAsync();
            var dto = mapper.Map<IEnumerable<CompanyDto>>(response);
            return Ok(CustomResponseDto<IEnumerable<CompanyDto>>.Success(dto, 200));
        }

        [HttpPost]
        public async Task<IActionResult> Post(CompanyAddDto companyDto)
        {
            var company = mapper.Map<Company>(companyDto);
            await _companyRepository.AddAsync(company);
            return Ok(CustomResponseDto<CompanyAddDto>.Success(companyDto, 200));
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetByIdAsync(int id)
        {
            var response = await _companyRepository.GetByIdAsync(id);
            var dto = mapper.Map<CompanyDto>(response);
            return Ok(CustomResponseDto<CompanyDto>.Success(dto, 200));
        }

        [HttpGet("[action]/{companyId}")]
        public async Task<IActionResult> GetCompanyUsers(int companyId)
        {
            var response =await _companyRepository.GetCompanyUsers(companyId);
            var dto= mapper.Map<CompanywithUsers>(response);
            return Ok(CustomResponseDto<CompanywithUsers>.Success(dto,200));
        }

        [HttpPut]
        public async Task<IActionResult> Update(CompanyUpdateDto companyDto)
        {
            var company = mapper.Map<Company>(companyDto);
             _companyRepository.Update(company);
            return Ok(CustomResponseDto<NoContentDto>.Success( 200));
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
             _companyRepository.Delete(id);
            return Ok(CustomResponseDto<NoContentDto>.Success(204));
        }
        
    }
}
