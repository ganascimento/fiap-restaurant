using Microsoft.EntityFrameworkCore;
using modelo.Domain.Entities;
using modelo.Domain.Gateways;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace modelo.Infrastructure.DataProviders.Repositories
{
    public class ProdutoRepository : RepositoryBase<Produto, Guid>, IProdutoGateway
    {
        private readonly DbSet<Produto> _produtoDbSet;

        public ProdutoRepository(DBContext dbContext) : base(dbContext)
        {
            _produtoDbSet = dbContext.Set<Produto>();
        }

        public async Task<IEnumerable<Produto>> GetProdutoByCategoriaIdAsync(Guid categoriaId)
        {
            var result = await _produtoDbSet.Where(x => x.CategoriaId.Equals(categoriaId)).ToListAsync();
            if (result != null)
                return result;

            return null;
        }
    }
}
