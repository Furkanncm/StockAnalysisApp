using AutoMapper;
using StockAnalyzeApp.Core.Dto;
using StockAnalyzeApp.Core.Dto.StockDtos;
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
    public class StockService : Service<Stock>, IStockService
    {
        private readonly IStockRepository _stockRepository;
        private readonly IMapper    _mapper;
        public StockService(IUnitOfWork unitOfWork, IGenericRepository<Stock> repository, IStockRepository stockRepository, IMapper mapper) : base(unitOfWork, repository)
        {
            _stockRepository=stockRepository;
            _mapper=mapper;
        }

        public async Task<CustomResponseDto<NoContentDto>> DeleteWithStockCode(int stockCode)
        {
            await _stockRepository.DeleteWithStocCode(stockCode);
            await _unitOfWork.CommitAsync();
            return CustomResponseDto<NoContentDto>.Success(204);
        }

        public async Task<CustomResponseDto<IEnumerable<StockDto>>> GetLessThan(int quantity)
        {
            var response= await _stockRepository.GetLessThan(quantity);
            var dto = _mapper.Map<IEnumerable<StockDto>>(response);
            return CustomResponseDto<IEnumerable<StockDto>>.Success(dto,200);
        }

        public async Task<CustomResponseDto<StockAddDto>> GetWithStockCode(int stockCode)
        {
            var response= await _stockRepository.GetWithStockCode(stockCode);
            var dto = _mapper.Map<StockAddDto>(response);
            return CustomResponseDto<StockAddDto>.Success(dto,200);
        }
    }
}
