using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using modelo.Application.Models.ProdutoModel;
using modelo.Domain.Gateways;

namespace modelo.Application.UseCases.ProdutoUseCase
{
    public class GetAllProdutoUseCaseAsync : IUseCaseIEnumerableAsync<IEnumerable<ProdutoResponse>>
    {
        private readonly IProdutoGateway gateway;
        private readonly IMapper mapper;


        public GetAllProdutoUseCaseAsync(IProdutoGateway gateway, IMapper mapper)
        {
            this.gateway = gateway;
            this.mapper = mapper;

        }
        public async Task<IEnumerable<ProdutoResponse>> ExecuteAsync()
        {
            var result = await gateway.GetAllAsync();

            return mapper.Map<IEnumerable<ProdutoResponse>>(result);
        }
    }
}
