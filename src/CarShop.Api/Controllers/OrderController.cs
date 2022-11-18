using CarShop.Application.Contracts;
using CarShop.Shared.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace CarShop.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private IApplicationServices<OrderDto, CreateOrderDto, UpdateOrderDto, OrderListDto> _services;

        public OrderController(IApplicationServices<OrderDto, CreateOrderDto, UpdateOrderDto, OrderListDto> services)
        {
            _services = services;
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody]CreateOrderDto createOrderDto)
        {
            var response = await _services.Add(createOrderDto);
            return Ok(response);
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var response = await _services.Get();
            if (response == null) return NoContent();
            return Ok(response);
        }
    }
}
