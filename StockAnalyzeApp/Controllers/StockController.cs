using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StockAnalyzeApp.Core.Dto.BaseResponseDtos;
using StockAnalyzeApp.Core.Dto.StockDtos;
using StockAnalyzeApp.Core.Models;
using StockAnalyzeApp.Core.Services;

[Route("api/[controller]")]
[ApiController]
public class StockController : ControllerBase
{
    private readonly IStockService _stockService;
    private readonly IMapper _mapper;

    public StockController(IStockService stockService, IMapper mapper)
    {
        _stockService = stockService;
        _mapper = mapper;
    }

    // Tüm stokları getir
    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var response = await _stockService.GetAllAsync();
        var responseDto = _mapper.Map<IEnumerable<StockDto>>(response);
        return Ok(CustomResponseDto<IEnumerable<StockDto>>.Success(responseDto, 200));
    }

    // Stok kodu ile stok ve kullanıcı bilgilerini getir
    [HttpGet("[action]/{StockCode}")]
    public async Task<IActionResult> GetStockWithUser([FromRoute] string StockCode)
    {
        var response = await _stockService.GetStockWithUser(StockCode);
        return Ok(response);
    }

    // Belirli bir miktardan az olan stokları getir
    [HttpGet("[action]/{quantity}")]
    public async Task<IActionResult> GetLessThan([FromRoute] int quantity)
    {
        var response = await _stockService.GetLessThan(quantity);
        return Ok(response);
    }

    // Stokta olmayan ürünleri getir
    [HttpGet("[action]")]
    public async Task<IActionResult> GetDontHaveStocks()
    {
        var response = await _stockService.GetDontHaveStocks();
        return Ok(response);
    }
    // Stok kodu ile stok bilgilerini getir


    // Sipariş kontrol et ve kabul et
    [HttpPost("[action]")]
    public async Task<IActionResult> CheckAndAcceptOrder([FromBody] AddStockWithAcceptOrder addStockWithAcceptOrder)
    {
        var response = await _stockService.CheckAndAcceptOrder(addStockWithAcceptOrder);
        return Ok(response);
    }

    // Barkod ile stok miktarını değiştir
    [HttpPost("[action]")]
    public async Task<IActionResult> ChangeQuantityStockWithBarcode([FromBody] AddQuantityWithtStockCode addQuantityWithtStockCode)
    {
        var response = await _stockService.ChangeQuantityStockWithBarcode(addQuantityWithtStockCode);
        return Ok(response);
    }

    [HttpGet("[action]")]
    public async Task<IActionResult> GetByStockCode([FromQuery] string stockCode)
    {
        var response = await _stockService.GetByStockCode(stockCode);
        return Ok(response);
    }

    // Stok güncelle
    [HttpPut]
    public async Task<IActionResult> Update([FromBody] StockUpdateDto stockUpdateDto)
    {
        var stock = _mapper.Map<Stock>(stockUpdateDto);
            await _stockService.Update(stock);
        

        return NoContent();
    }

    // Stok kodu ile stok sil
    [HttpDelete("[action]/{StockCode}")]
    public async Task<IActionResult> DeleteWithStockCode([FromRoute] string StockCode)
    {
        await _stockService.DeleteWithStockCode(StockCode);
        return Ok(CustomResponseDto<NoContentDto>.Success(204));
    }
}
