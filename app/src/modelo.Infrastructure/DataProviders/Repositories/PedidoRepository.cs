using modelo.Domain.Entities;
using modelo.Domain.Gateways;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using modelo.Domain.Enums;

namespace modelo.Infrastructure.DataProviders.Repositories
{
    public class PedidoRepository : RepositoryBase<Pedido, Guid>, IPedidoGateway
    {
        private readonly DbSet<Pedido> _pedidoDbSet;
        private readonly DBContext _dbContext;


        public PedidoRepository(DBContext dbContext) : base(dbContext)
        {
            _pedidoDbSet = dbContext.Set<Pedido>();
            _dbContext = dbContext;
        }

        public async Task<Pedido> GetPedidoBySenhaUseCaseAsync(int senha)
        {
            var result = await _pedidoDbSet
                .AsNoTracking()
                .Where(x => x.Senha == senha)
                .Include(x => x.ItensPedido)
                    .ThenInclude(x => x.Produto)
                        .ThenInclude(x => x.Categoria)
                .Include(x => x.Pagamento)
                .FirstOrDefaultAsync();

            return result;
        }

        public async Task<IEnumerable<Pedido>> GetPedidosDetalhadosAsync()
        {
            var result = await _pedidoDbSet
                .AsNoTracking()
                .Include(x => x.ItensPedido)
                    .ThenInclude(x => x.Produto)
                        .ThenInclude(x => x.Categoria)
                .Include(x => x.Pagamento)
                .Where(x => (short)x.Status != (short)Status.Pronto && (short)x.Pagamento.Status != (short)StatusPagamento.Reprovado)
                .OrderByDescending(pedido => pedido.Status)
                .ThenBy(pedido => pedido.Senha)
                .ToListAsync();

            return result;
        }

        public async Task<Pedido> GetIncludeAsync(Guid id)
        {
            var result = await _pedidoDbSet
                .AsNoTracking()
                .Where(x => x.Id == id)
                .Include(x => x.Pagamento)
                .FirstOrDefaultAsync();

            return result;
        }

        public async Task<IEnumerable<Pedido>> GetHistoricoAsync(string userId)
        {
            var result = await _pedidoDbSet
                .AsNoTracking()
                .Include(x => x.ItensPedido)
                    .ThenInclude(x => x.Produto)
                        .ThenInclude(x => x.Categoria)
                .Include(x => x.Cliente)
                .Include(x => x.Pagamento)
                .Where(x => x.Cliente.UserId == userId)
                .OrderByDescending(pedido => pedido.Status)
                .ThenBy(pedido => pedido.Senha)
                .ToListAsync();

            return result;
        }

        public async Task<Pedido> AddAsync(Pedido pedido)
        {
            pedido.DataCriacao = DateTime.UtcNow;
            _pedidoDbSet.Add(pedido);
            _dbContext.Entry<Cliente>(pedido.Cliente).State = EntityState.Detached;

            await _dbContext.SaveChangesAsync();

            return pedido;
        }
    }
}
