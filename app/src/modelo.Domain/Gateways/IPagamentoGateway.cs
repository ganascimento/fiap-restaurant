using System;
using System.Threading.Tasks;
using modelo.Domain.Entities;

namespace modelo.Domain.Gateways.External
{
    public interface IPagamentoGateway : IRepositoryGateway<Pagamento, Guid>
    {
        Task<Pagamento> GetByPedidoAsync(Guid pedidoId);
    }
}
