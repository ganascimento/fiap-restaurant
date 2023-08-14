using modelo.Domain.Entities;
using modelo.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace modelo.Domain.Gateways
{
    public interface IPedidoGateway : IRepositoryGateway<Pedido, Guid>
    {
        Task<PedidoDetalhadoDto> GetPedidoBySenhaUseCaseAsync(int senha);

        Task<IEnumerable<PedidoDetalhadoDto>> GetPedidosDetalhados();
        Task<Pedido> GetIncludeAsync(Guid id);
        Task<Pedido> AddAsync(Pedido pedido);
    }
}
