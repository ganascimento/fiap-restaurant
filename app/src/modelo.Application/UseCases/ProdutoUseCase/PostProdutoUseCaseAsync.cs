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
    public class PostProdutoUseCaseAsync : IUseCaseAsync<ProdutoPostRequest>
    {
        private readonly IProdutoGateway gateway;
        private readonly IMapper mapper;


        public PostProdutoUseCaseAsync(IProdutoGateway gateway, IMapper mapper)
        {
            this.gateway = gateway;
            this.mapper = mapper;

        }
        public async Task ExecuteAsync(ProdutoPostRequest request)
        {
            var insert = mapper.Map<ProdutoPostRequest, Produto>(request);

            gateway.Insert(insert);
        }
    }
}
