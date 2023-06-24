using System.Threading.Tasks;
using AutoMapper;
using modelo.Domain.Gateways;
using modelo.Application.Models.ProdutoModel;
using modelo.Application.Models.PedidoModel;

namespace modelo.Application.UseCases.ProdutoUseCase
{
    public class DeleteProdutoUseCaseAsync : IUseCaseAsync<ProdutoDeleteRequest>
    {
        private readonly IProdutoGateway _gateway;

        public DeleteProdutoUseCaseAsync(IProdutoGateway gateway)
        {
            _gateway = gateway;
        }

        public async Task ExecuteAsync(ProdutoDeleteRequest request)
        {
            await _gateway.DeleteAsync(request.Id);
        }
    }
}
