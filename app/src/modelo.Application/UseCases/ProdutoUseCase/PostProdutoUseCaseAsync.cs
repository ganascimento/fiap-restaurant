using System.Threading.Tasks;
using AutoMapper;
using modelo.Domain.Gateways;
using modelo.Domain.Entities;
using modelo.Application.Models.ProdutoModel;
using System.Collections.Generic;

namespace modelo.Application.UseCases.ProdutoUseCase
{
    public class PostProdutoUseCaseAsync : IUseCaseAsync<ProdutoPostRequest>
    {

        private readonly IProdutoGateway _produtoGateway;
        private readonly ICategoriaGateway _categoriaGateway;
        private readonly IMapper _mapper;

        public PostProdutoUseCaseAsync(IProdutoGateway produtoGateway, ICategoriaGateway categoriaGateway, IMapper mapper)
        {
            _produtoGateway = produtoGateway;
            _categoriaGateway = categoriaGateway;
            _mapper = mapper;

        }
        public async Task ExecuteAsync(ProdutoPostRequest request)
        {
            var insert = _mapper.Map<ProdutoPostRequest, Produto>(request);
            var categoria = await _categoriaGateway.GetAsync(request.CategoriaId ?? System.Guid.Empty);
            if (categoria == null)
                throw new KeyNotFoundException("Categoria não encontrado");


            await _produtoGateway.InsertAsync(insert);
        }
    }
}
