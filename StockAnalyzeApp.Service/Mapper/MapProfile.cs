using AutoMapper;
using StockAnalyzeApp.Core.Dto;
using StockAnalyzeApp.Core.Models;

public class MapProfile : Profile
{
    public MapProfile()
    {
        CreateMap<User, UserResponseDto>().ReverseMap();
        CreateMap<User, UserWithOrdersDto>().ReverseMap();
    }
}
