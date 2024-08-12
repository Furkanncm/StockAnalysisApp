using AutoMapper;
using StockAnalyzeApp.Core.Dto.CompanyDtos;
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
        CreateMap<Order, OrderAddDto>().ReverseMap();
        CreateMap<Order, OrderUpdateDto>().ReverseMap();
        CreateMap<Order, OrderInfoDto>().ReverseMap();
        CreateMap<Order, OrderWithUserDto>().ReverseMap();


        CreateMap<Stock, StockDto>().ReverseMap();
        CreateMap<Stock, StockAddDto>().ReverseMap();
        CreateMap<Stock, StockUpdateDto>().ReverseMap();
        CreateMap<Stock, StockWithUserDto>().ReverseMap();


        CreateMap<Company, CompanywithUsers>().ReverseMap();
        CreateMap<Company, CompanyAddDto>().ReverseMap();
        CreateMap<Company, CompanyDto>().ReverseMap();



    }
}
