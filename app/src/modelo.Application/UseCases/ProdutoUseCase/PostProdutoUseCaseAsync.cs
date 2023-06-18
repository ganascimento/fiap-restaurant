using System.Threading.Tasks;
using AutoMapper;
using modelo.Domain.Gateways;
using modelo.Domain.Entities;
using modelo.Application.Models.ProdutoModel;

namespace modelo.Application.UseCases.ProdutoUseCase
{
    public class PostProdutoUseCaseAsync : IUseCaseAsync<ProdutoPostRequest>
    {
        private readonly IProdutoGateway _gateway;
        private readonly IMapper _mapper;

        public PostProdutoUseCaseAsync(IProdutoGateway gateway, IMapper mapper)
        {
            _gateway = gateway;
            _mapper = mapper;

        }
        public async Task ExecuteAsync(ProdutoPostRequest request)
        {
            var insert = _mapper.Map<ProdutoPostRequest, Produto>(request);

            await _gateway.InsertAsync(insert);
        }
    }
}
