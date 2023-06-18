using modelo.Domain.Entities;
using modelo.Domain.Gateways;
using System;

namespace modelo.Infrastructure.DataProviders.Repositories
{
    public class CategoriaRepository : RepositoryBase<Categoria, Guid>, ICategoriaGateway
    {
        public CategoriaRepository(DBContext dbContext) : base(dbContext) { }
    }
}
