using CarShop.Application.Contracts;
using CarShop.Shared.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace CarShop.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarController : ControllerBase
    {
        protected readonly IApplicationServices<CarDto, CreateCarDto, UpdateCarDto, CarListDto> _applicationServices;

        public CarController(IApplicationServices<CarDto, CreateCarDto, UpdateCarDto, CarListDto> applicationServices)
        {
            _applicationServices = applicationServices;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var cars = await _applicationServices.Get();
            if(cars == null) return NoContent();
            return Ok(cars);
        }
    }
}
