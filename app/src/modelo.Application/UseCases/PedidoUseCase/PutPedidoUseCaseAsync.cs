using System.Collections.Generic;
using System.Threading.Tasks;
using modelo.Application.Models.PedidoModel;
using modelo.Domain.Gateways;

namespace modelo.Application.UseCases.PedidoUseCase
{
    public class PutPedidoUseCaseAsync : IUseCaseAsync<PedidoPutRequest>
    {
        private readonly IPedidoGateway _pedidoGateway;

        public PutPedidoUseCaseAsync(IPedidoGateway pedidoGateway)
        {
            _pedidoGateway = pedidoGateway;
        }

        public async Task ExecuteAsync(PedidoPutRequest request)
        {
            var pedido = await _pedidoGateway.GetIncludeAsync(request.Id);
            if (pedido == null)
                throw new KeyNotFoundException("Pedido não encontrado");
            if (pedido.Pagamento.Status == Domain.Enums.StatusPagamento.Pendente)
                throw new KeyNotFoundException("Pagamento pendente");
            if (pedido.Pagamento.Status == Domain.Enums.StatusPagamento.Reprovado)
                throw new KeyNotFoundException("Pagamento reprovado");

            pedido.SetStatus(request.Status);
            await _pedidoGateway.UpdateAsync(pedido);
        }
    }
}