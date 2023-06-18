using System.Collections.Generic;
using Microsoft.Extensions.DependencyInjection;
using modelo.Application.Models.CategoriaModel;
using modelo.Application.Models.ClienteModel;
using modelo.Application.Models.ProdutoModel;
using modelo.Application.UseCases;
using modelo.Application.UseCases.CategoriaUseCase;
using modelo.Application.UseCases.ClienteUseCase;
using modelo.Application.UseCases.ProdutoUseCase;
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
            services.AddTransient<IUseCaseIEnumerableAsync<IEnumerable<ClienteResponse>>, GetAllClienteUseCaseAsync>();
            services.AddTransient<IUseCaseAsync<ClienteRequest, ClienteResponse>, GetClienteByCPFUseCaseAsync>();
            services.AddTransient<IUseCaseAsync<ClientePostRequest>, PostClienteUseCaseAsync>();
            services.AddTransient<IUseCaseAsync<ClienteDeleteRequest>, DeleteClienteUseCaseAsync>();
            services.AddTransient<IUseCaseIEnumerableAsync<IEnumerable<CategoriaResponse>>, GetAllCategoriaUseCaseAsync>();
            services.AddTransient<IUseCaseIEnumerableAsync<IEnumerable<ProdutoResponse>>, GetAllProdutoUseCaseAsync>();
            services.AddTransient<IUseCaseIEnumerableAsync<ProdutoRequest, IEnumerable<ProdutoResponse>>, GetProdutoByCategoriaIdUseCaseAsync>();
            services.AddTransient<IUseCaseAsync<ProdutoPostRequest>, PostProdutoUseCaseAsync>();
            services.AddTransient<IUseCaseAsync<ProdutoPutRequest>, PutProdutoUseCaseAsync>();
            services.AddTransient<IUseCaseAsync<ProdutoDeleteRequest>, DeleteProdutoUseCaseAsync>();
        }

        private static void AddRepositories(IServiceCollection services)
        {
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
