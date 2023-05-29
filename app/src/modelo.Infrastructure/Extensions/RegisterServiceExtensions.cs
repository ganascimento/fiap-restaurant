using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using modelo.Application.Models;
using modelo.Application.UseCases;
using modelo.Domain.Gateways;
using modelo.Infrastructure.DataProviders;
using modelo.Infrastructure.DataProviders.Repositories;

namespace modelo.Infrastructure.Extensions
{
    public static class RegisterServiceExtensions
    {
        public static void RegisterService(this IServiceCollection services)
        {
            AddUseCase(services);
            AddRepositories(services);
            AddOthers(services);
        }
        private static void AddUseCase(IServiceCollection services)
        {
            services.AddTransient<IUseCaseAsyncResponse<IEnumerable<WeatherForecastResponse>>, GetAllWeatherForecastUseCaseAsync>();
            services.AddTransient<IUseCaseAsyncResponse<IEnumerable<ClienteResponse>>, GetAllClienteUseCaseAsync>();
            services.AddTransient<IUseCaseAsync< ClienteRequest, ClienteResponse >, GetClienteByNomeUseCaseAsync>();
            services.AddTransient<IUseCaseAsyncResponse<IEnumerable<CategoriaResponse>>, GetAllCategoriaUseCaseAsync>();


        }
        private static void AddRepositories(IServiceCollection services)
        {
            services.AddTransient<IWeatherForecastGateway, WeatherForecastRepository>();
            services.AddTransient<IClienteGateway, ClienteRepository>();
            services.AddTransient<ICategoriaGateway, CategoriaRepository>();
        }
        private static void AddOthers(IServiceCollection services)
        {
            services.AddTransient<DBContext>();
        }
    }
}
