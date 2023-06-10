using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using modelo.Application.Models;
using modelo.Domain.Gateways;

namespace modelo.Application.UseCases
{
    public class GetProdutoByCategoriaIdUseCaseAsync : IUseCaseIEnumerableAsync<ProdutoRequest, IEnumerable<ProdutoResponse>>
    {       

        private readonly IProdutoGateway produtoGateway;
        private readonly IMapper mapper;


        public GetProdutoByCategoriaIdUseCaseAsync(IProdutoGateway produtoGateway, IMapper mapper)
        {
            this.produtoGateway = produtoGateway;
            this.mapper = mapper;

        }

        public async Task<IEnumerable<ProdutoResponse>> ExecuteAsync(ProdutoRequest request)
        {
            var result = produtoGateway.GetProdutoByCategoriaId(request.CategoriaId);


            return mapper.Map<IEnumerable<ProdutoResponse>>(result);
        }

        
    }
}
