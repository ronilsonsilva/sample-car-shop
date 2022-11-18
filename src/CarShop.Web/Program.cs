using CarShop.Web;
using CarShop.Web.Helpers;
using CarShop.Web.Services;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using RestSharp;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddHttpClient();

//builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("https://localhost:7000") });
builder.Services.AddScoped<ICarServices, CarServices>();
builder.Services.AddScoped<IOrderServices, OrderServices>();

builder.Services.AddSingleton(sp => new RestClient(new HttpClient { BaseAddress = new Uri(Configuration.URL_API) }));



await builder.Build().RunAsync();
