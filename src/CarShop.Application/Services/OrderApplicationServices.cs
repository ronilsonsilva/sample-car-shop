using AutoMapper;
using CarShop.Domain.Contracts.DomainServices;
using CarShop.Domain.Entities;
using CarShop.Domain.Shared;
using CarShop.Shared.DTOs;

namespace CarShop.Application.Services
{
    public class OrderApplicationServices : ApplicationServices<Order, OrderDto, CreateOrderDto, UpdateOrderDto, OrderListDto>
    {
        private IDomainServices<Order> _orderService;
        private IDomainServices<Customer> _customerService;


        public OrderApplicationServices(IMapper mapper, IDomainServices<Order> service, IDomainServices<Customer> customerService) : base(mapper, service)
        {
            _orderService = service;
            _customerService = customerService;
        }

        public override async Task<Response<OrderDto>> Add(CreateOrderDto dto)
        {
            var customer = _mapper.Map<Customer>(dto.Customer);
            await _customerService.Add(customer);

            var order = _mapper.Map<Order>(dto);
            order.AddDetails(new OrderDetails(dto.CarId, Guid.NewGuid().ToString(), string.Empty))
                .SetPerson(customer.Id);

            var response = await _orderService.Add(order);
            return response.Map<OrderDto>(_mapper);
        }

        public override async Task<IList<OrderListDto>> Get()
        {
            var orders= await _orderService.Get();
            var orderList = new List<OrderListDto>();
            foreach (var order in orders)
            {
                var customer = await _customerService.Get(order.PersonId);
                var oderDto = new OrderListDto()
                {
                    Age = customer.Age,
                    CustomerFullName = customer.FirstName + " " + customer.LastName,
                    DateCreated= order.DateCreated,
                    MethodofPurchase = (MethodOfPurchaseEnumDto)order.MethodofPurchase,
                    OrderId = order.Id,
                    ProductId = order.OrderDetails.First().ProductId,
                    ProductNumber = order.OrderDetails.First().ProductNumber,
                    ProductOrigin = order.OrderDetails.First().ProductOrigin,
                };
                orderList.Add(oderDto);
            }
            return orderList;
        }
    }
}
