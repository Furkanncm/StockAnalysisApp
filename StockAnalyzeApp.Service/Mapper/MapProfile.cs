using AutoMapper;
using StockAnalyzeApp.Core.Dto.OrderDtos;
using StockAnalyzeApp.Core.Dto.StockDtos;
using StockAnalyzeApp.Core.Dto.UserDtos;
using StockAnalyzeApp.Core.Models;

public class MapProfile : Profile
{
    public MapProfile()
    {
        CreateMap<User, UserResponseDto>().ReverseMap();
        CreateMap<User, UserWithOrdersDto>().ReverseMap();
        CreateMap<User, UserUpdateDto>().ReverseMap();
        CreateMap<User, UserAddDto>().ReverseMap();
        CreateMap<User, UserInfoDto>().ReverseMap();
        CreateMap<User,UserWithStocksDto>().ReverseMap();



        CreateMap<Order, OrderDto>().ReverseMap();


        CreateMap<Stock, StockDto>().ReverseMap();
        CreateMap<Stock, StockAddDto>().ReverseMap();
        CreateMap<Stock, StockUpdateDto>().ReverseMap();



    }
}
