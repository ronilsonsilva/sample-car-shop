using CarShop.Shared.DTOs;
using CarShop.Web.ViewModels;

namespace CarShop.Web.Services
{
    public interface IOrderServices
    {
        Task<OrderDto> Create(NewOrderViewModel viewModel);
        Task<IList<OrderListDto>> GetOrders();
    }
}
