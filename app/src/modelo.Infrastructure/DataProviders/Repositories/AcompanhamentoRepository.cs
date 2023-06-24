using Microsoft.EntityFrameworkCore;
using modelo.Domain.Entities;
using modelo.Domain.Gateways;
using System;
using System.Threading.Tasks;
using System.Linq;

namespace modelo.Infrastructure.DataProviders.Repositories
{
    internal class AcompanhamentoRepository : RepositoryBase<Acompanhamento, Guid>, IAcompanhamentoGateway
    {
        private readonly DbSet<Acompanhamento> _acompanhamentoDbSet;

        public AcompanhamentoRepository(DBContext dbContext) : base(dbContext) 
        {
            _acompanhamentoDbSet = dbContext.Set<Acompanhamento>();
        }

        public async Task<Acompanhamento> GetBySenhaAsync(int senha)
        {
            var result = await _acompanhamentoDbSet.Where(x => x.Senha.Equals(senha)).FirstOrDefaultAsync();
            if (result != null)
                return result;

            return null;
        }
    }
}
