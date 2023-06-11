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
    public class GetProdutoByCategoriaIdUseCaseAsync : IUseCaseIEnumerableAsync<ProdutoRequest, IEnumerable<ProdutoResponse>>
    {

        private readonly IProdutoGateway gateway;
        private readonly IMapper mapper;


        public GetProdutoByCategoriaIdUseCaseAsync(IProdutoGateway gateway, IMapper mapper)
        {
            this.gateway = gateway;
            this.mapper = mapper;

        }

        public async Task<IEnumerable<ProdutoResponse>> ExecuteAsync(ProdutoRequest request)
        {
            var result = gateway.GetProdutoByCategoriaId(request.CategoriaId);


            return mapper.Map<IEnumerable<ProdutoResponse>>(result);
        }


    }
}
