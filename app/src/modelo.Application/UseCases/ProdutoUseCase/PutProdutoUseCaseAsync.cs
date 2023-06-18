using System.Threading.Tasks;
using AutoMapper;
using modelo.Domain.Gateways;
using modelo.Domain.Entities;
using modelo.Application.Models.ProdutoModel;

namespace modelo.Application.UseCases.ProdutoUseCase
{
    public class PutProdutoUseCaseAsync : IUseCaseAsync<ProdutoPutRequest>
    {
        private readonly IProdutoGateway _gateway;
        private readonly IMapper _mapper;

        public PutProdutoUseCaseAsync(IProdutoGateway gateway, IMapper mapper)
        {
            _gateway = gateway;
            _mapper = mapper;
        }

        public async Task ExecuteAsync(ProdutoPutRequest request)
        {
            var update = _mapper.Map<ProdutoPutRequest, Produto>(request);
            await _gateway.UpdateAsync(update);
        }
    }
}
