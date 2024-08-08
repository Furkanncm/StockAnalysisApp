using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StockAnalyzeApp.Core.Dto;
using StockAnalyzeApp.Core.Dto.StockDtos;
using StockAnalyzeApp.Core.Models;
using StockAnalyzeApp.Core.Services;

namespace StockAnalyzeApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StockController : ControllerBase
    {
        private readonly IStockService _stockService;
        private readonly IMapper _mapper;
        public StockController(IStockService stockService, IMapper mapper)
        {
            _stockService = stockService;
            _mapper=mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var response = await _stockService.GetAllAsync();
            var responseDto = _mapper.Map<IEnumerable<StockDto>>(response);
            return Ok(CustomResponseDto<IEnumerable<StockDto>>.Success(responseDto, 200));
        }

        [HttpGet("[action]/{StockCode}")]
        public async Task<IActionResult> GetWithStockCode(int StockCode)
        {
            var response = await _stockService.GetWithStockCode(StockCode);
            return Ok(response);
        }


        [HttpGet("[action]/{quantity}")]
        public async Task<IActionResult> GetLessThan(int quantity)
        {
            var response = await _stockService.GetLessThan(quantity);
            return Ok(response);
        }

        [HttpPost]
        public async Task<IActionResult> Add(StockAddDto stockAddDto)
        {
            var stock = _mapper.Map<Stock>(stockAddDto);
            await _stockService.AddAsync(stock);
            return Created();
        }

        [HttpPut]
        public async Task<IActionResult> Update(StockUpdateDto stockUpdateDto)
        {
            var stock = _mapper.Map<Stock>(stockUpdateDto);
            await _stockService.Update(stock);
            return NoContent();
        }

        [HttpDelete("[action]/{StockCode}")]
        public async Task<IActionResult> DeleteWithStockCode(int StockCode)
        {
            await _stockService.DeleteWithStockCode(StockCode);
            return Ok(CustomResponseDto<NoContentDto>.Success(204));
        }
    }

}
