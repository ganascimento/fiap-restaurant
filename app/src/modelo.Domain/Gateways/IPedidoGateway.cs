using modelo.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace modelo.Domain.Gateways
{
    public interface IPedidoGateway : IRepositoryGateway<Pedido, Guid>
    {
        Task<Pedido> GetPedidoBySenhaUseCaseAsync(int senha);

        Task<IEnumerable<Pedido>> GetPedidosDetalhados();
        Task<Pedido> GetIncludeAsync(Guid id);
        Task<Pedido> AddAsync(Pedido pedido);
    }
}
