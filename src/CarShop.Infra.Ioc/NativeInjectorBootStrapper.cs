using AutoMapper;
using CarShop.Application.AutoMapper;
using CarShop.Application.Contracts;
using CarShop.Application.Services;
using CarShop.Domain.Contracts.DomainServices;
using CarShop.Domain.Contracts.RepositoriesServices;
using CarShop.Domain.DomainServices;
using CarShop.Domain.Entities;
using CarShop.Infra.Data.Context;
using CarShop.Infra.Data.Repositories;
using CarShop.Shared.DTOs;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CarShop.Infra.Ioc
{
    public class NativeInjectorBootStrapper
    {
        public static void RegisterServices(IServiceCollection services, IConfiguration configuration)
        {
            #region [Configurations]

            var connection = configuration["CONNECTION_STRING:CarShopContext"];
            services.AddDbContext<CarShopContext>
                (options =>
                    options.UseSqlServer(connectionString: connection)
                );
            services.AddScoped<CarShopContext, CarShopContext>();

            // Configurar Automapper
            var mapperConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new AutoMapperProfile());
            });

            IMapper mapper = mapperConfig.CreateMapper();
            services.AddSingleton(mapper);

            #endregion

            #region [DI]

            //services.AddScoped(typeof(IApplicationServices<,,>), typeof(ApplicationServices<,,,>));
            services.AddScoped(typeof(IDomainServices<>), typeof(DomainService<>));
            services.AddScoped(typeof(IRepository<>), typeof(RepositoryBase<>));

            services.AddScoped(typeof(IRepository<Order>), typeof(OrderRepository));

            services.AddScoped(typeof(IApplicationServices<CarDto, CreateCarDto, UpdateCarDto, CarListDto>), typeof(ApplicationServices<Car, CarDto, CreateCarDto, UpdateCarDto, CarListDto>));
            services.AddScoped(typeof(IApplicationServices<OrderDto, CreateOrderDto, UpdateOrderDto, OrderListDto>), typeof(OrderApplicationServices));

            #endregion
        }
    }
}
