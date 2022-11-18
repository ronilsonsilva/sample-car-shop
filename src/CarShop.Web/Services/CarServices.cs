using CarShop.Shared.DTOs;
using RestSharp;

namespace CarShop.Web.Services
{
    public interface ICarServices
    {
        Task<IList<CarDto>> GetCars();
    }

    public class CarServices : ICarServices
    {
        private RestClient _restClient;
        
        public CarServices(RestClient restClient)
        {
            _restClient = restClient;
        }

        public async Task<IList<CarDto>> GetCars()
        {
            return await _restClient.GetJsonAsync<CarDto[]>("car");
        }
    }
}
