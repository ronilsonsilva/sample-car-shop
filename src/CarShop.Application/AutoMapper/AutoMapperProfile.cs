using AutoMapper;
using CarShop.Shared.DTOs;
using CarShop.Domain.Entities;

namespace CarShop.Application.AutoMapper
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<CarDto, Car>().ReverseMap();
            CreateMap<CreateCarDto, Car>().ReverseMap();
            CreateMap<UpdateCarDto, Car>().ReverseMap();
            CreateMap<CarListDto, Car>().ReverseMap();

            CreateMap<CustomerDto, Customer>().ReverseMap();
            CreateMap<CreateCustomerDto, Customer>().ReverseMap();
            CreateMap<UpdateCustomerDto, Customer>().ReverseMap();


            CreateMap<OrderDto, Order>().ReverseMap();
            CreateMap<CreateOrderDto, Order>().ReverseMap();
            CreateMap<UpdateOrderDto, Order>().ReverseMap();

            CreateMap<OrderDetailsDto, OrderDetails>().ReverseMap();
            CreateMap<CreateOrderDetailsDto, OrderDetails>().ReverseMap();
            CreateMap<UpdateOrderDetailsDto, OrderDetails>().ReverseMap();
        }
    }
}
