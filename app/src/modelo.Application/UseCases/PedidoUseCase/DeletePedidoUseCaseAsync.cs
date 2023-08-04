using System.Threading.Tasks;
using modelo.Domain.Gateways;
using modelo.Application.Models.PedidoModel;
using System.Collections.Generic;

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
            var exists = await _gateway.GetAsync(request.Id);
            if (exists == null)
                throw new KeyNotFoundException("Pedido não encontrado");

            await _gateway.DeleteAsync(request.Id);
        }
    }
}
