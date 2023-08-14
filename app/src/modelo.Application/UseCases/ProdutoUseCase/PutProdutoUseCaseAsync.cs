using System.Threading.Tasks;
using AutoMapper;
using modelo.Domain.Gateways;
using modelo.Domain.Entities;
using modelo.Application.Models.ProdutoModel;
using System.Collections.Generic;

namespace modelo.Application.UseCases.ProdutoUseCase
{
    public class PutProdutoUseCaseAsync : IUseCaseAsync<ProdutoPutRequest>
    {
        private readonly IProdutoGateway _produtoGateway;
        private readonly ICategoriaGateway _categoriaGateway;
        private readonly IMapper _mapper;

        public PutProdutoUseCaseAsync(IProdutoGateway produtoGateway, ICategoriaGateway categoriaGateway, IMapper mapper)
        {
            _produtoGateway = produtoGateway;
            _categoriaGateway = categoriaGateway;
            _mapper = mapper;
        }

        public async Task ExecuteAsync(ProdutoPutRequest request)
        {
            var update = _mapper.Map<ProdutoPutRequest, Produto>(request);

            var existsItem = await _produtoGateway.GetAsync(request.Id ?? System.Guid.Empty);
            if (existsItem == null)
                throw new KeyNotFoundException("Produto não encontrado");

            var categoria = await _categoriaGateway.GetAsync(request.CategoriaId ?? System.Guid.Empty);
            if (categoria == null)
                throw new KeyNotFoundException("Categoria não encontrado");

            await _produtoGateway.UpdateAsync(update);
        }
    }
}
