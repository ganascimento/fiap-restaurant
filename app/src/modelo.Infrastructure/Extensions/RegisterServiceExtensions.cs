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
            services.AddTransient<IUseCaseIEnumerableAsync<IEnumerable<WeatherForecastResponse>>, GetAllWeatherForecastUseCaseAsync>();
            services.AddTransient<IUseCaseIEnumerableAsync<IEnumerable<ClienteResponse>>, GetAllClienteUseCaseAsync>();
            services.AddTransient<IUseCaseAsync< ClienteRequest, ClienteResponse >, GetClienteByNomeUseCaseAsync>();
            services.AddTransient<IUseCaseIEnumerableAsync<IEnumerable<CategoriaResponse>>, GetAllCategoriaUseCaseAsync>();
            services.AddTransient<IUseCaseIEnumerableAsync<ProdutoRequest,IEnumerable<ProdutoResponse>>, GetProdutoByCategoriaIdUseCaseAsync>();


        }
        private static void AddRepositories(IServiceCollection services)
        {
            services.AddTransient<IWeatherForecastGateway, WeatherForecastRepository>();
            services.AddTransient<IClienteGateway, ClienteRepository>();
            services.AddTransient<ICategoriaGateway, CategoriaRepository>();
            services.AddTransient<IProdutoGateway, ProdutoRepository>();
        }
        private static void AddOthers(IServiceCollection services)
        {
            services.AddTransient<DBContext>();
        }
    }
}
