using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using modelo.Domain.Gateways;
using modelo.Domain.Entities;
using modelo.Application.Models.ProdutoModel;

namespace modelo.Application.UseCases.ProdutoUseCase
{
    public class PutProdutoUseCaseAsync : IUseCaseAsync<ProdutoPutRequest>
    {
        private readonly IProdutoGateway gateway;
        private readonly IMapper mapper;


        public PutProdutoUseCaseAsync(IProdutoGateway gateway, IMapper mapper)
        {
            this.gateway = gateway;
            this.mapper = mapper;

        }
        public async Task ExecuteAsync(ProdutoPutRequest request)
        {
            var update = mapper.Map<ProdutoPutRequest, Produto>(request);

            gateway.Update(update);
        }
    }
}
