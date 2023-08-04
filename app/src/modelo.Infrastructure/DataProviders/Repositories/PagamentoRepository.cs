using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using modelo.Domain.Entities;
using modelo.Domain.Gateways.External;

namespace modelo.Infrastructure.DataProviders.Repositories.External
{
    public class PagamentoRepository : RepositoryBase<Pagamento, Guid>, IPagamentoGateway
    {
        private readonly DbSet<Pagamento> _pagamentoDbSet;

        public PagamentoRepository(DBContext dbContext) : base(dbContext)
        {
            _pagamentoDbSet = dbContext.Set<Pagamento>();
        }

        public async Task<Pagamento> GetByPedidoAsync(Guid pedidoId)
        {
            var result = await _pagamentoDbSet
                .AsNoTracking()
                .Where(x => x.PedidoId == pedidoId)
                .FirstOrDefaultAsync();

            return result;
        }
    }
}
