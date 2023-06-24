using System.Threading.Tasks;
using AutoMapper;
using modelo.Domain.Gateways;
using modelo.Application.Models.ProdutoModel;
using modelo.Application.Models.PedidoModel;

namespace modelo.Application.UseCases.PedidoUseCase
{
    public class DeletePedidoUseCaseAsync : IUseCaseAsync<PedidoDeleteRequest>
    {
        private readonly IPedidoGateway _gateway;

        public DeletePedidoUseCaseAsync(IPedidoGateway gateway)
        {
            _gateway = gateway;
        }

        public async Task ExecuteAsync(PedidoDeleteRequest request)
        {
            await _gateway.DeleteAsync(request.Id);
        }
    }
}
