

using CarShop.Domain.Shared;
using CarShop.Shared.DTOs;
using CarShop.Web.ViewModels;
using RestSharp;

namespace CarShop.Web.Services
{
    public class OrderServices : IOrderServices
    {
        private RestClient _restClient;

        public OrderServices(RestClient restClient)
        {
            _restClient = restClient;
        }

        public async Task<OrderDto> Create(NewOrderViewModel viewModel)
        {
            var createOrderDto = new CreateOrderDto()
            {
                CarId = viewModel.CarId,
                Customer = new CustomerDto()
                {
                    Age = viewModel.Age,
                    FirstName = viewModel.FirstName,
                    LastName = viewModel.LastName,
                    MartialStatus = viewModel.MartialStatus,
                    Occupation = viewModel.Occupation
                },
                MethodofPurchase = MethodOfPurchaseEnumDto.Online
            };

            var response = await _restClient.PostJsonAsync<CreateOrderDto, Response<OrderDto>>("order", createOrderDto);
            return response.Entity;
        }

        public async Task<IList<OrderListDto>> GetOrders()
        {
            return await _restClient.GetJsonAsync<IList<OrderListDto>>("order");
        }
    }
}
