using modelo.Domain.Entities;
using modelo.Domain.Gateways;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modelo.Infrastructure.DataProviders.Repositories
{
    public class CategoriaRepository : RepositoryBase<Categoria, Guid>, ICategoriaGateway
    {
        public CategoriaRepository(DBContext dbContext) : base(dbContext){ }
    }
}
