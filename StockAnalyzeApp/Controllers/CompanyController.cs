using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StockAnalyzeApp.Core.Dto.BaseResponseDtos;
using StockAnalyzeApp.Core.Dto.CompanyDtos;
using StockAnalyzeApp.Core.Models;
using StockAnalyzeApp.Core.Repositories;
using StockAnalyzeApp.Core.Services;

namespace StockAnalyzeApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompanyController : ControllerBase
    {
        private readonly ICompanyService _companyService;
        private readonly IMapper _mapper;
        public CompanyController( IMapper mapper, ICompanyService companyService)
        {
            _mapper=mapper;
            _companyService=companyService;
        }


        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var response = await _companyService.GetAllAsync();
            var dto = _mapper.Map<IEnumerable<CompanyDto>>(response);
            return Ok(CustomResponseDto<IEnumerable<CompanyDto>>.Success(dto, 200));
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody]CompanyAddDto companyDto)
        {
            var company = _mapper.Map<Company>(companyDto);
            company.CreatedDate = DateTime.Now;
            await _companyService.AddAsync(company);
            var dto = _mapper.Map<CompanyAddDto>(company);
            return Ok(CustomResponseDto<CompanyAddDto>.Success(dto, 200));
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetByIdAsync([FromRoute] int id)
        {
            var response = await _companyService.GetByIdAsync(id);
            var dto = _mapper.Map<CompanyDto>(response);
            return Ok(CustomResponseDto<CompanyDto>.Success(dto, 200));
        }

        [HttpGet("[action]/{companyId}")]
        public async Task<IActionResult> GetCompanyUsers([FromRoute]int companyId)
        {
            var response =await _companyService.GetCompanyUsers(companyId);
            return Ok(response);
        }

        [HttpPut]
        public async Task<IActionResult> Update([FromBody] CompanyUpdateDto companyDto)
        {
            var company = await _companyService.GetByIdAsync(companyDto.Id);
            var updatedCompany = _mapper.Map<Company>(company);
            updatedCompany.Name = companyDto.Name;
            updatedCompany.Address = companyDto.Address;
            company.UpdatedDate = DateTime.Now;
            await _companyService.Update(updatedCompany);
            return Created();
        }


        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete([FromRoute] int id)
        {
            await _companyService.Delete(id);
            return Ok(CustomResponseDto<NoContentDto>.Success(204));
        }
        
    }
}
