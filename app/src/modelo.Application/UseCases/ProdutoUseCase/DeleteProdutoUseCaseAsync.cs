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
    public class DeleteProdutoUseCaseAsync : IUseCaseAsync<ProdutoDeleteRequest>
    {
        private readonly IProdutoGateway gateway;
        private readonly IMapper mapper;

        public DeleteProdutoUseCaseAsync(IProdutoGateway gateway, IMapper mapper)
        {
            this.gateway = gateway;
            this.mapper = mapper;

        }
        public async Task ExecuteAsync(ProdutoDeleteRequest request)
        {
            await gateway.DeleteAsync(request.Id);
        }
    }
}
