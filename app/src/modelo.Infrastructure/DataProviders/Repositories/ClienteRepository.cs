using Microsoft.EntityFrameworkCore;
using modelo.Domain.Entities;
using modelo.Domain.Gateways;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace modelo.Infrastructure.DataProviders.Repositories
{
    public class ClienteRepository : RepositoryBase<Cliente, Guid>, IClienteGateway
    {
        private readonly DbSet<Cliente> _clienteDbSet;

        public ClienteRepository(DBContext dbContext) : base(dbContext)
        {
            _clienteDbSet = dbContext.Set<Cliente>();
        }

        public async Task<Cliente> GetByCPFAsync(string cpf)
        {
            var result = await _clienteDbSet.Where(x => x.Cpf.Equals(cpf)).FirstOrDefaultAsync();
            if (result != null)
                return result;

            return null;
        }
    }
}
