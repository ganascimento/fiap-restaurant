using modelo.Domain.Entities;
using modelo.Domain.Gateways;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modelo.Infrastructure.DataProviders.Repositories
{
    public class ClienteRepository : RepositoryBase<Cliente,Guid>, IClienteGateway
    {
        private readonly DBContext dBContext;
        public ClienteRepository(DBContext dbContext) : base(dbContext){
        this.dBContext = dbContext;
        }

        public Cliente GetByCPF(string CPF)
        {
            var data = dBContext.Cliente.AsQueryable();

            var result = data.Where(x => x.CPF.Equals(CPF)).FirstOrDefault();
            if (result != null)
                return result;

            return null;
        }
    }
}
